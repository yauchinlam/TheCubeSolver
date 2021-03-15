using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace CubeSolver
{
    class ConvertToVirtual
    {
        
        public static void Convert1(Bitmap b)
        {
            string appPath = @"C:\Users\yauch\OneDrive\Documents\GitHub\TheCubeSolver\";
            string[,] colors = new string[(b.Width),(b.Height)];
            using (StreamWriter file = new StreamWriter(appPath+"Test.txt"))
            {
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c = b.GetPixel(i, j);
                                               
                        string RGB = c.ToString()+"("+i+","+j+")";
                        colors[i,j] = RGB;
                    }
                }
                foreach (String color in colors)
                {
                    file.WriteLine(color);
                }

            }
        }
    }
}