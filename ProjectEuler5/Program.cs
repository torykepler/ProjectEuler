/* https://projecteuler.net/problem=5
 * 
 * Title: Smallest multiple
 * 
 * Description: 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 *
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */

int max = 20;
int result = max;

Boolean sentinel = true;

while (sentinel)
{
    for(int i = max; i > 0; i--)
    {
        if (result % i != 0)
        {
            result += max;
            sentinel = true;
            break;
        }
        else
        {
            sentinel = false;
        }
    }
}

Console.WriteLine(result);