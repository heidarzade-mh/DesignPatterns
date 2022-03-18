using System;
using System.Collections.Generic;

namespace Memento.Business
{
    public class Caretaker
    {
        private List<Models.Memento> ledTvList = new List<Models.Memento>();

        public void AddMemento(Models.Memento m)
        {
            ledTvList.Add(m);
            Console.WriteLine("LED TV's snapshots Maintained by CareTaker :" + m.GetDetails());
        }

        public Models.Memento GetMemento(int index)
        {
            return ledTvList[index];
        }
    }
}