using System.Collections.Generic;
using rev101.Models.entites;

namespace rev101.Helpers
{
    public interface IMyArrayList<T> where T:IHasId
    {
        void Insert(T element);
        void Delete(int id );
    }
}