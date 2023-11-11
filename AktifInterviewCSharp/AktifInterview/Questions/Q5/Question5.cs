namespace AktifInterview.Questions.Q5
{
    public class Question5
    {
        /* Potential Pitfalls
         * The lock keyword stops threads other than the thread on which it is used
         * In this way, the class is prevented from receiving more than one request at the same time and from creating instances more than once.*/
        Question5() { }

        static readonly object lockControl = new object();
        static Question5 Instance;
        public static Question5 GetInstance
        {
            get
            {
                lock (lockControl)
                    return Instance ??= new Question5();
            }
        }
    }
}
