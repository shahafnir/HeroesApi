namespace HeroesApi.Dtos.Responses
{
    public class AuthResultDto
    {
        public string Token { get; set; }
        public string TrainerId { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
