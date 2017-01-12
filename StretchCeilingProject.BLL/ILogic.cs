using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace StretchCeilingProject.BLL
{
    [ContractClass(typeof(ContractClassForILogic<,>))]
    public interface ILogic<TItem, TFilter> : ICRUD<TItem>
    {
        IEnumerable<TItem> GetByFilter(TFilter filter);
    }

    [ContractClassFor(typeof(ILogic<,>))]
    internal abstract class ContractClassForILogic<TItem, TFilter> : ILogic<TItem, TFilter>
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