using Iterator.Abstraction;
using Iterator.Models;

namespace Iterator.Business
{
    public class Iterator : AbstractIterator
    {
        private ConcreteCollection _collection;
        private int _current = 0;
        private const int Step = 1;

        // Constructor
        public Iterator(ConcreteCollection collection)
        {
            this._collection = collection;
        }

        // Gets first item
        public Elempoyee First()
        {
            _current = 0;
            return _collection.GetEmployee(_current);
        }

        // Gets next item
        public Elempoyee Next()
        {
            _current += Step;
            if (!IsCompleted)
            {
                return _collection.GetEmployee(_current);
            }

            return null;
        }

        // Check whether iteration is complete
        public bool IsCompleted => _current >= _collection.Count;
    }
}