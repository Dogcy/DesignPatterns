using System;

namespace Memento
{
    class Program
    {
        // 備忘錄模式(Memento)
        // 備份上一次資料
        static void Main(string[] args)
        {
           
            Originator o = new Originator();
            o.Stage = "On"; 
            o.Show();

            Caretaker c = new Caretaker(); // 封裝 保存狀態
            c.Memento = o.CreateMemento(); // 將現有資料備份
            o.Stage = "off";
            o.Show();
            o.SetMemento(c.Memento); // 還原上一次資料
            o.Show();

            Console.Read();
          
        }
    }
}
