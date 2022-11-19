//1 Сборник задач
/* 1 ПРАКТИЧЕСКАЯ РАБОТА
Console.WriteLine("Вы ввели число: ");
Console.ReadLine();*/


/* 1 ПРАКТИЧЕСКАЯ РАБОТА
float a1 = 5.8f;
float b1 = -7.9f;
b1 = a1;
a1= b1;
Console.WriteLine("a)");
Console.WriteLine("a = " + a1);
Console.WriteLine("b = " + b1);*/


/* 2 ПРАКТИЧЕСКАЯ РАБОТА
float a2 = 0;
float b2 = -9.99f;
b2 = a2;
a2 = b2;
Console.WriteLine("б)");
Console.WriteLine("a = " + a2);
Console.WriteLine("b = " + b2);*/


/* 3 ПРАКТИЧЕСАЯ РАБОТА
Console.WriteLine("Введите x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y:");
int y = Convert.ToInt32(Console.ReadLine());

double a = x + 2 + y / Math.Pow(x, 2);
double b = y + 1 / Math.Sqrt(Math.Pow(x, 2) + 10);
double z = a / b;

double q = 2.8f * Math.Asin(z) + Math.Abs(y);

Console.WriteLine("z = " + z + " " + " q = " + q);*/


/* 4 ПАРКТИЧЕСКАЯ РАБОТА 
Console.WriteLine("Введите значение температуры по Цельсия: ");
int c = Convert.ToInt32(Console.ReadLine());

float f = c * 1.8f + 32;
Console.WriteLine("Фарингейт = " + f);
float k = c + 273.15f;
Console.WriteLine("Кельвин = " + k);*/


/* 5 ПАРКТИЧЕСКАЯ РАБОТА
Console.WriteLine("Введите число");
string s = Console.ReadLine();
Console.WriteLine("Ваше число в обратном виде");
if (s[0] != '-')
    for (int i = s.Length - 1; i > -1; --i)
        Console.Write((s[i]));
else
{
    Console.Write("-");
    for (int i = s.Length - 1; i > 0; --i)
        Console.Write((s[i]));
}
Console.Read();*/


/* 6 ПРАКТИЧЕСКАЯ РАБОТА
Console.WriteLine("Введите число x");
int n = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;
int a = n / 100;
int b = n % 10;
int c = n % 100 / 10;
if (min <= n && n <= max)
{
    Console.WriteLine("Изначальное n-ое число:");
    Console.WriteLine(a + "" + b + "" + c);
}
else
{
    Console.WriteLine("Вы ввели число не подходящие условию, введите заново");
}*/


/* 7 ПРАКТИЧЕСКАЯ РАБОТА
int x = 0;
int y = 0;
int z = 1;
if (x == 0 || y == 0 && z != 1)
{
    Console.WriteLine("a) X или Y и не Z");
}

if (x != 0 && y != 0)
{
    Console.WriteLine("б) не X и не Y");
}

if (!(x == 0 && z == 1) || y == 0)
{
    Console.WriteLine("в) не (X и Z) или Y");
}

if (x == 0 && y != 0 || z == 1)
{
    Console.WriteLine("г) X и не Y или Z");
}

if (x == 0 && (y != 0 || z == 1))
{
    Console.WriteLine("д) X и (не Y или Z)");
}

if (x == 0 || (!(y == 0 || z == 1)))
{
    Console.WriteLine("е) X или (не (Y или Z))");
}*/


/* 8 ПРАКТИЧЕСКАЯ РАБОТА
Console.WriteLine("Введите x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z");
int z = Convert.ToInt32(Console.ReadLine());
if (!((y == 0 || y == 1) || (x != 0 || x != 1)) || (z == 0 || z == 1))
{
    Console.WriteLine("а) не (Y или не X и Z) или Z");
}

if ((x == 0 || x == 1) && !((y != 0 || y != 1) || (z == 0 || z == 1)) || (y == 0 || y == 1))
{
    Console.WriteLine("б) X и не (не Y или Z) или Y");
}

if (!((x == 0 || x == 1) || (y == 0 || y == 1) && (z == 0 || z == 1)) || (x != 0 || x != 1))
{
    Console.WriteLine("в) не (X или Y и Z) или не X");
}*/


/* 9 ПРАКТИЧЕСКАЯ РАБОТА
Console.WriteLine("Введите первое вещественное число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе вещественное число");
int y = Convert.ToInt32(Console.ReadLine());
if (x > y)
{
    Console.WriteLine("Первое вещественно чило больше второго");
}
else if(y < x)
{
    Console.WriteLine("Второе вещественно чило больше первого");
}*/


/* 10 ПРАКТИЧЕСКАЯ РАБОТА
Console.WriteLine("Введите двухзначное число");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100 && 9 >= a)
{
    Console.WriteLine("a) Число не является двухзначным");
}
else
{
    Console.WriteLine("а) Число являтся двухзнычным");
}

Console.WriteLine("Введите второе число для сравнениея");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Второе число меньше числа a");
}
if (a < b)
{
    Console.WriteLine("Второе число больше числа a");
}*/


/* 11 ПРАКТИЧЕСКАЯ РАБОТА
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if ((a / 2 == 0) || (b % a) == 0) 
{
    Console.WriteLine("Да, одно из чисел является делителем другого");
}
else
{
    Console.WriteLine("Нет, ни одно из чисел не является делителем другого");
}*/


/* 12 ПРАКТИЧЕСКАЯ РАБОТА
Console.WriteLine("Введите четырёх значное число");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 1000;
int b = n / 100 % 10;
int c = n / 10 % 10;
int d = n % 10;

if (n >= 10000 && n <= 999)
{
    Console.WriteLine("Введнно не четырёх значное число");
}
else if (a == d && b == c)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не являтеся палиндромом");
}*/


/* 13 ПРАКТИЧЕСКАЯ РАБОТА
Console.WriteLine("Введите три вещественных числа");
float a = Convert.ToInt32(Console.ReadLine());
float b = Convert.ToInt32(Console.ReadLine());
float c = Convert.ToInt32(Console.ReadLine());

if (a > 0)
{
    Console.WriteLine(Math.Pow(a, 2));
}
else
{
    Console.WriteLine(a);
}

if (b > 0)
{
    Console.WriteLine(Math.Pow(b, 2));
}
else
{
    Console.WriteLine(b);
}

if (c > 0)
{
    Console.WriteLine(Math.Pow(c, 2));
}
else
{
    Console.WriteLine(c);
}*/


