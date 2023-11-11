using AktifInterview.Questions.Q1;
using AktifInterview.Questions.Q2;
using AktifInterview.Questions.Q3;
using AktifInterview.Questions.Q4;
using AktifInterview.Questions.Q5;
using AktifInterview.Questions.Q7;
using AktifInterview.Questions.Q8;

namespace AktifInterview
{
    public class Program
    {
        static void Main(string[] args)
        {
            Question1();
            //Question2();
            //Question3();
            //Question4();
            //Question5ThreadSafe();
            //Question7();
            //Question8();

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.Write("Press any key to close the application.");
            Console.ReadKey();
        }

        #region Question1
        static void Question1()
        {
            var question = new Question1();

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sumOfEvenNums = question.GetSumOfEvenNumsInArray(array);
            Console.WriteLine("Sum of even numbers in the array: " + sumOfEvenNums);
        }
        #endregion

        #region Question2
        static void Question2()
        {
            var question = new Question2();

            var products = new List<Product>
            {
                new Product("Laptop", 9_499.9f),
                new Product("Telefon", 7_999.9f),
                new Product("Defter", 7.5f)
            };
            var filteredProducts = question.FilterProductsWherePriceGreaterThan100(products);

            if (filteredProducts.Count > 0)
                Console.WriteLine("The products where price is greater than 100:");

            filteredProducts.ForEach(product
                => Console.WriteLine(product.Name));

        }
        #endregion

        #region Question3
        static void Question3()
        {
            var question = new Question3();

            var list1 = new List<int> { 7, 1, 5, 4, 5, 6 };
            var list2 = new List<int> { 8, 1, 4, 5, 4 };
            var mergedSortedList = question.MergeSortedLists(list1, list2);

            if (mergedSortedList.Count > 0)
                Console.WriteLine("Merged Sorted List :");

            mergedSortedList.ForEach(x => Console.WriteLine(x));
        }
        #endregion

        #region Question4
        static void Question4()
        {
            var question = new Question4();

            question.DescriptionAndUsingOfForEachMethod();
        }
        #endregion

        #region Question5
        static void Question5ThreadSafe()
        {
            var questionInstance1 = Question5.GetInstance;
            var questionInstance2 = Question5.GetInstance;

            Console.WriteLine($"    ==  : {questionInstance1 == questionInstance2}");
            Console.WriteLine($"Equals  : {questionInstance1.Equals(questionInstance2)}");
        }
        #endregion

        #region Question7
        static void Question7()
        {
            string email = "ayazzsami@gmail.com";
            string result = email.IsValidEmailFormat() ? "Email format is correct" : "Email format is wrong";
            Console.WriteLine(result);
        }
        #endregion

        #region Question8
        static void Question8()
        {
            var question = new Question8();
            question.SaySomething("Hello, World!");
        }
        #endregion
    }
}