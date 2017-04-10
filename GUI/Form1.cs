using QLSVuserLinq.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVuserLinq
{
    
    public partial class Form1 : Form
    {
        SVBLL svBLL = new SVBLL();
        LopBLL lopBLL = new LopBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = svBLL.LayTatCa();
        }
    }
}