/* 14 ПРАКТИЧЕСКАЯ РАБОТА
Console.WriteLine("Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine("Самое большое число " + a);
}

else if (a < b && a < c)
{
    Console.WriteLine("Самое маленькое число " + a);
}

else if (a < c && b == a)
{
    Console.WriteLine("Среднее число " + a);
}

else if (a < b && c == a)
{
    Console.WriteLine("Среднее число " + a);
}

if (b > a && b > c)
{
    Console.WriteLine("Самое большое число " + b);
}

else if (b < a && b < c)
{
    Console.WriteLine("Самое маленькое число " + b);
}

else if (a < c && a == b)
{
    Console.WriteLine("Среднее число " + b);
}

else if (a < b && c == b)
{
    Console.WriteLine("Среднее число " + b);
}

if (c > a && c > b)
{
    Console.WriteLine("Самое большое число " + c);
}

else if (a < c && b < c)
{
    Console.WriteLine("Самое маленькое число " + c);
}

else if (c < b && a == c )
{
    Console.WriteLine("Среднее число " + c);
}

else if (c < a && b == c)
{
    Console.WriteLine("Среднее число " + c);
}*/


/* 15 ПРАКТИЧЕСКАЯ РАБОТА
Console.Write("Введите курс доллара: ");
double rate = double.Parse(Console.ReadLine());
Console.WriteLine("\nfor\n");
for (int i = 5; i <= 120; i += 5)
    Console.WriteLine("{0} долларов - {1} рублей", i, i * rate);*/


/* 16 ПРАКТИЧЕСКАЯ РАБОТА
int i, mult = 8;
for (i = 9; i <= 15; ++i)
    mult = mult * i;
Console.WriteLine("Произведение ровно " + mult);

Console.WriteLine("Введите число больше 1 и меньше 20:");
int i1;
int mult1;
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 1 || a >= 20)
    Console.WriteLine("Некоретный ввод");
else
{
    mult1 = a;
    for (i1 = a + 1; i1 <= 20; i1++)
        mult1 = mult1 * i1;
    Console.WriteLine("Произведение равно " + mult1);
}

Console.WriteLine("Введите число больше 1 и меньше 20:");
int i2;
int mult2;
int b = Convert.ToInt32(Console.ReadLine());
if (b <= 1 || b >= 20)
    Console.WriteLine("Некоретный ввод");
else
{
    mult2 = 1;
    for (i2 = 2; i2 <= b; i2++)
        mult2 = mult2 * i2;
    Console.WriteLine("Произведение равно " + mult2);
}

Console.WriteLine("Введите число больше 1 и меньше 20:");
int i3;
int mult3;
int a3 = Convert.ToInt32(Console.ReadLine());
int b3 = Convert.ToInt32(Console.ReadLine());
if (a3 <= 1 || a3 >= 20 && b3 <= 1 || b3 >= 20)
    Console.WriteLine("Некоретный ввод");
else
{
    mult3 = a3;
    for (i3 = a3 + 1; i3 <= b3; i3++)
        mult3 = mult3 * i3;
    Console.WriteLine("Произведение равно " + mult3);
}*/


/* 17 ПРАКТИЧЕСКАЯ РАБОТА
float k;
float s = 0;
Console.WriteLine("Последовательное соединение");
for (k = 1; ; ++k)
{
    Console.WriteLine("Введите сопротивление " + k + " элемента цепи или 0 для завершения ввода ");
    float temp = Convert.ToInt32(Console.ReadLine());
    if (temp == 0)
        break;
    s += temp;
}
Console.WriteLine("Общее сопротивление цепи составляет " + s + " Ом"); */


/* 18 ПРАКТИЧЕСКАЯ РАБОТА
int n = 4;
long result = 1;
for (long i = 1; i < n; i++)
{
    result = result * i;
}
 Console.WriteLine(result);*/


/* 19 ПРАКТИЧЕСКАЯ РАБОТА
int k, n, last, c, m, cnt0, cnt5, kc, sum7, prod7;
cnt5 = 0;
cnt0 = 0;
Console.WriteLine("Введите число N");
n = int.Parse(Console.ReadLine());
m = n % 10;
last = 0;
k = 0;
kc = 0;
sum7 = 0;
prod7 = 1;

do
{
    c = n % 10;
    if ((n % 10) == 3) { k = k + 1; }
    if (n % 2 == 0) { kc = kc + 1; };
    if (c == m) { last = last + 1; }
    if (n % 10 == 0) { cnt0 = cnt0 + 1; }
    if (n % 10 == 5) { cnt5 = cnt5 + 1; }
    if (c > 7) { prod7 = prod7 * c; sum7 = sum7 + c; }
    n = n / 10;
}
while (n != 0);
Console.WriteLine("Число 3 встречается: " + k + " раз");
Console.WriteLine("Последнее число встречается: " + last + " раз");
Console.WriteLine("Четных чисел: " + kc);
Console.WriteLine("Всего чисел 5 и 0:" + (cnt0 + cnt5));
Console.WriteLine("Сумма чисел больше 7: " + sum7);
Console.WriteLine("Произведение чисел больше 7: " + prod7);

Console.ReadKey();*/


/* 20 ПРАКТИЧЕСКАЯ РАБОТА  
int number = 436123;

//а)с использованием двух операторов цикла;
do
{
    number = number / 10;

    if (number < 100)
    {
        do
        {
            number = number - 10;

            if (number < 10)
            {
                Console.WriteLine("Вторая (с начала) цифра : {0}", number);
            }
        }
        while (number > 10);
    }
}
while (number > 100);

//б)с использованием одного оператора цикла. 
number = 436123;

do
{
    number = number / 10;

    if (number < 100)
    {

        Console.WriteLine("Вторая (с начала) цифра : {0}",
            number.ToString().ToCharArray()[1]);
    }
}
while (number > 100);

//Delay
Console.WriteLine(new string('-', 50));
Console.WriteLine("Ready!");
Console.ReadKey();*/


/* 21 ПРАКТИЧЕСКАЯ РАБОТА 
double a = Convert.ToInt32(Console.ReadLine());
double b = Math.Pow(a, 1.0/3);
double c = Math.Pow(a, 1.0/5);
Console.WriteLine(b);
if (a == 8)
{
    Console.WriteLine("Степень тройки");
}
if (a == 32)
{
    Console.WriteLine("Степень пятёрки");
}*/


/* 22 ПРАКТИЧЕСКАЯ РАБОТА 
Console.WriteLine("204");*/


/* 23 ПРАКТИЧЕСКАЯ РАБОТА   Номер задания: 7.15
var b = new[] { 1.0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var P = 3.2;
var B = 7.8;
var sum = 0.0;
foreach (var t in b)
    if (t > P && t < B)
        sum += t;
Console.WriteLine(sum);*/


