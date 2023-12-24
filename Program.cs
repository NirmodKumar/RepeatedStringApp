// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var s = "a";
long n = 10000000000;

var response = RepeatedString(s, n);

Console.WriteLine(response);

static long RepeatedString(string s, long n)
{
    long repeatedStringCounter = 0;
    long remainingSubStr = 0;

    if (string.IsNullOrWhiteSpace(s) || !s.Contains('a') || n <= 0)
    {
        return repeatedStringCounter;
    }

    remainingSubStr = n < s.Length ? n : s.Length;

    for (int i = 0; i < remainingSubStr; i++)
    {
        if (s[i] == 'a')
        {
            repeatedStringCounter = repeatedStringCounter + 1;
        }
    }

    if (n > remainingSubStr)
    {
        repeatedStringCounter = (n / remainingSubStr) * repeatedStringCounter;
        remainingSubStr = n % remainingSubStr;

        if (remainingSubStr > 0)
        {
            for (int i = 0; i < remainingSubStr; i++)
            {
                if (s[i] == 'a')
                {
                    repeatedStringCounter = repeatedStringCounter + 1;
                }
            }
        }
    }

    return repeatedStringCounter;
}

Console.ReadLine();