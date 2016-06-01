using System;
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

            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT Код, Название, Сокращение FROM dbo.unit");
            comboUnit.DataSource = dataReaderBySql.GetDataSource();

            dataReaderBySql.CloseDbConnection();

            comboUnit.DisplayMember = "Сокращение";
            comboUnit.ValueMember = "Код";
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
                shop.setNewGoods(Status, idRead, Convert.ToInt32(comboUnit.SelectedValue.ToString()), name.Text, har.Text, comboUnit.Text, price.Text, comboUnit.SelectedIndex.ToString());
                Goods.ActiveForm.Close();
            }
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

        private void Goods_Load(object sender, EventArgs e)
        {

        }
    }
}
