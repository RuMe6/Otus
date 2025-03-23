using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_BinaryTree
{
    internal class BinaryTreeNode
    {
        public TreeNode _node { get; set; }

        public void AddNode(string _name, int _salary)
        {
            _node = NewNode(_node, _name, _salary);
        }

        private TreeNode NewNode(TreeNode node, string _name, int _salary)
        {
            if(node == null) return new TreeNode(_name, _salary);
            if (_salary < node.salary) node.Left = NewNode(node.Left, _name, _salary);
            else if (_salary > node.salary) node.Right = NewNode(node.Right, _name, _salary);
            else node.Right = NewNode(node.Right, _name, _salary);

            return node;
        }


        private void SalaryDataPrint(TreeNode node)
        {
            if (node != null)
            {
                SalaryDataPrint(node.Right);
                Console.WriteLine($"Salary: {node.salary}, Name: {node.name}");
                SalaryDataPrint(node.Left);
            }
        }

        private TreeNode SalaryDataSearch(TreeNode node, int _salary)
        {
            if (node == null) return null;
            if (node.salary == _salary) return node;
            if (_salary < node.salary) return SalaryDataSearch(node.Left, _salary);
            return SalaryDataSearch(node.Right, _salary);

        }

        private void EraseTreeNode(TreeNode node)
        {
            if (node == null) return;

            EraseTreeNode(node.Left);
            EraseTreeNode(node.Right);

            node.Left = null;
            node.Right = null;
        }

        public void PrintData(TreeNode node)
        {
            SalaryDataPrint(node);
        }

        public TreeNode DataSearch(int value)
        {
            return SalaryDataSearch(_node, value);
        }

        public void ClearNode()
        {
            EraseTreeNode(_node);
            _node = null;
        }
    }
}
