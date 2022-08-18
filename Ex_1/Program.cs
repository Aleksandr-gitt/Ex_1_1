// Разница между мин и макс в рандомном ограниченном множестве множестве:

void Array(int[] numbers)
{

int len = numbers.Length;

Console.WriteLine("Введите 1 границу диапазона чисел помещаемых в массив: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 границу диапазона чисел помещаемых в массив: ");
int B = Convert.ToInt32(Console.ReadLine());

for(int i =0; i < len; i++)
{
    numbers[i] = new Random().Next(A,B);
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();

int min = numbers[0];
int max = numbers[0]; 

for(int i = 0; i < len; i++)
{
    if(max < numbers[i]) max = numbers[i];
    if(min > numbers[i]) min = numbers[i];
}

Console.WriteLine($"MaxNumber = {max}");
Console.WriteLine($"MinNumber = {min}");

int result = max - min;
Console.WriteLine(result);

}

Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Array(new int[length]);