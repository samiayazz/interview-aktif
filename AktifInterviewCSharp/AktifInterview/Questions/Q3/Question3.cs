using System.Reflection.Metadata.Ecma335;

namespace AktifInterview.Questions.Q3
{
    public class Question3
    {
        public List<int> MergeSortedLists(List<int> list1, List<int> list2)
        {
            //Removing same values and sorting and null checks
            list1 ??= new List<int>(); list1 = list1.Distinct().ToList(); list1.Sort();
            list2 ??= new List<int>(); list2 = list2.Distinct().ToList(); list2.Sort();
            List<int> sameValuesInTwoLists = new List<int>();
            list1.ForEach(x =>
            {
                if (list2.Contains(x))
                    sameValuesInTwoLists.Add(x);
            });
            list1.RemoveAll(x => sameValuesInTwoLists.Contains(x));

            var mergedSortedList = new List<int>();

            for (int i = 0, j = 0; i < list1.Count || j < list2.Count;)
            {
                if (i == list1.Count && j != list2.Count)
                {
                    mergedSortedList.AddRange(list2.GetRange(j, list2.Count - j));
                    return mergedSortedList;
                }
                else if (j == list2.Count && i != list1.Count)
                {
                    mergedSortedList.AddRange(list1.GetRange(i, list1.Count - i));
                    return mergedSortedList;
                }

                var item1 = list1[i];
                var item2 = list2[j];

                if (item1 < item2)
                {
                    mergedSortedList.Add(item1);
                    i++;
                }
                else if (item2 < item1)
                {
                    mergedSortedList.Add(item2);
                    j++;
                }
            }

            return mergedSortedList;
        }
    }
}
