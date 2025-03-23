using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;


namespace Otus_Arrays
{
    static class ConsoleDataPrint
    {

        static StringBuilder sb1 = new StringBuilder("[ ");
        static StringBuilder sb2 = new StringBuilder("[ ");
        static StringBuilder sb3 = new StringBuilder("[ ");

        static int sb1Count;
        static int sb2Count;
        static int sb3Count;

        static public void BuildListConsoleMessage(int element)
        {
            sb1Count++;
            sb1.Append(element);
            sb1.Append(" - ");
            sb1.Append(" ]");
        }

        static public void BuildArrayListConsoleMessage(int element)
        {
            sb2Count++;
            sb2.Append(element);
            sb2.Append(" - ");
            sb2.Append(" ]");
        }

        static public void BuildLinkedListConsoleMessage(int element)
        {
            sb3Count++;
            sb3.Append(element);
            sb3.Append(" - ");
            sb3.Append(" ]");
        }
        static public void PrintList()
        {
            Console.Write("The total elements that divide to 777 is: " + sb1Count.ToString());
        }

        static public void PrintArrayList()
        {
            Console.Write("The total elements that divide to 777 is: " + sb2Count.ToString());
        }

        static public void PrintLinkedList()
        {
            Console.Write("The total elements that divide to 777 is: " + sb3Count.ToString());
        }

    }
}
