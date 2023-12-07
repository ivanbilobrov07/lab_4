using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class MathOperations
    {
        public event DivisionHandler OnEvent;
        public delegate void DivisionHandler(int result, EventArgs args);

        public int Addition (int a, int b) {  return a + b; }

        public int Subtraction (int a, int b) { return a - b; }

        public int Multiplication (int a, int b) { return a * b; }

        public int Division (int a, int b) 
        {
            if (OnEvent == null) return -1;

            OnEvent.Invoke(a / b, EventArgs.Empty);

            return a / b;
        }
    }
}
