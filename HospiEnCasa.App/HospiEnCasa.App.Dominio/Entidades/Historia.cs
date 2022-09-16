using System.Collections.Generic;//importacion de la lista
namespace HospiEnCasa.App.Dominio
{
    public class Historia
    {
        public int Id { get; set; }
        public string Diagnostico { get; set; }
        public string Entorno { get; set; }
        public List<SugerenciaCuidado> Sugerencias { get; set; }//creacion de la lista
    }
}