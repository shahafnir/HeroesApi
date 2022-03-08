namespace HeroesApi.Dtos.Responses
{
    public class HeroTrainingResultDto
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public int? PowerIncrementPercent { get; set; }
        public decimal? CurrentPower { get; set; }
    }
}
