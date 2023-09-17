using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xara_assistant_v1.Models.Helper;

public struct DataMessage
{
    public int ErrorId { get; set; }
    public int SuccessId { get; set; }
    public string Message { get; set; }
}
