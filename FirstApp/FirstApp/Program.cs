using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte age;

            age = 20;
            age = 30;
            age = 40;

            var result1 = 10 + age;


            float price1 = 45.5f;
            decimal price2 = 55.5m;

            var result2 = 100 / 3d;

            string word1 = "Tello";

            var firstLetter = word1[0];

            //snake case
            //var check_start_with_h = firstLetter == 'H';

            //pascal case
            //var CheckStartWithH = firstLetter == 'H';

            //camel case
            var checkWord1StartsWithH = firstLetter == 'H';


            if (checkWord1StartsWithH)
            {
                Console.WriteLine("Yazi H ile baslayir");
            }
            else
            {
                Console.WriteLine("Yazi H ile baslamir");
            }

            Console.WriteLine(firstLetter);

            var avgOfStudentPoints = 55.5;


            var a = 10;
            var b = 20;
            var c = 20;

            if (a < b)
            {
                if (a < c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            else if (b < c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }

            if(a<=b && a <= c)
            {
                Console.WriteLine(a);
            }
            else if(b<=a && b <= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }

            byte dayOfWeek = 5;

            if(dayOfWeek == 1)
            {
                Console.WriteLine("Bazar ertesi");
            }
            else if(dayOfWeek == 2)
            {
                Console.WriteLine("Cersenbe axsami");
            }
            else if(dayOfWeek == 3)
            {
                Console.WriteLine("Cersenbe");
            }
            else if(dayOfWeek == 4)
            {
                Console.WriteLine("Cume axsami");
            }
            else if(dayOfWeek == 5)
            {
                Console.WriteLine("Cume");
            }
            else if(dayOfWeek == 6)
            {
                Console.WriteLine("Senbe");
            }
            else if(dayOfWeek == 7)
            {
                Console.WriteLine("Bazar");
            }
            else
            {
                Console.WriteLine("Gun yanlisdir!");
            }

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Bazar ertesi");
                    break;
                case 2:
                    Console.WriteLine("Cersenbe axsami");
                    break;
                case 3:
                    Console.WriteLine("Cersenbe");
                    break;
                case 4:
                    Console.WriteLine("Cume axsami");
                    break;
                case 5:
                    Console.WriteLine("Cume");
                    break;
                case 6:
                    Console.WriteLine("Senbe");
                    break;
                case 7:
                    Console.WriteLine("Bazar");
                    break;
                default:
                    Console.WriteLine("Heftenin gunu yanlisdir");
                    break;
            }

            //var numbers = new int[5];
            //int[] numbers = new int[] { 10,45,55,-18,5};
            int[] numbers = {45,90,-10,77 };

            //int i = 0;
            //while (i<numbers.Length)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            for (int i = 0; i < numbers.Length; i++)       
            {
                Console.WriteLine(numbers[i]);
            }


            string password = "Student123";
            string passwordInput;
            do
            {
                Console.WriteLine("Sifreni daxil et");
                passwordInput = Console.ReadLine();
            }
            while (password != passwordInput);


            string[] names = { "Abbas", "Hikmet", "Aofiq", "Nermin", "Abdulla" };

            int wantedNamesCount = 0;
            for(int i=0; i<names.Length; i++)
            {
                if(names[i][0] == 'A')
                {
                    wantedNamesCount++;
                }
            }

            Console.WriteLine(wantedNamesCount);


            //Verilmsi 3 eded icerisinden en boyuk olani tapan proqram

            Console.WriteLine("num1:");
            string num1Str = Console.ReadLine();
            Console.WriteLine("num2:");
            string num2Str = Console.ReadLine();
            Console.WriteLine("num3:");
            string num3Str = Console.ReadLine();

            int num1 = Convert.ToInt32(num1Str);
            int num2 = Convert.ToInt32(num2Str); 
            int num3 = Convert.ToInt32(num3Str); 

            if (num1 >= num2 && num1 >= num3)
                Console.WriteLine(num1);
            else if (num2 >= num1 && num2 >= num3)
                Console.WriteLine(num2);
            else 
                Console.WriteLine(num3);


            //Verilmsi eddeleri siyahisindaki cut ededlerin ededi ortasini tapan proqram

            int[] numbersInput = { 46, 11, 90, 10, 31, 11 };

            int sum = 0;
            double count = 0;

            for (int i = 0; i < numbersInput.Length; i++) 
            {
                if (numbersInput[i] % 2 == 0)
                {
                    sum+=numbersInput[i];
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Cut eded yoxdur");
            }
            else
            {
                Console.WriteLine(sum / count);
            }


        }
    }
}
