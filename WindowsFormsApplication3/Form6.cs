using System;
using System.Collections.Generic;
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

            labelId.Text = Convert.ToString(GetLastDokId() + 1);
            



            /////////////////////////
            labelId.Text = Convert.ToString(GetLastDokId() + 1);
            
            labelKod.Text=Convert.ToString(GetLastDokId() + 1);
            

            LoadSklad();
        }



        private int GetLastDokId()
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql(
                "select ISNULL((select avg(Код) from dbo.dok group by [Код]),0)  as maxid");

            var source = dataReaderBySql.GetDataSource();
            dataReaderBySql.CloseDbConnection();

            if (source.Rows.Count > 0)
            {
                return (int) source.Rows[0]["maxid"];
            }
            return 0;
        }
        private int GetRowCountDok()
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql(
                "select ISNULL((select count(Код) from dbo.dok group by [Код]),0)  as dokcount");

            var source = dataReaderBySql.GetDataSource();
            dataReaderBySql.CloseDbConnection();

            if (source.Rows.Count > 0)
            {
                return (int)source.Rows[0]["dokcount"];
            }
            return 0;
        }

        private void LoadSklad()
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql(
                "SELECT  [Код], [Наименование], [Кол], [Ед Из], [Цена], [Стоимость], [Хар-ка], " +
                "[Код Продукта], [Код Ед ИЗ] from dbo.sklad");
            dataGridView1.DataSource = dataReaderBySql.GetDataSource();
            //if (dataGridView1.DataSource!=null) dataGridView1.Columns[0].Visible = false;
            dataReaderBySql.CloseDbConnection();
        }

        private void InsertSklad(string name, string count, string unit, string price, string kodProd, string summ,
            string har, string kodunit)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand(
                "INSERT INTO [dbo].[sklad] ([Наименование], [Кол], [Ед Из], [Цена], [Стоимость], [Хар-ка], [Код Продукта], [Код Ед ИЗ])" +
                " VALUES (\'" + name + "\', \'" + count + "\', \'" + unit + "\', \'" + price + "\', \'" + summ +
                "\',  \'" + har + "\',\'" + kodProd + "\', \'" + kodunit + "\')");

            dataReaderBySql.CloseDbConnection();

            LoadSklad();
        }

        private static void ClearSklad()
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("delete from dbo.sklad ");
            dataReaderBySql.CloseDbConnection();
        }

        private void RemoveSklad(string kodSklad)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("delete from dbo.sklad where [Код]=\'" + kodSklad + "\'");
            dataReaderBySql.CloseDbConnection();
            LoadSklad();
        }

        private void CreateNomenkulatura(string kod)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("INSERT INTO [dbo].[nomenklatura] (" +
                                         " [Наименование], [Кол], [Ед Из], [Цена],[Стоимость], " +
                                         "[Код Продукта], [Хар-ка], [Код Ед ИЗ], [primary_sklad])" +
                                         " " +
                                         "SELECT [Наименование], [Кол], [Ед Из], [Цена], [Стоимость]," +
                                         " [Код Продукта],[Хар-ка], [Код Ед ИЗ], \'"+kod+"\' " +
                                         "from dbo.sklad");
            dataReaderBySql.CloseDbConnection();
            ClearSklad();
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
            if (selectedItem != null)
            {
                labelAdresClient.Text = selectedItem.Row["Адрес"].ToString();
                labelKodClient.Text = selectedItem.Row["Код"].ToString();
            }
        }

        private void ReloadUserData()
        {
            var selectedItem = comboUser.SelectedItem as DataRowView;
            if (selectedItem != null) labelAdresUser.Text = selectedItem.Row["Адрес"].ToString();
        }


        private void comboClient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ReloadClientData();
        }

        private void comboUser_SelectionChangeCommitted(object sender, EventArgs e)
        {
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
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT        [Код], [Имя], [Фамилия], [Отчество], [Пароль], [Тел], [Адрес] FROM [user]");
            comboUser.DataSource = dataReaderBySql.GetDataSource();

            comboUser.DisplayMember = "Фамилия";
            comboUser.ValueMember = "Код";

            dataReaderBySql.CloseDbConnection();

            ReloadUserData();
        }

        private DataRow GetGoodById(int indexGoods)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("select [Код], [Название], [Хар-ка], [Ед Из], [Цена], [Код Ед ИЗ] from dbo.[goods] where [Код]=\'" +
            indexGoods + "\'");

            var source = dataReaderBySql.GetDataSource();
            dataReaderBySql.CloseDbConnection();

            if (source.Rows.Count>0)
            {
                return source.Rows[0];
            }
            return null;
        }

        public void setNewAddGoods(int indexGoods, int kolGoods)
        {

            var good = GetGoodById(indexGoods);
            
            int sum = Convert.ToInt32(Summa.Text);
            var priceGoods = Convert.ToInt32(good["Цена"]);
            int price = priceGoods * kolGoods;
            sum = sum + price;
            Summa.Text = sum.ToString();


            InsertSklad(good["Название"].ToString(), kolGoods.ToString(), good["Ед Из"].ToString(),priceGoods.ToString(),
                            indexGoods.ToString(), sum.ToString(), good["Хар-ка"].ToString(), good["Код Ед ИЗ"].ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboClient.Text == "" || comboUser.Text == "" || dataGridView1.Rows.Count < 1)
            {
                label7.Visible = true;
            }
            else
            {

                // label7.Text = dataGridView1.Rows.Count.ToString();
                //sklad - >nomen
                var dokkod = labelKod.Text;
                CreateNomenkulatura(dokkod);
                ShopForm shop = (ShopForm) this.Owner;
                shop.setNewDok(dokkod, date.Text, labelKodClient.Text, comboClient.Text, labelAdresClient.Text,
                    comboUser.Text, Summa.Text);

                Close();
                shop.LoadNomenklatura();
                shop.LoadDok();
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {

                var selectRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                var selectedKod = dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString();
                

                int sum = Convert.ToInt32(Summa.Text);
                
                var priceGoods = Convert.ToInt32( dataGridView1.Rows[selectRowIndex].Cells[5].Value.ToString() );
                sum = sum - priceGoods;
                Summa.Text = sum.ToString();

                RemoveSklad(selectedKod);
            }
            
        }

        private void Dok_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                ClearSklad();
            }
        }

        

        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void comboUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
