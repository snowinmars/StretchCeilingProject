﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StretchCeilingProject.BLL
{
    public interface ICRUD<T>
    {
        void Add(T item);
        T Get(Guid id);
        void Update(T item);
        void Remove(Guid id);
    }
}
