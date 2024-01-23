//Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.


// {"Russia", "Denmark", "Kazan"}
// {"Hello", "2", "world", ":-)"}
// {"1234", "1567", "-2", "computer science"}

Console.Write("Введите количество элементов массива: ");
int el = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[el];

void InputElements (string[] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");   
}

string[] DeletElementsMoreThanThree(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        count++;
        }
    }
    string[] resultArray = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            resultArray[index] = array[i];
            index++;
        }
    }
    return resultArray;
}

InputElements(array1);
PrintArray(array1);
string[] array2 = DeletElementsMoreThanThree(array1);
PrintArray(array2);