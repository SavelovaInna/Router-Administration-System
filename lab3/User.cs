using System.Text;
using System.Security.Cryptography;

namespace lab3
{
    public static class User
    {
        public static void AddUser(string login, string password)
        {
            Properties.Settings.Default.login = login;
            SHA256 sha = new SHA256Managed();
            Properties.Settings.Default.hash = Encoding.Unicode.GetString(
                sha.ComputeHash(Encoding.Unicode.GetBytes(password)));
            Properties.Settings.Default.Save();
        }
        public static bool IsExistUser()
        {
            return !Properties.Settings.Default.login.Equals("") &&
                !Properties.Settings.Default.hash.Equals("");
        }
        public static bool Authentificate(string login, string password)
        {
            SHA256 sha = new SHA256Managed();
            string hash  = Encoding.Unicode.GetString(
                sha.ComputeHash(Encoding.Unicode.GetBytes(password)));
            return Properties.Settings.Default.login.Equals(login) &&
                Properties.Settings.Default.hash.Equals(hash);              
        }
        public static void Reset()
        {
            Properties.Settings.Default.login = "";
            Properties.Settings.Default.hash = "";
            Properties.Settings.Default.Save();
        }
    }
}
