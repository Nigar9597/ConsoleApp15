namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void Task1()
        {
            double num1 = 5;
            double num2 = 10;
            Console.WriteLine(num1 + num2);
        }
        static void Task2()
        {
            double num = 4;
            Console.WriteLine(num * num);
        }
        static void Task3()
        {
            string name = "Nigar";
            int age = 21;
            Console.WriteLine($"Salam, menim adım {name}-dır və menim {age} yaşım var.");
        }
        static void Task4()
        {
            double a = 10, b = 20;
            Console.WriteLine($"a={a},b={b}");
            double temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a={a},b={b}");
        }
        static void Task5()
        {
            Console.WriteLine("Üç eded daxil edin");
            double num1 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToInt32(Console.ReadLine());
            double num3 = Convert.ToInt32(Console.ReadLine());
            double sum = num1 + num2 + num3;
            double avg = sum / 3.0;
            Console.WriteLine($"Cem: {sum}, Ortalama: {avg}");
        }
        static void Task6()
        {
            Console.WriteLine("4 reqemli eded daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"Ededlerin cemi: {sum}");
        }
        static void Task7()
        {
            Console.WriteLine("Eded daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Cüt");
            }
            else
            {
                Console.WriteLine("Tek");
            }
        }
        static void Task8()
        {
            Console.WriteLine("Birinci ededi daxil edin");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci ededi daxil edin");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine($"{num1} > {num2}");
            else if (num2 > num1)
                Console.WriteLine($"{num2} < {num1}");
            else
                Console.WriteLine($"{num2} = {num1}");
        }
        static void Task9()
        {
            Console.WriteLine("Eded daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                Console.WriteLine("Müsbet");
            else if (num < 0)
                Console.WriteLine("Menfi");
            else
                Console.WriteLine("Sıfır");
        }
        static void Task10()
        {
            Console.WriteLine("Eded daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 15 == 0)
            {
                Console.WriteLine("Eded 3e ve 5e bölünür");
            }
            else
            {
                Console.WriteLine("Eded 3e ve 5e bölünmür");
            }
        }
        static void Task11()
        {
            Console.WriteLine("Eded daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0 || num % 3 == 0)
            {
                Console.WriteLine("Eded 2e ve ya 3e bölünür");
            }
            else
            {
                Console.WriteLine("Eded 2e ve ya 3e bölünmür");
            }
        }
        static void Task12()
        {
            Console.WriteLine("Ay nömresi daxil edin (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;
                case 2:
                    Console.WriteLine("Fevral");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Aprel");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("İyun");
                    break;
                case 7:
                    Console.WriteLine("İyul");
                    break;
                case 8:
                    Console.WriteLine("Avqust");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr");
                    break;
                case 10:
                    Console.WriteLine("Oktyabr");
                    break;
                case 11:
                    Console.WriteLine("Noyabr");
                    break;
                case 12:
                    Console.WriteLine("Dekabr");
                    break;
                default:
                    Console.WriteLine("Sehv secim dacxil etdiniz");
                    break;
            }
        }
        static void Task13()
        {
            Console.WriteLine("Bal daxil edin");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
        static void Task14()
        {
            Console.WriteLine("Birinci ededi daxil edin");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Emeliyyat daxil edin (+, -, *, /)");
            char emeliyyat = Convert.ToChar(Console.ReadLine());
            double result = 0;
            switch (emeliyyat)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Sehv emeliyat daxil etdiniz.");
                    return;
            }
            Console.WriteLine($"Cavab: {result}");
        }
        static void Task15()
        {
            Console.WriteLine("Mebleği daxil edin");
            double amount = Convert.ToDouble(Console.ReadLine());
            double discount = 0;
            if (amount >= 100)
                discount = 0.10;
            else if (amount >= 50)
                discount = 0.05;
            Console.WriteLine($"Ödeyeceyiniz mebleğ {amount - (amount * discount)} AZN, {amount * discount} AZN endirim tetbiq edildi");
        }
        static void Task16()
        {
            string adminName = "admin";
            string adminPassword = "2222";
            Console.WriteLine("Ad daxil edin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Şifre daxil edin: ");
            string password = Console.ReadLine();
            if (name == adminName && password == adminPassword)
            {
                Console.WriteLine("Hesaba ugurla daxil olundu.");
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz melumatlar sehvdir.");
            }
        }
        static void Task17()
        {
            Console.WriteLine("AZN->USD üçün 1e basın ve ya USD->AZN üçün 2ye basın");
            char choice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Mebleğ daxil edin");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (choice == '1')
            {
                Console.WriteLine($"{amount} AZN = {amount / 1.7} USD");
            }
            else if (choice == '2')
            {
                Console.WriteLine($"{amount} USD = {amount * 1.7} AZN");
            }
            else
            {
                Console.WriteLine("Seciminiz qebul edilmedi");
            }
        }
        static void Task18()
        {
            Console.WriteLine("Boyunuzu daxil edin");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilonuzu daxil edin");
            double weight = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine($"BMI: {bmi}");
            if (bmi < 18.5)
            {
                Console.WriteLine("Çeki azlığı");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("Normal çeki");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("Artıq çeki");
            }
            else
            {
                Console.WriteLine("Piylenme");
            }
        }
        static void Task19()
        {
            double balance = 208;
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("1. Balansı yoxla");
                Console.WriteLine("2. Medaxil");
                Console.WriteLine("3. Mexaric");
                Console.WriteLine("4. Çıxış");
                char choice = Convert.ToChar(Console.ReadLine());
                switch (choice)
                {
                    case '1':
                        Console.WriteLine($"Balans: {balance} AZN");
                        break;
                    case '2':
                        Console.WriteLine("Medaxil mebleğini daxil edin");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        if (deposit > 0)
                        {
                            balance += deposit;
                        }
                        else
                        {
                            Console.WriteLine("Yanlis secim");
                        }
                        break;
                    case '3':
                        Console.WriteLine("Mexaric mebleğini daxil edin");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        if (withdraw > 0 && withdraw <= balance)
                        {
                            balance -= withdraw;
                        }
                        else
                        {
                            Console.WriteLine("Yanlis secim");
                        }
                        break;
                    case '4':
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Yanlis secim.");
                        break;
                }
            }
        }
        static void Task20()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        static void Task21()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine($"Cem: {sum}");
        }
        static void Task22()
        {
            double[] nums = { 1, 2, 3, 4, 5 };
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine($"Ortalama: {sum / nums.Length}");
        }
        static void Task23()
        {
            int[] nums = { 5, 2, 8, 1, 9 };
            int min = nums[0], max = nums[0];
            int minIndex = 0, maxIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                    minIndex = i;
                }
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"Min: {min}, min index: {minIndex}");
            Console.WriteLine($"Max: {max}, max index: {maxIndex}");
        }
        static void Task24()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Cüt ededler");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                    Console.WriteLine(nums[i]);
            }
        }
        static void Task25()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[arr.Length - 1 - i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
        static void Task26()
        {
            int[] nums = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Konkret ededi daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            int index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num)
                {
                    index = i;
                }
            }
            Console.WriteLine($"Index: {index}");
        }
        static void Task27()
        {
            int[] nums = { 1, 2, 3, 2, 4, 5, 4, 6 };
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        Console.WriteLine(nums[i]);
                    }
                }
            }
        }
        static void Task28()
        {
            int[] nums = { 5, 2, 8, 1, 9, 3 };
            int max1 = int.MinValue, max2 = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (num > max1)
                {
                    max2 = max1;
                    max1 = num;
                }
                else if (num > max2 && num != max1)
                {
                    max2 = num;
                }
            }
            Console.WriteLine($"Ikinci en böyük eded: {max2}");
        }
        static void Task29()
        {
            Console.WriteLine("Eded daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"Reqemlerin cemi: {sum}");
        }
        static void Task30()
        {
            Console.WriteLine("Eded daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (num > 0)
            {
                count++;
                num /= 10;
            }
            Console.WriteLine($"Reqemlerin sayı: {count}");
        }
        static void Task31()
        {
            Console.WriteLine("Eded daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Composite");
            }
        }
        static void Task32()
        {
            Console.WriteLine("Eded daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            int numCopy = num;
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            if (numCopy == result)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }



}   
}
