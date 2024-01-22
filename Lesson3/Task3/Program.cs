//Создадим функцию, который каким-то образом
//будет изменять элементы массива.

void ZeroEvenElements(int[] arr) //Скажем хотим обнулить элементы массива;
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array);
PrintArray(array);