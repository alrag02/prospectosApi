using System.ComponentModel.DataAnnotations;

namespace prospectosApi.Models
{
    public class Prospectos
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string colonia { get; set; }
        public string codigoPostal { get; set; }
        public string telefono { get; set; }
        public string rfc { get; set; }
        public int estatus { get; set; }
    }
}
