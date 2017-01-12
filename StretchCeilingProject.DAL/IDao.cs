using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace StretchCeilingProject.DAL
{
    [ContractClass(typeof(ContractClassForIDao<,>))]
    public interface IDao<TItem, TFilter> : ICRUD<TItem>
    {
        IEnumerable<TItem> GetByFilter(TFilter filter);
    }

    [ContractClassFor(typeof(IDao<,>))]
    internal abstract class ContractClassForIDao<TItem, TFilter> : IDao<TItem, TFilter>
    {
        public void Add(TItem item)
        {
        }

        public TItem Get(Guid id)
        {
            return default(TItem);
        }

        public void Remove(Guid id)
        {
        }

        public void Update(TItem item)
        {
        }

        public IEnumerable<TItem> GetByFilter(TFilter filter)
        {
            Contract.Requires<ArgumentNullException>(filter != null, "Filter is null");
            Contract.Ensures(Contract.Result<IEnumerable<TItem>>() != null, "Item is null");
            return new TItem[0];
        }
    }
}