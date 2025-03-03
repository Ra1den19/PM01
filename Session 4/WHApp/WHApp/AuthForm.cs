using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace WHApp
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }


        private async void AuthLoginButton_Click(object sender, EventArgs e)
        {
            var requestData = new
            {
                employeeID = 0,
                firstname = "string",
                lastName = "string",
                login = textLogin.Text,
                password = textPassword.Text,
                email = "string",
                role = "string"
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.PostAsJsonAsync("https://localhost:7033/api/auth/login", requestData);

                    string login = requestData.login;
                    string role = requestData.role;
                    if (login == "Admin")
                    {
                        role = "Администратор";
                        MessageBox.Show("Добро пожаловать, Администратор!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textLogin.Clear();
                        textPassword.Clear();
                        AdminForm af = new AdminForm();
                        af.ShowDialog();
                    }
                    else if (login == "Clad")
                    {
                        role = "Кладовщик";
                        MessageBox.Show("Добро пожаловать, Кладовщик!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textLogin.Clear();
                        textPassword.Clear();
                        CladForm cf = new CladForm();
                        cf.ShowDialog();
                    }
                    else if (login == "Manager")
                    {
                        role = "Менеджер по продажам";
                        MessageBox.Show("Добро пожаловать, Менеджер по продажам!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textLogin.Clear();
                        textPassword.Clear();
                        ManagerForm mf = new ManagerForm();
                        mf.ShowDialog();
                    }
                    else if (login == "Buhgalter")
                    {
                        role = "Бухгалтер";
                        MessageBox.Show("Добро пожаловать, Бухгалтер!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textLogin.Clear();
                        textPassword.Clear();
                        BuhgalterForm bf = new BuhgalterForm();
                        bf.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка сети: " + ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textLogin.Clear();
                    textPassword.Clear();
                }
            }
        }

        private async void AuthEmailButton_Click(object sender, EventArgs e)
        {
            var requestData = new
            {
                employeeID = 0,
                firstname = "string",
                lastName = "string",
                login = "string",
                password = textPass.Text,
                email = textEmail.Text,
                role = "string"
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.PostAsJsonAsync("https://localhost:7033/api/auth/loginByEmail", requestData);

                    string email = requestData.email;
                    string role = requestData.role;

                    if (response.IsSuccessStatusCode)
                    {


                        
                        if (email == "admin@mail.ru")
                        {
                            role = "Администратор";
                            MessageBox.Show("Добро пожаловать, Администратор!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textEmail.Clear();
                            textPass.Clear();
                            AdminForm af = new AdminForm();
                            af.ShowDialog();
                        }
                        else if (email == "clad@mail.ru")
                        {
                            role = "Кладовщик";
                            MessageBox.Show("Добро пожаловать, Кладовщик!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textEmail.Clear();
                            textPass.Clear();
                        }
                        else if (email == "manager@mail.ru")
                        {
                            role = "Менеджер по продажам";
                            MessageBox.Show("Добро пожаловать, Менеджер по продажам!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textEmail.Clear();
                            textPass.Clear();
                        }
                        else if (email == "buhgalter@mail.ru")
                        {
                            role = "Бухгалтер";
                            MessageBox.Show("Добро пожаловать, Бухгалтер!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textEmail.Clear();
                            textPass.Clear();
                        }
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Ошибка входа: " + error, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textEmail.Clear();
                        textPass.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка сети: " + ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textEmail.Clear();
                    textPass.Clear();
                }
            }
        }

        private void toggleSwitchPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSwitchPassword.Checked == true)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else if(toggleSwitchPassword.Checked == false) 
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void toggleSwitchPass_CheckedChanged(object sender, EventArgs e)
        {
            if(toggleSwitchPass.Checked == true)
            {
                textPass.UseSystemPasswordChar = false;
            }
            else if(toggleSwitchPass.Checked == false)
            {
                textPass.UseSystemPasswordChar = true;
            }
        }
    }
}
