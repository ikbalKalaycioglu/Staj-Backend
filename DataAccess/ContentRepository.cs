using Entities;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ContentRepository : IContentRepository
    {
        private readonly IMemoryCache _memoryCache;

        public ContentRepository(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public Content Get(string title)
        {
            Deserialize deserialize = new Deserialize();
            var content = deserialize.GetAll().Contents.Where(d => d.Title == title).FirstOrDefault();
            return content;

        }

        public List<Content> GetAll()
        {
            Deserialize deserialize = new Deserialize();
            return deserialize.GetAll().Contents;
        }

        public List<Content> GetContentsWithCache()
        {
            Deserialize deserialize = new Deserialize();
            List<Content> contentList;
            contentList = _memoryCache.Get<List<Content>>("contents");

            if (contentList is null)
            {
                contentList = deserialize.GetAll().Contents;
                _memoryCache.Set("contents",contentList,TimeSpan.FromMinutes(1));
            }
            return contentList;
        }
    }
}
