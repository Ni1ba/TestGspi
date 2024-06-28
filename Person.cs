 
namespace TestGspi

{
    public class Person
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public decimal AvgSalary(List<Person> list)
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

        public Dictionary<char, int> CommonChar(List<Person> list)
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


    }



}
