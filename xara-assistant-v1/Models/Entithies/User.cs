using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xara_assistant_v1.Models.Entithies;

public class User
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Username { get; set; }
    [DataType(DataType.Password)]
    public string Password { get; set; }
    public bool IsSuperAdmin { get; set; } = false;
}
