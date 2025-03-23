using System;
using System.Collections.Generic;
using System.Drawing;

namespace Otus_Classes
{
    public class StackClass
    {
        List<string> data = new List<string>();

        public int Size 
        { 
            get => data.Count; 
        }
        public string? Top
        {
            get
            {
                return data[Size - 1];
            }
        }

        public StackClass(params string[] temp)
        {
            for (int i = 0; i < temp.Length; i++ )
            {
                data.Add(temp[i]);
                Console.WriteLine($"Word '{temp[i]}' was added to List.\n" +
                    $"List have {i + 1} element");
            }
        }

        public void AddData(string element)
        {
            data.Add(element);
            Console.WriteLine($"\n\tThe '{element}' was added to Stack. STACK size = {Size}\n");
        }

        public void PopData()
        {
            try
            {
                var temp = Top;

                data.RemoveAt(Size - 1);
                Console.WriteLine($"\n\tThe '{temp}' was removed from Stack. STACK size = {Size}.\n");
       
            }
            catch
            {
                 Console.WriteLine("\n\tThe STACK IS NULL... \n");                
            }
        }
    }
}
