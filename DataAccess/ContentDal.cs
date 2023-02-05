using Entities;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class ContentDal : ContentRepository, IContentDal
    {
        public ContentDal(IMemoryCache memoryCache) : base(memoryCache)
        {
        }
    }
}
