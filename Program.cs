using System;
using System.Windows.Forms;
namespace CubeSolver
{
    //WELCOME TO VERSION 2.0
    //v2.0 that will have the image processor and console app and BFS!
    //v3.0 will image processor and 3d game engine and console app
    //v4.0 will not use the console app
    //v5.0 will be an app.
    class Program
    {
        static Form1 MyForm;
        static void Main(string[] args)
        {
            int[,,] myCube = new int[3, 2, 9]
        {/*Since this is in a one 3D array of size 3,2,9 instead of six 3 by 3 3D array
          *I was unable to use the rotation matrices so I had to create them based on different scenarios shown
          *in the comments below each rotation.
          */
            { {1,1,1,1,1,1,1,1,1},{4,4,4,4,4,4,4,4,4}},
            { {2,2,2,2,2,2,2,2,2},{5,5,5,5,5,5,5,5,5}},
            { {3,3,3,3,3,3,3,3,3},{6,6,6,6,6,6,6,6,6}}
        };
            DataStructure mysCube = new DataStructure(myCube);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            MyForm = new Form1();
            Application.Run(MyForm);
            //bool endApp = false;
            //Console.WriteLine("Virtual Cube in C#\r");
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Because Rubik's Cube is trademarked...\r");
            //Console.WriteLine("------------------------");
            //mysCube.Color();
            ////This is to make it not a long amount of code shown on console app.
            //Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            //if (Console.ReadLine() == "n") endApp = true;
            //Console.Clear();
            ////allow them continuous interface with it until they get bored
            //while (!endApp)
            //{
            //    mysCube.Color();
            //    Console.WriteLine("Type a rotation for the cube, and then press Enter: ");
            //    Console.Write("Your choices are:\n");
            //    Console.Write("w for White,  r for Red, b for Blue, y for Yellow, o for Orange, and g for Green, \n");
            //    string input1;
            //    input1 = Console.ReadLine();
            //    Console.Clear();
            //    UserInput.DoOperation(input1, mysCube).Color();
            //    Console.WriteLine($"You just rotated {input1} by 90 degrees clockwise\n");
            //    Console.WriteLine("------------------------\n");

            //    // Wait for the user to respond before closing.
            //    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            //    if (Console.ReadLine() == "n") { endApp = true; }
            //    Console.Clear();
            //} 

        }
    }
}

