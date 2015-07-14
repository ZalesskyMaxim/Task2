using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2BinaryTree
{
    public class TreeNode<TValue>
    {
        public TValue Value { get; set; }
        public TreeNode<TValue> Left { get; set; }
        public TreeNode<TValue> Right { get; set; }

        public TreeNode(TValue value)
        {
            this.Value = value;
        }
    }
}
