namespace TestGspi
{
    internal class InputData
    {

        public List<Dictionary<string, string>> Task1()
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


            Map = new();

            Map["Имя"] = "Алексей";
            Map["Фамилия"] = "Кузинов";
            Map["Отдел"] = "IT";
            Map["Зарплата"] = "75000";
            employees.Add(Map);

            return employees;
        }

        public  List<Person> Task2()
        {

            return null;
        }

        public (int[] arr, int min, int max) Task3()
        {
            Console.WriteLine();
            Console.WriteLine("Задание 3 ");
            //входные данные
            
            int minValue = -1;
            int maxValue = 3;
            int arrSize = 0;
            int cnt = 0;

            if (minValue < 0)
            {
                arrSize = minValue * (-1) + maxValue;
            }
            else
            {
                arrSize = minValue + maxValue;
            }

            int[] arrTask3 = new int[arrSize + 2];

            for (int i = minValue; cnt < arrTask3.Length - 1; i++)
            {
                arrTask3[cnt] = i;
                cnt++;
            }

            //здесь вводим какое число будет дублем
            arrTask3[arrTask3.Length - 1] = 2;

            return (arrTask3,minValue,maxValue);    
        }
    }
}
