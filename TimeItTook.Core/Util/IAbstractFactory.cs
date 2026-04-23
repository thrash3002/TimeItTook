using System;
using System.Collections.Generic;
using System.Text;

namespace TimeItTook.Core.Util
{
    public interface IAbstractFactory<T>
    {
        T Create();
    }
}