/* 24 ПРАКТИЧЕСКАЯ РАБОТА 
int sum;
for (int n = 50; n <= 70; n++)
{
    sum = 0;
    for (int i = 2; i <= n / 2; i++)
    {
        if (n % i == 0)
        {
            sum += i;
        }
    }
    sum += 1 + n;
    Console.Write(n);
    Console.Write(" sum=");
    Console.Write(sum);
    Console.Write("\n");
}*/


/* 25 ПРАКТИЧЕСКАЯ РАБОТА 
string[] cities = { "Москва", "Киев", "Вашингтон" };
int min = cities[0].Length;
int max = cities[0].Length;
int minIndex = 0;
int maxIndex = 0;
for (int i = 1; i < cities.Length; i++)
{
    if (cities[i].Length > max)
    {
        maxIndex = i;
        max = cities[i].Length;
        continue;
    }
    if (cities[i].Length < min)
    {
        minIndex = i;
        min = cities[i].Length;
    }
}
Console.WriteLine("Самое длинное название: " + cities[maxIndex]);
Console.WriteLine("Самое короткое название: " + cities[minIndex]);
Console.ReadKey();*/


/* 26 ПРАКТИЧЕСКАЯ РАБОТА 
string rost = "трос";
string rost1 = "трос";

rost = rost.Trim(new char[] { 'т' });
rost1 = rost1.Trim(new char[] { 'р', 'о', 'с'});
Console.WriteLine(rost + rost1);

string tors = "трос";
string tors1 = "трос";
string tors2 = "трос";
string tors3 = "трос";

tors = tors.Trim(new char[] { 'р', 'о', 'с' });
tors1 = tors1.Trim(new char[] { 'р', 'т', 'с' });
tors2 = tors2.Trim(new char[] { 'о', 'т', 'с' });
tors3 = tors3.Trim(new char[] { 'о', 'т', 'р' });
Console.WriteLine(tors + tors1 + tors2 + tors3);

string sort = "трос";
string sort1 = "трос";
string sort2 = "трос";
string sort3 = "трос";

sort = sort.Trim(new char[] { 'р', 'о', 'т' });
sort1 = sort1.Trim(new char[] { 'р', 'т', 'с' });
sort2 = sort2.Trim(new char[] { 'о', 'т', 'с' });
sort3 = sort3.Trim(new char[] { 'о', 'с', 'р' });
Console.WriteLine(sort + sort1 + sort2 + sort3);*/


/* 27 ПРАКТИЧЕСКАЯ РАБОТА 
Console.WriteLine("________");*/


/* 28 ПРАКТИЧЕСКАЯ РАБОТА  
string prdl = "hello my young gentleman";
int dub = 0;
char lastLetter = '0';

for (int i = 0; i < prdl.Length - 1; i++)
{
    if (char.IsLetter(prdl[i]))
        lastLetter = prdl[i];
    if (lastLetter == prdl[i + 1])
        dub++;
}

Console.WriteLine(dub);*/


/* 29 ПРАКТИЧЕСКАЯ РАБОТА 
string text = " Даноо предложение, в котором нет символа «-«";
text = text.Trim();
int i = 0;
int q = 0;
do
{
    if (text[i] == 'о')
  {
        q++;
    }
    i++;
    if (text[i] == ' ')
  {
        Console.WriteLine($"количество букв ‘о’ в первом слове { q}");
        break;
    }
}
while (i > 0);*/


/* 30 ПРАКТИЧЕСКАЯ РАБОТА 
Console.WriteLine("собаки");
string sobaki = "собаки";
string sobaki1 = "собаки";

sobaki = sobaki.Replace('о', 'к');
sobaki = sobaki.Remove(4, 1);
sobaki = sobaki.Remove(4, 1);
sobaki1 = sobaki1.Remove(0, 1);
sobaki1 = sobaki1.Remove(1, 3);

Console.WriteLine(sobaki + sobaki1);*/


/* 31 ПРАКТИЧЕСКАЯ РАБОТА 
Console.WriteLine("стекляный_");
Console.WriteLine("стеклянный");*/


/* 32 ПРАКТИЧЕСКАЯ РАБОТА  
string s = Console.ReadLine();
var q = s.Distinct();
foreach (char c in q)
    Console.Write(c);
Console.WriteLine("\n{0}", q.Count());
Console.ReadLine();*/


/* 33 ПРАКТИЧЕСКАЯ РАБОТА  
Console.WriteLine("Введите какое-нибудь предложение");
string s = Console.ReadLine();

string maxWord = "";
foreach (string one_word in s.Split(' '))
{
    if (one_word.Length > maxWord.Length)
        maxWord = one_word;
}
Console.WriteLine("самое длинное слово: {0}", maxWord);

Console.Write(" ");
Console.ReadKey(true);*/


/* 34 ПРАКТИЧЕСКАЯ РАБОТА  
const int n = 10;
string ss = "";
Console.Write("Введите B: ");
int b = Convert.ToInt32(Console.ReadLine());
int[] a = new int[10];
Console.WriteLine("Исходный массив: ");
Random r = new Random();
for (int i = 0; i < n; i++)
{
    a[i] = r.Next(-10, 10);
    ss = ss + string.Format("{0,4:0}", a[i]);
}
Console.WriteLine(ss);
int last = a[a.Length - 1];
Console.WriteLine("Новый массив: ");
for (int i = 0; i < a.Length; i++)
{
    a[i] -= 20;
    a[i] *= last;
    a[i] += b;
    Console.Write(a[i]);
}
Console.ReadKey();*/


/* 35 ПРАКТИЧЕСКАЯ РАБОТА   
Random random = new Random();
int[] A = new int[20].Select(_ => random.Next(176) - 55).ToArray();
Console.WriteLine("Максимальный отрицательный элемент: {0}", A.Where(x => x < 0).Max());*/


/* 36 ПРАКТИЧЕСКАЯ РАБОТА  
int[] mas = new int[] { -1, -3, 4, 5, -10, 34, -60, 3, 5, 7, 1 };
int sum = mas.Sum();

for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] > sum) Console.WriteLine(i);
}*/


/* 37 ПРАКТИЧЕСКАЯ РАБОТА  
int[] x = new int[100];
Random r = new Random();
x = x.Select(i =>
{
    int a = r.Next(1, 500);
    Console.Write(a + " ");
    return a;
}).ToArray();
int max = x.Max();
Console.WriteLine("\nMAX = " + max);*/


