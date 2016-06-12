using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApplication3;

namespace shop
{
    public partial class AddGoods : Form
    {
        public AddGoods()
        {//подглючаем базу для составления списка продуктов
            InitializeComponent();

            /*var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT Код, Название FROM dbo.goods");
            comboGoods.DataSource = dataReaderBySql.GetDataSource();

            dataReaderBySql.CloseDbConnection();

            comboGoods.DisplayMember = "Название";
            comboGoods.ValueMember = "Код";*/
        }

        private void button2_Click(object sender, EventArgs e)
        {//закрываем форму
            Close();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {//загружаем список продуктов по первому клику на бокс

            if (comboGoods.DataSource == null) { 
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT Код,Название,Цена FROM dbo.goods");
            comboGoods.DataSource = dataReaderBySql.GetDataSource();
            
            dataReaderBySql.CloseDbConnection();

            comboGoods.DisplayMember = "Название";
            comboGoods.ValueMember = "Код";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//передаем ид выбраного товара для занесенее его в накладную

            var selectedItem = comboGoods.SelectedItem as DataRowView;
            if (selectedItem==null) return;
            var goodId= Convert.ToInt32(selectedItem.Row["Код"].ToString());

            if (comboGoods.Text == "" || textKol.Text == "")
            {
                label5.Visible = true;
            }
            else
            {
                Dok Dok = (Dok)this.Owner;
                
                
                Dok.setNewAddGoods((int)comboGoods.SelectedValue, Convert.ToInt32(textKol.Text));
                Close();
            }
        }

        private void comboGoods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
