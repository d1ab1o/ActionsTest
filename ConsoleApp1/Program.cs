namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var class1 = new Class1();

            for (var i = 0; i < 10; i++)
            {
                class1.LogMessage("Console App 1");
            }
        }
    }
}