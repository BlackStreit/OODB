using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var db = new DataBase();
            db.dbConnect();
            db.addUser(new User("Name", "Password", 123));
            var list = db.GetUsers();
            dataGridView1.DataSource = list;
            db.dbClose();
        }
    }
}
