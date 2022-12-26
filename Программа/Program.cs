/* Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

string[] arrayInput = new string[4] { "Hello", "-2", "world", ":-)" };
string[] arrayOutput = new string[arrayInput.Length];

NewArray(arrayInput, arrayOutput);
PrintArray(arrayOutput);



void NewArray(string[] arrayIn, string[] arrayOut)
{
    int newElement = 0;
    for (int i = 0; i < arrayIn.Length; i++)
    {
        if (arrayIn[i].Length <= 3)
        {
            arrayOut[newElement] = arrayIn[i];
            newElement++;
        }
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
