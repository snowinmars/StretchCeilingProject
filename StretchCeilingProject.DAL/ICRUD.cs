using System;

namespace StretchCeilingProject.DAL
{
    public interface ICRUD<T>
    {
        void Add(T item);

        T Get(Guid id);

        void Remove(Guid id);

        void Update(T item);
    }
}