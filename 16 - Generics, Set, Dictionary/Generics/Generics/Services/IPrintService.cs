using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Services
{
    public interface IPrintService<T>
    {
        public void AddValue(int value);
        public int First();
        public void Print();
    }
}
