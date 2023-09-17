using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xara_assistant_v1.Models.ViewModels;

public class CreateUserVm
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string RePassword { get; set; }
}
