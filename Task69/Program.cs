Console.WriteLine("введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите натуральное число");
int exp = Convert.ToInt32(Console.ReadLine());


int Exponentiation(int num, int exp)
{
    if( exp == 0) return 1;
     return num * Exponentiation(num, exp - 1);


}



Console.WriteLine($"  {exp} -> {number} = {Exponentiation(number, exp)}");