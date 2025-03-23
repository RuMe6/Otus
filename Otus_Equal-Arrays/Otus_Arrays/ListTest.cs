using System;
using System.Collections;
using cnsl = System.Console;

namespace Otus_Arrays
{
    internal class ListTest
    {
        List<int> list = new List<int>();

        Random rnd = new Random();
        
        internal void ListAddData(int maxValue)
        {            
            WatchTimer.StartWatchTimer();

            for (int i = 0; i <= maxValue; i++)
            {
                list.Add(i);
                //list.Add(rnd.Next(maxValue + 1));
                //cnsl.WriteLine(list[i]);
            }

            WatchTimer.StopWatchTimer();
            
            //cnsl.WriteLine(ConsoleDataPrint.BuildConsoleMessage(ref list));
            cnsl.WriteLine();
            cnsl.WriteLine("The time of adding items to List: " + WatchTimer.ElapsedTimer());
        }

        internal void FindElementInList(int value)
        {
            WatchTimer.StartWatchTimer();

            var el = list.IndexOf(value);

            WatchTimer.StopWatchTimer();

            cnsl.WriteLine(@"The time of find element {0} in List: " + WatchTimer.ElapsedTimer(), el);
        }

        internal void ListDivisionByElement(int value)
        {
            WatchTimer.StartWatchTimer();

            foreach (int element in list)
            {
                if (element % value == 0)
                {
                    ConsoleDataPrint.BuildListConsoleMessage(element);
                }
            }
            WatchTimer.StopWatchTimer();

            cnsl.WriteLine("The time of Division Operations in List: " + WatchTimer.ElapsedTimer());
            ConsoleDataPrint.PrintList();
            cnsl.WriteLine();
        }
    }
}
