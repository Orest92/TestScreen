using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestScreen
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            string fileName = "D:\\Screen\\abc.png";
            var bound = Screen.GetBounds(Point.Empty);
            using (var bitmap = new Bitmap(bound.Width, bound.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bound.Size);
                    bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                }

            }
        }
    }
}
