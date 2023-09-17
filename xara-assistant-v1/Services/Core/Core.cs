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
    private readonly MyDb _db = new MyDb() ;

    public DataMessage CreateUser( CreateUserVm userVm)
    {
        if(IsUsernameExist(userVm.Username.ToUpper() ))
        {
            return new DataMessage()
            {
                ErrorId = -150,
                Message = "Username is Exist ",
            };
        }

        var message = ValidateCreateUser(userVm);
        if (message.ErrorId < 0)
            return message;

        // time to create user
        AddUser(new User()
        {
            Username = userVm.Username.ToUpper(),
            Password = HashPasswordC.EncodePasswordMd5(userVm.Password),
            UserId = CreateRandomNumberId.Create(),
        });


        return new DataMessage()
        {
            SuccessId = 100,
            Message = "Done",
        };
    }
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
    private void AddUser(User user)
    {
        _db.Users.Add(user);
        Save();
    }
    private void Save()
    {
        _db.SaveChanges();
    }
    private DataMessage ValidateCreateUser( CreateUserVm userVm)
    {
        if(userVm == null)
        {
            return new DataMessage()
            {
                ErrorId = -100,
                Message = "invalid data",
            };
        }else if(userVm.Username.Length < 2 || userVm.Username.Length > 25 )
        {
            return new DataMessage()
            {
                ErrorId = -110,
                Message = "Length is not correct",
            };
        }else if(RegexIsString(userVm.Username))
        {
            return new DataMessage()
            {
                ErrorId = -140,
                Message = "data type is not correct [username]",
            };
        }else if(userVm.Password.Length < 5 ||  userVm.Password.Length > 15)
        {
            return new DataMessage()
            {
                ErrorId = -140,
                Message = "Password length",
            };
        }else if(userVm.Password != userVm.RePassword)
        {
            return new DataMessage()
            {
                ErrorId = -200,
                Message = "Password and RePassword",
            };
        }



        return new DataMessage()
        {
            SuccessId = 100,
            Message = "done",
        };
    }
    private bool IsUsernameExist( string username)
    {
        return _db.Users.Any(x => x.Username == username.ToUpper() );
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
