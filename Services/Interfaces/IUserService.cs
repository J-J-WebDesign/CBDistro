using CBDistro.Models.Domain;
using System.Threading.Tasks;
using CBDistro.Models.Requests.Users;
using System;

namespace CBDistro.Services
{
    public interface IUserService 
    {
        int Create(UserAddRequest model);
        Task<bool> LogInAsync(string email, string password);
        Task<UserAuth>  Authenticate(string email, string password);
        Task<bool> LogInTest(string email, string password, int id, string[] roles = null);
        UserAuth GetAuth(string email);
        void ConfirmAcct(Guid token);
        int ForgotPassword(string email);
        int ResetPassword(UpdatePassword model);
        Task<bool> LogOutUser();
        bool GetByEmailToVerify(string email);
        int ResendConfirm(string email);
        Guid GetToken(int id);
   
    }
}