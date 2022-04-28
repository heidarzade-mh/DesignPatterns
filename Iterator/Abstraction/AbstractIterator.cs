using Iterator.Models;

namespace Iterator.Abstraction
{
    public interface AbstractIterator
    {
        Elempoyee First();
        Elempoyee Next();
        bool IsCompleted { get; }
    }
}