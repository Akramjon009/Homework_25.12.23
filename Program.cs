public class Sorting
{
    public static void SortArray(int[] array, Func<int[], int[]> func)
    {
        array = func(array);
    }

    static void Main(string[] args)
    {

        int[] Myarray = [5, 6, 1, 2, 3, 10];

        SortArray(Myarray, func: Sort1);
        Console.WriteLine("O'sish tartibda");
        for (int i = 0; i < Myarray.Length; i++)
        {
            Console.Write(Myarray[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        SortArray(Myarray, func: Sort2);
        Console.WriteLine("Kamayish tartibda tartibda");
        for (int i = 0; i < Myarray.Length; i++)
        {
            Console.Write(Myarray[i] + " ");
        }


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        SortArray(Myarray, func: Sort3);
        Console.WriteLine("Alphabetic tartibda tartiblangan.");
        for (int i = 0; i < Myarray.Length; i++)
        {
            Console.Write(Myarray[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        
    }





    public static int[] Sort1(int[] array)
    {



        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int box = array[i];
                    array[i] = array[j];
                    array[j] = box;

                }
            }

        }
        return array;
    }

    public static int[] Sort2(int[] array)
    {



        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    int box = array[i];
                    array[i] = array[j];
                    array[j] = box;

                }
            }

        }
        return array;
    }

    public static int[] Sort3(int[] array)
    {
        string[] newArray = new string[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i].ToString();
        }
        Array.Sort(newArray);

        for (int j = 0; j < array.Length; j++)
        {
            array[j] = Convert.ToInt32(newArray[j]);
        }

        return array;
    }


}

