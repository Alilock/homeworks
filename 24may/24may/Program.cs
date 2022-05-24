using System;

namespace _24may
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


        }

        // Verilmiş ədədin rəqəmləri cəmini tapıb qaytaran  metod

        static int Sum(int a)
        {
            int digit;
            int digitsSum = 0;
            while (a > 0)
            {
                digit = a % 10;
                digitsSum += digit;
                a = (a - digit) / 10;
            }
            return digitsSum;



        }

        //Verilmiş interger arrayində verilmiş integer ədədinin yerləşdiyi ilk indexi tapıb qaytaran metod.
        //Əgər tapmasa -1 qaytarsın.(Metodu işlətdikdə içinə arqument olaraq bir integer array və bir ədəd göndərilir)

        static int IndexFinder(int[] arr, int a)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        //Verilmiş 3 ədədən ən böyüyünü qaytaran metod 

        static int Biggest(int num1, int num2, int num3)
        {
            int biggest;
            if (num1 > num2 && num1 > num3)
            {
                biggest = num1;
            }
            else if (num2 > num1 && num2 > num3)
                biggest = num2;
            else 
                biggest = num3;

            return biggest;
        }
        
            
       





    }
}
