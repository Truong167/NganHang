using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGANHANG.DTO
{
    public class TaiKhoanLogin
    {
        private string loginName;
        private string password;
        private string role;

        public TaiKhoanLogin(string loginName, string password, string role)
        {
            this.loginName = loginName;
            this.password = password;
            this.role = role;
        }

        public string LoginName { get => loginName; set => loginName = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
