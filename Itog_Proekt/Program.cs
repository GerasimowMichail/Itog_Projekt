Console.WriteLine("Введите число элементов массива");
int n=Convert.ToInt32(Console.ReadLine());

string [] mas=new string[n];
for(int i=0; i<n; i++)
{
    Console.Write("Введите элемент "+$"{i}" + " ");
    mas[i]=Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine($"Массив, длина элементов, которого меньше либо равна 3-м символам");
Console.WriteLine();

for(int j=0; j<n; j++)
{
    if (mas[j].Length<=3)
    {
        Console.WriteLine($"Элемент массива {j}");    
        Console.WriteLine($" {mas[j]} ");
    }
}