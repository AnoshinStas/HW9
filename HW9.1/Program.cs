Console.WriteLine("Enter N: ");
int num1 = 1;
int num2 = int.Parse(Console.ReadLine());

Numbers(num1, num2);

int Numbers(int number1, int number2)
{
    if(number1 > number2) return number2;
    
    else
    {
        Console.Write(number1 + ", ");
        number1++;
    }
    
    return Numbers(number1++, number2);
}

