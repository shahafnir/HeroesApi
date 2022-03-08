using HeroesApi.Dtos.Generic;

namespace HeroesApi.Dtos.Responses
{
    public class HeroDetailsDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Ability { get; set; }

        public DateTime StartedTrainingAt { get; set; }

        public IEnumerable<ColorDto> SuitColors { get; set; }

        public decimal StartingPower { get; set; }

        public decimal CurrentPower { get; set; }
        public string TrainerId { get; set; }
    }
}
