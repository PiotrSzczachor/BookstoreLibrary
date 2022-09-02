using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreLibrary.Entities;
using BookstoreLibrary.GUI;
using System.Windows.Forms;

namespace BookstoreLibrary.Logic
{
    public class LogInLogic
    {
        public void logIn(string username, string password, LoginForm form)
        {
            SignUpLogic signUpLogic = new SignUpLogic();
            Encoder encoder = new Encoder();
            bool isEmail = signUpLogic.checkIfEmailIsValid(username);
            using (var db = new BookstoreLibContext())
            {
                User user;
                if (isEmail)
                {
                    user = db.Users.Where(u => u.Email == username).FirstOrDefault();
                } else
                {
                    user = db.Users.Where(u => u.Username == username).FirstOrDefault();
                }
                if (user == null || encoder.encodePassword(password) != user.Password)
                {
                    MessageBox.Show("Invalid login or password",
                                    "Login failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                } else
                {
                    if (user != null)
                    {
                        form.Hide();
                        if (user.Role.IsAdmin)
                        {
                            new AdminPanelForm(user).ShowDialog();
                        }
                        else
                        {
                            if (user.Role.IsUser)
                            {
                                new UserPanelForm(user).ShowDialog();
                            }
                            else
                            {
                                new SellerPanelForm(user).ShowDialog();
                            }
                        }
                        form.Close();
                    }
                        
                }
            }
                
        }
    }
}

