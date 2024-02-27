using otus_Solid.Interfaces;
using otus_Solid.Settings;


namespace otus_Solid.Services
{
    internal class Randomizer : IRandomaizer
    {
        private readonly Random _random = null!;
        public Randomizer()
        {
            _random = new Random();
        }
        public int GenerateRandomNumber()
        {
            if (Setting.AttemptsRangeMin >= Setting.AttemptsRangeMax)
            {
                throw new ArgumentOutOfRangeException("Invalid range in program settings");
            }
            return _random.Next(Setting.AttemptsRangeMin, Setting.AttemptsRangeMax + 1);
        }
    }
}
