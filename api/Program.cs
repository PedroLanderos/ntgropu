namespace api;

class Program
{

    class Numbers
    {
        int n; 
        int sume;
        int[] numbers;

        public void FillArray()
        {
            for (int i = 0; i < 100; i++)
                numbers[i] = i + 1;
        }

        public Numbers()
        {
            n = 100;
            sume = ((n) * (n + 1) / 2); //using the gauss formula (5050)
            numbers = new int[n];
            FillArray();
        }


        public void Extract(int n)
        {
            for (int i = 0; i < 100; i++)
            {
                if( numbers[i] == n)
                    numbers[i] = 0;
            }
        }

        public int FindNumber()
        {
            int newSume = 0;
            for (int i = 0;i < 100;i++)
                newSume += numbers[i];

            return sume - newSume;
        }
    }


    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Empty number");
            return;
        }
        if (int.TryParse(args[0], out int number))
        {
            if (number > 100 || number < 1)
            {
                Console.WriteLine("Number out of range");
                return;
            }   
            Numbers numbers = new Numbers();
            numbers.Extract(number);
            int missingNumber = numbers.FindNumber();
            Console.WriteLine($"Missing number: {missingNumber}");
        }
        else
        {
            Console.WriteLine("Please enter a number");
        }

    }
}
