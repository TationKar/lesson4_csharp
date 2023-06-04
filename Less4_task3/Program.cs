// Factorial
Console.Clear();

double Factorial(double n)
{
    if (n==1) return 1;
    else {
        return n * Factorial(n-1);
    }

}



Console.Write("Введите число для нахождения его факториала: ");
double factr = double.Parse(Console.ReadLine());
for (double i = 1; i <= factr; i++)
{
    Console.WriteLine($"Factorial {i}! = " + Factorial(i));
} 
Console.WriteLine(Factorial(factr));