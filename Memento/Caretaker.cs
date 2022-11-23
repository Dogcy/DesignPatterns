using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>
    /// 管理者(Caretaker)
    /// </summary>
    class Caretaker
    {
        private Memento memento;
        public Memento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
