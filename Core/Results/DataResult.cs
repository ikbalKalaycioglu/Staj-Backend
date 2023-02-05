using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Results
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult()
        {
        }

        public DataResult(T contents)
        {
            Contents = contents;
        }

        public T Contents { get; }
    }
}
