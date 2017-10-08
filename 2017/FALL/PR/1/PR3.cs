using System;


namespace PR2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 32;
            string s = "";
            while (x > 0)
            {
                s = ((x % 2 == 0) ? "0" : "1") + s;
                x /= 2; //  в правильном порядке
            }
                s += " ";
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    s += s[i] + ""; // в обратном 
                }
            
            Console.WriteLine(s); 



        }
    }
}
