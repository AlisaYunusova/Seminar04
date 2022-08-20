// Создаем функцию, которая ничего не принимает, но выводит массив из заданого колличества чисел
class Program
{
    static int[] CreaterArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }
    static void WrireArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

    }
    static void Main(string[] args)
    {
        WrireArray(CreaterArray(10));
    }
}

// Корректируем, что бы работать с дальнейшими данными
class Program
{
    static int[] CreaterArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }
    static void WrireArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

    }
    static void Main(string[] args)
    {
        // Передаем этот список внутрь массива
        int[] array = CreaterArray(10);
        WrireArray(array);
    }
}

// Перемешиваем рандомно числа внутри массива. Используется для создания игр, лотерей, рандомайзеров
class Program
{
    static int[] CreaterArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }
    static void WrireArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

    }
    static int[] Shuffle(int[] array)
    {
    for (int i = 0; i < array.Length; i++)
        {
            // Функция перемешивания
            int j = new Random().Next(0,i+1);
            int number = array[j];
            array[j] = array [i];
            array[i] = number;
        }
        return array;
    }
    static void Main(string[] args)
    {
        int[] array = CreaterArray(10);
        WrireArray(array);
        Console.WriteLine(" ");
        array = Shuffle(array);
        WrireArray(array);
    }
}

