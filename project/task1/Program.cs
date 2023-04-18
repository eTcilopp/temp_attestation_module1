// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

List<string> GetListOfTruncatedValues(List<string> inboundList)
{
    // string[] outboundList={};
    var outboundList = new List<string>();
    int i = 0;
    foreach(string element in inboundList)
    {
        if (element.Length > 3) continue;
        outboundList.Add(element);
        i++;
    }
    return outboundList;
}

List<string> mylist = ["Hello", "2", "world", ":-)"];

Console.WriteLine(GetListOfTruncatedValues(mylist));

