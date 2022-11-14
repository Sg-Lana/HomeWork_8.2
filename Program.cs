//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

int [,] CreateMatrix(int lenRows, int lenColumns, int minLimit, int maxLimit) //задаем массив
{
        int [,] matrix = new int[lenRows, lenColumns];
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++) // генерация строк
        {
                for (int j = 0; j < matrix.GetLength(1); j++) // генерация столбцов
                {
                        matrix[i, j] = random.Next(minLimit, maxLimit); // задали вывод случайных, целых элементов массива
                }
        }
        return matrix; // вернули двумерный массив
}

void PrintMatrix(int[,] matrix) // вывод на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine(); // переход на следующую строку
    }
}

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


void SumLine (int[,] matrix)
{
    int index = 0;
    int minsumm = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ =0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ+= matrix[i,j];
        }
        if (i==0)
        {
            minsumm = summ;
        }
        else if (summ<minsumm)
        {
            minsumm = summ;
            index = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов -> {index+1} ");  
}        

int rows = Prompt ("введите количество строк матрицы - > ");
int columns = Prompt ("введите количество столбцов матрицы- > ");
int min = Prompt ("введите минимальное значение диапазона чисел - > ");
int max = Prompt ("ввелите максимальное значение диапазона чисел  - > ");
int[,] matrix = CreateMatrix(rows, columns, min, max);
PrintMatrix(matrix);
SumLine(matrix);