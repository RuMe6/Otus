using System;
using cnsl = System.Console;

namespace Otus_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxValue = 1_000_000;
            const int elementToFind = 496_753;
            const int elementForDivivsion = 777;

            #region Add Items, Find element, Division to element in Arrays
            ListTest listTest = new ListTest();
            listTest.ListAddData(maxValue);
            listTest.FindElementInList(elementToFind);
            listTest.ListDivisionByElement(elementForDivivsion);

            cnsl.ReadKey();

            ArrayListTest arrayListTest = new ArrayListTest();
            arrayListTest.ArrayListAddData(maxValue);
            arrayListTest.FindElementInArrayList(elementToFind);
            arrayListTest.ArrayListDivisionByElement(elementForDivivsion);

            cnsl.ReadKey();

            LinkedListTest linkedListTest = new LinkedListTest();
            linkedListTest.LinkedListAddData(maxValue);
            linkedListTest.FindElementInLinkedList(elementToFind);
            linkedListTest.LinkedListDivisionByElement(elementForDivivsion);

            cnsl.ReadKey();

            #endregion

        }
    }
}
