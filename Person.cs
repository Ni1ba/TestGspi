 
namespace TestGspi

{
    public class Person
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        //метод для задания 2
        public TaskDto Task2(List<Person> listTask2)
        {
            Console.WriteLine("Задание 2 ");

            TaskDto dto = new TaskDto();
            //средняя зп
            dto._avgSalary = AvgSalary(listTask2);
            dto._popularChar = CommonChar(listTask2);
            dto._popularDepartment = CommonDepartment(listTask2);
            dto._similarSecondName = SimilarSecondNameFind(listTask2);

            return dto;
        }

        private decimal AvgSalary(List<Person> list)
        {
            decimal sum = 0;
            int count = 0;
            foreach (Person p in list)
            {
                sum += p.Salary;
                count++;

            }

            if (count == 0)
            {
                return 0;
            }
            else
            {
                return sum / count;
            }
        }

        private Dictionary<char, int> CommonChar(List<Person> list)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();


            foreach (Person p in list)
            {
                //разобрать имя в список чар
                List<char> charList = new();
                charList = p.Name.ToCharArray().ToList();
                char tmpChr = '\0';
                int tmpCnt = 0;

                //проходим по каждому элементу в списке символов имени
                foreach (char c in charList)
                {
                    tmpChr = char.ToLower(c);
                    if (dict.ContainsKey(tmpChr))
                    {
                        dict[tmpChr]++;
                    }
                    else
                    {
                        dict.Add (tmpChr, 1);
                    }
                }
            }

            //еще раз проходим по списку и создаем новый список из существующих чаще всего встречающихся значений
            Dictionary<char, int> resultDict = new();
            int maxValue = dict.Values.Max();
            foreach (var c in dict)
            {
                if (c.Value == maxValue)
                {
                    resultDict.Add(c.Key,c.Value);
                }
            }
            return resultDict;
        }
        private Dictionary<string, int> CommonDepartment(List<Person> list)
        {
            //todo: назвать как нибудь получше
            Dictionary<string, int> cnt = new Dictionary<string, int>();
            foreach (Person p in list)
            {
                if (cnt.ContainsKey(p.Department))
                {
                    cnt[p.Department]++;
                }
                else
                {
                    cnt.Add(p.Department, 1);
                }
            }
            Dictionary<string, int> resultDict = new();
            int maxValue = cnt.Values.Max();
            foreach (var c in cnt)
            {
                if (c.Value == maxValue)
                {
                    resultDict.Add(c.Key, c.Value);
                }
            }
            return resultDict;
        }
        private Dictionary<string, int> SimilarSecondNameFind(List<Person> listTask2)
        {
            List<string> secondNames = new();
            foreach (Person p in listTask2)
            {
                secondNames.Add(p.SecondName);
            }
            string targetName = "Кузин";

            return FindClosestSurname(targetName, secondNames);
        }

        private Dictionary<string, int> FindClosestSurname(string target, List<string> surnames)
        {
            int minDistance = int.MaxValue;
            string closestSurname = null;
            Dictionary<string, int> dict = new();
            foreach (string surname in surnames)
            {
                int distance = LevenshteinDistance(target, surname);
                if (distance < minDistance)
                {
                    dict.Add(surname, distance);
                }
            }

            Dictionary<string, int> sortedDictByValue = dict.OrderBy(x => x.Value)
                                        .ToDictionary(x => x.Key, x => x.Value);

            return sortedDictByValue;
        }

        private int LevenshteinDistance(string a, string b)
        {
            int[,] dp = new int[a.Length + 1, b.Length + 1];

            for (int i = 0; i <= a.Length; i++)
                dp[i, 0] = i;

            for (int j = 0; j <= b.Length; j++)
                dp[0, j] = j;

            for (int i = 1; i <= a.Length; i++)
            {
                for (int j = 1; j <= b.Length; j++)
                {
                    int cost = (a[i - 1] == b[j - 1]) ? 0 : 1;
                    dp[i, j] = Math.Min(Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1), dp[i - 1, j - 1] + cost);
                }
            }

            return dp[a.Length, b.Length];
        }
    }



}
