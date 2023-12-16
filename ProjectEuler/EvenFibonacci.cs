namespace ProjectEuler
{
    public class EvenFibonacci
    {
        public static List<int> GetFibonacciSequence(int N)
        {
            var fibCollection = new List<int> { 1, 2 };

            if (N == 0 || N < 0) throw new Exception("Invalid fibonacci range");
            if (N == 1) return fibCollection.Slice(0, 1);
            if (N == 2) return fibCollection.Slice(0, 2);

            for (int i = 0; i < N - 2; i++)
                fibCollection.Add(fibCollection[i] + fibCollection[i + 1]);

            return fibCollection;
        }

        public static double FindSumOfEvenFibsUnderN(int N)
        {
            int index = 1;
            List<int> fibs = new List<int>();
            int last = 0;

            while (last < N)
            {
                fibs = GetFibonacciSequence(index);
                last = fibs.Last();
                index++;
            }

            var evenFibSum = fibs.Take(fibs.Count - 1).Where(f => f % 2 == 0).Sum();

            return evenFibSum;
        }
    }
}
