﻿using ALQUILER_VIDEOJUEGOS_BACK.Context;
using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ALQUILER_VIDEOJUEGOS_BACK.Services
{
    public class AutenticacionService : IAutenticacionService
    {
        private readonly AlquilerVideoJuegoContext _context;
        private readonly string secretKey;

        public AutenticacionService(IConfiguration configuration,AlquilerVideoJuegoContext context)
        {
            this._context = context;
            secretKey = configuration.GetSection("settings").GetSection("secretkey").ToString();
        }
        public async Task<Response<LoginUsuarioInfo>> LoginUsuario(string correo)
        {
            var result = new Response<LoginUsuarioInfo>();
            try
            {

                var usuariologin = _context.LoginUsuario.FromSqlInterpolated($"dbo.LoginUsuarioInfo {correo}").ToList();
                result.SingleData = usuariologin.FirstOrDefault();

            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        public async Task<Response> ValidarAutenticacion(string correo, string contrasena)
        {
            var result = new Response<LoginUsuarioInfo>();
            var token = new Response<TokenGot>();
            try
            {
                result = await LoginUsuario(correo);
                var passHash = Utilidades.HashPassword(contrasena);

                if(result.SingleData != null)
                {
                    if (correo == result.SingleData.Correo && passHash.SequenceEqual(result.SingleData.Contrasena))
                    {
                        result.Message = "La contraseña es igual";
                        var keyBytes = Encoding.ASCII.GetBytes(secretKey);
                        var claims = new ClaimsIdentity();

                        claims.AddClaim(new Claim(ClaimTypes.NameIdentifier,correo));

                        var tokenDescriptor = new SecurityTokenDescriptor
                        {
                            Subject = claims,
                            Expires = DateTime.UtcNow.AddHours(1),
                            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes),SecurityAlgorithms.HmacSha256Signature),
                        };

                        var tokenHandler = new JwtSecurityTokenHandler();
                        var tokenConfig = tokenHandler.CreateToken(tokenDescriptor);

                        string tokencreado = tokenHandler.WriteToken(tokenConfig);

                        token.SingleData = new TokenGot { Token = tokencreado };

                        return token;
                    }
                    else
                    {
                        token.Message = "La contraseña ingresada no coincide con su contraseña";
                        token.SingleData = new TokenGot { Token = ""};

                        return token;
                    }

                }
                else
                {
                    token.Message = "El correo ingresado no existe";
                }

            }
            catch (Exception ex)
            {
                token.Errors.Add(ex.Message);
            }

            return token;
        }
    }
}
