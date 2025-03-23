using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Otus_BinaryTree
{
    internal class GetInputData
    {
        BinaryTreeNode binaryTreeNode;
        public GetInputData(BinaryTreeNode binaryTreeNode)
        {
            this.binaryTreeNode = binaryTreeNode;
        }

        public void GetData()
        {
            bool isStarted = true;

            do
            {
                string name = GetName();
                int salary;
                if (name == " ")
                {
                    isStarted = false;
                    break;
                }
                else salary = GetSalary();
                binaryTreeNode.AddNode(name, salary);

            }while(isStarted);

        }

        private string GetName()
        {
            string _name = string.Empty;
            bool isName = true;

            do
            {
                Console.WriteLine("Введите имя, или нажмите Пробел для завершения ввода.");
                _name = Console.ReadLine();

                if (_name != string.Empty) isName = false;
                else if (string.IsNullOrEmpty(_name))
                {
                    Console.WriteLine("Поле \"Имя\" не должно быть пустым.");
                    isName = true;
                }
            } while (isName);

            return _name;
        }

        private int GetSalary()
        {
            int _salary = 0;
            bool isNum = false;

            do
            {
                Console.WriteLine("Введите зарплату...");
                isNum = int.TryParse(Console.ReadLine(), out int slr);
                if (!isNum)
                {
                    Console.WriteLine("Введите числовые значения.");
                }
                _salary = slr;

            } while (!isNum);

            return _salary;
        }
    }
}