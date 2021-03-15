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
         *White, Orange and Green make the xyz Cartesian axis 
         */
        public int[,,] theCube = new int[3, 2, 9]
        {/*Since this is in a one 3D array of size 3,2,9 instead of six 3 by 3 3D array
          *I was unable to use the rotation matrices so I had to create them based on different scenarios shown
          *in the comments below each rotation.
          */
            { {1,1,1,1,1,1,1,1,1},{4,4,4,4,4,4,4,4,4}},
            { {2,2,2,2,2,2,2,2,2},{5,5,5,5,5,5,5,5,5}},
            { {3,3,3,3,3,3,3,3,3},{6,6,6,6,6,6,6,6,6}}
        };

    public DataStructure(int[,,] input)
            {
            theCube = input;
            }
        
        /*Since the xyz coordinate is white, orange, green, when tmb(top middle bottom) is given 0 it defaults
         *            white z
         *                  |
         *      green x     |   orange y 
         *                  |
         *                  /\
         *                 /  \
         *                /    \
         *               /      \
         *               yellow bottom of z
         *  the z line is the edge that touches orange and green
         *  the y line is the edge that touches orange and yellow
         *  the x line is the edge that touches green and yellow
        *those three colors and 2 for the other three. In xy rotate looking at white, 
        *it would white for top, yellow for bottom and other
        *for middle. Since looking from white, yellow goes CCW counterclockwise and so on!
        */
        
        //This method rotates white 90 degree CW or yellow 90 degree CCW 
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
             *blue red and yellow make the axis
             */

            int[,] rotation = new int[3, 4];
            
            for (int i = 0; i < 3; i++)
            {
                //2
                rotation[i, 0] = theCube[1, 0, 3 * tmb + i];
                //3
                rotation[i, 1] = theCube[2, 0, 3 * tmb + i];
                //5
                rotation[i, 2] = theCube[1, 1, 3 * tmb + i];
                //6
                rotation[i, 3] = theCube[2, 1, 3 * tmb + i];

                //2 get 3
                theCube[1, 0, 3 * tmb + i] = rotation[i, 1];
                //3 get 5
                theCube[2, 0, 3 * tmb + i] = rotation[i, 2];
                //5 get 6
                theCube[1, 1, 3 * tmb + i] = rotation[i, 3];
                //6 get 2
                theCube[2, 1, 3 * tmb + i] = rotation[i, 0];
                //

            }
            //
            //the axis that gets rotated
            int axis = 0;
            OnTheAxis(tmb,axis);
        }
        
        //This method rotates orange 90 degree CW or red 90 degree CCW
        public void Rotateyzcw(int tmb)
        {

            //{1,1,1,1,1,1,6,6,6} {3,3,3,4,4,4,4,4,4}
            //{2,2,2,2,2,2,2,2,2} {5,5,5,5,5,5,5,5,5}
            //{1,1,1,3,3,3,3,3,3} {6,6,4,6,6,4,6,6,4}
            /*1=white top of z
            *2 =orange top of y 
             *3=green top of x
             *4=yellow bottom of z
             *5=red bottom of y
             *6=blue bottom of x
             *green, orange and white make the axis
            */
            //tmb=0 for orange and 2 for red
            int[,] rotation = new int[3,4];
            for (int i = 0; i < 3; i++)
            {
                //1[0,0,i]
                //6,7,8 for orange
                //0,1,2 for red
                rotation[i, 0] = theCube[0, 0, 3 * (2 - tmb) + i];
                //3[2,0,i]
                //0,3,6 for orange
                //2,5,8 for red
                rotation[i, 1] = theCube[2, 0, 3 * i + tmb];
                //4[0,1,i]
                //0,1,2 for orange
                //6,7,8 for red
                rotation[i, 2] = theCube[0, 1, 3 * tmb + i];
                //6[2,1,i]
                //2,5,8 for orange
                //0,3,6 for red
                rotation[i, 3] = theCube[2, 1, 3 * i + (2 - tmb)];

                //3 gets 1
                //green gets white
                theCube[2, 0, 3 * i + tmb] = rotation[i, 0];
                //6 gets 4
                //blue gets yellow
                theCube[2, 1, 3 * i + (2 - tmb)] = rotation[i, 2];
            }
            //fixes the orientation
            for (int i = 0; i < 3; i++)
            {
                //1 gets 6
                //white gets blue
                theCube[0, 0, 3 * (2 - tmb) + i] = rotation[2 - i, 3];
                
                //4 gets 3
                //yellow gets green
                theCube[0, 1, 3 * tmb + i] = rotation[2-i, 1];
            }
            int axis = 1;
            OnTheAxis(tmb, axis);
        }

        //This method rotates green 90 degree CW or blue 90 degree CCW
        public void Rotatexzcw(int tmb)
        {
            //{1,1,2,1,1,2,1,1,2} {4,4,5,4,4,5,4,4,5}
            //{2,2,4,2,2,4,2,2,4} {1,5,5,1,5,5,1,5,5}
            //{3,3,3,3,3,3,3,3,3} {6,6,6,6,6,6,6,6,6}   
            /*1=white top of z
                     *2=orange top of y 
                     *3=green top of x
                     *4=yellow bottom of z
                     *5=red bottom of y
                     *6=blue bottom of x
                     *white, orange and green make the axis
                     */
            int[,] rotation = new int[3, 4];
            //green tmb is 0 and blue is 2
            for (int i = 0; i < 3; i++)
            {
                //1[0,0,i]
                //2,5,8 for green
                //0,3,6 for blue
                rotation[i, 0] = theCube[0, 0, 3 * i + (2 - tmb)];

                //2[1,0,i]
                //2,5,8 for green
                //0,3,6 for blue
                rotation[i, 1] = theCube[1, 0, 3 * i + (2 - tmb)];
                //4[0,1,i]
                //2,5,8 for green
                //0,3,6 for blue
                rotation[i, 2] = theCube[0, 1, 3 * i + (2 - tmb)];
                //5[1,1,i]
                //0,3,6 for green
                //2,5,8 for blue
                rotation[i, 3] = theCube[1, 1, 3 * i + tmb];
                //1 gets 2
                theCube[0, 0, 3 * i + (2 - tmb)] = rotation[i, 1];
                //2 gets 4
                theCube[1, 0, 3 * i + (2 - tmb)] = rotation[i, 2];

            }
            //the numbering makes half of them need to be received upside down
            for (int i = 0; i < 3; i++)
            { 
                               
                //4 gets 5 
                theCube[0, 1, 3 * i + (2 - tmb)] = rotation[2-i, 3];
                //5 gets 1
                theCube[1, 1, 3 * i + tmb] = rotation[2-i, 0];
            }
            int axis = 2;
            OnTheAxis(tmb, axis);
        }
        
        //This is basically a 3D Rotation matrix on the axis you rotate
        public void OnTheAxis(int tmb, int axis)
        {
            int[] rotationC = new int[9];

            //this is for yellow, blue and red since it goes opposite direction
            if (tmb == 2)
            {
                tmb = 1;
                for (int j = 0; j < 9; j++)
                //123 //012
                //456 //345
                //789 //678 //before

                //369 //258
                //258 //147
                //147 //036 //after
                { rotationC[j] = theCube[axis, tmb, j]; }
                for (int i = 0; i < 3; i++)
                {
                    theCube[axis, tmb, i] = rotationC[2 + 3 * i];
                    theCube[axis, tmb, 3 + i] = rotationC[1 + 3 * i];
                    theCube[axis, tmb, 6 + i] = rotationC[3 * i];
                }
                return;



            }
            //this is for white, orange and green
            else
            {
                for (int j = 0; j < 9; j++)

                { rotationC[j] = theCube[axis, tmb, j]; }

                //123 //012
                //456 //345
                //789 //678

                //741 //630
                //852 //741
                //963 //852
                for (int i = 0; i < 3; i++)
                {
                    theCube[axis, tmb, i] = rotationC[3 * (2 - i)];
                    //theCube[axis, tmb, 1]= rotationC[3];
                    //theCube[axis, tmb, 2] = rotationC[0];
                    theCube[axis, tmb, 3 + i] = rotationC[1 + (3 * (2 - i))];
                    //theCube[axis, tmb, 4]= rotationC[4];
                    //theCube[axis, tmb, 5] = rotationC[1];

                    theCube[axis, tmb, 6 + i] = rotationC[2 + (3 * (2 - i))];
                    //theCube[axis, tmb, 7] = rotationC[5];
                    //theCube[axis, tmb, 8] = rotationC[2];
                }
            }
        }
        
        //This converts the number system to colors
        //White as read from your face point of view with red on top
        //123
        //456
        //789
        //Yellow as read from your face point of view with orange on top
        //123
        //456
        //789
        //The other four are read from your face point of view with white on top
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
