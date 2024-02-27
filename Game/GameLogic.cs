using otus_Solid.Interfaces;
using otus_Solid.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Solid.Game
{
    enum AttemtResult { Less, More, Equal  }
    internal class GameLogic: IGameLogic
    {

        private int _randomNumber;
        private int _playersAttemptCounter;

        private readonly IRandomaizer _randomaizer;

        public GameLogic(IRandomaizer randomaizer)
        {
            _randomaizer = randomaizer;
            _playersAttemptCounter = Settings.Setting.AttemptsSize;
        }

        public void InitRandomNumber()
        {
            _randomNumber = _randomaizer.GenerateRandomNumber();
        }

        public bool IsAttemts()
        {
            return _playersAttemptCounter > 0;
        }

        public AttemtResult TryAttemtResult(int number)
        {
            --_playersAttemptCounter;
            var gesResult = AttemtResult.Equal;
            
            if (number < _randomNumber)
                gesResult = AttemtResult.Less;
            if (number > _randomNumber)
                gesResult = AttemtResult.More;
            return gesResult;
        }


        public int NumderDebbug() { 
            return _randomNumber; 
        }
    }
}
