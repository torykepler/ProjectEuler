/* https://projecteuler.net/problem=1
 * 
 * Title: Multiples of 3 or 5
 * 
 * Description: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 *
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

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