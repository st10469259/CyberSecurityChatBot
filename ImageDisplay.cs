
using System;
using System.Drawing;

namespace CyberSecurityChatbot
{//start of namespace 
    public class ImageDisplay
    {//start of public class 
        public ImageDisplay()
        {//start of ascii logo constructor

            //calls the asci method
            asci();

        }//end of constructor

        //asii drawing method
        private void asci()
        {
            //path of the logo [ where the logo is ]
            string path = string.Empty;

            //auto get the full path
            string fullpath = AppDomain.CurrentDomain.BaseDirectory;

            //now combine the paths
            path = fullpath.Replace(@"bin\Debug\", "Logo1.jpg");

            Bitmap image = new Bitmap(path);

            // Resize for better console fit
            int width = 140;
            int height = 60; //(image.Height * width) / image.Width;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            // Default color , you can set yours before this line
            Console.ForegroundColor = ConsoleColor.Cyan;
            string asciiChars = "@#S%?*+;:,. ";

            //start by the height
            for (int y = 0; y < resized.Height; y++)
            {
                //then width
                for (int x = 0; x < resized.Width; x++)
                {
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        }

    }//end of public class
}//end of file
