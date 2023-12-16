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

        [Test]
        public void First10FibTerms()
        {
            var firstTenFibTerms = EvenFibonacci.GetFibonacciSequence(10);

            Assert.That(firstTenFibTerms, Is.EquivalentTo(new List<int> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 }));
        }

        [Test]
        public void FirstFibTerm()
        {
            var firstFibTerm = EvenFibonacci.GetFibonacciSequence(1);

            Assert.That(firstFibTerm, Is.EquivalentTo(new List<int> { 1 }));
        }

        [Test]
        public void FirstTwoFibTerms()
        {
            var firstTwoFibTerms = EvenFibonacci.GetFibonacciSequence(2);

            Assert.That(firstTwoFibTerms, Is.EquivalentTo(new List<int> { 1, 2 }));
        }
    }
}