using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApplication3;


namespace shop
{
    public partial class Dok : Form
    {
        public Dok()
        {
            InitializeComponent();
        }

        private void Dok_Load(object sender, EventArgs e)
        {
          

            //labelId.Text = Convert.ToString(dbDataSet.dok.Count+1);
            //int i=dbDataSet.dok.Count;
            //labelKod.Text=Convert.ToString(dbDataSet.dok.Count+1);
           // labelKod.Text = Convert.ToString(Convert.ToInt32(dbDataSet.dok.Rows[dbDataSet.dok.Count - 1]["Ид"].ToString()) + 1);
           
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            AddGoods newForm = new AddGoods();
            newForm.Owner = this;
            newForm.ShowDialog();

        }

        private void ReloadClientData()
        {
            var selectedItem = comboClient.SelectedItem as DataRowView;
            labelAdresClient.Text = selectedItem.Row["Адрес"].ToString();
            labelKodClient.Text = selectedItem.Row["Код"].ToString();
        }

        private void ReloadUserData()
        {
            var selectedItem = comboUser.SelectedItem as DataRowView;
            labelAdresUser.Text = selectedItem.Row["Адрес"].ToString();
            
        }


        private void comboClient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ReloadClientData();
        }

        private void comboUser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // labelAdresUser.Text = dbDataSet.user.Rows[Convert.ToInt32(comboUser.SelectedValue.ToString()) - 1]["Адрес"].ToString();
            ReloadUserData();
        }

        private void comboUser_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }

        private void comboClient_Click(object sender, EventArgs e)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT Код, Наименование, Телефон, Адрес FROM dbo.client");
            comboClient.DataSource = dataReaderBySql.GetDataSource();

            comboClient.DisplayMember = "Наименование";
            comboClient.ValueMember = "Код";

            dataReaderBySql.CloseDbConnection();

            ReloadClientData();
        }

        private void comboUser_Click(object sender, EventArgs e)
        {
            /*comboUser.DataSource = dbDataSet.user;
            comboUser.DisplayMember = "Фамилия";
            comboUser.ValueMember = "Код";*/

            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT        [Код], [Имя], [Фамилия], [Отчество], [Пароль], [Тел], [Адрес] FROM [user]");
            comboUser.DataSource = dataReaderBySql.GetDataSource();

            comboUser.DisplayMember = "Фамилия";
            comboUser.ValueMember = "Код";

            dataReaderBySql.CloseDbConnection();

            ReloadUserData();
        }
        
        public void setNewAddGoods(int indexGoods, int kolGoods)
        {
           /* int sum = Convert.ToInt32(Summa.Text.ToString());
            int priceGoods = Convert.ToInt32(dbDataSet.goods.Rows[indexGoods]["Цена"].ToString());
            int price = priceGoods * kolGoods;
            sum = sum + price;
            Summa.Text = sum.ToString();

            DataRow r = dbDataSet.sklad.NewRow();
            r["Код Продукта"] = dbDataSet.goods.Rows[indexGoods]["Код"].ToString();
            r["Наименование"] = dbDataSet.goods.Rows[indexGoods]["Название"].ToString();
            r["Хар-ка"] = dbDataSet.goods.Rows[indexGoods]["Хар-ка"].ToString();
            r["Кол"] = kolGoods;
            r["Цена"] = priceGoods;
            r["Стоимость"] = price;
            r["Код Ед ИЗ"] = dbDataSet.goods.Rows[indexGoods]["Код Ед ИЗ"].ToString();
            r["Ед Из"] = dbDataSet.goods.Rows[indexGoods]["Ед Из"].ToString();
            
            dbDataSet.sklad.Rows.Add(r);

            this.skladTableAdapter.Update(this.dbDataSet.sklad);
            this.skladTableAdapter.Fill(this.dbDataSet.sklad);
            */
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          /*  if (comboClient.Text == "" || comboUser.Text == "" || dbDataSet.sklad.Rows.Count < 1)
            {
                label7.Visible = true;
            }
            else
            {

                // label7.Text = dbDataSet.sklad.Rows.Count.ToString();
                for (int i = 0; i <= dbDataSet.sklad.Rows.Count - 1; i++)
                {//заносим табличные значения

                    DataRow r = dbDataSet.nomenklatura.NewRow();
                    r["Код Продукта"] = dbDataSet.sklad.Rows[i]["Код Продукта"].ToString();
                    r["Наименование"] = dbDataSet.sklad.Rows[i]["Наименование"].ToString();
                    r["Хар-ка"] = dbDataSet.sklad.Rows[i]["Хар-ка"].ToString();
                    r["Кол"] = dbDataSet.sklad.Rows[i]["Кол"].ToString();
                    r["Цена"] = dbDataSet.sklad.Rows[i]["Цена"].ToString();
                    r["Стоимость"] = dbDataSet.sklad.Rows[i]["Стоимость"].ToString();
                    r["Код Ед Из"] = dbDataSet.sklad.Rows[i]["Код Ед ИЗ"].ToString();
                    r["Ед Из"] = dbDataSet.sklad.Rows[i]["Ед Из"].ToString();
                    r["primary_sklad"] = Convert.ToInt32(labelId.Text.ToString());

                    dbDataSet.nomenklatura.Rows.Add(r);

                    this.nomenklaturaTableAdapter.Update(this.dbDataSet.nomenklatura);
                    this.nomenklaturaTableAdapter.Fill(this.dbDataSet.nomenklatura);

                }
                ShopForm shop = (ShopForm)this.Owner;
                shop.setNewDok(labelKod.Text, date.Text, labelKodClient.Text, comboClient.Text, labelAdresClient.Text, comboUser.Text, Summa.Text);
                this.Close();
            }

    */

        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            /*
            if (dbDataSet.sklad.Rows.Count > 0)
            {
                int sum = Convert.ToInt32(Summa.Text.ToString());
                int priceGoods = Convert.ToInt32(dbDataSet.sklad.Rows[skladBindingSource.Position]["Цена"].ToString());
                int kolGoods = Convert.ToInt32(dbDataSet.sklad.Rows[skladBindingSource.Position]["Кол"].ToString());
                priceGoods = priceGoods * kolGoods;
                sum = sum - priceGoods;
                Summa.Text = sum.ToString();

                this.skladTableAdapter.DeleteMyQuery(Convert.ToInt32(dbDataSet.sklad.Rows[skladBindingSource.Position][0]));
                this.skladTableAdapter.Update(this.dbDataSet.sklad);
                this.skladTableAdapter.Fill(this.dbDataSet.sklad);
            }
            */
        }

        private void Dok_FormClosed(object sender, FormClosedEventArgs e)
        {
          /*  if (dbDataSet.sklad.Rows.Count > 0)
            {
                for (int i = 0; i <= dbDataSet.sklad.Rows.Count; i++)
                {//очищает таблицу
                   // label7.Text = Convert.ToString(dbDataSet.sklad.Rows.Count);
                    this.skladTableAdapter.DeleteMyQuery(Convert.ToInt32(dbDataSet.sklad.Rows[skladBindingSource.Position][0]));
                    this.skladTableAdapter.Update(this.dbDataSet.sklad);
                    this.skladTableAdapter.Fill(this.dbDataSet.sklad);
                }
            }
*/        }

        public void Edit()
        {//процедура заполняет поля значениями, при редактировании(вызывается из первой формы)
            /*idRead = id;
            Status = "read";
            nameUnit.Text = name1;
            nameUnit2.Text = name2;
            */
        }

        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void comboUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
