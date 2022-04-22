

static void SumOfTwoVariables(int a, int b) 
{
    int c = a + b;
    Console.WriteLine(c);
}

static void PrintNombersInRange(int a, int b) 
{
    for (int i = a; i <= b; i++)
    {
        Console.WriteLine(i);
    }   
}

static void SortNumbersByAscending(int[] a)
{
    int temp;

    for (int i = 0; i < a.Length-1; i++)
    {
        for (int j = 0; j < a.Length-1; j++)
        {
            if (a[j] > a[j + 1])
            {
                temp = a[j + 1];
                a[j + 1] = a[j];
                a[j] = temp;
            }
        }
    }
    foreach (var item in a)
    {
        Console.WriteLine(item);
    }
  
}

static void ExportOddNumbers(int[] a)
{
    foreach (var item in a)
    {
        if (item % 2 == 1)
        {
            Console.WriteLine(item);
        }
    }
}

static void ExportEvenNumbers(int[] a)
{
    foreach (var item in a)
    {
        if (item % 2 == 0)
        {
            Console.WriteLine(item);
        }
    }
}