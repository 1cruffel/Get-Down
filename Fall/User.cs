using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall
{
    public class User
    {
        string currUser;
        public void UserName(string username)
        {
            currUser = username;
            MessageBox.Show(username);
        }
        public string GetUser()
        {
            return currUser;
        }

    }
}
