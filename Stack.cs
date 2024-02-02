using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        public int[] arr;
        public int top;
        public int stacksize;

        public Stack(int size)
        {
            top = -1;
            arr = new int[size];
            stacksize= size;
        }
        public void push(int value)
        {
            if(top!=stacksize-1)
            {
                arr[++top] = value;
            }
            else
            {
                Console.WriteLine("Stack is overflow");
            }
        }
        public void pop()
        {
            if (top==-1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                top--;
            }
        }
        public int size()
        {
            return stacksize;
        }
        public void show()
        {
            for(int i = 0; i < top + 1; i++)
            {
                Console.WriteLine(arr[i]);  
            }
        }
    }
}
