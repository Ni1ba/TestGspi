using System.Collections;
using System.Collections.Generic;
using TestGspi;
public class Program
{
    public static void Main(string[] args)
    {

        //входные данные для теста

        List<Dictionary<string, string>> employees = new List<Dictionary<string, string>>();

        Dictionary<string, string> Map = new Dictionary<string, string>();

        Map["Имя"] = "Иван";
        Map["Фамилия"] = "Иванов";
        Map["Отдел"] = "Продажи";
        Map["Зарплата"] = "50000";
        employees.Add(Map);


        Map = new();

        Map["Имя"] = "Петр";
        Map["Фамилия"] = "Петров";
        Map["Отдел"] = "Маркетинг";
        Map["Зарплата"] = "60000";
        employees.Add(Map);

        Map = new();

        Map["Имя"] = "Анна";
        Map["Фамилия"] = "Сидорова";
        Map["Отдел"] = "Бухгалтерия";
        Map["Зарплата"] = "45000";
        employees.Add(Map);

        Map = new();

        Map["Имя"] = "Сергей";
        Map["Фамилия"] = "Козлов";
        Map["Отдел"] = "IT";
        Map["Зарплата"] = "71000";
        employees.Add(Map);

        Map = new();

        Map["Имя"] = "Елена";
        Map["Фамилия"] = "Кикитина";
        Map["Отдел"] = "Продажи";
        Map["Зарплата"] = "55000";
        employees.Add(Map);

       
        Map=new();

        Map["Имя"] = "Алексей";
        Map["Фамилия"] = "Соколов";
        Map["Отдел"] = "IT";
        Map["Зарплата"] = "75000";
        employees.Add(Map);



        //Метод задания 1
        SimpleConverterToPerson converterToPerson = new();
        List <Person> filtredList = converterToPerson.FilterEmployees(employees);


        //вывод данных
        converterToPerson.PrintList(filtredList);


    }


   
}

