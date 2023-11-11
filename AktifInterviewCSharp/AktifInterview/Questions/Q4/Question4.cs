namespace AktifInterview.Questions.Q4
{
    public class Question4
    {
        //Description: ForEach method provides loop in items with linq
        public void DescriptionAndUsingOfForEachMethod()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var list2 = new List<int>() { 1, 2, 3, 4 };
            //Using
            list1.ForEach(x =>
            {
                if (x > 4)
                    list2.Add(x);
            });
        }
    }
}
