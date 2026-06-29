namespace EverythingAppBackend.Models
{
    public class VatRequest
    {
        public decimal NetAmount { get; set; }
        public decimal VatRate { get; set; }
        public bool IsNet { get; set; }
    }
}
