//Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.


void PrintArray(int[,] table)
{
for (int i = 0; i < 3; i++) 
{
    for (int j = 0; j < 4; j++)  
    {
        Console.Write($"{table[i,j]} "); 
    }
    Console.WriteLine();
}
}
void FillArray (int[,]table)
{
    for (int i = 0; i < 3; i++)  
{
    for (int j = 0; j < 4; j++)  
    {
        table[i,j]= new Random().Next(1,100);
    }
}
}
int [,] table2= new int [3,4];
FillArray(table2);
Console.WriteLine();
PrintArray(table2);
int i1 = ReadInt("Введите индекс строки: ");
int j1 = ReadInt("Введите индекс столбца: ");
if (i1 < table2.GetLength(00) && j1 < table2.GetLength(00)) Console.WriteLine(table2[i1, j1]);
else Console.WriteLine($"{i1}{j1}  такого элемента в массиве нет");

 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

