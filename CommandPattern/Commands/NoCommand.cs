using System;


namespace CommandPattern.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No command Execute");
        }

        public void Undo()
        {
            Console.WriteLine("No command Undo");
        }
    }
}
