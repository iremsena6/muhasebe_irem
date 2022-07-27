using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace muhasebe_irem
{
    public partial class vt : Form
    {
        public vt()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=LENOVO-IREMS\\SQLEXPRESS01;Initial Catalog = muhasebe; Integrated Security = True";
        SqlConnection connect = new SqlConnection(constring);
    }
}
