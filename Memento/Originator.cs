using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>
    /// 發起人
    /// </summary>
    class Originator
    {
        private string state;
        public string Stage
        {
            get { return this.state; }
            set { this.state = value; }
        }
        public Memento CreateMemento()
        {
            return new Memento(this.state);
        }
        public void SetMemento(Memento memento)
        {
            this.state=memento.State;
        }
        public void Show()
        {
            Console.WriteLine("State = " + this.state);
        }
    }
    // 備份用
    class Memento
    {
        private string state;
        public Memento(string state)
        {
            this.state = state;
        }

        public string State
        {
            get { return this.state;}
        }
    }
}
