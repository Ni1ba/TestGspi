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


        //задания 1
        SimpleConverterToPerson converterToPerson = new();
        //метод реализован
        List <Person> filtredList = converterToPerson.FilterEmployees(listTask1);
        //вывод данных
        converterToPerson.PrintList(filtredList);


        //задания 2

        //реализация метода

        //задания 3

        //реализация метода

    }



}

