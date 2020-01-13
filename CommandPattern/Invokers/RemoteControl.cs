using System.Text;
using CommandPattern.Commands;

namespace CommandPattern.Invokers
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            NoCommand noCommand = new NoCommand();
            for (int i = 7 - 1; i >= 0; i--)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonPushed(int slot)
        {
            
            _onCommands[slot].Execute();
        }


        public void OffButtonPushed(int slot)
        {
            _offCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append($"[slot {i}] {_onCommands[i].GetType().Name} | {_offCommands[i].GetType().Name}\n");
            }

            return stringBuilder.ToString();
        }
    }
}
