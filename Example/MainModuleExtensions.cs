using System;
using System.Threading.Tasks;

namespace Example
{
    public static class MainModuleExtensions
    {
        public static async Task<Guid> Work(this IMainModule mainModule, string name, Guid userId)
        {
            await mainModule.Worker.DoSomethingAsync(userId);
            return Guid.NewGuid();
        }
    }   
}