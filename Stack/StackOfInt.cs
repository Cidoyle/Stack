using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackOfInt
    {
        private int[] data;
        private int top = 0;

        
        public StackOfInt(int i)
        {
            data = new int[i];
        }

        public void push(int i)
        {
            data[top++] = i;
        }

        public int pop()
        {
            if (top == 0)
            {
                throw new Exception("Underflow");
                
            }

            top = top - 1;


            return data[top];

        }

    }
}