/* 38 ПРАКТИЧЕСКАЯ РАБОТА  
int[] a = new int[10] { 1, 5, 3, 4, 5, 6, 7, 8, 5, 8 };
int index = 0;
a.First(n => { index++; return n == 5; });

Console.WriteLine("Номер первого элемента:" + Array.IndexOf(a, 5));
Console.WriteLine("Номер последнего элемента:" + Array.LastIndexOf(a, 5));
Console.ReadKey();*/


/* 39 ПРАКТИЧЕСКАЯ РАБОТА   
for (int i = 1; i < 20; i++)
{

    Console.Write("Введите мощность ");
    Console.Write(i);
    Console.Write(" автомобиля: ");

    int input = Convert.ToInt32(Console.ReadLine());

    if (input > 200)
    {
        Console.Write("Автомобиль ");
        Console.Write(i);
        Console.Write(" Превышает мощность двигателя в 200 л.с");
        Console.Write("\n");
    }
}*/


/* 40 ПРАКТИЧЕСКАЯ РАБОТА  
int[,] a = new int[8, 9];
int x = 5; 
Console.Write(a[3, x]);*/


/* 41 ПРАКТИЧЕСКАЯ РАБОТА  
int N, M, Sum = 0, Proizv = 1;
Console.WriteLine("Введите N-строк и M-столбцов!");
Console.Write("N = ");
N = Convert.ToInt32(Console.ReadLine());
Console.Write("M = ");
M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] Mass = new int[N, M];
Random Rand = new Random();

// Заполнение двумерного массива
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        // Рандомные числа от 2 до 5
        Mass[i, j] = Rand.Next(2, 5);

        Console.Write("{0} ", Mass[i, j]);
    }
    Console.WriteLine();
}
// Четвертая строка
int Row = 4;

// Cумму элементов 4й строки
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        if (i == Row - 1)
        {
            Sum += Mass[i, j];
        }
    }
}
string RezNumber = Sum.ToString().Length == 2 ? "двузначное число" : "не двузначное число";
Console.WriteLine($"Сумма строки  {Sum} - {RezNumber}");
Console.Write("Введите номер столбца: ");
int Column = Convert.ToInt32(Console.ReadLine());

// Произведение элементов столбца
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        if (j == Column - 1)
        {
            Proizv *= Mass[i, j];
        }
    }
}

string RezColumn = Proizv > 2 ? "превышает" : "Не превышает";
Console.WriteLine($"Произведение {Column} столбца {Proizv} {RezColumn} заданное число");     //выводим сумму столбца
Console.ReadKey();*/


/* 42 ПРАКТИЧЕСКАЯ РАБОТА  
int[,] mas = new int [5,5];
mas[mas.GetLength(0) - 1, 0] = mas[0, mas.GetLength(0) - 0];*/


/* 43 ПРАКТИЧЕСКАЯ РАБОТА 
int[,] mass = new int[4, 4]
            {
                {5,9,3,1 },
                {2,3,0,8 },
                {7,6,9,10 },
                {0,1,2,4 }
            };

//меняем строчки местами
int bufer;

for (int i = 0; i < 2; i = +2)
{
    for (int j = 0; j < 4; j++)
    {
        bufer = mass[i + 1, j];
        mass[i + 1, j] = mass[i, j];
        mass[i, j] = bufer;

    }
}
//вывод нового массива
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.ReadKey();*/


/* 44 ПРАКТИЧЕСКАЯ РАБОТА 
StreamWriter file = new StreamWriter("H:\\TestFile.txt");
file.WriteLine("1, 2, 3, 4, 5, 6, 7");
file.WriteLine("1.1, 2.2, 3.3, 4.4");
file.WriteLine("текст это пишу для задания");
file.Close();*/


/* 45 ПРАКТИЧЕСКАЯ РАБОТА 
int year = Convert.ToInt32(Console.ReadLine());
string color = string.Empty;
switch (((year + 6) % 10 + 2) / 2)
{
    case 1:
        color = "Green";
        break;
    case 2:
        color = "Red";
        break;
    case 3:
        color = "Yellow";
        break;
    case 4:
        color = "White";
        break;
    case 5:
        color = "Black";
        break;
}
switch ((year - 3) % 12)
{
    case 1:
        Console.WriteLine($"{color} Mouse year");
        break;
    case 2:
        Console.WriteLine($"{color} Cow year");
        break;
    case 3:
        Console.WriteLine($"{color} Tiger year");
        break;
    case 4:
        Console.WriteLine($"{color} Rabbit year");
        break;
    case 5:
        Console.WriteLine($"{color} Dragon year");
        break;
    case 6:
        Console.WriteLine($"{color} Snake year");
        break;
    case 7:
        Console.WriteLine($"{color} Horse year");
        break;
    case 8:
        Console.WriteLine($"{color} Sheep year");
        break;
    case 9:
        Console.WriteLine($"{color} Monkey year");
        break;
    case 10:
        Console.WriteLine($"{color} Cock year");
        break;
    case 11:
        Console.WriteLine($"{color} Dog year");
        break;
    case 0:
        Console.WriteLine($"{color} Pig year");
        break;
}*/


