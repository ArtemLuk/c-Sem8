// Задача 1: Задайте двумерный массив.
//Напишите программу, которая упорядочит
//по убыванию элементы каждой строки двумерного массива.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8

int[,] GetArray(int m, int n){
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)    {
        for (int j = 0; j < n; j++){
            result[i, j] = new Random().Next(1,10);
            }
        }
    return result;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
            }
        Console.WriteLine();
    }
}
void SortArray(int[,] inArray){
    for (int a = 0; a<inArray.GetLength(0); a++){
    for (int i = 0; i < inArray.GetLength(1); i++){
        for (int j = i + 1; j < inArray.GetLength(1); j++){
            if (inArray[a,i] > inArray[a,j]){
                int k = inArray[a,i];
                inArray[a,i] = inArray[a,j];
                inArray[a,j] = k;
            }
        }
    }
}
}

Console.Clear();
int[,] A=GetArray(5,5);
PrintArray(A);
Console.WriteLine("Sorted array is: ");
SortArray(A);
PrintArray(A);