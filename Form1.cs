using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Interfaces;

namespace kursovaya
{
    public partial class AuthForm : MetroFramework.Forms.MetroForm
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


    private void button2_Click(object sender, EventArgs e)
        {
            if (Theme == MetroThemeStyle.Light)
            {
                Theme = MetroThemeStyle.Dark;
                button1.Theme = MetroThemeStyle.Dark;
                button2.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                Theme = MetroThemeStyle.Light;
                button1.Theme = MetroThemeStyle.Light;
                button2.Theme = MetroThemeStyle.Light;
            }
            
        }
    }
}
