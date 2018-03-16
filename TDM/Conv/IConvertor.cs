using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace TDM.Conv
{
    interface IConvertor
    {
        string Convert(string src, string res);
    }
}
