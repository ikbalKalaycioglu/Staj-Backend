using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IContentRepository
    {
        public List<Content> GetAll();
        public Content Get(string title);
        public List<Content> GetContentsWithCache();
        
    }
}
