namespace EverythingApp.Models
{
    public class BmiResponse
    {
        public double Bmi { get; set; }
        public double AgeFactor { get; set; }
        public double SexFactor { get; set; }
        public double RegionFactor { get; set; }
        public string Category { get; set; } = "";
    }
}
