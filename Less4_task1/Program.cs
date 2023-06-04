// See https://aka.ms/new-console-template for more information
Console.Clear();
/* string[,] table = new string[2,5];

table[1,2] = "слово";

for (int rows = 0; rows < table.GetLength(0); rows++)
{
    for (int columns = 0; columns < table.GetLength(1); columns++)
    {
        Console.Write($"-{table[rows,columns]}-");
    }
    Console.WriteLine();
}
Console.WriteLine(); */


void PrintArray(int[,] matr)
    {for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows,columns]} ");
        }
        Console.WriteLine();
    }

}

void randNum(int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }

}

int[,] matrix = new int[3, 4];
PrintArray(matrix);

randNum(matrix);
    Console.WriteLine();
PrintArray(matrix);