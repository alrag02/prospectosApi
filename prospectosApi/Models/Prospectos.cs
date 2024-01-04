using System.ComponentModel.DataAnnotations;

namespace prospectosApi.Models
{
    public class Prospectos
    {
        [Key]
        public int id { get; set; }
        
        [Required(ErrorMessage = "La solicitud no tiene un Nombre")]
        [StringLength(50, ErrorMessage = "Inserte un nombre valido")]
        public string nombre { get; set; }
        
        [Required(ErrorMessage = "La solicitud no tiene un Apellido")]
        [StringLength(100, ErrorMessage = "Inserte un apellido paterno valido")]
        public string apellidoPaterno { get; set; }

        [StringLength(100, ErrorMessage = "Inserte un apellido materno valido")]
        public string apellidoMaterno { get; set; }
        
        [Required(ErrorMessage = "La solicitud no tiene una calle")]
        [StringLength(100, ErrorMessage = "Inserte una calle valida")]
        public string calle { get; set; }
        
        [Required(ErrorMessage = "La solicitud no tiene un Numero de domicilio")]
        [StringLength(20, ErrorMessage = "Inserte un Numero de domicilio valido")]
        public string numero { get; set; }
        
        [Required(ErrorMessage = "La solicitud no tiene una Colonia")]
        [StringLength(100, ErrorMessage = "Inserte una colonia valida")]
        public string colonia { get; set; }
        
        [Required(ErrorMessage = "La solicitud no tiene un Código Postal")]
        [RegularExpression(@"^[0-9]{5}$", ErrorMessage = "Inserte un código postal valido")]
        public string codigoPostal { get; set; }
        
        [Required(ErrorMessage = "La solicitud no tiene un Teléfono")]
        [StringLength(15, ErrorMessage = "Inserte un telefono valido")]
        public string telefono { get; set; }
        
        [Required(ErrorMessage = "La solicitud no tiene un RFC")]
        [RegularExpression(@"^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1]))([A-Z\d]{3})?$", ErrorMessage = "Inserte un RFC valido")]
        public string rfc { get; set; }
        
        [Required(ErrorMessage = "La solicitud no tiene un estatus")]
        [Range(1, 3, ErrorMessage = "Inserte un estatus valido")]
        public int estatus { get; set; }
    }
}
