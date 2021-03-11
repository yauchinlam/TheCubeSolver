using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSolver
{
    class UserInput
    {
        public static DataStructure DoOperation(string input1, DataStructure mycube)
        {
            switch (input1)
            {
                case "w":
                    mycube.Rotatexycw(0);
                    break;
                case "g":
                    mycube.Rotatexzcw(2);
                    break;
                case "r":
                    mycube.Rotateyzcw(0);
                    break;
                case "b":
                    mycube.Rotatexzcw(0);
                    break;
                case "o":
                    mycube.Rotateyzcw(2);
                    break;
                case "y":
                    mycube.Rotatexycw(2);
                    break;
                case "wryo":
                    mycube.Rotatexzcw(1);
                    break;
                case "wgyb":
                    mycube.Rotateyzcw(1);
                    break;
                case "ogrb":
                    mycube.Rotatexycw(1);
                    break;
                default:
                    Console.WriteLine("That is not one of the nine options.");
                    break;
            }
            return mycube;
        }
    }
}
