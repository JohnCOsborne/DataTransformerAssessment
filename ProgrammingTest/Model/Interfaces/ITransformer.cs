using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTestIDNetwork.Model.Interfaces
{
    interface ITransformer
    {
        IEnumerable<object> Transform(string dataToTransform);
    }
}
