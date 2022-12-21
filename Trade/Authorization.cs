using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Trade
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            Program.authorization = this;

        }

        private void Authorization_Shown(object sender, EventArgs e)
        {

        }

        private void LogUpBtn_Click(object sender, EventArgs e)
        {


            DataTable UserTable = SQL.table($@"SELECT Users.id, login, password, email, surname, Users.name, patronymic, 
            Role.id as 'roleid',  Role.name as 'role'
            FROM Users
            Inner Join Role Role on Role.id = Users.role
            where login = '{LoginTextBox.Text}' and password = '{PasswordTextBox.Text}'").Tables[0];
            if (UserTable.Rows.Count >0)
            {

                string json = JsonConvert.SerializeObject(UserTable);
                json = json.Trim('[', ']');
                User user = JsonConvert.DeserializeObject<User>(json);
                MessageBox.Show(
                  $"Добро пожаловать\n{User.Surname} {User.Name[0]}. {User.Patronymic[0]}.\n({User.Role})",
                  "Сообщение");
                Program.MyApplicationContext.Open(new Main());
                PasswordTextBox.Clear();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Невырный Логин или Пароль");
            }

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogUpBtn2_Click(object sender, EventArgs e)
        {
            
        }

        bool PasswordVisibility = true;
        private void PasswordBtn_Click(object sender, EventArgs e)
        {
            if (PasswordVisibility)
            {
                PasswordBtn.Text = "☻";
                PasswordTextBox.UseSystemPasswordChar = false;
                PasswordVisibility = false;
            }
            else
            {
                PasswordBtn.Text = "☺";
                PasswordTextBox.UseSystemPasswordChar = true;
                PasswordVisibility = true;
            }
        }

        private void FormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormPanel.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            TitleLabel.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }


    }
}

public class User
{
    public static int Id;
    public static string Login;
    public static string Password;
    public static string Email;
    public static string Name;
    public static string Surname;
    public static string Patronymic;
    public static int Roleid;
    public static string Role;

 
    public string login
    {
        get { return Login; }
        set { Login = value; }
    }
    public string password
    {
        get { return Password; }
        set { Password = value; }
    }
    public string email
    {
        get { return Email; }
        set { Email = value; }
    }
    public string name
    {
        get { return Name; }
        set { Name = value; }
    }
    public string surname
    {
        get { return Surname; }
        set { Surname = value; }
    }
    public string patronymic
    {
        get { return Patronymic; }
        set { Patronymic = value; }
    }
    public int roleid
    {
        get { return Roleid; }
        set { Roleid = value; }
    }
    public string role
    {
        get { return Role; }
        set { Role = value; }
    }
}