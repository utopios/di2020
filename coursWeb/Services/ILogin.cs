using System;
namespace coursWeb.Services
{
    public interface ILogin
    {
        void SaveAccessToSession(string email, string password);
        bool IsLogin();
        string getNameFromSession();
    }
}
