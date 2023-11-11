namespace AktifInterview.Questions.Q8
{
    public class Question8
    {
        public void SaySomething(string sentence)
        {
            string result = "";
            try
            {
                if (String.IsNullOrEmpty(sentence))
                    throw new ArgumentNullException("The sentence isn't nullable!");

                result = sentence;
            }
            catch (ArgumentNullException ex)
            {
                result = "ArgumentNullException: " + ex.Message;
            }
            catch (Exception)
            {
                result = "An unexpected error occurred!";
            }
            finally
            {
                Console.WriteLine(result);
            }
        }
    }
}
