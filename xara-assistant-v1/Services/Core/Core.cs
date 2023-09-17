using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xara_assistant_v1.Db;
using xara_assistant_v1.Models.Entithies;
using xara_assistant_v1.Models.Helper;
using xara_assistant_v1.Models.ViewModels;
using xara_assistant_v1.Security;

namespace xara_assistant_v1.Services.Core;

public class Core : ICore
{
    public User User { get; set; } = null;
    private readonly MyDb _db;

    public DataMessage LoginUser(LoginUserVm userVm)
    {

        var message = ValidateLoginUserInput(userVm);
        if (message.ErrorId < 0)
            return message;

        var user = _db.Users.FirstOrDefault(x => x.Username == userVm.Username.ToUpper());
        if (user == null)
            return new DataMessage()
            {
                ErrorId = -200,
                Message = "User has been not found!",
            };

        userVm.Password = HashPasswordC.EncodePasswordMd5(userVm.Password);


        if (userVm.Password == user.Password)
        {
            // login is complate
            User = user;

            return new DataMessage()
            {
                SuccessId = 100,
                Message = "done",
            };
        }


        return new DataMessage()
        {
            ErrorId = -500,
            Message = "Somethings wrong",
        };
    }
    public bool IsUserLogin()
    {
        if(User == null) return false;


        return true;
    }
    private DataMessage ValidateLoginUserInput(LoginUserVm userVm)
    {
        if (userVm == null)
            return new DataMessage()
            {
                ErrorId = -100,
                Message = "Invalid Data"
            };
        else if (userVm.Username == null)
            return new DataMessage()
            {
                ErrorId = -110,
                Message = "Invalid Username"
            };
        else if (RegexIsString(userVm.Username) || RegexIsString(userVm.Password))
            return new DataMessage()
            {
                ErrorId = -120,
                Message = "Invalid dataType Username and Password",
            };
        else if (userVm.Password.Length < 3 || userVm.Username.Length < 2)
            return new DataMessage()
            {
                ErrorId = -130,
                Message = "to short",
            };
        return new DataMessage()
        {
            SuccessId = 100,
            Message = "done"
        };
    }
    private bool RegexIsString(string data)
    {
        var reg = new Regex("[0-9]");
        if (!reg.IsMatch(data))
        {
            return false;
        }

        return true;
    }
}
