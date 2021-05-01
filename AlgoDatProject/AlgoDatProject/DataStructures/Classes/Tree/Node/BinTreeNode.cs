using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDatProject.DataStructures.Classes.Tree.Node
{
    class BinTreeNode
    {
        protected BinTreeNode leftChild = null, rightChild = null;
        protected int key;

        //Constructors
        #region
        public BinTreeNode(int key)
        {
            this.key = key;
        }
        #endregion

        public void Append(int key)
        {
            if (this.key == key) return;
            if (key > this.key) { if (rightChild != null) rightChild.Append(key); } else { rightChild = new BinTreeNode(key); }
            if (key < this.key) { if (leftChild != null) leftChild.Append(key); } else { leftChild = new BinTreeNode(key); }
        }

        public bool Search(int key)
        {
            if(key > this.key)
            {
                if (rightChild == null) return false;
                if(rightChild.key == key) { return true; } else { return rightChild.Search(key); }
            }
            if(key < this.key)
            {
                if (leftChild== null) return false;
                if (leftChild.key == key) { return true; } else { return leftChild.Search(key); }
            }
            return false;
        }
    }
}
