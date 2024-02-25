// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string []  Find_string_in_array (string [] array)
{
    int length = array.Length;
    int count = 0;
    // Определяем кол-во строк, в которых <= 3 символов   
    foreach(string str in array)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;
    for(int i = 0; i < length; i++)
    {
        if(array[i].Length <= 3 )
        {
            result[index] = array[i];
            index++;
        }
    }
    return result;

} 

string [] input = {"Hello", "World", "from", "SPB", "!"};

Console.WriteLine($"Массив из строк длиной менее либо равной 3 символам: [{string.Join(", ", Find_string_in_array(input))}]: ");
