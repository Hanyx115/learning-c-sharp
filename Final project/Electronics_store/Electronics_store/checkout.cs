using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronics_store
{
    public partial class checkout : Form
    {
        public checkout()
        {
            InitializeComponent();
        }

        private void checkout_Load(object sender, EventArgs e)
        {
            //hn7ot ezay total hena


        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //visa feha details

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
            Cash cash = new Cash();
            cash.Show(); ;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            visa V=new visa();
            V.Show(); 
        }
    }
}
