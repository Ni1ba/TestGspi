using TestGspi;
public class Program
{
    public static void Main(string[] args)
    {

        //входные данные для теста
        InputData inputData = new();
        List<Dictionary<string, string>> listTask1 = inputData.Task1();
        Program program = new();

        //задания 1
        SimpleConverterToPerson converterToPerson = new();
        //метод реализован
        List<Person> filtredList = converterToPerson.FilterEmployees(listTask1);
        //вывод данных
        Console.WriteLine("Задание 1. Поиск сотрудников по критериям зп>70к, Фамилия начинается с 'К': ");
        converterToPerson.PrintList(filtredList);


        //задания 2
        Console.WriteLine("Задание 2 ");
        List<Dictionary<string, string>> tempList = inputData.Task1();
        List<Person> listTask2 = converterToPerson.ConvertToListPerson(tempList);
        Person person = new();
        //средняя зп
        Console.WriteLine($"avg зп: {person.AvgSalary(listTask2)}");

        //самая частая буква
        Console.WriteLine("Частый символ в фамилии:");
        var result = person.CommonChar(listTask2);
        foreach (var kvp in result)
        {
            Console.WriteLine($"Значение: {Convert.ToString(kvp.Key)}, Частота:  {Convert.ToString(kvp.Value)}");
        }


        //самый частый отдел 
        Console.WriteLine("");
        Console.WriteLine("Самый частый отдел ");
        converterToPerson.PrintList(person.CommonDepartment(listTask2));

        //todo:фамилию, наиболее похожую на «Кузин»

        //todo:Возвращает метод полученные данные в виде dtoclass (необходимо реализовать dto class)


        //реализация метода

        //задания 3
        //реализация метода
        var task3TestData = inputData.Task3();

        Console.WriteLine($"Дубликат: {program.FindDuplicate(task3TestData.arr, task3TestData.min, task3TestData.max)}");
    }

    //метод вернет любое число которое не будет или будет находится в диапазоне минимального : максимального значения
    public int FindDuplicate(int[] arr, int min, int max)
    {
        Array.Sort(arr);
        int sum = 0;
        int duplicate = 0;
        int cnt = 0;
        for (int i = arr.First(); cnt < arr.Length; i++)
        {
            sum += arr[cnt];
            cnt++;
        }
        int expectedSum = 0;

        for (int i = min; i <= max; i++)
        {
            expectedSum += i;
        }

        duplicate = sum - expectedSum;

        return duplicate;
    }


}

