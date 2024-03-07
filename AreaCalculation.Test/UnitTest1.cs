namespace AreaCalculation.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Circle_Test()
        {
            var res = Area.Circle(4);
            double correct = 50.26548245743669;

            Assert.AreEqual(correct, res);
        }

        [Test]
        public void Triangle_Test()
        {
            var res = Area.Triangle(10, 20, 25);
            double correct = 94.99177595981665;

            Assert.AreEqual(correct, res);
        }

        [Test]
        public void TriangleAny_Test()
        {
            var res = Area.Any(10, 20, 25);
            double correct = 94.99177595981665;

            Assert.AreEqual(correct, res);
        }

        [Test]
        public void CircleAny_Test()
        {
            var res = Area.Any(4);
            double correct = 50.26548245743669;

            Assert.AreEqual(correct, res);
        }

        [Test]
        public void CircleEx_Test()
        {
            Assert.Throws<ArgumentException>(() => Area.Circle(-4));
        }

        [Test]
        public void TriangleEx_Test()
        {
            Assert.Throws<ArgumentException>(() => Area.Triangle(1, 2, 3));
        }
    }
}