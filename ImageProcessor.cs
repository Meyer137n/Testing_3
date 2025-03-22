using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Testing_3
{
    internal class ImageProcessor
    {
         public Image LoadImage(string path)
        {
            return Image.FromFile(path);
        }
    }
}
