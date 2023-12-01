namespace Escuela.Repository
{
    public interface IRepository
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edada { get; set; }
        public string Direccion { get; set; }
    }
}
