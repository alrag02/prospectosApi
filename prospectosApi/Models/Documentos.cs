namespace prospectosApi.Models
{
    public class Documentos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int prospectoId { get; set; }
        public string urlDocumento { get; set; }
        public Prospectos Prospecto { get; set; }
    }
}
