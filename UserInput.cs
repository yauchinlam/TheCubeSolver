using System;


namespace CubeSolver
{
    class UserInput
    {
        public static DataStructure DoOperation(string input1, DataStructure mycube)
        {
            //since three of them rotate CCW I applied to three times so now they ALL will rotate CW
            //from their face point of view
            switch (input1)
            {
                case "w":
                    mycube.Rotatexycw(0);
                    break;
                case "g":
                    mycube.Rotatexzcw(0);
                    break;
                case "r":
                    mycube.Rotateyzcw(2);
                    mycube.Rotateyzcw(2);
                    mycube.Rotateyzcw(2);
                    break;
                case "b":
                    mycube.Rotatexzcw(2);
                    mycube.Rotatexzcw(2);
                    mycube.Rotatexzcw(2);
                    break;
                case "o":
                    mycube.Rotateyzcw(0);
                    break;
                case "y":
                    mycube.Rotatexycw(2);
                    mycube.Rotatexycw(2);
                    mycube.Rotatexycw(2);
                    break;
                default:
                    Console.WriteLine("That is not one of the six options.");
                    break;
            }
            return mycube;
        }
    }
}
