using xara_assistant_v1.Models.Entithies;
using xara_assistant_v1.Models.Helper;
using xara_assistant_v1.Models.ViewModels;

namespace xara_assistant_v1.Services.Core
{
    public interface ICore
    {
        User User { get; set; }

        DataMessage LoginUser(LoginUserVm userVm);
        bool IsUserLogin();
    }
}