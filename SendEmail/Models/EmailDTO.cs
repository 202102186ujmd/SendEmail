namespace SendEmail.Models
{
    public class EmailDTO
    {
        public string Para { get; set; } = string.Empty; //Destinatario
        public string Asunto { get; set; } = string.Empty; //asusnto
        public string Contenido { get; set; } = string.Empty; //contenido
    }
}
