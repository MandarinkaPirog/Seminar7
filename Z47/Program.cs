//Задача 47. Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами.


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
        table[i,j]= new Random().Next(-99,99);
    }
}
}
int [,] table2= new int [3,4];
FillArray(table2);
Console.WriteLine();
PrintArray(table2);