/* 46 ПРАКТИЧЕСКАЯ РАБОТА  
Console.WriteLine("Введите числа:\n");
Console.WriteLine("m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("n=");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ответ: ");
switch (m)
{
    case 1: if (n >= 2) Console.WriteLine($"январь {n - 1}"); else Console.WriteLine("31 декабря"); break;
    case 2: if (n >= 2) Console.WriteLine($"февраль {n - 1}"); else Console.WriteLine("31 января"); break;
    case 3: if (n >= 2) Console.WriteLine($"март {n - 1}"); else Console.WriteLine("28 февраля"); break;
    case 4: if (n >= 2) Console.WriteLine($"апрель {n - 1}"); else Console.WriteLine("31 марта"); break;
    case 5: if (n >= 2) Console.WriteLine($"май {n - 1}"); else Console.WriteLine("30 апреля"); break;
    case 6: if (n >= 2) Console.WriteLine($"июня {n - 1}"); else Console.WriteLine("31 мая"); break;
    case 7: if (n >= 2) Console.WriteLine($"июля {n - 1}"); else Console.WriteLine("30 июня"); break;
    case 8: if (n >= 2) Console.WriteLine($"августа {n - 1}"); else Console.WriteLine("31 июля"); break;
    case 9: if (n >= 2) Console.WriteLine($"сентября {n - 1}"); else Console.WriteLine("31 августа"); break;
    case 10: if (n >= 2) Console.WriteLine($"октября {n - 1}"); else Console.WriteLine("30 сентября"); break;
    case 11: if (n >= 2) Console.WriteLine($"ноября {n - 1}"); else Console.WriteLine("31 октября"); break;
    case 12: if (n >= 2) Console.WriteLine($"декабря {n - 1}"); else Console.WriteLine("30 ноября"); break;
}

Console.WriteLine("Введите числа:\n");
Console.WriteLine("m1=");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("n1=");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ответ: ");
switch (m1)
{
    case 1: if (n1 <= 30) Console.WriteLine($"январь {n1 + 1}"); else Console.WriteLine("1 февраля"); break;
    case 2: if (n1 <= 27) Console.WriteLine($"февраль {n1 + 1}"); else Console.WriteLine("1 марта"); break;
    case 3: if (n1 <= 30) Console.WriteLine($"март {n1 + 1}"); else Console.WriteLine("1 апреля"); break;
    case 4: if (n1 <= 29) Console.WriteLine($"апрель {n1 + 1}"); else Console.WriteLine("1 мая"); break;
    case 5: if (n1 <= 30) Console.WriteLine($"май {n1 + 1}"); else Console.WriteLine("1 июня"); break;
    case 6: if (n1 <= 29) Console.WriteLine($"июня {n1 + 1}"); else Console.WriteLine("1 июля"); break;
    case 7: if (n1 <= 30) Console.WriteLine($"июль {n1 + 1}"); else Console.WriteLine("1 августа"); break;
    case 8: if (n1 <= 30) Console.WriteLine($"август {n1 + 1}"); else Console.WriteLine("1 сентября"); break;
    case 9: if (n1 <= 29) Console.WriteLine($"сентября {n1 + 1}"); else Console.WriteLine("1 октября"); break;
    case 10: if (n1 <= 30) Console.WriteLine($"октября {n1 + 1}"); else Console.WriteLine("1 ноября"); break;
    case 11: if (n1 <= 29) Console.WriteLine($"ноября {n1 + 1}"); else Console.WriteLine("1 декабря"); break;
    case 12: if (n1 <= 30) Console.WriteLine($"декабря {n1 + 1}"); else Console.WriteLine("1 января"); break;
}*/


/* 47 ПРАКТИЧЕСКАЯ РАБОТА
double kolvo = 0;
double ploshadj = 0;

Console.WriteLine("Напишиье количество жителей(в тысячах человек)  \n enter\n после площадь(в км2)» + «\n enter \n количество жителей(в тысячах человек)  \n enter\n  площадь(в км2)");
for (int a = 1; a <= 12; a++)
{
    kolvo = Convert.ToDouble(Console.ReadLine());
    ploshadj = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("кол-во: " + kolvo + " i площади: " + ploshadj + "\n");
Console.WriteLine("средняя плотность населения по области в целом: " + (kolvo / ploshadj));*/


/* 48 ПРАКТИЧЕСКАЯ РАБОТА 
int N4count = 0;
int N4;
do
{
    Console.WriteLine($"Введите {N4count + 1}-e число последовательности");
    N4 = Convert.ToInt32(Console.ReadLine());
    N4count++;
}
while (N4 < 0);
Console.WriteLine($"В начале последовательности {N4count - 1} отрицательных чисел");
Console.ReadKey();*/


/* 49 ПРАКТИЧЕСКАЯ РАБОТА 
int N13;
int N13count = 0;
int N13Min1 = 0;
bool B13 = true;
while (N13count < 15)
{
    Console.WriteLine($"число А{N13count + 1}");
    N13 = Convert.ToInt32(Console.ReadLine());
    if (N13 < 0 && B13) { N13Min1 = N13; B13 = false; }
    N13count++;
}
Console.WriteLine(N13Min1 < 0 ? $"Первое отрицательное число в последовательности {N13Min1}" : "В последовательности нет отрицательных чисел");
Console.ReadKey();*/







/*(50) 1 ПРАКТИЧЕСКАЯ РАБОТА 
Console.WriteLine("Введите стороны А и В по очереди: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
double S = a * b;
double P = 2*(a * b);
Console.WriteLine("Периметр (Р) = {0}, Площадь (S) = {1}", P, S);*/


/*(51) 2 ПРАКТИЧЕСКАЯ РАБОТА 
double x1, x2, x3, y1, y2, y3;
Console.WriteLine("Введите координаты:");
x1 = Double.Parse(Console.ReadLine());
y1 = Double.Parse(Console.ReadLine());
x2 = Double.Parse(Console.ReadLine());
y2 = Double.Parse(Console.ReadLine());
x3 = Double.Parse(Console.ReadLine());
y3 = Double.Parse(Console.ReadLine());

double dist12 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
double dist13 = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
double dist23 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
double P = dist12 + dist13 + dist23;
double p = P / 2;
double Area = p * (p - dist12) * (p - dist13) * (p - dist23);

Console.WriteLine("Площадь {0}", Area);
Console.ReadKey();*/


/*(52) 3 ПРАКТИЧЕСКАЯ РАБОТА   
double a, b, c, x1, x2, d;
Console.Write("A: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("B: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("C: ");
c = Convert.ToDouble(Console.ReadLine());

d = Math.Pow(b, 2) - 4 * a * c;
x1 = ((-1) * b + Math.Sqrt(d)) / (2 * a);
x2 = ((-1) * b - Math.Sqrt(d)) / (2 * a);

if (x1 > x2)
{
    Console.WriteLine("X1 больше чем X2");
}
else
{
    Console.WriteLine("X1 меньше чем X2 ");
}*/


/*(53) 4 ПРАКТИЧЕСКАЯ РАБОТА 
int a, b;
Console.WriteLine("A: ");
a = Convert.ToInt32(Console.ReadLine());
b = a % 1000 / 100;
Console.WriteLine("B: " +b);*/


/*(54) 5 ПРАКТИЧЕСКАЯ РАБОТА 
int a, b;
Console.WriteLine("A: ");
a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("B: ");
b = Convert.ToInt16(Console.ReadLine());
if (a > 0 || b < (-2)) Console.WriteLine(true);
else Console.WriteLine(false);*/


/*(55) 6 ПРАКТИЧЕСКАЯ РАБОТА  
int a;
Console.WriteLine("A: ");
a = Convert.ToInt32(Console.ReadLine());
if (a % 10 == a / 1000 & a % 100 / 10 == a % 1000 / 100) Console.WriteLine(true);
else Console.WriteLine(false);*/


/*(56) 7 ПРАКТИЧЕСКАЯ РАБОТА 
Console.Write("a:");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0) a++;
Console.Write(a);*/


