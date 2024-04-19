namespace ALQUILER_VIDEOJUEGOS_BACK.DTO
{
    public class Response
    {
        public bool Succeded => !Errors.Any();
        public long EntityId { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; } = new List<string>(0);
    }
    public class Response<T> : Response where T : class
    {
        public List<T> DataList { get; set; }
        public T SingleData { get; set; }
    }
}
