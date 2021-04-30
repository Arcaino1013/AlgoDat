using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoDatProject
{
    interface IDictionary
    {
        bool Search(int key);
        void Insert(int key);
        void Delete(int key);
        void Print();
    }
}
