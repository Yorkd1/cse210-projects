public class Spinner
{
// create spinner method 
    public void ShowSpinner(int seconds)
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        List<string> spinner = new List<string>();
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        

        while (DateTime.Now < end)
        {
            
            foreach (string i in spinner)
            {    
                Console.Write(i);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            
        }

    }
}