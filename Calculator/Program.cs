using System;

namespace Calculator
{
    public class Program
    {
        //static void Input() {
        //    Console.WriteLine("Skriv in ditt först nummer: ");
        //    double firstnum = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Skriv in ditt andra nummer: ");
        //    double secondnum = Convert.ToDouble(Console.ReadLine());
        //}
        //static void Addition()
        //{
        //    Console.WriteLine("Skriv in ditt först nummer: ");
        //    double firstnum = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Skriv in ditt andra nummer: ");
        //    double secondnum = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine(firstnum + " + " + secondnum + " = " + (firstnum + secondnum));
        //}

        //static void Subtraction()
        //{
        //    Console.WriteLine("Skriv in ditt först nummer: ");
        //    double firstnum = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Skriv in ditt andra nummer: ");
        //    double secondnum = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine(firstnum + " - " + secondnum + " = " + (firstnum - secondnum));
        //}

        //static void Multiplication()
        //{
        //    Console.WriteLine("Skriv in ditt först nummer: ");
        //    double firstnum = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Skriv in ditt andra nummer: ");
        //    double secondnum = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine(firstnum + " * " + secondnum + " = " + (firstnum * secondnum));
        //}

        //static void Division()
        //{
        //    Console.WriteLine("Skriv in ditt först nummer: ");
        //    double firstnum = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Skriv in ditt andra nummer: ");
        //    double secondnum = Convert.ToDouble(Console.ReadLine());
        //    if (secondnum == 0)
        //    {
        //        Console.WriteLine("Du kan inte dividera med 0. ");
        //    }
        //    else {
        //        Console.WriteLine(firstnum + " / " + secondnum + " = " + (firstnum / secondnum));
        //    }
            
        //}
        public static double Addition(double num1, double num2)
        {
            
            return num1 + num2;
            
        }

        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Addition(double[] numberArray)
        {
            double sum = 0;
            for (int i = 0; i < numberArray.Length; i++){
                sum += numberArray[i];
            }
                return sum;
            
        }

        public static double Subtraction(double[] numberArray)
        {
            double difference = 0;
            if (numberArray[0] > 0)
            {
                difference = difference + numberArray[0];
                for (int i = 1; i < numberArray.Length; i++)
                {
                    difference -= numberArray[i];
                }
            }
            else
            {
                for (int i = 0; i < numberArray.Length; i++)
                {
                    difference -= numberArray[i];
                }
            }
            return difference;

        }

        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Division(double num1, double num2)
        {

            if (num2 != 0)
            {
                return num1 / num2;

            }
            else
            {
                return 0;
            }

        }

        static void Main(string[] args)
        {
            double[] numberArray = { 1.6, 2.8, 0.0, 1.4 };
            Console.WriteLine("Välkommen till kalkylatorn. Skriv exit för att avsluta programmet.");
            while (true)
            {

                Console.WriteLine("Vill du [A]ddera, [S]ubtrahera, [M]ultiplicera eller [D]ividera? ");
                string method = Console.ReadLine();


                if (method.ToUpper() == "A")
                {
                    Addition(1, 2);
                }
                else if (method.ToUpper() == "S")
                {
                    Subtraction(1, 2);
                }
                else if (method.ToUpper() == "M")
                {
                    Multiplication(1, 2);
                }
                else if (method.ToUpper() == "D")
                {
                    Division(1, 2);
                }
                else if (method.ToUpper() == "EXIT")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ogiltigt räknemetod, var snäll skriv in en giltig bokstav. ");
                }
            }
        }
    }
}
