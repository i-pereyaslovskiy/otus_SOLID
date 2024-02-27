using otus_Solid.Interfaces;
using otus_Solid.Settings;

namespace otus_Solid.Game
{
    internal class GameProcess:IGameProcess
    {
        private readonly IMessage _message;
        private readonly ITimeDelay _timeDelay;
        private readonly IUserInput _userInput;
        private readonly IGameLogic _gameLogic;

       
        public GameProcess(IMessage message, ITimeDelay timeDelay, IUserInput userInput, IGameLogic gameLogoc)
        {
            _message = message;
            _timeDelay = timeDelay;
            _userInput = userInput;
            _gameLogic = gameLogoc;
        }

        public void InitGame()
        {

            _gameLogic.InitRandomNumber();

            _message.ShowMassageLine(" --= The \"Guess the Number\" game has begun! =-- ");
            _message.ShowMassageLine($"Please try to guess the number between " +
                $"{Setting.AttemptsRangeMin} and " +
                $"{Setting.AttemptsRangeMax} within " +
                $"{Setting.AttemptsSize} attempts.");



            _message.ShowMassageLine($"For debuggin: {_gameLogic.NumderDebbug()}");
            _timeDelay.Delay(1000);


            do {
                _message.ShowMassage("Guess the number: ");
                var userInputNumber = _userInput.UserInputNumber();
                switch (_gameLogic.TryAttemtResult(userInputNumber))
                {
                    case AttemtResult.Less:
                        _message.ShowMassageLine("Number is higher");
                        break;
                    case AttemtResult.More:
                        _message.ShowMassageLine("Number is lower");
                        break;
                    case AttemtResult.Equal:
                        _message.ShowMassageLine("Congratulations! You guessed the number.");
                        return;
                }


                if (!_gameLogic.IsAttemts()) {
                    _message.ShowMassageLine("Game over");
                    break;
                }

            }
            while (_gameLogic.IsAttemts());


        }
    }
}
