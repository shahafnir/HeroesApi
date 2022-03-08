namespace HeroesApi.Utilities
{
    public static class Utils
    {
        public static int GetRandomNumberInRange(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max + 1);
        }
    }
}
