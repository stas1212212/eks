using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Маршрутка
{
    private readonly int _сидячихМісць;
    private readonly int _стоячихМісць;
    private readonly List<Пасажир> _пасажири;

    public Маршрутка(int сидячихМісць, int стоячихМісць)
    {
        _сидячихМісць = сидячихМісць;
        _стоячихМісць = стоячихМісць;
        _пасажири = new List<Пасажир>();
    }

    public void ДодатиПасажира(Пасажир пасажир)
    {
        _пасажири.Add(пасажир);
    }

    public void ВийтиПасажира(Пасажир пасажир)
    {
        _пасажири.Remove(пасажир);
    }

    public void Рухатися()
    {
        for (int i = 0; i <= _пасажирів.Count; i++)
        {
            _пасажири[i].Рухатися();
        }
    }
}

using System;

delegate int Delegate(int n);

static int Average(Delegate[] delegates)
{
    int sum = 0;
    int count = delegates.Length;

    foreach (Delegate delegate in delegates)
    {
        sum += delegate (count);
    }

    return sum / count;
}

class Program
{
    static void Main(string[] args)
    {
        // Створюємо масив делегатів
        Delegate[] delegates = new Delegate[10];

        // Поєднуємо делегати з методами, які повертають випадкові значення типу int
        for (int i = 0; i < delegates.Length; i++)
        {
            delegates[i] = delegate (int n)
            {
                return new Random().Next(100);
            };
        }

        // Використовуємо анонімний метод для обчислення середнього арифметичного значень, що повертаються делегатами
        int average = Average(delegates);

        // Друкуємо середнє арифметичне значення
        Console.WriteLine("Середнє арифметичне значення: {0}", average);
    }
}
