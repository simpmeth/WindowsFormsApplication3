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
    public partial class Unit : Form
    {
        public String Status = "";
        public int idRead = 0;

        public Unit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Unit.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameUnit.Text == "" || nameUnit2.Text == "")
            {
                label5.Visible = true;
            }
            else
            {
                ShopForm a = (ShopForm)this.Owner;
                a.setNewUnit(Status, idRead, nameUnit.Text, nameUnit2.Text);
                Unit.ActiveForm.Close();
            }
        }


        public void Edit(int id, string name1, string name2)
        {//процедура заполняет поля значениями, при редактировании(вызывается из первой формы)
            idRead = id;
            Status = "read";
            nameUnit.Text = name1;
            nameUnit2.Text = name2;
          
        }
    }
}
