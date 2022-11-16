// Собрать строку с числами от a до b, a ≤ b

string NumberRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumberRec(a + 1, b);
    else return String.Empty;
}

string NumberFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

// string NumberFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result +=  $"{i} ";
//     }
//     return result;
// }

// Console.WriteLine(NumberFor(1,10));

// string NumberRec(int a, int b)
// {
//     if (a >= b) return $"{a} " + NumberRec(a-1, b);
//     else return String.Empty;
// }

// Console.WriteLine(NumberRec(10,1));



// Сумма чисел от 1 до n

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

// Console.WriteLine(SumRec(10));



// Факториал числа

int FactorialRec(int n)
{
    if (n == 0) return 1;
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

// Console.WriteLine(FactorialRec(4));



// Вычислить а^n

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

// Console.WriteLine(PowerFor(2, 4));

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return a * PowerRec(a, n - 1);
}

// Console.WriteLine(PowerRec(2, 4));

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return a * PowerRecMath(a, n - 1);
}

// Console.WriteLine(PowerRecMath(2, 6));


int n = 1;
void FindWords(string alphabet, char[] word, int lenght = 0)
{
    if (lenght == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[lenght] = alphabet[i];
        FindWords(alphabet, word, lenght +1);
    }
}

// FindWords("аисв", new char[3]);


