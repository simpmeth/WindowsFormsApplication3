using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop
{
    public partial class AddGoods : Form
    {
        public AddGoods()
        {//подглючаем базу для составления списка продуктов
            InitializeComponent();

            this.goodsTableAdapter.Fill(this.dbDataSet.goods);
        }

        private void button2_Click(object sender, EventArgs e)
        {//закрываем форму
            AddGoods.ActiveForm.Close();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {//загружаем список продуктов по первому клику на бокс
            comboGoods.DataSource = dbDataSet.goods;
            comboGoods.DisplayMember = "Название";
            comboGoods.ValueMember = "Код";
        }

        private void button1_Click(object sender, EventArgs e)
        {//передаем ид выбраного товара для занесенее его в накладную
            if (comboGoods.Text == "" || textKol.Text == "")
            {
                label5.Visible = true;
            }
            else
            {
                Dok Dok = (Dok)this.Owner;
                Dok.setNewAddGoods(Convert.ToInt32(comboGoods.SelectedValue.ToString()) - 1, Convert.ToInt32(textKol.Text.ToString()));
                AddGoods.ActiveForm.Close();
            }
        }

        private void textKol_TextChanged(object sender, EventArgs e)
        {

        }

        private void textKol_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboGoods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
