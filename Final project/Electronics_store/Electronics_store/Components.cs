using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronics_store
{
    public partial class Components : Form
    {
        List<ASMComponent> res = new List<ASMComponent>();
        List<ASMComponent> trans = new List<ASMComponent>();
        
        // ASMComponent[]r=new ASMComponent[5]; size problem (static)

        public Components()
        {
            InitializeComponent();
            LoadDataFromDatabase();
            FillComboBox();
        }
        public void LoadDataFromDatabase()
        {
         SqlConnection con = new SqlConnection();
         con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mohamed\\OneDrive\\Desktop\\Electronics_store\\Electronics_store\\asm.mdf;Integrated Security=True;Connect Timeout=30";
         con.Open();
         SqlCommand command = new SqlCommand("SELECT Id,Name,Price,Quantity  FROM Resistors;",con);

          SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    String name = reader.GetString(1);
                    double price = reader.GetDouble(2);
                    int qty = reader.GetInt32(3);

                    ASMComponent c = new ASMComponent(id,name,price,qty);
                    res.Add(c);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();

            command = new SqlCommand("SELECT Id,Name,Price,Quantity  FROM Transistors;", con);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    String name = reader.GetString(1);
                    double price = reader.GetDouble(2);
                    int qty = reader.GetInt32(3);

                    ASMComponent c = new ASMComponent(id, name, price, qty);
                    trans.Add(c);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }


            reader.Close();

        }
        public void FillComboBox()
        {
            foreach (ASMComponent c in res)
            {

                comboResistors.Items.Add(c);
            }
            foreach (ASMComponent c in trans)
            {

                comboTransistors.Items.Add(c);
            }
          
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Components_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asmDataSet1.Transistors' table. You can move, or remove it, as needed.
            this.transistorsTableAdapter.Fill(this.asmDataSet1.Transistors);
            // TODO: This line of code loads data into the 'asmDataSet.Resistors' table. You can move, or remove it, as needed.
            this.resistorsTableAdapter.Fill(this.asmDataSet.Resistors);

        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (comboResistors.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose Res");
                return;
            }
            if (comboTransistors.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose Tra");
                return;
            }
            


            ASMComponent res =comboResistors.SelectedItem as ASMComponent;
       
            int quantityres= (int)numQuantityRes.Value;

            double total = quantityres * res.Price;


              ASMComponent tra = comboTransistors.SelectedItem as ASMComponent;
            int quantitytra = (int)numQuantityTrans.Value;
            total += quantitytra * tra.Price;

            MessageBox.Show("Total is " + total);
            checkout c = new checkout();
            c.Show();
            







        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
