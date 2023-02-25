// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы
//каждого элемента.

//массив размером 2 x 2 x 2
//int[,,]

//12(0,0,0) 22(0,0,1)

//45(1,0,0) 53(1,0,1)

int[,,] GetArray(int a, int b, int c){
    int[,,] result = new int[a, b, c];
        int i = 0;         
        while (i<a){
            int j = 0;
            while (j<b){
                int k = 0; 
                while (k<c){
                    bool ind=false;
                    int Num = new Random().Next(10,100);
                    for (int x=0; x<i; x++){
                        for (int y=0; y<j; y++){
                            for (int z=0; z<k; z++){
                                if (result[x,y,z]==Num){
                                    ind = true;
                                    break; 
                                } 
                            }
                        }
                    }
                    if (!ind){
                        result[i,j,k]=Num; 
                    }                                                                                                                            
                k++; 
                }
          j++;  
            }
       i++; 
        }
    return result;
}

void PrintArray(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k<array.GetLength(2); k++){
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
        Console.WriteLine();
    }
    }
}

Console.Clear();
int[,,] A=GetArray(2,2,2);
PrintArray(A);