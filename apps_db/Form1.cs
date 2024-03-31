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


namespace apps_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conString = "server=localhost;user id=root;database=db_csharp;password=;";
            MySqlConnection con = new MySqlConnection(conString);
                       
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    this.label1.BackColor = Color.Green;
                    this.label1.Text = "Success";
                }
                else
                {
                    this.label1.BackColor = Color.Red;
                    this.label1.Text = "Failed";
                }
         
            
          //  MySql.Data.MySqlClient.MySqlConnection con1 = new MySql.Data.MySqlClient.MySqlConnection(conString);

        }
    }
}
