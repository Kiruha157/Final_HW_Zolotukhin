// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string []  Find_string_in_array (string [] array)
{
    int length = array.Length;
    string [] result = new string[length];
    
    
    
    for(int i = 0; i < length; i++)
    {
        if(array[i].Length <= 3 )
        {
            result[i] = array[i];
        }
    }
    return result;

} 

string [] input = {"Hello", "World", "from", "SPB", "!"};

Console.WriteLine($"Массив из строк длиной мене либо равной 3 символам: [{string.Join(", ", Find_string_in_array(input))}]: ");
