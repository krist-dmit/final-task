string[] Vvod()
{
    Console.WriteLine("Сколько элементов будет в массиве?");
    int count = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[count];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine("Ведите слово, число, символ, сроку");
        array[i] = Console.ReadLine();
    }
    return array;
}
string[] NewMethod(string[] array)
{
    int i = 0;
    string[] array2 = new string[array.Length];
    int k = 0;
    while (i < array.Length)
    {
        if (array[i].Length <= 3)
        {
            array2[k] = array[i];
            k++;
        }
        i++;
    }
    return array2;
}
Console.WriteLine(string.Join(' ', NewMethod(Vvod())));