/*(57) 8 ПРАКТИЧЕСКАЯ РАБОТА  
int n;
Console.WriteLine("A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("C: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("D: ");
int d = Convert.ToInt16(Console.ReadLine());
if (a == b && b == c) Console.WriteLine(n = 1);
else if (a == b && a == d) Console.WriteLine(n = 2);
else if (a == c && a == d) Console.WriteLine(n = 3);
else if (b == d && b == d) Console.WriteLine(n = 4);
else Console.WriteLine(n = 5);*/


/*(58) 9 ПРАКТИЧЕСКАЯ РАБОТА  
int N;
int m;
Console.WriteLine("Номер действия:");
N = int.Parse(Console.ReadLine());
Console.WriteLine("Масса:");
m = int.Parse(Console.ReadLine());

switch (N)
{
    case 1:
        Console.WriteLine(m);
        break;
    case 2:
        Console.WriteLine(m / 1000000);
        break;
    case 3:
        Console.WriteLine(m / 1000);
        break;
    case 4:
        Console.WriteLine(m * 1000);
        break;
    case 5:
        Console.WriteLine(m * 100);
        break;
}*/


/*(59) 10 ПРАКТИЧЕСКАЯ РАБОТА 
Console.Write("Price =");
double c = Convert.ToDouble(Console.ReadLine());
double i;
for (i = 0.1; i < 1; i += 0.1)
    Console.WriteLine($"{i} kg = {c * i}");

Console.ReadKey();*/


/*(60) 11 ПРАКТИЧЕСКАЯ РАБОТА 
float x;
Console.WriteLine("X:");
x = float.Parse(Console.ReadLine());
int n;
Console.WriteLine("N:");
n = int.Parse(Console.ReadLine());

float x1 = 1F;
float n1 = 1F;
float rez = 1.0F;
int i;

for (i = 1; i <= n; ++i)
{
    n1 *= (float)i;
    x1 *= x;
    rez += x1 / n1;
}
Console.WriteLine(rez);*/


/*(61) 12 ПРАКТИЧЕСКАЯ РАБОТА
int a;
int b;
Console.WriteLine("A:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("B:");
b = int.Parse(Console.ReadLine());

int temp = a;
while (temp >= 0)
{
    temp -= b;
}
Console.Write(temp + b);*/


/*(62) 13 ПРАКТИЧЕСКАЯ РАБОТА   
int N;
int R = 0; 
Console.WriteLine("Введите  целое число N (>0): ");
N = int.Parse(Console.ReadLine());
while (N > 0)
{
    int M = N % 10;
    R = R * 10 + M;
    N /= 10;
}
Console.Write("Число полученное при прочтении числа N справа налево: ");
Console.Write(R);
Console.Write("\n");*/


/*(63) 14 ПРАКТИЧЕСКАЯ РАБОТА  
Double r;
int i, n, sum = 0;
Console.Write("N=");
n = Convert.ToInt32(Console.ReadLine());

for (i = 1; i <= n; i++)
{
    Console.Write("Введите число ");
    r = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine((int)(r + (r >= 0 ? 0.5 : -0.5)));
    sum += (int)(r + (r >= 0 ? 0.5 : -0.5));
}
Console.WriteLine("Сумма = " + sum);*/



/*(64) 15 ПРАКТИЧЕСКАЯ РАБОТА  
int n;
int s = 0;
int flag = 0;
int i;
n = int.Parse(Console.ReadLine());
int[] mas = new int[n];
for (i = 0; i < n; ++i)
{
    mas[i] = int.Parse(Console.ReadLine());
}
for (i = 0; i < n; ++i)
{
    if (mas[i] == 0)
    {
        flag++;
    }
    if (flag == 2)
    {
        break;
    }
    if (flag >= 1)
    {
        s += mas[i];
    }
}
Console.Write(s);*/


/*(65) 16 ПРАКТИЧЕСКАЯ РАБОТА 
public static class Globals
{
    public static int SumRange(int A, int B)
    {
        int sum = 0;
        if (A > B)
        {
            return 0;
        }
        for (int i = A; i <= B; i++)
        {
            sum += i;
        }
        return sum;
    }

    internal static void Main()
    {
        int A;
        int B;
        int C;
        Console.Write("Enter 3 numbers: ");
        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        Console.Write("Sum of numbers in range (A, B): ");
        Console.Write(SumRange(A, B));
        Console.Write("\nSum of numbers in range (B, C): ");
        Console.Write(SumRange(B, C));
        Console.Write("\n");
    }
}*/


/*(66) 17 ПРАКТИЧЕСКАЯ РАБОТА 
class zadanie39
{
    static double Power1(double A, double B)
    {
        double result;
        if (A <= 0)
        {
            { return 0; }
        }
        else
        {
            result = Math.Exp(B * Math.Log(A));
        }
        return result;
    }
    static double Power2(double A, int N)
    {
        double rezult = 1;
        if (N < 0)
        {
            for (int i = 0; i > Math.Abs(N); i--)
            {
                rezult *= A;
            }
            return 1 / rezult;
        }
        else
        {
            if (N == 0) { return 1; }
            else
            {
                for (int i = 0; i < N; i++) { rezult *= A; }
                return rezult;
            }
        }
    }
    static double Power3(double A, double B)
    {
        double result;
        double x1 = Math.Floor(B);
        double x2 = B - Math.Floor(B);
        if (x2 == 0)
        {
            result = Power2(A, (int)Math.Round(B));
            { return result; }
        }
        else
        {
            result = Power1(A, B);
        }
        return result;
    }
    static void Main()
    {
        double d;
        Console.Write("Press P: ");
        double P = double.Parse(Console.ReadLine());
        Console.Write("Press A: ");
        double A = double.Parse(Console.ReadLine());
        Console.Write("Press B: ");
        double B = double.Parse(Console.ReadLine());
        Console.Write("Press C: ");
        double C = double.Parse(Console.ReadLine());
        d = Power3(A, P);
        Console.WriteLine("AP: " + d);
        d = Power3(B, P);
        Console.WriteLine("BP: " + d);
        d = Power3(C, P);
        Console.WriteLine("CP: " + d);
        Console.ReadKey();
    }
}*/


/*(67) 18 ПРАКТИЧЕСКАЯ РАБОТА 
float b, c, r, max = -1;
int maxnum = 0, i;

Console.WriteLine("B:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("C:");
c = Convert.ToInt32(Console.ReadLine());

for (i = 1; i <= 10; ++i)
{
    Console.WriteLine("i>" + i);
    r = Convert.ToInt32(Console.ReadLine());

    if ((b < r) && (r < c) && ((r > max) || (maxnum == 0)))
    {
        max = r;
        maxnum = i;
    }
}
Console.WriteLine("i f\n" + maxnum + max);*/


