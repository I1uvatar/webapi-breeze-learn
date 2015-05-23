using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookDemoAPI.Entities;
using BookDemoAPI.WebAPI.Models;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using Newtonsoft.Json.Linq;

namespace BookDemoAPI.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private readonly EFContextProvider<BooksDemoContext> _contextProvider = new EFContextProvider<BooksDemoContext>();


        public string MetaData
        {
            get { return _contextProvider.Metadata(); }
            
        }
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _contextProvider.SaveChanges(saveBundle);
        }

        public IQueryable<Book> Books()
        {
            return _contextProvider.Context.Books;
        }

        public IQueryable<Order> Orders()
        {
            return _contextProvider.Context.Orders;
        }
    }
}
