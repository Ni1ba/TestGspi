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
        List<Dictionary<string, string>> tempList = inputData.Task1();
        List <Person> listTask2 = converterToPerson.ConvertToListPerson(tempList);
        Person person = new Person();
        //средняя зп
        Console.WriteLine(person.AvgSalary(listTask2));

        //самая частая буква
        person.CommonChar(listTask2);
        //самый частый отдел 


        //реализация метода

        //задания 3

        //реализация метода

    }



}

