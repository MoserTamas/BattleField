using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_OOP
{
    internal class BattleField
    {
        private List<IBasicCharacter> _basicCharacters = new List<IBasicCharacter>();

        public void Add(IBasicCharacter basicCharacter)
        {
            _basicCharacters.Add(basicCharacter);
        }

        private void MoveCharacters()
        {
            foreach (var basicCharacter in _basicCharacters)
            {
                basicCharacter.Move();
            }
        }
        private void SayCharacters()
        {
            foreach (var basicCharacter in _basicCharacters)
            {
                basicCharacter.Say();
            }
        }

        public void Simulate()
        {
            MoveCharacters();
            SayCharacters();
        }
    }
}
