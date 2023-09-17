using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xara_assistant_v1.Models.Helper;

public class CreateRandomNumberId
{
    public static int Create()
    {
        var rnd = new Random();
        return rnd.Next(100 , 999 );
    }
}
