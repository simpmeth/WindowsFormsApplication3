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
    public partial class Goods : Form
    {
     public String Status = "";
     public int idRead = 0;

        public Goods()
        {
            InitializeComponent();
            this.unitTableAdapter.Fill(this.dbDataSet.unit);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Goods.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || har.Text == "" || comboUnit.Text == "" || price.Text == "")
            {
                label5.Visible = true;
            }
            else
            {
                ShopForm shop = (ShopForm)this.Owner;
                int kodEd = Convert.ToInt32(comboUnit.SelectedValue.ToString());
                shop.setNewGoods(Status, idRead, kodEd, name.Text, har.Text, comboUnit.Text, price.Text);
                Goods.ActiveForm.Close();
            }
        }

        private void unit_Click(object sender, EventArgs e)
        {
            comboUnit.DataSource = dbDataSet.unit;
            comboUnit.DisplayMember = "Сокращение";
            comboUnit.ValueMember = "Код";
        }

         public void Edit(int id,string name1,string har1,string comboUnit1,string price1)
        {//процедура заполняет поля значениями, при редактировании(вызывается из первой формы)
            idRead = id;
             Status = "read";
            name.Text=name1;
            har.Text=har1;
            comboUnit.Text=comboUnit1;
            price.Text = price1;
        }

         private void price_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (Char.IsDigit(e.KeyChar))
             {
             }

             else
             {
                 e.Handled = true;
             }
         }

         private void label5_Click(object sender, EventArgs e)
         {

         }
    }
}
