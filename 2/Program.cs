//Задача 2: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49

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

int[,] NewArray(int[,] A, int[,] B){
    int [,] C = new int[A.GetLength(0),A.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++){
        for (int j = 0; j < A.GetLength(1); j++) {
          C[i,j]=A[i,j]*B[i,j];
        }
    }
    return C;
}

Console.Clear();
int[,] A=GetArray(4,4);
Console.WriteLine("Array 1 is: ");
PrintArray(A);
int[,] B=GetArray(4,4);
Console.WriteLine("Array 2 is: ");
PrintArray(B);
int[,] C= NewArray(A,B);
Console.WriteLine("New array is: ");
PrintArray(C);