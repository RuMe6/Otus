using System;
using System.Collections;
using cnsl = System.Console;


namespace Otus_Arrays
{
    internal class LinkedListTest
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        Random rnd = new Random();

        internal void LinkedListAddData(int maxValue)
        {
            WatchTimer.StartWatchTimer();

            for (int i = 1; i < maxValue; i++)
            {
                linkedList.AddLast(i);
                //cnsl.WriteLine(i);
            }

            WatchTimer.StopWatchTimer();

            //cnsl.WriteLine();
            //cnsl.WriteLine(ConsoleDataPrint.BuildConsoleMessage(ref linkedList));
            cnsl.WriteLine();
            cnsl.WriteLine("The time of adding items to list: " + WatchTimer.ElapsedTimer());
        }

        internal void FindElementInLinkedList(int value)
        {
            WatchTimer.StartWatchTimer();

            var el = linkedList.ElementAt(value - 1);

            WatchTimer.StopWatchTimer();

            cnsl.WriteLine(@"The time of find element in {0} LinkedList: " + WatchTimer.ElapsedTimer(), el);
        }

        internal void LinkedListDivisionByElement(int value)
        {
            WatchTimer.StartWatchTimer();
            foreach (int element in linkedList)
            {
                if (element % value == 0)
                {
                    ConsoleDataPrint.BuildLinkedListConsoleMessage(element);
                }
            }
            WatchTimer.StopWatchTimer();
            
            cnsl.WriteLine("The time of Division Operations in LinkedList: " + WatchTimer.ElapsedTimer());
            ConsoleDataPrint.PrintLinkedList();
            cnsl.WriteLine();
        }
    }
}