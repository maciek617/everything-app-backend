namespace EverythingApp.Models
{
    public class BmiRequest
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public double YearFactor { get; set; }
        public double SexFactor { get; set; }
        public double RegionFactor { get; set; }

    }
}
