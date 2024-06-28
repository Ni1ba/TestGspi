using System.Collections;
using System.Collections.Generic;
using TestGspi;
public class Program
{
    public static void Main(string[] args)
    {

        //входные данные для теста
        InputData inputData = new InputData();
        List<Dictionary<string, string>> listTask1 = inputData.Task1();


        //Метод задания 1
        SimpleConverterToPerson converterToPerson = new();
        List <Person> filtredList = converterToPerson.FilterEmployees(listTask1);
        //вывод данных
        converterToPerson.PrintList(filtredList);





    }


   
}

