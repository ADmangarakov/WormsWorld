using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormsWorld
{
    class Worm
    {
        private readonly string _name;
        private Coord _position;

        public Worm(string name, Coord position)
        {
            _name = name;
            _position = new Coord(position);
        }

        public override string ToString()
        {
            return $"{_name} {_position}";
        }

        public IAction GetAction(int currentStep)
        {
            if (currentStep == 0)
            {
                return MoveAction.Up;
            }
            else if (currentStep == 1)
            {
                return MoveAction.Right;
            }

            currentStep -= 2;
            currentStep %= 8;
            if (currentStep == 0 || currentStep == 1 )
            {
                return MoveAction.Down;
            }
            else if (currentStep == 2 || currentStep == 3)
            {
                return MoveAction.Left;
            }
            else if (currentStep == 4 || currentStep == 5)
            {
                return MoveAction.Up;
            }
            else if (currentStep == 6 || currentStep == 7)
            {
                return MoveAction.Right;
            }
            throw new ArgumentException("No Action implemented for this step");
        }

        public void MakeAction(IAction action)
        {
            _position += ((MoveAction)action).GetAction();
        }
    }
}
