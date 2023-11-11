using AktifInterview.Questions.Q2;

namespace AktifInterview.Questions.Q1
{
    public class Question1
    {
        public int GetSumOfEvenNumsInArray(int[] array)
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));

            int sum = 0;

            foreach (int number in array)
                if (number % 2 == 0)
                    sum += number;

            return sum;
        }

        public int GetSumOfEvenNumsInArrayWithLinq(int[] array)
            => array is null
            ? throw new ArgumentNullException(nameof(array))
            : array.Where(x => x % 2 == 0).Sum();
    }
}
