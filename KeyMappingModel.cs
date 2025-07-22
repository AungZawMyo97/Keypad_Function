using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPadConsole_CodeTest;

public static class Keypad
{
    public static readonly Dictionary<char, string> Mappings = new()
    {
        { '2', "ABC"  },
        { '3', "DEF"  },
        { '4', "GHI"  },
        { '5', "JKL"  },
        { '6', "MNO"  },
        { '7', "PQRS" },
        { '8', "TUV"  },
        { '9', "WXYZ" },
        { '0', " "    }
    };
}
