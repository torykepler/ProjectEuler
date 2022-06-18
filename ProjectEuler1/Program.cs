var watch = new System.Diagnostics.Stopwatch();

watch.Start();

int sum = 0;

for (int i = 0; i < 1000; i++)
{    
    if(i % 3 == 0 || i % 5 == 0)
    {
        sum+= i;
    }
}

Console.WriteLine(sum);

watch.Stop();

Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");