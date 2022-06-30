/* https://projecteuler.net/problem=4
 * 
 * Title: Largest palindrome product
 * 
 * Description: A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 *
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */

var watch = new System.Diagnostics.Stopwatch();
Console.WriteLine(GetPalindromeProduct(999, 999));
watch.Stop();

Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");


static int GetPalindromeProduct(int input1, int input2)
{
    int largestPalindrome = 0;
    
    for(int i=input1; i > 0; i--)
    {
        for (int j = input2; j > 0; j--)
        {
            int possibleAnswer = i * j;


            if (IsPalindrome(possibleAnswer) && possibleAnswer > largestPalindrome)
            {
                largestPalindrome = possibleAnswer;
            }
        }
    }

    return largestPalindrome;
}

static bool IsPalindrome(int input)
{
    string textInput = input.ToString();
    
    // If the input is an even # of characters then compare first half vs second half
    if(textInput.Length % 2 == 0)
    {
        int midwayPoint = textInput.Length / 2;

        string firstPart = textInput.Substring(0, midwayPoint);
        string secondPart = ReverseString(textInput.Substring(midwayPoint));

        if(firstPart == secondPart)
        {
            return true;
        }

        return false;
    }
    else
    {
        int midwayPoint = textInput.Length / 2;

        string firstPart = textInput.Substring(0, midwayPoint);
        string secondPart = ReverseString(textInput.Substring(midwayPoint +1));

        if (firstPart == secondPart)
        {
            return true;
        }

        return false;
    }
}

static string ReverseString(string text)
{
    char[] chars = text.ToCharArray();
    Array.Reverse(chars);

    return new string(chars);
}