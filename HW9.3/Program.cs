Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int n = int.Parse(Console.ReadLine());
 
Console.WriteLine($"{Pow(m,n)}");
 
int Pow(int number,int degree)
{
   if (degree == 0) return 1;
   if(degree == 1) return number;
   return (number * Pow(number, degree-1));
}