/*(68) 19 ПРАКТИЧЕСКАЯ РАБОТА  
float[] a = new float[1001];
float n;
float d;
n = float.Parse(Console.ReadLine());
a[0] = float.Parse(Console.ReadLine());
d = float.Parse(Console.ReadLine());
for (int i = 1; i < n; i++)
{
    a[i] = a[0] + (i) * d;
}
for (int i = 0; i < n; i++)
{
    Console.Write(a[i]);
    Console.Write(" ");
}*/


/*(69) 20 ПРАКТИЧЕСКАЯ РАБОТА 
int[] a = new int[10];
int n;
int k;
int l;

Console.Write("N: ");
n = int.Parse(Console.ReadLine());
Console.Write("K: ");
k = int.Parse(Console.ReadLine());
Console.Write("L: ");
l = int.Parse(Console.ReadLine());

int i;
for (i = 0; i < n; ++i)
{
    Console.Write("a[");
    Console.Write(i + 1);
    Console.Write("] :");
    a[i] = int.Parse(Console.ReadLine());
}

int sum = 0;
for (i = 0; i < k - 1; ++i)
{
    sum += a[i];
}
for (i = l; i < n; ++i)
{
    sum += a[i];
}

Console.Write((float)sum / (float)(k - 1 + (n - l)));*/


/*(70) 21 ПРАКТИЧЕСКАЯ РАБОТА 
Console.Write("Введите количество элементов массива");
Console.Write("\n");
uint lenthOfArray = 0; //переменная длины массива
lenthOfArray = uint.Parse(Console.ReadLine());
//создаем Массив 
int[] Array = new int[lenthOfArray];
int M = 1;
Console.Write("Вводите элементы массива:");
Console.Write("\n");
for (int i = 0; i < lenthOfArray; i++)
{
    Array[i] = int.Parse(Console.ReadLine());


    if (i > 1)
    {
        if ((Array[i] > Array[i - 1]) && (Array[i - 1] < Array[i - 2]))
        {
            M++;

        }
        else
        {
            if ((Array[i] < Array[i - 1]) && (Array[i - 1] > Array[i - 2]))
            {
                M++;
            }
            else
            {
                if ((Array[i] == Array[i - 1]) && (Array[i - 1] != Array[i - 2]))
                {
                    M++;
                }
            }
        }
    }

}


Console.Write("Количество промежутков монотонности: ");
Console.Write(M);
Console.Write("\n");

Console.ReadKey(true);
Array = null;*/


/*(71) 22 ПРАКТИЧЕСКАЯ РАБОТА   
int n = 9;
byte[] arr = new byte[n];
byte[] newarr = new byte[n];
new Random(DateTime.Now.Millisecond).NextBytes(arr);
int indexMin = n - 1;
int indexMax = 0;

Console.WriteLine("исходный массив:");
Console.WriteLine(string.Join(" ", arr));

for (int i = 0; i < n; i++)
{
    indexMin = arr[indexMin] > arr[i] ? i : indexMin;
    indexMax = arr[indexMax] < arr[i] ? i : indexMax;
}
if (indexMin > indexMax)
{
    int y = indexMax;
    indexMax = indexMin;
    indexMin = y;
}
int k = 0;
for (int i = 0; i < indexMin; i++)
    newarr[k++] = arr[i];
for (int i = indexMax; i >= indexMin; i--)
    newarr[k++] = arr[i];
for (int i = indexMax + 1; i < n; i++)
    newarr[k++] = arr[i];
Console.Write(string.Join(" ", newarr));*/


/*(72) 23 ПРАКТИЧЕСКАЯ РАБОТА  
int n;
n = int.Parse(Console.ReadLine());

// Считываем и сразу затираем каждый второй элемент
int[] arr = new int[n / 2 + 1];
for (int i = 1; i <= n; i++)
{
    arr[i / 2] = int.Parse(Console.ReadLine());
}

// Получаем реальное кол-во элементов и выводим их
n = (n + 1) / 2;
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i]);
    Console.Write(" ");
}*/


/*(73) 24 ПРАКТИЧЕСКАЯ РАБОТА 
int[] InputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int SizeArray = 0;

Console.Write("Результат без нечетных элементов: ");

for (int i = 0; i < InputArray.Length; i++)
{
    if (InputArray[i] % 2 == 0)
    {
        SizeArray++;

        Console.Write($"{InputArray[i]} ");
    }
}
Console.WriteLine();

Console.WriteLine($"Размер новой последовательности: {SizeArray}");*/


/*(74) 25 ПРАКТИЧЕСКАЯ РАБОТА 
int[] a = new int[20];
int n;
Console.Write("N: ");
n = int.Parse(Console.ReadLine());

int i;
for (i = 0; i < n; ++i)
{
    Console.Write("a[");
    Console.Write(i + 1);
    Console.Write("] : ");
    a[i] = int.Parse(Console.ReadLine());
}

int i2;
for (i = 0; i < n; ++i)
{
    if (i + 1 < n)
    {
        if (a[i + 1] != a[i])
        {
            ++n;
            for (i2 = n - 1; i2 > i; --i2)
            {
                a[i2] = a[i2 - 1];
            }
            ++i;
        }
    }
}
++n;
a[n - 1] = a[n - 2];

for (i = 0; i < n; ++i)
{
    Console.Write(' ');
    Console.Write(i + 1);
    Console.Write(": ");
    Console.Write(a[i]);
    Console.Write("\n");
}*/


/*(75) 26 ПРАКТИЧЕСКАЯ РАБОТА 
int m, n, k, i, j;

Console.Write("M=");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("N=");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("K=");
k = Convert.ToInt32(Console.ReadLine());

// Объявляем массив
int[,] A = new int[m, n];

// Вводим массив
for (i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        Console.Write("A[" + (i + 1) + "," + (j + 1) + "]=");
        A[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

// Выводим k-ю строку
Console.WriteLine("Строка " + k);
for (j = 0; j < n; j++)
{
    Console.Write("A[" + (k) + "," + (j + 1) + "]=" + A[k - 1, j] + " ");
}*/


