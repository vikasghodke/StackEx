using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack;
public class Program
{


    static void Main(string[] args)
    {
        Stack s1 = new Stack(7);
        s1.push(2);
        s1.push(4);
        s1.push(5);
        s1.push(8);
        s1.push(9);

        s1.pop();
        s1.pop();
        s1.show();
    }
}
