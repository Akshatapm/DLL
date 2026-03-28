namespace Assignmnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n----- MENU -----");
                Console.WriteLine("1. Display Hello Message");
                Console.WriteLine("2. Basic Operations (All)");
                Console.WriteLine("3. Operations by Choice");
                Console.WriteLine("4. Display Name 10 Times");
                Console.WriteLine("5. Even Numbers (All Loops)");
                Console.WriteLine("6. Odd Numbers (All Loops)");
                Console.WriteLine("7. Table of a Number (All Loops)");
                Console.WriteLine("8. Numbers from 100 to 5 with gap 3");
                Console.WriteLine("9. Integers in One Line");
                Console.WriteLine("10. Integers in Separate Lines");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello Message");
                        break;

                    case 2:
                        Console.Write("Enter two numbers: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Addition: " + (a + b));
                        Console.WriteLine("Subtraction: " + (a - b));
                        Console.WriteLine("Product: " + (a * b));
                        Console.WriteLine("Quotient: " + (a / b));
                        break;

                    case 3:
                        Console.Write("Enter two numbers: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("1.Add 2.Sub 3.Mul 4.Div");
                        int op = Convert.ToInt32(Console.ReadLine());

                        if (op == 1) Console.WriteLine(x + y);
                        else if (op == 2) Console.WriteLine(x - y);
                        else if (op == 3) Console.WriteLine(x * y);
                        else if (op == 4) Console.WriteLine(x / y);

                        switch (op)
                        {
                            case 1: Console.WriteLine(x + y); break;
                            case 2: Console.WriteLine(x - y); break;
                            case 3: Console.WriteLine(x * y); break;
                            case 4: Console.WriteLine(x / y); break;
                        }
                        break;

                    case 4:
                        for (int i = 1; i <= 10; i++)
                            Console.WriteLine("YourName");
                        break;

                    case 5:
                        int i1 = 0;
                        while (i1 <= 20)
                        {
                            Console.Write(i1 + " ");
                            i1 += 2;
                        }

                        Console.WriteLine();
                        int i2 = 0;
                        do
                        {
                            Console.Write(i2 + " ");
                            i2 += 2;
                        } while (i2 <= 20);

                        Console.WriteLine();
                        for (int i = 0; i <= 20; i += 2)
                            Console.Write(i + " ");
                        break;

                    case 6:
                        int j1 = 1;
                        while (j1 <= 20)
                        {
                            Console.Write(j1 + " ");
                            j1 += 2;
                        }

                        Console.WriteLine();
                        int j2 = 1;
                        do
                        {
                            Console.Write(j2 + " ");
                            j2 += 2;
                        } while (j2 <= 20);

                        Console.WriteLine();
                        for (int j = 1; j <= 20; j += 2)
                            Console.Write(j + " ");
                        break;

                    case 7:
                        Console.Write("Enter number: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= 10; i++)
                            Console.WriteLine(num * i);

                        int k = 1;
                        while (k <= 10)
                        {
                            Console.WriteLine(num * k);
                            k++;
                        }

                        int l = 1;
                        do
                        {
                            Console.WriteLine(num * l);
                            l++;
                        } while (l <= 10);
                        break;

                    case 8:
                        for (int i = 100; i >= 5; i -= 3)
                            Console.Write(i + " ");
                        break;

                    case 9:
                        int p = 10, q = 20, r = 30;
                        Console.WriteLine(p + " " + q + " " + r);
                        break;

                    case 10:
                        int m = 5, n = 15, o = 25;
                        Console.WriteLine(m);
                        Console.WriteLine(n);
                        Console.WriteLine(o);
                        break;
                }

            } while (choice != 0);
        }
    }
}