/*(76) 27 ПРАКТИЧЕСКАЯ РАБОТА  
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите M");
int M = int.Parse(Console.ReadLine());
int i, j;
int[,] massiv = new int[N, M];

for (i = 0; i < N; i++)
{
    for (j = 0; j < M; j++)
    {
        Console.Write("Massiv[{0},{1}]", i, j);
        massiv[i, j] = int.Parse(Console.ReadLine());
    }
}
double k = double.MinValue;
int row = 0;
for (i = 0; i < N; i++)
{
    double sum = 0;
    for (j = 0; j < M; j++)
    {
        sum += massiv[i, j];
    }
    if (sum > k)
    {
        row = i;
        k = sum;
    }
}
Console.WriteLine("Номер строки {0}", row + 1);
Console.WriteLine("Cумма {0}", k);*/



/*(77) 28 ПРАКТИЧЕСКАЯ РАБОТА 
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine());
int i, j;
int[,] massiv = new int[n, m];

for (i = 0; i < n; i++)                                
{
    for (j = 0; j < m; j++)
    {
        Console.Write("Massiv[{0},{1}] ", i, j);
        massiv[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Исходный массив");
for (i = 0; i < n; i++)
{
    for (j = 0; j < m; j++)
    {
        Console.Write(" {0} ", massiv[i, j]);
    }
    Console.WriteLine();
}
int flag = 1;
while (flag == 1)
{
    flag = 0;
    for (i = 0; i < n - 1; i++)
    {
        int max = 0;
        int max1 = 0;
        for (j = 0; j < m; j++)
        {
            if (massiv[j, i] > max)
            {
                max = massiv[j, i];
            }
            if (massiv[j, i + 1] > max1)
            {
                max1 = massiv[j, i + 1];
            }
        }
        if (max > max1)
        {
            for (j = 0; j < m; j++)
            {
                int tmp = massiv[j, i];
                massiv[j, i] = massiv[j, i + 1];
                massiv[j, i + 1] = tmp;
            }
            flag = 1;
        }
    }
}
Console.WriteLine("Преобразованный массив");
for (i = 0; i < n; i++)
{
    for (j = 0; j < m; j++)
    {
        Console.Write(" {0} ", massiv[i, j]);
    }
    Console.WriteLine();
}*/


/*(78) 29 ПРАКТИЧЕСКАЯ РАБОТА  
class ca
{ 
    static void Main(string[] args)
    {
        int n = 5; //parse from
        int[,] matrix = new int[n, n];
    
        //fill up matrix
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(0, 10);
            }
        }
    
        Console.WriteLine("Source:");
        DisplayMatrix(matrix);
    
        Console.WriteLine("\n\nMirror:");
        DisplayMirrorMatrix(matrix);
    
        Console.ReadKey();
    }
    
    static void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}, ");
            }
            Console.Write("\b\b\0\n");
        }
    }
    
    static void DisplayMirrorMatrix(int[,] matrix)
    {
        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
        {
            for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
            {
                Console.Write($"{matrix[j, i]}, ");
            }
            Console.Write("\b\b\0\n");
        }
    }
}*/


/*(79) 30 ПРАКТИЧЕСКАЯ РАБОТА  
string line = "Дана строка. Подсчитать общее количество содержащихся в ней cтрочных латинских и русских букв. Basic C# Programming";

int count = 0;
for (int i = 0; i < line.Length; i++)
{
    if (char.IsUpper(line[i]))
    {
        count++;
    }
}

Console.WriteLine(count);
Console.ReadLine();*/


/*(80) 31 ПРАКТИЧЕСКАЯ РАБОТА   
var line = "Школа   Магазин Автомобиль  Университет";
var result = string.Join(' ', line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x.First()));
Console.WriteLine(result);*/


/*(81) 32 ПРАКТИЧЕСКАЯ РАБОТА  
int i;
string[] mass = File.ReadAllLines(@"F:\projects\12.txt");
for (i = 0; i < mass.Length; i++)
{
    if (mass[i] != "")
        Console.WriteLine(mass[i]);
}*/


/*(82) 33 ПРАКТИЧЕСКАЯ РАБОТА   
using System.Text;

string filePath = @"text.txt";
string[] lines = File.ReadAllLines(filePath, Encoding.Default);
int maxLength = lines.Max(line => line.Length);
for (int i = 0; i < lines.Length; i++)
{
    if (maxLength > 50)
    {
        lines[i] = lines[i].PadLeft(maxLength);
    }
    else
    {
        lines[i] = lines[i].PadLeft(50);
    }
}
File.WriteAllLines(filePath, lines, Encoding.Default);*/


/*(83) 34 ПРАКТИЧЕСКАЯ РАБОТА   
class Program
{
    static int NOD(int a, int b)
    {
        return b != 0 ? NOD(b, a % b) : a;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(NOD(15, 20));
    }
}*/


/*(84) 35 ПРАКТИЧЕСКАЯ РАБОТА   
public static class Globals
{
    internal static void Main()
    {

        List<int> v = new List<int>(new int[10]);
        List<int> ch = new List<int>();
        List<int> no = new List<int>();

        for (int i = 0; i < 10; i++)
        {

            v[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < 10; i++)
        {

            if (v[i] % 2 == 0)
            {

                ch.Add(v[i]);

            }
            else
            {

                no.Add(v[i]);

            }

        }

        for (int i = 0; i < ch.Count; i++)
        {

            Console.Write(ch[i]);
            Console.Write(" ");

        }

        Console.Write("\n");

        for (int i = 0; i < no.Count; i++)
        {

            Console.Write(no[i]);
            Console.Write(" ");

        }


    }
}*/


/*(85) 36 ПРАКТИЧЕСКАЯ РАБОТА   
double a;
Console.Write("a:");
a = Convert.ToDouble(Console.ReadLine());
double P = 4 * a;
Console.WriteLine("P:" + P);
Console.ReadKey();*/


/*(86) 37 ПРАКТИЧЕСКАЯ РАБОТА  
double x1, x2, y1, y2, P, S;
Console.Write("X1: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y1: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("X2: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y2: ");
y2 = Convert.ToDouble(Console.ReadLine());
P = 2 * (Math.Abs(x1 - x2) + Math.Abs(y1 - y2));
Console.WriteLine("P: " +P);
S = Math.Abs(x1 - x2) * Math.Abs(y1 - y2);
Console.WriteLine("S: " +S);*/


/*(87) 38 ПРАКТИЧЕСКАЯ РАБОТА  
double v1, v2, s, t, result;
Console.Write("V1: ");
v1 = Convert.ToDouble(Console.ReadLine());
Console.Write("V2: ");
v2 = Convert.ToDouble(Console.ReadLine());
Console.Write("S: ");
s = Convert.ToDouble(Console.ReadLine());
Console.Write("T: ");
t = Convert.ToDouble(Console.ReadLine());
result = Math.Abs(s - (v1 * t + v2 * t));

Console.Write("Result: " +result);*/