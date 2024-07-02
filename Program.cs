//1.mashq
int sum = 0;
int number = 1;

while (number <= 1000)
{
    if (number % 2 != 0) // toq sonlarni tekshirish
    {
        sum += number;
    }
    number++;
}

Console.WriteLine("1 dan 1000 gacha bo’lgan toq sonlarning yig’indisi: " + sum);

//2.mashq
int[] numbers = { 3, 5, 7, 2, 8, -1, 4, 10, 12 }; // misol array
int max = numbers[0];
int min = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

int product = max * min;
Console.WriteLine("Array ichidagi eng katta va eng kichik qiymatlarning ko'paytmasi: " + product);

//3.mashq
Console.Write("Butun son kiriting: ");
int x = int.Parse(Console.ReadLine());

long factorial = 1;

for (int i = 1; i <= x; i++)
{
    factorial *= i;
}

Console.WriteLine(x + "! ning qiymati: " + factorial);