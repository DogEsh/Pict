using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    interface IFunction<T, G>
    {
        T Calc(G value);
    }
}
