using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_BinaryTree
{
    internal class TreeNode
    {
        public string name;
        public int salary;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(string _name, int _salary)
        {
            name = _name;
            salary = _salary;
            Left = Right = null;
        }
    }
}