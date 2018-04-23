using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class IntNode
    {
        public IntNode Next { get; }
        public int Val { get; }
        public IntNode(int i, IntNode n)
            {

            Val = i;
            Next = n;

            }
    }
}
