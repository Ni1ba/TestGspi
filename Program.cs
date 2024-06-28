using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using TestGspi;
public class Program
{
    public static void Main(string[] args)
    {
        
        //входные данные для теста
        InputData inputData = new InputData();
        List<Dictionary<string, string>> listTask1 = inputData.Task1();


        //задания 1
        SimpleConverterToPerson converterToPerson = new();
        //метод реализован
        List <Person> filtredList = converterToPerson.FilterEmployees(listTask1);
        //вывод данных
        converterToPerson.PrintList(filtredList);


        //задания 2
        Console.WriteLine("Задание 2 ");
        List<Dictionary<string, string>> tempList = inputData.Task1();
        List <Person> listTask2 = converterToPerson.ConvertToListPerson(tempList);
        Person person = new Person();
        //средняя зп
        Console.WriteLine($"avg зп: {person.AvgSalary(listTask2)}");

        //самая частая буква
        Console.WriteLine("Частый символ в фамилии:");
        var result =person.CommonChar(listTask2);
        foreach (var kvp in result)
        {
            Console.WriteLine($"Значение: { Convert.ToString(kvp.Key)}, Частота:  { Convert.ToString(kvp.Value)}");
        }
        //самый частый отдел 


        //реализация метода

        //задания 3
        Console.WriteLine();
        Console.WriteLine("Задание 3 ");
        Program program = new Program();
        int minValue=0; 
        int maxValue=6;
        int[] arrTask3= new int[maxValue+2];
        for (int i = minValue; i < arrTask3.Length; i++)
        {
            arrTask3[i] = i ;
        }
        arrTask3[arrTask3.Max()]=2;
        //реализация метода
        Console.WriteLine($"Дубликат: {program.FindDuplicate(arrTask3, minValue, maxValue)}");
    }

    public  int FindDuplicate(int[] arr, int min, int max)
    {
        int sum = 0;
        int duplicate = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
            int expectedSum=0;

        for (int i = min; i <= max; i++)
        {
            expectedSum += i;
        }
        
        duplicate = sum - expectedSum;

        return duplicate;
    }


}

