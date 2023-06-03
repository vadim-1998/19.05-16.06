// Задайте массив
// Напишите программу которая определяет присутствует ли заданное 
// число в массиве



int[] CreateArray(int size, int min, int max)
{
   int[] arr = new int[size];
   Random rnd = new Random();
   for (int i = 0; i < arr.Length; i++)
   {
    arr[i] = rnd.Next(min, max + 1);
   }
   return arr;
}

void PrintArray(int[] arr, string sep = ",")
{
      for (int i = 0; i < arr.Length; i++)
   {
    if(i < arr.Length - 1) Console.Write ($"{arr[i]}{sep} ");
    else Console.Write($"{arr[i]} ");
   }
}


bool ContainsNumber(int [] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num) return true;

    }
    return false;
}




int [] array = CreateArray(10, -10, 10);
PrintArray(array);

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ContainsNumber(array, number) ? $"массив содержит число {number}" : $"массив не содержит число {number}");
