using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSolver
{
    public class DataStructure
    {
        //creates the object of the cube that uses numbers for mathematical calculations required to make the 
        //rotation
        /*1=white top of z
             *2=orange top of y
             *3=green top of x
             *4=yellow bottom of z
             *5=red bottom of y
             *6=blue bottom of x
             *blue white and red make the axis (Because its white an equivalent cartesian coordinate would be upside 
             *down
             */
        public int[,,] theCube { get; set; }
            
            public DataStructure(int[,,] input)
            {
            theCube = input;
            }
        /*since the xyz coordinate is blue white and red, when tmb(top middle bottom) is given 0 it defaults
        *those three colors. In xy rotate looking at white, it would white for top, yellow for bottom and other
        *for middle. Since looking from white, yellow goes CCW counterclockwise!
        */
        public void Rotatexycw(int tmb)
        {
            //    Array myCube = new int[3, 2, 9]
            //{
            //    { {1,1,1,1,1,1,1,1,1},{4,4,4,4,4,4,4,4,4} },
            //    { {3,3,3,2,2,2,2,2,2},{6,6,6,5,5,5,5,5,5}},
            //    { {5,5,5,3,3,3,3,3,3},{2,2,2,6,6,6,6,6,6}}
            //};
            /*1=white top of z
             *2=orange top of y 
             *3=green top of x
             *4=yellow bottom of z
             *5=red bottom of y
             *6=blue bottom of x
             *blue red and white make the axis
             */

            int[,] rotation = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                //2
                rotation[i, 0] = theCube[1, 0, 3*tmb+i];
                //3
                rotation[i, 1] = theCube[2, 0, 3 * tmb + i];
                //5
                rotation[i, 2] = theCube[1, 1, 3 * tmb + i];
                //6
                rotation[i, 3] = theCube[2, 1, 3 * tmb + i];
                //2 new
                theCube[1, 0, 3 * tmb + i] = rotation[i, 1];
                //3 new
                theCube[2, 0, 3 * tmb + i] = rotation[i, 2];
                //5 new
                theCube[1, 1, 3* tmb + i] = rotation[i, 3];
                //6 new
                theCube[2, 1, 3*tmb+i] = rotation[i, 0];
            }
            
        }
        public void Rotatexzcw(int tmb)
        {
            //        { {5,1,1,5,1,1,5,1,1},{2,4,4,2,4,4,2,4,4} },
            //        { {1,2,2,1,2,2,1,2,2},{5,5,4,5,5,4,5,5,4}},
            //        { {3,3,3,3,3,3,3,3,3},{6,6,6,6,6,6,6,6,6}}
            /*1=white top of z
                     *2=orange top of y 
                     *3=green top of x
                     *4=yellow bottom of z
                     *5=red bottom of y
                     *6=blue bottom of x
                     *blue red and white make the axis
                     */
            int[,] rotation = new int[3,4];
            for(int i = 0; i < 3; i++)
            {
                //1[0,0,i]
                rotation[i, 0] = theCube[0, 0, 3*i+tmb];
                //2[1,0,i]
                rotation[i, 1] = theCube[1, 0, 3*i+tmb];
                //4[0,1,i]
                rotation[i, 2] = theCube[0, 1, 3*i+tmb];
                //5[1,1,i]
                rotation[i, 3] = theCube[1, 1, 3*i+(2-tmb)];

                theCube[0, 0, 3 * i + tmb] = rotation[i, 3];
                theCube[1, 0, 3 * i + tmb] = rotation[i, 0];
                theCube[0, 1, 3 * i + tmb] = rotation[i, 1];
                theCube[1, 1, 3 * i + (2 - tmb)] = rotation[i, 2];
            }
            
        }
        public void Rotateyzcw(int tmb)
        {
            
            //    int[,,] myCube = new int[3, 2, 9]
            //{
            //    { { 3,3,3,1,1,1,1,1,1},{ 4,4,4,4,4,4,6,6,6} },
            //{ { 2,2,2,2,2,2,2,2,2},{ 5,5,5,5,5,5,5,5,5} },
            //{ { 3,3,4,3,3,4,3,3,4},{ 1,6,6,1,6,6,1,6,6} }
            //};
            /*1=white top of z
                     *2=orange top of y 
                     *3=green top of x
                     *4=yellow bottom of z
                     *5=red bottom of y
                     *6=blue bottom of x
                     *blue red and yellow make the axis
                     */
            int[,] rotation = new int[3,4];
            for(int i = 0; i < 3; i++)
            {
                //1[0,0,i]
                rotation[i, 0] = theCube[0, 0, i+3*tmb];
                //3[2,0,i]
                rotation[i, 1] = theCube[2, 0, 3*i+2-tmb];
                //4[0,1,i]
                rotation[i, 2] = theCube[0, 1, 6+i-3*tmb];
                //6[2,1,i]
                rotation[i, 3] = theCube[2, 1, 3*i+tmb];


                theCube[0, 0, i + 3*tmb] = rotation[i, 1];
                theCube[2, 0, 3 * i + 2 - tmb] = rotation[i, 2];
                theCube[0, 1, 6 + i - 3 * tmb] = rotation[i, 3];
                theCube[2, 1, 3 * i + tmb] = rotation[i, 0];
            }
        }

        /*Creates the number conversion to letter conversion to represent each color using 4 for loops.
         * Three for each dimension and the fourth to make it 3 by 3 on console application.
         */
        public void Color()
        {
        for (int i = 0; i < 3; i++)
        { 
           for (int j = 0; j < 2; j++)
           {    
                for (int l=0;l<3; l++)
                { 
                    for (int k = 0; k < 3; k++)
                    {
                            switch (theCube[i, j, 3*l + k])
                            {
                                case 1:
                                    Console.Write("W ");
                                    break;
                                case 2:
                                    Console.Write("O ");
                                    break;
                                case 3:
                                    Console.Write("G ");
                                    break;
                                case 4:
                                    Console.Write("Y ");
                                    break;
                                case 5:
                                    Console.Write("R ");
                                    break;
                                case 6:
                                    Console.Write("B ");
                                    break;
                                default:
                                    Console.WriteLine("Default case");
                                    break;
                            }
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
