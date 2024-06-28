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
            Map["Фамилия"] = "Соколов";
            Map["Отдел"] = "IT";
            Map["Зарплата"] = "75000";
            employees.Add(Map);

            return employees;
        }

        public  List<Person> Task2()
        {

            return null;
        }

        public List<Person> Task3()
        {

            return null;
        }
    }
}
