
using System;

namespace Otus_BinaryTree
{
    internal class Program
    {
        public static int countNode = 0;
                
        static BinaryTreeNode binaryTreeNode = new BinaryTreeNode();
        static GetInputData getInputData = new GetInputData(binaryTreeNode);

        public static void Main(string[] args)
        {
            SetData();
        }

        public static void Search()
        {
            bool isNum = false;

            Console.WriteLine($"Введите зарплату для поиска...");

            do
            {
                isNum = int.TryParse(Console.ReadLine(), out int sum);
                if (isNum)
                {
                    TreeNode node = binaryTreeNode.DataSearch(sum);
                    var text = node != null ? 
                        $"Зарплата: {node.salary}, Сотрудник: {node.name}" 
                        : $"Такой сотрудник не найден";
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine($"Неверный формат.");
                }
            }
            while (!isNum);

            Action();
        }

        public static void SetData()
        {
            getInputData.GetData();

            binaryTreeNode.PrintData(binaryTreeNode._node );

            Action();
        }

        public static void EraseNode()
        {
            binaryTreeNode.ClearNode();
        }

        public static void Action()
        {
            bool isNum = false;

            Console.WriteLine($"Выберите действий" +
                $"\n0 - Начать заполнение заново." +
                $"\n1 - Перейти к поиску значений");

            do
            {
                isNum = int.TryParse(Console.ReadLine(), out int result);
                if (isNum)
                {
                    if (result == 0)
                    {
                        isNum = false;
                        EraseNode();
                        SetData();
                    }
                    else if (result == 1)
                    {
                        isNum = false;
                        Search();
                    }
                    else isNum = false;
                }                
            } 
            while (!isNum);
        }
    }
}
