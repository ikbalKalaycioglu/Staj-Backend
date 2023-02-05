using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IContentService
    {
        public List<Content> GetContent();
        public Content GetContentByTitle(string title);
        public List<Content> GetContentByCategory(string mainCategory, string secondCategory);
    }
}
