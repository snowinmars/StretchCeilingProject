using System;
using System.Diagnostics.Contracts;

namespace StretchCeilingProject.BLL
{
    [ContractClass(typeof(ContractClassForICRUD<>))]
    public interface ICRUD<T>
    {
        void Add(T item);

        T Get(Guid id);

        void Remove(Guid id);

        void Update(T item);
    }

    [ContractClassFor(typeof(ICRUD<>))]
    internal abstract class ContractClassForICRUD<T> : ICRUD<T>
    {
        public void Add(T item)
        {
            Contract.Requires<ArgumentNullException>(item != null, "Item is null");
        }

        public T Get(Guid id)
        {
            Contract.Requires<ArgumentException>(id != default(Guid), "Guid is default");
            Contract.Ensures(Contract.Result<T>() != null, "Item is null");
            return default(T);
        }

        public void Remove(Guid id)
        {
            Contract.Requires<ArgumentException>(id != default(Guid), "Guid is default");
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            Contract.Requires<ArgumentNullException>(item != null, "Item is null");
            throw new NotImplementedException();
        }
    }
}