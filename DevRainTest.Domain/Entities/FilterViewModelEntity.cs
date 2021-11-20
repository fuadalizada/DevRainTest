namespace DevRainTest.Domain.Entities
{
    public class FilterViewModelEntity
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Metric { get; set; }
        public bool? IsSuccess { get; set; }
    }
}
