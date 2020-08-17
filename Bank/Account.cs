namespace Bank
{
    public class Account
    {
        private readonly Clock _clock;
        private readonly Console _console;

        public Account(Clock clock, Console console)
        {
            _clock = clock;
            _console = console;
        }
    }
}