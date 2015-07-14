using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2BinaryTree
{
    class BinaryTree<T>// : ICollection<T>
    {
        private TreeNode<T> root;
        //private IComparer<T> comparer;

        public BinaryTree()
        {
            //comparer = Comparer<T>.Default;
        }

        
        public int Compare(object x, object y)
        {
            Word wordX;
            Word wordY;
            if (x is Word)
            {
                wordX = (Word)x;
            }
            else { return 0; }
            if (y is Word)
            {
                wordY = (Word)y;
            }
            else { return 0; }
            return string.Compare(wordX.Value, wordY.Value);
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var value in collection)
                Add(value);
        }

        public int Count { get; protected set; }
        public void Add(T item)
        {
            var node = new TreeNode<T>(item);

            if (root == null)
                root = node;
            else
            {
                TreeNode<T> current = root, parent = null;

                while (current != null)
                {
                    parent = current;
                    if (Compare(item, current.Value) < 0)
                        current = current.Left;
                    else
                        current = current.Right;
                }

                if (Compare(item, parent.Value) < 0)
                    parent.Left = node;
                else
                    parent.Right = node;
            }
            ++Count;
        }

        public void Clear()
        {
            root = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            var current = root;
            while (current != null)
            {
                var result = Compare(item, current.Value);
                if (result == 0)
                    return true;
                if (result < 0)
                    current = current.Left;
                else
                    current = current.Right;
            }
            return false;
        }

        public TreeNode<T> FindItem(T item)
        { 
            var current = root;
            while (current != null)
            {
                var result = Compare(item, current.Value);
                if (result == 0) 
                { 
                    Console.WriteLine("Seeking element: {0}", current.Value); 
                    return current;
                }
                if (result < 0) { current = current.Left; }
                else { current = current.Right; }
            }
            //Console.WriteLine("Element is not find");
            //throw new Exception("Element is not find");
            return null;
        }

        public IEnumerable<T> Inorder()
        {
            if (root == null)
                yield break;

            var stack = new Stack<TreeNode<T>>();
            var node = root;

            while (stack.Count > 0 || node != null)
            {
                if (node == null)
                {
                    node = stack.Pop();
                    yield return node.Value;
                    node = node.Right;
                }
                else
                {
                    stack.Push(node);
                    node = node.Left;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Inorder().GetEnumerator();
        }

    }
}
