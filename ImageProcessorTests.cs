using NUnit.Framework;
using System.Drawing;
using System.IO;

namespace Testing_3.Tests
{
    public class ImageProcessorTests
    {
        private readonly ImageProcessor processor = new();
        private const string TestImagePath = "C:\\Users\\taych\\OneDrive\\Изображения\\test_images\\sample.jpg";

        [Test]
        public void LoadImage_ShouldReturnImage()
        {
            var image = processor.LoadImage(TestImagePath);
            Assert.IsNotNull(image);
            Assert.IsInstanceOf<Image>(image);
        }
    }
}