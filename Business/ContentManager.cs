using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public List<Content> GetContent()
        {
            return _contentDal.GetContentsWithCache();
            
        }

        public List<Content> GetContentByCategory(string mainCategory, string secondCategory)
        {
            string category = "/"+mainCategory+"/"+secondCategory;
            List<Content> contents = _contentDal.GetContentsWithCache();
            List<Content> contentList = new List<Content>();

            foreach (var content in contents)
            {
                foreach (var categoryPath in content.Category)
                {
                    if (categoryPath == category)
                    {
                        contentList.Add(content);
                    }
                }
            }
            return contentList;
        }

        public Content GetContentByTitle(string title)
        {
            return _contentDal.GetContentsWithCache().Where(x => x.Title == title).FirstOrDefault();
        }
    }
}
