﻿using ALQUILER_VIDEOJUEGOS_BACK.Context;
using ALQUILER_VIDEOJUEGOS_BACK.DTO;
using ALQUILER_VIDEOJUEGOS_BACK.Interfaces;
using ALQUILER_VIDEOJUEGOS_BACK.Models;
using Microsoft.EntityFrameworkCore;

namespace ALQUILER_VIDEOJUEGOS_BACK.Services
{
    public class AlquilerService : IAlquilerService
    {
        private readonly AlquilerVideoJuegoContext _Context;
        public AlquilerService(AlquilerVideoJuegoContext Context)
        {
            this._Context = Context;
        }
        public async Task<Response<GetAlquilerDTO>> GetAlquiler()
        {
            var result = new Response<GetAlquilerDTO>();
            try
            {
                result.DataList = _Context.GetAlquilerDTO.FromSqlInterpolated($"dbo.GetAlquiler").ToList();
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);
            }

            return result;
        }

        public async Task<Response> SetAlquiler(SetAlquiler model)
        {
            var result = new Response();
            try
            {
                _Context.Database.
                    ExecuteSqlInterpolated($"dbo.SetAlquiler {model.IdUsuario},{model.IdVideoJuego},{model.FechaInicio}, {model.FechaFin} ,{model.PrecioTotal},{model.EstatusPago}, {model.CantidadAlquilado}");

                result.Message = "Los datos fueron ingresados exitosamente!";
            }
            catch (Exception ex)
            {
                result.Errors.Add(ex.Message);

            }

            return result;
        }

        public async Task<Response> UpdateAlquiler(UpdateAlquiler model)
        {
            var resultado = new Response();

            try
            {
                _Context.Database.
                   ExecuteSqlInterpolated($"dbo.UpdateAlquiler {model.IdAlquiler},{model.IdUsuario},{model.IdVideoJuego},{model.FechaInicio}, {model.FechaFin} ,{model.PrecioTotal},{model.EstatusPago}, {model.CantidadAlquilado}");

                resultado.Message = "Los datos fueron ingresados exitosamente!";
            }
            catch (Exception ex)
            {
                resultado.Errors.Add(ex.Message);
            }

            return resultado;
        }
    }
}
