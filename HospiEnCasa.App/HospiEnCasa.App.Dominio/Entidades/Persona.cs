namespace HospiEnCasa.App.Dominio
{
    public class Persona //debe ser public para poder acceder a ella o se genera un error
    {
        public int Id { get; set; } //prop+tab
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NumeroTelefono { get; set; }
        public Genero Genero { get; set; }
    }
}