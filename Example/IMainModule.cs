using System;
using System.Threading.Tasks;

namespace Example
{
    public interface IMainModule
    {
        IWorker Worker { get; }
    }

    public interface IWorker
    {
        Task DoSomethingAsync(Guid userId);
    }
}
