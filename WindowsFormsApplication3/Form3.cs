using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3;

namespace shop
{
    public partial class Client : Form
    {
        public String Status = "";
        public int idRead = 0;

        public Client()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || tel.Text == "" || adres.Text == "")
            {
                label5.Visible = true;
            }
            else
            {
                ShopForm shop = (ShopForm)this.Owner;
                shop.setNewClient(Status, idRead, name.Text, tel.Text, adres.Text);
                Client.ActiveForm.Close();
            }
        }

        public void Edit(int id, string name1, string tel1, string adres1)
        {//процедура заполняет поля значениями, при редактировании(вызывается из первой формы)
            idRead = id;
            Status = "read";
            name.Text = name1;
            tel.Text = tel1;
            adres.Text = adres1;
          
        }
    }
}
