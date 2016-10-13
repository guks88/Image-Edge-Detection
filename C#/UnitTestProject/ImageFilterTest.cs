using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace UnitTestProject
{
    [TestClass]
    public class ImageFilterTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullExceptionOnNullImage()
        {
            Bitmap nulled = null;
            //ImageFilters.
        }

        private Bitmap getImage(Color wantedColor)
        {
            Bitmap bmp = new Bitmap(50, 50);
            for (int with = 0; with < bmp.Width; with++)
                for (int height = 0; height < bmp.Height; height++)
                    bmp.SetPixel(with, height, wantedColor);
            return bmp;
        }
    }
}
