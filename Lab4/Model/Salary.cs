using System;

namespace Lab4.Model
{
    public class Salary
    {
        public double Sum { get; }
        private static readonly Random Rand = new Random();
        public Salary() => Sum = Rand.Next(10000);
        public override string ToString() => $"{Sum:c}";
    }
}