/* https://projecteuler.net/problem=3
 * 
 * Title: Largest prime factor
 * 
 * Description: The prime factors of 13195 are 5, 7, 13 and 29.
 *
 * What is the largest prime factor of the number 600851475143 ?
 */

var watch = new System.Diagnostics.Stopwatch();

watch.Start();

OptimizedAlgorithm(600851475143);
//NaiveAlgorithm(600851475143);

watch.Stop();

Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");


/**
 * The optimized algorithm works by first identifying the numbers that divide into the input from smallest to largest
 * When the smallest divisor is found we divide the input by that divisor to get a potential largest prime divisor
 * We then just need to see if that potential answer is actually prime
 */
static long OptimizedAlgorithm(long input)
{
    long bound = input / 2 + 1;

    for (long i = 2; i < bound; i++)
    {
        if (input % i == 0)
        {
            long potentialAnswer = input / i;

            if (IsPrime(potentialAnswer))
            {
                Console.WriteLine($"{potentialAnswer} is the largest prime factor of {input}");
                return potentialAnswer;
            }
        }
    }

    return 0;
}

/**
 * The naive algorithm is a simple brute force algorithm
 * iterate from 2 to input/2 and find the largest prime factor
 */
static long NaiveAlgorithm(long input)
{
    long largestFactor = 0;

    long bound = input / 2 + 1;

    for (long i = 2; i < bound; i++)
    {
        if (input % i == 0 && IsPrime(i))
        {
            largestFactor = i;
            Console.WriteLine($"{i} is a prime factor of {input}");
        }
    }

    return largestFactor;
}

static bool IsPrime(long number)
{
    long bound = number / 2 + 1;

    for (long i = 2; i < bound; i++)
    {
        if(number % i == 0)
        {
            return false;
        }
    }

    return true;
}