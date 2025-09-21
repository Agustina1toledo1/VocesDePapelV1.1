using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Servicios
{
    internal interface IContraseniaHasher
    {
        string Hash(string contraseniaPlana);
        bool Verify(string contraseniaPlana, string almacenaHash);
    }
}
