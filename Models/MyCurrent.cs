using climapi.Models.Current;
namespace climapi.Models.MyCurrent
{
    public class MyCurrent
    {
        public Location? Location { get; set; }
        public double Temp_c { get; set;}
        public double Temp_f { get; set;}
        public double Wind { get; set;}
        public string? Wind_dir { get; set;}
        public string? Condition  { get; set;}
        public string? Date  { get; set;}

    }
}