using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using BookDemoAPI.Entities;
using BookDemoAPI.Repositories;
using Breeze.ContextProvider;
using Breeze.WebApi2;
using Newtonsoft.Json.Linq;

namespace BookDemoAPI.WebAPI.Controllers
{
    [BreezeController]
    public class BooksController : ApiController
    {
        private readonly IBooksRepository _repo;

        public BooksController(IBooksRepository repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        public string Metadata()
        {
            return _repo.MetaData;
        }

        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _repo.SaveChanges(saveBundle);
        }

        [HttpGet]
        public IQueryable<Book> Books()
        {
            return _repo.Books();
        }

        [HttpGet]
        public IQueryable<Order> Orders()
        {
            return _repo.Orders();
        }

    }
}
