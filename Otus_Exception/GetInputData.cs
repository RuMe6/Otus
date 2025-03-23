using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Otus_Exception
{
    internal class GetInputData
    {
        ErrorSeverity errorSeverity = ErrorSeverity.Error;

        public void GetInputRun() 
        {
            GetInputRunMethod(); 
        }

        private void GetInputRunMethod()
        {
            double[] numbers = new double[3];
            char[] letters = { 'a', 'b', 'c' };

            for (byte i = 0; i < numbers.Length; )
            {
                try
                {
                    Console.WriteLine($"Enter the {letters[i]}'s number");

                    double number = double.Parse(Console.ReadLine());
                    numbers[i] = number;
                                        
                    if (i == 2) FindRootsEquation(numbers);
                    i++;
                }
                catch (Exception ex)
                {
                    FormatData(letters[i]);
                }
            }
        }

        private void FindRootsEquation(double[] numbers)
        {
            double a = numbers[0], b = numbers[1], c = numbers[2];

            double discr;
            try
            {
                discr = b * b - 4 * a * c;
                if (discr > 0)
                {
                    double d = (-b + Math.Sqrt(discr)) / (2 * a);
                    double d2 = (-b - Math.Sqrt(discr)) / (2 * a);
                    Console.WriteLine($"Два корня: {d}, {d2}");
                }
                else if (discr == 0)
                {
                    double d = -b / (2 * a);
                    Console.WriteLine($"Один корень: {d}");
                }
                else throw new RootsEquationNotFoundException("Вещественных значений не найдено");
            }
            catch(RootsEquationNotFoundException ex)
            {
                errorSeverity = ErrorSeverity.Warning;
                FormatData(ex);
            }            
        }

        private void FormatData(RootsEquationNotFoundException ex)
        {
            if (errorSeverity == ErrorSeverity.Warning)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                PrintLine();
                Console.WriteLine($"\n{ex.Message}");
                PrintLine();
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void FormatData(char _char)
        {
            if (errorSeverity == ErrorSeverity.Error)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                PrintLine();
                Console.WriteLine($"\nНеверный формат параметра {_char}");
                PrintLine();
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        
        private void PrintLine()
        {
            for( int i = 0; i < 50; i++)
            {
                Console.Write("-");                
            }
        }

        enum ErrorSeverity
        {
            Error,
            Warning
        }
    }
}
