namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 4, 5, 1, 6 };
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total duplicate elements: " + count);

            Console.Write("\nEnter Physics marks: ");
            int phy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemistry marks: ");
            int chem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Maths marks: ");
            int math = Convert.ToInt32(Console.ReadLine());

            int total = phy + chem + math;
            int mathPhy = math + phy;

            if ((math >= 65 && phy >= 55 && chem >= 50 && total >= 180) || (mathPhy >= 140))
                Console.WriteLine("The candidate is eligible for admission.");
            else
                Console.WriteLine("The candidate is not eligible for admission.");

            Console.Write("\nEnter Customer ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            int units = Convert.ToInt32(Console.ReadLine());

            double charge = 0;

            if (units < 200)
                charge = units * 1.20;
            else if (units < 400)
                charge = units * 1.50;
            else if (units < 600)
                charge = units * 1.80;
            else
                charge = units * 2.00;

            double surcharge = 0;
            if (charge > 400)
                surcharge = charge * 0.15;

            double netAmount = charge + surcharge;

            if (netAmount < 100)
                netAmount = 100;

            Console.WriteLine("\nCustomer IDNO : " + id);
            Console.WriteLine("Customer Name : " + name);
            Console.WriteLine("Unit Consumed : " + units);
            Console.WriteLine("Amount Charges : " + charge.ToString("F2"));
            Console.WriteLine("Surcharge Amount : " + surcharge.ToString("F2"));
            Console.WriteLine("Net Amount Paid By the Customer : " + netAmount.ToString("F2"));
        }
    }
}
