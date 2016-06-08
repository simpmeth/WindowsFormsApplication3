using System;
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
            AddGoods.ActiveForm.Close();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {//загружаем список продуктов по первому клику на бокс
            
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT Код, Название FROM dbo.goods");
            comboGoods.DataSource = dataReaderBySql.GetDataSource();
            
            dataReaderBySql.CloseDbConnection();

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
                Dok.SetNewAddGoods(Convert.ToInt32(comboGoods.SelectedIndex), Convert.ToInt32(textKol.Text));
                AddGoods.ActiveForm.Close();
            }
        }

       
    }
}
