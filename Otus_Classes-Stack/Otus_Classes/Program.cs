
namespace Otus_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackClass sc = new StackClass("a", "b", "c");
            
            bool start = true;

            while(start)
            {
                Console.WriteLine("For the adding items to Stack, Enter '1'.\n" +
                "For the deleting the items from Stack, Enter '2'.\n" +
                "For exit, Enter '9'.\n");

                byte temp = 0;
                string? num = Console.ReadLine();
                bool boolNum = byte.TryParse(num, out byte result);
                if (boolNum == true)
                {
                    if ((result > 0) && (result < 3)) temp = result;
                    if (result == 9)
                    {
                        start = false;
                        break;
                    }
                }

                switch (temp)
                {
                    case 1:
                        Console.WriteLine("\nPlease enter the item to adding....\n");
                        string? addData = Console.ReadLine();
                        sc.AddData(addData);
                        break;
                    case 2:
                        sc.PopData();
                        break;
                }
            }
        }
    }
}
