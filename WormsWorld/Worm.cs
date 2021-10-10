using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormsWorld
{
    class Worm
    {
        private string name;
        private Coord position;

        public Worm(string name, Coord position)
        {
            this.name = name;
            this.position = new Coord(position);
        }

        public override string ToString()
        {
            return $"{name} {position}";
        }

        public Action getAction(int currentStep)
        {
            if (currentStep == 0)
            {
                return MoveAction.UP;
            }
            else if (currentStep == 1)
            {
                return MoveAction.RIGHT;
            }

            currentStep -= 2;
            currentStep %= 8;
            if (currentStep == 0 || currentStep == 1 )
            {
                return MoveAction.DOWN;
            }
            else if (currentStep == 2 || currentStep == 3)
            {
                return MoveAction.LEFT;
            }
            else if (currentStep == 4 || currentStep == 5)
            {
                return MoveAction.UP;
            }
            else if (currentStep == 6 || currentStep == 7)
            {
                return MoveAction.RIGHT;
            }
            throw new ArgumentException("No Action implemented for this step");
        }

        public void makeAction(Action action)
        {
            position += ((MoveAction)action).getAction();
        }
    }
}
