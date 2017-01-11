using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace StretchCeilingProject.DAL
{
    [ContractClass(typeof(ContractClassForIDao<>))]
    public interface IDao<T> : ICRUD<T>
    {
        IEnumerable<T> GetByFilter();
    }

    [ContractClassFor(typeof(IDao<>))]
    internal abstract class ContractClassForIDao<T> : IDao<T>
    {
        public void Add(T item)
        {
        }

        public T Get(Guid id)
        {
            return default(T);
        }

        public IEnumerable<T> GetByFilter()
        {
            Contract.Ensures(Contract.Result<IEnumerable<T>>() != null, "Item is null");
            return new T[0];
        }

        public void Remove(Guid id)
        {
        }

        public void Update(T item)
        {
        }
    }
}