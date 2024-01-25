//Задача №1
//Создать двумерный массив с размерами 3x5
//состоящий из целых чисел;
//Вывести его элементы на экран

int[,] matrix = new int[3, 5];

Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        //Random rnd = new Random(); такой вариант может замедлить код,
        //потому что у нас 15 элементов, и при каждом обращении к массиву,
        //Random воссоздаться 15 раз. Перенесем Random за предели циклов!
        matrix[i, j] = rnd.Next(1, 11);
    }
}

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// } Мешал выводу функции на экран;

int[,] CreateMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] mtx = CreateMatrix(4, 5);
ShowMatrix(mtx);