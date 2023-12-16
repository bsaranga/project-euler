using ProjectEuler;

namespace ProjecEulerTests
{
    public class EulerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(10)]
        public void MultiplesOf3And5UnderANumberN(int N)
        {
            int result = MultiplesOf3And5.GetMultiplesOf3And5BelowN(N);

            Assert.That(result, Is.EqualTo(23));
        }
    }
}