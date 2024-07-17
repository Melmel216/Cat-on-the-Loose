namespace ConsoleHelpers
{
    public static class Helpers
    {
        public static void TypeWriter(string text, int milisecondDelay)
        {
            foreach (char c in text)
            {
                if (c != '\n' || c != '\"')
                {
                    Console.Write(c);
                    Thread.Sleep(milisecondDelay);
                }  
            }
            Console.Write("\n\n");
        }

        //Helpers.TypeWriter("", 70);
    }
}
