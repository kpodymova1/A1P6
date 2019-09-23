using System;

namespace A1P6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a very questionable approach.");
            Console.WriteLine("I did not turn it into a method, but I got the numbers.");
            string uber = "UBER";
            Console.WriteLine("For 'UBER', we have:");
			foreach (byte b in System.Text.Encoding.UTF8.GetBytes(uber.ToCharArray()))
				Console.Write(b.ToString() + " ");
            Console.Write("\n");
            Console.WriteLine("And for '+COOL', we have:");
            string cool = "+COOL";
            foreach (byte z in System.Text.Encoding.UTF8.GetBytes(cool.ToCharArray()))
                Console.Write(z.ToString() + " ");
            Console.Write("\n");
            Console.WriteLine("For 'uncle', we need to get:");
            string uncle = "uncle";
            foreach (byte f in System.Text.Encoding.UTF8.GetBytes(uncle.ToCharArray()))
                Console.Write(f.ToString() + " ");
            Console.Write("\n");
            Console.WriteLine("I decided to manualy assign these values to characters to avoid making extra mistakes.");
            int U = 85;
            int B = 66;
            int E = 69;
            int R = 82;
            int P = 43;
            int C = 67;
            int O = 79;
            int L = 76;
            int u = 117;
            int n = 110;
            int c = 99;
            int l = 108;
            int e = 101;
            Console.WriteLine("-----");
            Console.WriteLine("U = " + U);
            Console.WriteLine("B = " + B);
            Console.WriteLine("E = " + E);
            Console.WriteLine("R = " + R);
            Console.WriteLine("-----");
            Console.WriteLine("+ = " + P);
            Console.WriteLine("-----");
            Console.WriteLine("C = " + C);
            Console.WriteLine("O = " + O);
            Console.WriteLine("L = " + L);
            Console.WriteLine("-----");
            Console.WriteLine("u = " + u);
            Console.WriteLine("n = " + n);
            Console.WriteLine("c = " + c);
            Console.WriteLine("l = " + l);
            Console.WriteLine("e = " + e);
            Console.WriteLine("-----");
            // int[] word = new int[5];
            Console.WriteLine("Now...");
            Console.WriteLine("Note: P = '+'");
            int letterU= 0;
            int letterN = P + C;
            int letterC = B + L - P;
            int letterL = E + R - P;
            int letterE = E + R + O - P - P - P;
            Console.WriteLine("Letter u = ? " + letterU);
            Console.WriteLine("Letter n = P + C = " + letterN);
            Console.WriteLine("Letter c = B + L - P = " + letterC);
            Console.WriteLine("Letter l = E + R - P = " + letterL);
            Console.WriteLine("Letter e = E + R + O - P - P - P = " + letterE);
            Console.WriteLine("-----");
            Console.WriteLine("May be it is a coincidence -- brute force for sure.");
            Console.WriteLine("The problem is incomplete too.");
            Console.WriteLine("But I wanted to show that I tried.");
        }
    }
}
