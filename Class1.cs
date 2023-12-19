using System;

delegate int Delegate(int n);

static int Average(IEnumerable<Delegate> delegates)
{
    int sum = 0;
    int count = 0;

    foreach (Delegate delegate in delegates)
    {
        sum += delegate (count);
        count++;
    }

    return sum / count;
}

class Program
{
    static void Main(string[] args)
    {
        // Створюємо список делегатів
        List<Delegate> delegates = new List<Delegate>();

        // Поєднуємо делегати з методами, які повертають випадкові значення типу int
        for (int i = 0; i < 10; i++)
        {
            delegates.Add(delegate (int n)
            {
                return new Random().Next(100);
            });
        }

        // Використовуємо анонімний метод для обчислення середнього арифметичного значень, що повертаються делегатами
        int average = Average(delegates);

        // Друкуємо середнє арифметичне значення
        Console.WriteLine("Середнє арифметичне значення: {0}", average);
    }
}
