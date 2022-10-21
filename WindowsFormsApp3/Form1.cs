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

namespace WindowsFormsApp3
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        class db
        {
            MySqlConnection connectiON = new MySqlConnection("server=caseum.ru;port=33333;user=st_4_20_18;database=asd;password=96446255;");
            public void OpenConn()
            {
                if(connectiON.State == System.Data.ConnectionState.Closed)
                    connectiON.Open();
            }
            public void ClosedConn()
            {
                if(connectiON.State == System.Data.ConnectionState.Open)
                    connectiON.Close();
            }
            public MySqlConnection CheckConnection()
            {
                return connectiON;
                
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
