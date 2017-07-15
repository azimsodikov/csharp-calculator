using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Calculator
    {
        public int Add(int x, int y) 
        {
            int sum = (x + y);
            return sum;
        } 
        public int Subtract(int x, int y) 
        {
            int sum = (x - y);
            return sum;
        }  
        public int Multiply(int x, int y) 
        {
            int sum = (x * y);
            return sum;
        }  
        public int Divide(int x, int y) 
        {
            int sum = (x / y);
            return sum;
        }         
    }
}
