namespace TDD
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var nums = numbers.Split(',', '\n');
            int sum = 0;
            foreach (var n in nums)
            {
                try
                {
                    int num = int.Parse(n);
                    switch (num)
                    {
                        case < 0:
                            throw new ArgumentOutOfRangeException();
                        case <= 1000:
                            sum += num;
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.Error.WriteLine(e);
                    return 0;
                }
            }
            return sum;
        }
    }
}

