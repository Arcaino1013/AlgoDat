using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoDatProject.DataStructures.Classes.Tree.Node;

namespace AlgoDatProject.DataStructures.Classes.Tree
{
    public class BinSearchTree : ISetSorted
    {
        BinTreeNode rootNode;

        public BinSearchTree(int key)
        {
            rootNode = new BinTreeNode(key);
        }

        public BinSearchTree(params int[] key)
        {
            rootNode = new BinTreeNode(key[0]);
            for (int i = 1; i < key.Length; i++)
            {
                Insert(key[i]);
            }
        }

        #region
        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public void Insert(params int[] key)
        {
            for(int i = 0; i < key.Length; i++)
            {
                Insert(key[i]);
            }
        }

        public void Insert(int key)
        {
            rootNode.Append(key);
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public bool Search(int key)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
