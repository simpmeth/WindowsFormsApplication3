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
    public partial class User : Form
    {
        public String Status = "";
        public int idRead = 0;

        public User()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || family.Text == "" || otch.Text == "" || pas.Text == "")
            {
                label7.Visible = true;
            }
            else
            {
                ShopForm shop = (ShopForm)this.Owner;
                shop.setNewUser(Status, idRead, name.Text, family.Text, otch.Text, pas.Text, tel.Text, adres.Text);
                User.ActiveForm.Close();
            }
        }
        public void Edit(int id, string name1, string fam1, string otch1, string pas1, string tel1, string adr1)
        {//процедура заполняет поля значениями, при редактировании(вызывается из первой формы)
            idRead = id;
            Status = "read";
            name.Text = name1;
            family.Text = fam1;
            otch.Text = otch1;
            pas.Text = pas1;
            tel.Text = tel1;
            adres.Text = adr1;
        }
    }
}
