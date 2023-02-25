// Задача 5. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

int[,] GetArray(int N){
    int[,] array = new int[N,N];
    int s = 1;
    for (int j = 0; j < N; j++) {
        array[0,j] = s;
        s++;
        }
    for (int i = 1; i < N; i++) {
        array[i,N - 1] = s;
        s++;
        }
    for (int j = N-2; j >= 0; j--) {
            array[N - 1,j] = s;
            s++;
        }
    for (int i = N - 2; i > 0; i--) {
            array[i,0] = s;
            s++;
        }
    for (int j=1;j<N-1;j++){
        array[1,j]=s;
        s++;
    }
    for (int j=N-2;j>0;j--){
        array[N-2,j]=s;
        s++;    
    }
    return array;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
            }
        Console.WriteLine();
    }
}

Console.Clear();
PrintArray(GetArray(4));

