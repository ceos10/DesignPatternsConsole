using System;

namespace DesignPatternsConsole.Models.Mediator
{
    public class Participant
    {
        private readonly string _name;

        public Participant(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public Chatroom Chatroom { set; get; }

        public void Send(string to, string message)
        {
            Chatroom.Send(_name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
    }
}
