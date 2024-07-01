using TestGspi;
public class Program
{
    public static void Main(string[] args)
    {

        //входные данные для теста
        InputData inputData = new();
        List<Dictionary<string, string>> listTask1 = inputData.Task1();
        Program program = new();
        EmployeeConverter EConverter = new();

        //задания 1
        //метод реализован
        List<Person> filtredList = EConverter.FilterEmployees(listTask1);
        //вывод данных
        Console.WriteLine("Задание 1. Поиск сотрудников по критериям зп>70к, Фамилия начинается с 'К': ");
        EConverter.PrintList(filtredList);


        //заданиe 2 
        //входные данные
        //Console.WriteLine("Задание 2 ");
        List<Dictionary<string, string>> tempList = inputData.Task1();
        List<Person> listTask2 = EConverter.ConvertToListPerson(tempList);
        Person person = new();
        TaskDto dtoVar = new();

        //Метод задания 2
        dtoVar = person.Task2(listTask2);

        //Console.WriteLine($"avg зп: {person.AvgSalary(listTask2)}");

        ////самая частая буква
        //Console.WriteLine("Частый символ в фамилии:");
        //var result = person.CommonChar(listTask2);
        //foreach (var kvp in result)
        //{
        //    Console.WriteLine($"Значение: {Convert.ToString(kvp.Key)}, Частота:  {Convert.ToString(kvp.Value)}");
        //}

        ////самый частый отдел 
        //Console.WriteLine("");
        //Console.WriteLine("Самый частый отдел ");
        //EConverter.PrintList(person.CommonDepartment(listTask2));

        //todo:фамилию, наиболее похожую на «Кузин»

        //todo:Возвращает метод полученные данные в виде dtoclass (необходимо реализовать dto class)


        //реализация метода

        //задания 3
        //реализация метода
        var task3TestData = inputData.Task3();

        Console.WriteLine($"Дубликат: {EConverter.FindDuplicate(task3TestData.arr, task3TestData.min, task3TestData.max)}");
    }

     
   


}

