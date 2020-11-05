using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace SortedTree
{
    /// <summary>
    /// Här ska du fylla på med lämplig information
    /// </summary>
    public class Tree : ITree
    {
        private class Node
        {
            public string Key { get; set; }
            public int Value { get; set; }
            public Node Left = null, Right = null;

            #region Drawing Methods

            // Drawing parameters.
            private const int NodeRadius = 10;
            private const int XSpacing = 20;
            private const int YSpacing = 20;
            private Point NodePoint;
            private Rectangle NodeRect;
            private Rectangle SubtreeRect;

            // Position the node assuming its size has already been set.
            public void PositionSubtree(int xmin, int ymin)
            {
                int xmax = xmin;

                // See if the node has any children.
                if ((Left == null) && (Right == null))
                {
                    // There are no children. Put the node here.
                    SubtreeRect = new Rectangle(
                        xmin, ymin, 2 * NodeRadius, 2 * NodeRadius);
                }
                else
                {
                    // Position the left subtree.
                    int height = 0;

                    if (Left != null)
                    {
                        Left.PositionSubtree(xmax, ymin + 2 * NodeRadius + YSpacing);

                        // Update xmax to allow room for the left subtree.
                        xmax = Left.SubtreeRect.Right;

                        // If there is also a right child, allow room between them.
                        if (Right != null) xmax += XSpacing;

                        // Update the height.
                        height = Left.SubtreeRect.Bottom;
                    }
                    else xmax += 2 * NodeRadius;

                    // Position the right subtree.
                    if (Right != null)
                    {
                        Right.PositionSubtree(xmax, ymin + 2 * NodeRadius + YSpacing);

                        // Update xmax.
                        xmax = Right.SubtreeRect.Right;

                        // Update the height.
                        if (Right.SubtreeRect.Bottom > height)
                            height = Right.SubtreeRect.Bottom;
                    }
                    else xmax += 2 * NodeRadius;

                    // Position this node centered over the subtrees.
                    SubtreeRect = new Rectangle(
                        xmin, ymin, xmax - xmin, 2 * NodeRadius + YSpacing + height);
                }

                // Position the node.
                NodePoint = new Point(
                    (SubtreeRect.Left + SubtreeRect.Right) / 2,
                    SubtreeRect.Top + NodeRadius);
                NodeRect = new Rectangle(
                    NodePoint.X - NodeRadius, NodePoint.Y - NodeRadius,
                    2 * NodeRadius, 2 * NodeRadius);
            }

            // Draw the subtree's links.
            public void DrawSubtreeLinks(Graphics gr, Pen pen)
            {
                if (Left != null)
                {
                    Left.DrawSubtreeLinks(gr, pen);
                    gr.DrawLine(pen, NodePoint, Left.NodePoint);
                }
                if (Right != null)
                {
                    Right.DrawSubtreeLinks(gr, pen);
                    gr.DrawLine(pen, NodePoint, Right.NodePoint);
                }
            }

            // Draw the subtree's nodes.
            public void DrawSubtreeNodes(Graphics gr, Font font, Brush fgBrush, Brush bgBrush, Pen pen)
            {
                // Draw the node.
                gr.FillEllipse(bgBrush, NodeRect);
                gr.DrawEllipse(pen, NodeRect);
                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    gr.DrawString(Key.ToString(), font, fgBrush, NodeRect, format);
                }

                // Draw the descendants' nodes.
                if (Left != null) Left.DrawSubtreeNodes(gr, font, fgBrush, bgBrush, pen);
                if (Right != null) Right.DrawSubtreeNodes(gr, font, fgBrush, bgBrush, pen);
            }

            #endregion Drawing Methods
        }

        #region Drawing Methods
        public void PositionSubtree(int xmin, int ymin)
        {
            root.PositionSubtree(xmin, ymin);
        }

        public void DrawSubtreeLinks(Graphics gr, Pen pen)
        {
            root.DrawSubtreeLinks(gr, pen);
        }

        public void DrawSubtreeNodes(Graphics gr, Font font, Brush fgBrush, Brush bgBrush, Pen pen)
        {
            root.DrawSubtreeNodes(gr, font, fgBrush, bgBrush, pen);
        }
        #endregion

        internal List<string> traverselist = new List<string>();

        private Node root;
        public int Count { get; private set; }

        public void Add(string key, int value)
        {
            Add(key, value, ref root);
        }
        public void Traverse(ListBox listbox)
        {
            Traverse(listbox, ref root);
        }
        public void Traverse(string fileName)
        {
            Traverse(fileName, ref root);
        }
        public bool Contains(string key)
        {
            return Contains(key, ref root);
        }
        public int Get(string key, int dummy)
        {
            return Get(key, dummy, ref root);
        }
        public void Set(string key, int newValue)
        {
            Set(key, newValue, ref root);
        }
        public void Remove(string key)
        {
            Remove(key, ref root);
        }

        public int Height()
        {
            return Height(ref root);
        }

        private void Add(string key, int value, ref Node subroot)
        {
            if (subroot == null)
            {
                subroot = new Node() { Key = key, Value = value };
                Count++;
            }
            else if (key.CompareTo(subroot.Key) < 0)
                Add(key, value, ref subroot.Left);
            else
                Add(key, value, ref subroot.Right);
        }
        private void Traverse(ListBox listbox, ref Node subroot)
        {
            if (subroot == null)
            {
                listbox.Items.Add("The tree is empty");
            }
            else
            {
                List<string> listan = Traverse(ref subroot);
                foreach(string item in listan)
                {
                    listbox.Items.Add(item);
                }
                listan.Clear();
            }
        }

        private void Traverse(string fileName, ref Node subroot)
        {

            if (subroot == null)
            {
                return;
            }
            else
            {
                List<string> listan = Traverse(ref subroot);
                File.WriteAllLines(fileName, listan);
                listan.Clear();
            }
        }


        private List<string> Traverse(ref Node subroot)
        {
              if (subroot == null)
                 {
                     return null;
                 }
                 else
                 {
                     Node traverseNode = subroot;

                     if (traverseNode.Left != null)
                     {
                         Traverse(ref traverseNode.Left);
                     }

                traverselist.Add(traverseNode.Key + "\t" + traverseNode.Value);

                    if (traverseNode.Right != null)
                         {
                             Traverse(ref traverseNode.Right);
                         }
                     }

                return traverselist;
        }
        private bool Contains(string key, ref Node subroot)
        {
           if (findNode(key, ref subroot) == null)
            {
                return false;
            } else
            {
                return true;
            }
        }
        private int Get(string key, int dummy, ref Node subroot)
        {
            Node noden = findNode(key, ref subroot);
            if (noden != null)
            {
                return noden.Value;
            }
            else
            {
                return dummy;
            }
        }
        private void Set(string key, int newValue, ref Node subroot)
        {
            Node noden = findNode(key, ref subroot);
            if (noden == null)
            {
                return;
            }
            else
            {
                noden.Value = newValue;
            }
        }

        private Node findNode(string key, ref Node subroot)
        {
            if (subroot == null) return null;

            Node noden = subroot;

            if (string.Compare(noden.Value.ToString(), key) == 0)
            {
                return noden;
            }
            else
            {
                if (string.Compare(key, noden.Key) == -1) { return findNode(key, ref noden.Left); }
                if (string.Compare(key, noden.Key) == 1) { return findNode(key, ref noden.Right); }
            }
            return noden;
        }

        private void Remove(string key, ref Node subroot)
        {
            if (subroot == null) return;

            if (string.Compare(key, subroot.Key) == -1)
            {
                Remove(key, ref subroot.Left);
            }
            else if (string.Compare(key, subroot.Key) == 1) 
            {
                Remove(key, ref subroot.Right);
            }
            else if (subroot.Left != null && subroot.Right != null)
            {
                Node minstaNod = findMin(ref subroot.Right);
                subroot.Key = minstaNod.Key; subroot.Value = minstaNod.Value;
                Remove(subroot.Key, ref subroot.Right);
            }
            else
            {
                if (subroot.Left != null)
                {
                    subroot = subroot.Left;
                    Count--;
                }
                else
                {
                    subroot = subroot.Right;
                    Count--;
                }
            }
        }

        private Node findMin(ref Node subroot)
        {
            if (subroot == null) return null;
            Node currentNode = subroot;
            while (currentNode.Left != null)
            {
                currentNode = currentNode.Left;
            }
            return currentNode;
        }

        private int Height(ref Node subroot)
        {
            if (subroot == null)
            {
                return -1;
            }
            else
            {
                int leftHeight = Height(ref subroot.Left);
                int rightHeight = Height(ref subroot.Right);
                int maxHeight = Math.Max(leftHeight, rightHeight);
                return maxHeight + 1;
            }
        }
    }
}