namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int sum = 0;
            foreach (int val in arr)
                sum += val;
            double avg = (double)sum / arr.Length;
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + avg);
            int[,] A = {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            int[,] B = {
                {9,8,7},
                {6,5,4},
                {3,2,1}
            };

            int[,] C = new int[3, 3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    C[i, j] = A[i, j] + B[i, j];

            Console.WriteLine("\nMatrix Sum:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(C[i, j] + " ");
                Console.WriteLine();
            }

            int max = arr[0];
            foreach (int val in arr)
                if (val > max)
                    max = val;
            Console.WriteLine("\nMax Element = " + max);

            int[,] mat = {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            Console.WriteLine("\nColumn Wise Sum:");
            for (int j = 0; j < 3; j++)
            {
                int colSum = 0;
                for (int i = 0; i < 3; i++)
                    colSum += mat[i, j];
                Console.WriteLine("Column " + j + " Sum = " + colSum);
            }

            Console.WriteLine("\nRow Wise Sum:");
            for (int i = 0; i < 3; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < 3; j++)
                    rowSum += mat[i, j];
                Console.WriteLine("Row " + i + " Sum = " + rowSum);
            }
        }
    }
}
