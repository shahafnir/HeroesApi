namespace HeroesApi.Models.Heroes
{
    public class HeroTraining
    {
        public Guid HeroId { get; set; }

        public DateTime TrainedAt { get; set; }

        public static HeroTraining Create(string heroId)
        {
            return new HeroTraining
            {
                HeroId = Guid.Parse(heroId),
                TrainedAt = DateTime.UtcNow
            };
        }
    }
}
