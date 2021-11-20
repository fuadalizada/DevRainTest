namespace DevRainTest.WebApi.Models
{
    public class FilterViewModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Metric { get; set; }
        public bool? IsSuccess { get; set; }           
    }
}
