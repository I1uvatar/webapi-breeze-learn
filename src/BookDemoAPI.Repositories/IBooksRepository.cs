using System.Linq;
using BookDemoAPI.Entities;
using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;

namespace BookDemoAPI.Repositories
{
    public interface IBooksRepository
    {
        string MetaData { get; }
        SaveResult SaveChanges(JObject saveBundle);

        IQueryable<Book> Books();
        
        IQueryable<Order> Orders();
    }
}
