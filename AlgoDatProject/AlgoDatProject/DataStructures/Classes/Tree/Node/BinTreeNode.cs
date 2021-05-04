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

        public bool Search(int key, out BinTreeNode toDeleteParent)
        {
            toDeleteParent = null;
            if(key > this.key)
            {
                if (rightChild == null) return false;
                if(rightChild.key == key) { toDeleteParent = this; return true; } else { return rightChild.Search(key, out toDeleteParent); }
            }
            if(key < this.key)
            {
                if (leftChild== null) return false;
                if (leftChild.key == key) { toDeleteParent = this; return true; } else { return leftChild.Search(key, out toDeleteParent); }
            }
            return false;
        }

        public void Delete(int key)
        {
            BinTreeNode toDelete = null, successorNode = null;
            //Step 1 : Find out which child has to be deleted or if an error has ocurred
            if (leftChild.key == key) { toDelete = leftChild; } else if (rightChild.key == key) {toDelete = rightChild;} else { throw new Exception("The key cannot be found"); }
            
            //step 2 : Find the successor node
            if (toDelete.leftChild != null && toDelete.rightChild == null) { successorNode = toDelete.leftChild;}
            if (toDelete.leftChild == null && toDelete.rightChild != null) { successorNode = toDelete.rightChild;}
            if (toDelete.leftChild != null && toDelete.rightChild != null)
            {
                successorNode = this.leftChild.FindSuccesor();
            }

            //Step 3 : Delete Node and place Succesor
            if(toDelete == this.leftChild) 
            {
                this.leftChild = successorNode;
                toDelete = null;
                return;
            }
            if(toDelete == this.rightChild) 
            {
                this.rightChild = successorNode;
                toDelete = null;
                return;
            }
            throw new Exception("You shouldnt have reached the end. Something went wrong while finding the node you should delete");
        }

        protected BinTreeNode FindSuccesor()
        {
            if (this.rightChild != null) return this.rightChild.FindSuccesor();
            return this;
        } 
    }
}
