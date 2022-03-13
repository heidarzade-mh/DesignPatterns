using Iterator.Models;

namespace Iterator.Abstraction
{
    interface AbstractIterator
    {
        Elempoyee First();
        Elempoyee Next();
        bool IsCompleted { get; }
    }
}