using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Можно перетаскивать форму мышкой
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем текущую форму
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            String username = username_field.Text;
            String password = password_field.Text;

            Database database = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();


            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`= @us AND `password`=@ps",database.GetConnection());
            command.Parameters.Add("@us", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                //MessageBox.Show("OK");
            show_label.Text = "Succeful";
            else
                //MessageBox.Show("NOT");
            show_label.Text = "not";

        }
    }
}
