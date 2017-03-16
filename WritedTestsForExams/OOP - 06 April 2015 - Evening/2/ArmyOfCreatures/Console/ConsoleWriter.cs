namespace ArmyOfCreatures.Console
{
    using System;

    using ArmyOfCreatures.Logic;

    public class ConsoleLogger : ILogger
    {
        public virtual void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
