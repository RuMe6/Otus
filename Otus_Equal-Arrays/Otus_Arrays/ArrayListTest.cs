using System;
using System.Collections;
using cnsl = System.Console;

namespace Otus_Arrays
{
    internal class ArrayListTest
    {
        ArrayList arrayList = new ArrayList();

        Random rnd = new Random();

        internal void ArrayListAddData(int maxValue)
        {
            WatchTimer.StartWatchTimer();

            for (int i = 0; i < maxValue; i++)
            {
                arrayList.Add(i);                
                //arrayList.Add(rnd.Next(maxValue + 1));
                //cnsl.WriteLine(i);
            }

            WatchTimer.StopWatchTimer();
                        
            //cnsl.WriteLine(ConsoleDataPrint.BuildConsoleMessage(ref arrayList));
            cnsl.WriteLine();
            cnsl.WriteLine("The time of adding items to ArrayList: " + WatchTimer.ElapsedTimer());
        }

        internal void FindElementInArrayList(int value)
        {
            WatchTimer.StartWatchTimer();

            var el = arrayList.IndexOf(value);

            WatchTimer.StopWatchTimer();

            cnsl.WriteLine(@"The time of find element {0} in ArrayList: " + WatchTimer.ElapsedTimer(), el);
        }

        internal void ArrayListDivisionByElement(int value)
        {
            WatchTimer.StartWatchTimer();

            //for(int i = 0; i <= value; i++)
            foreach(int element in arrayList)
            {
                if (element % value == 0)
                {
                    ConsoleDataPrint.BuildArrayListConsoleMessage(element);
                }
            }
            WatchTimer.StopWatchTimer();
            
            cnsl.WriteLine("The time of Division Operations in ArrayList: " + WatchTimer.ElapsedTimer());
            ConsoleDataPrint.PrintArrayList();
            cnsl.WriteLine();
        }
    }
}
