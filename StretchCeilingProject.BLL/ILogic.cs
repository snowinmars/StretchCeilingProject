using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace StretchCeilingProject.BLL
{
    [ContractClass(typeof(ContractClassForILogic<>))]
    public interface ILogic<T> : ICRUD<T>
    {
        IEnumerable<T> GetByFilter();
    }

    [ContractClassFor(typeof(ILogic<>))]
    internal abstract class ContractClassForILogic<T> : ILogic<T>
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