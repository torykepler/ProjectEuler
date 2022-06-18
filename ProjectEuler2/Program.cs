var watch = new System.Diagnostics.Stopwatch();

watch.Start();

Console.WriteLine(Fibonacci(1, 2, 4000000, 2));

static int Fibonacci(int x, int y, int max, int sum)
{
    int nextNumber = x + y;

    if(nextNumber > max)
    {
        return sum;
    }
    else
    {
        if (nextNumber % 2 == 0)
        {
            sum += nextNumber;
        }

        return Fibonacci(y, nextNumber, max, sum);
    }
}


watch.Stop();

Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");