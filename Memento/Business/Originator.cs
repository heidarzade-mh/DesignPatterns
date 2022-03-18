using Memento.Models;

namespace Memento.Business
{
    public class Originator
    {
        public LEDTV ledTV;

        public Models.Memento CreateMemento()
        {
            return new Models.Memento(ledTV);
        }

        public void SetMemento(Models.Memento memento)
        {
            ledTV = memento.ledTV;
        }

        public string GetDetails()
        {
            return "Originator [ledTV=" + ledTV.GetDetails() + "]";
        }
    }
}