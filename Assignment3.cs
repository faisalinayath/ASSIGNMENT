//Write a Math Calc Program that allows Users to enter the values and operation and the Program should display the
//result based on the operator the user has typed. It should be in a loop until the user specifies to close it.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faisal_Inayath_Assignments
{
    class Assignment3
    {
        class operations
        {
            public int number1 { get; set; }
            public int number2 { get; set; }

            public operations(int num1,int num2)
            {
                number1 = num1;
                number2 = num2;
            }

            public int add()
            {
                int res = number1 + number2;
                return res;
            }

            public int subtract()
            {
                int res = number1 - number2;
                return res;
            }

            public int divide()
            {
                int res = number1 / number2;
                return res;
            }

            public int multiply()
            {
                int res = number1 * number2;
                return res;
            }
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter \n1 -> Addition\n2->Subtraction\n3->Multiplication\n4->Division\n5->Exit");
                
                var choice= Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter The First Number...");
                int num1 =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Second Number...");
                int num2 = Convert.ToInt32(Console.ReadLine());


                operations obj = new operations(num1,num2);

                switch (choice)
                {
                    
                    case 1:
                        Console.WriteLine("The sum of the two numbers is {0}",obj.add());
                        break;
                    case 2:
                        Console.WriteLine("The differnce of the two numbers is {0}",obj.subtract());
                        break;

                    case 3:
                       Console.WriteLine("The product of the two numbers is {0}",obj.multiply());
                        break;
                    case 4:
                        Console.WriteLine("The quotient of the two numbers is {0}", obj.divide());

                        break;
                    case 5:
                        return;

                }
            }
        }
    }
}
