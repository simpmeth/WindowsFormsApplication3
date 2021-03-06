﻿using shop;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace WindowsFormsApplication3
{
    public partial class ShopForm : Form
    {   

       
        public ShopForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet1.nomenklatura". При необходимости она может быть перемещена или удалена.
            // this.nomenklaturaTableAdapter.Fill(this.dbDataSet1.nomenklatura);
            LoadNomenklatura();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.unit". При необходимости она может быть перемещена или удалена.
            //this.unitTableAdapter.Fill(this.dbDataSet.unit);
            LoadUnit();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.user". При необходимости она может быть перемещена или удалена.
            //this.userTableAdapter.Fill(this.dbDataSet.user);
            LoadUsers();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.client". При необходимости она может быть перемещена или удалена.
            //this.clientTableAdapter.Fill(this.dbDataSet.client);
            LoadClients();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.goods". При необходимости она может быть перемещена или удалена.
            // this.goodsTableAdapter.Fill(this.dbDataSet.goods);
            LoadGoods();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.dok". При необходимости она может быть перемещена или удалена.
            //this.dokTableAdapter.Fill(this.dbDataSet.dok);
            LoadDok();
            Autoriz newForm = new Autoriz();
            newForm.Owner = this;

            //newForm.ShowDialog();

        }

        private void LoadUnit()
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT Код, Название, Сокращение FROM dbo.unit");
            dataGridView4.DataSource = dataReaderBySql.GetDataSource();
            dataGridView4.Columns[0].Visible = false;
            dataReaderBySql.CloseDbConnection();
            
        }

        private void RemoveUnit(string kod)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("delete from dbo.unit where Код=" + kod);
            dataReaderBySql.CloseDbConnection();

            LoadClients();
        }

        private void UpdateUnit(string id ,string name,string name2)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("update dbo.unit set Название=\'"+name+"\', Сокращение=\'" + name2 + "\'  where Код=\'" + id+"\'" );
            dataReaderBySql.CloseDbConnection();

            LoadUnit();
        }

        private void InsertUnit(string name,string name2)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("insert into dbo.unit  (Название, Сокращение) values (\'"+name+"\',\'"+name2+"\')");
            dataReaderBySql.CloseDbConnection();

            LoadUnit();
        }

        public void LoadDok()
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT Код, Ид, Дата, Клиент, Кладовщик, Сумма, [Адрес Кл.], [Код Кл.] FROM dbo.dok");

            dataGridView5.DataSource = dataReaderBySql.GetDataSource();

            dataReaderBySql.CloseDbConnection();
        }
        private void RemoveDok(string kod)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("delete FROM dbo.dok where Код=\'"+kod+"\'");
            dataReaderBySql.CloseDbConnection();

            LoadDok();
        }

        private void InsertDok(string kod, string date, string kodClient, string client, string adresClienta, string user, string summa)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("INSERT INTO [dbo].[dok] " +
                                         "( [Ид], [Дата], [Клиент], [Кладовщик], [Сумма], " +
                                         "[Адрес Кл.], [Код Кл.])" +
                                         " VALUES ( \'" + kod + "\', \'" + date + "\', \'" +client+ "\', \'" +user + "\', \'" +summa + "\', \'" + adresClienta
                                         + "\', \'" + kodClient + "\')");
            dataReaderBySql.CloseDbConnection();
            
            LoadDok();
        }

        private void LoadGoods()
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT Код, Название, [Хар-ка], [Ед Из], Цена, [Код Ед ИЗ] FROM dbo.goods");
            dataGridView2.DataSource = dataReaderBySql.GetDataSource();
            dataGridView2.Columns[0].Visible = false;
            dataReaderBySql.CloseDbConnection();
        }

        private void RemoveGoods(string kod)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("delete from dbo.goods where Код=" + kod);
            dataReaderBySql.CloseDbConnection();

            LoadGoods();
        }

        private void UpdateGoods(string kod, string name, string har, string unit, string prise,string unitId)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("update  dbo.goods set Название='" + name+ "\', [Хар-ка]='" + har+ "\', [Ед Из]='" + unit+ "\', Цена=\'" + prise
                                                + "\',[Код Ед ИЗ]='" + unitId+ "\' where Код=\'" + kod+"\'");
            dataReaderBySql.CloseDbConnection();

            LoadGoods();
        }

        private void InsertGoods(string name, string har, string unit, string prise, string unitId)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("insert into dbo.goods (Название, [Хар-ка], [Ед Из], Цена, [Код Ед ИЗ]) values (\'" + name 
                                                                        + "\',\'"+har+"\',\'"+unit+"\',\'"+prise+"\',\'"+unitId+"\') ");
            dataReaderBySql.CloseDbConnection();

            LoadGoods();
        }
        private void LoadClients()
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT Код, Наименование, Телефон, Адрес FROM dbo.client");
            dataGridView1.DataSource = dataReaderBySql.GetDataSource();
            
            dataReaderBySql.CloseDbConnection();
        }
        private void RemoveClients(string kod)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("delete from dbo.client where Код=" + kod);
            dataReaderBySql.CloseDbConnection();

            LoadClients();
        }

        private void UpdateClient(string kod,string name,string tel,string adres)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("update dbo.client set Наименование=\'"+name+"\', Телефон=\'"+tel+"\', Адрес=\'"+adres+"\'  where Код=" + kod);
            dataReaderBySql.CloseDbConnection();

            LoadClients();
        }

        private void InsertClient(string name, string tel, string adres)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("insert into dbo.client (Наименование,Телефон,Адрес) values (\'"+name+"\',\'"+tel+"\',\'"+adres+"\')");
            dataReaderBySql.CloseDbConnection();

            LoadClients();
        }

        private void LoadUsers()
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT        [Код], [Имя], [Фамилия], [Отчество], [Пароль], [Тел], [Адрес] FROM [user]");
            dataGridView3.DataSource = dataReaderBySql.GetDataSource();
            dataReaderBySql.CloseDbConnection();
        }
         private void RemoveUsers(string kod)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("delete from dbo.user where Код=" + kod);
            dataReaderBySql.CloseDbConnection();

            LoadUsers();
        }

        private void UpdateUser(string id, string name,string family,string otch,string pas,string tel,string adres)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("update dbo.user set" +
                                               "[Имя]=\'" + name + "\', [Фамилия]=\'" + family + "\', " +
                                               "[Отчество]=\'" + otch + "\', [Пароль]=\'" + pas + "\', " +
                                               "[Тел]=\'" + tel + "\', [Адрес] =\'" + adres+ "\' where" +
                                               " [Код]=\'" + id + "\', ");
            dataReaderBySql.CloseDbConnection();
        }

        private void InsertUser(string name, string family, string otch, string pas, string tel, string adres)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("insert into dbo.user ([Имя], [Фамилия], [Отчество], [Пароль], [Тел], [Адрес]) " +
                                               "values(\'"+name+"\',\'"+family+"\',\'"+otch+ "\',\'"+pas+"\',\'"+tel+"\',\'"+adres+"\')");
            dataReaderBySql.CloseDbConnection();
        }

        public void LoadNomenklatura()
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT   Код, Наименование, Кол, [Ед Из], Цена, [Код Продукта], [Хар-ка], [Код Ед ИЗ], Стоимость, primary_sklad from dbo.nomenklatura");
            dataGridView6.DataSource = dataReaderBySql.GetDataSource();
            dataReaderBySql.CloseDbConnection();
        }

        public DataRowCollection GetNomenklatura(string dokId)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.GetDataReaderBySql("SELECT   Код, Наименование, Кол, [Ед Из], Цена, [Код Продукта], [Хар-ка], [Код Ед ИЗ], Стоимость, primary_sklad from dbo.nomenklatura where primary_sklad=\'" + dokId + "\'");
            var dataSource = dataReaderBySql.GetDataSource();
            dataReaderBySql.CloseDbConnection();

            return dataSource.Rows;
        }

        private void RemoveNomenklatura(string kod)
        {
            var dataReaderBySql = new DataReaderBySql();
            dataReaderBySql.DoSqlCommand("delete from dbo.nomenklatura where primary_sklad=\'"+kod+"\'");
            dataReaderBySql.CloseDbConnection();

            LoadNomenklatura();
        }

       


        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goods newForm = new Goods();
            newForm.Owner = this;
            newForm.ShowDialog();
           
        }

        private void клиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client newForm = new Client();
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        private void кладовщикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User newForm = new User();
            newForm.Owner = this;
            newForm.ShowDialog();
        }

        private void едИзToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unit newForm = new Unit();
            newForm.Owner = this;
            newForm.ShowDialog();
        }
        private void накладнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dok newForm = new Dok();
            newForm.Owner = this;
            newForm.ShowDialog();
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (MessageBox.Show("Вы уверены что хотите удалить запись?", "Выйти?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                  
            if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Товар}"))
            {
                    //todo count(*)
                if (dataGridView2.RowCount > 0)
                {
                    var selectRowIndex = dataGridView2.SelectedCells[0].RowIndex;
                    var selectedKod = dataGridView2.Rows[selectRowIndex].Cells[0].Value.ToString();
                     RemoveGoods(selectedKod);
                }
            }
            if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Клиенты}"))
            {
                if (dataGridView1.RowCount > 0)
                {
                        var selectRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        var selectedKod = dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString();
                        RemoveClients(selectedKod);
                    }
            }
                if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Кладовщики}"))
                {
                    if (dataGridView3.RowCount > 0)
                    {
                        var selectRowIndex = dataGridView3.SelectedCells[0].RowIndex;
                        var selectedKod = dataGridView3.Rows[selectRowIndex].Cells[0].Value.ToString();
                        RemoveUsers(selectedKod);
                    }
                }
                if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Ед. Из.}"))
                {
                    if (dataGridView4.RowCount > 0)
                    {
                        var selectRowIndex = dataGridView4.SelectedCells[0].RowIndex;
                        var selectedKod = dataGridView4.Rows[selectRowIndex].Cells[0].Value.ToString();
                        RemoveUnit(selectedKod);
                    }

                }
                if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Накладные}"))
                {
                    if (dataGridView5.RowCount > 0)
                    {
                        var selectRowIndex = dataGridView5.SelectedCells[0].RowIndex;
                        var selectedKod = dataGridView5.Rows[selectRowIndex].Cells[0].Value.ToString();
                        RemoveDok(selectedKod);


                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {//открываем на редактирование табличное значение

            {

                if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Товар}"))
                {
                    if (dataGridView2.RowCount > 0)
                   {//проверка чтобы не пытаться открыть пустые значения
                        Goods newForm = new Goods();
                        newForm.Owner = this;

                        var selectRowIndex = dataGridView2.SelectedCells[0].RowIndex;
                        var selectedKod = dataGridView2.Rows[selectRowIndex].Cells[0].Value.ToString();
                        
                        String name = dataGridView2.Rows[selectRowIndex].Cells[1].Value.ToString();
                        String har = dataGridView2.Rows[selectRowIndex].Cells[2].Value.ToString();
                        String unit = dataGridView2.Rows[selectRowIndex].Cells[3].Value.ToString();
                        String prise = dataGridView2.Rows[selectRowIndex].Cells[4].Value.ToString();



                        newForm.Edit(Convert.ToInt32(selectedKod), name, har, unit, prise);
                        newForm.ShowDialog();
                    }
                }
                if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Клиенты}"))
                {
                    if (dataGridView1.RowCount > 0)
                    {
                        Client newForm = new Client();
                        newForm.Owner = this;

                        var selectRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        var selectedKod = dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString();

                        String name = dataGridView1.Rows[selectRowIndex].Cells[1].Value.ToString();
                        String tel = dataGridView1.Rows[selectRowIndex].Cells[2].Value.ToString();
                        String adres = dataGridView1.Rows[selectRowIndex].Cells[3].Value.ToString();




                        newForm.Edit(selectedKod, name, tel, adres);
                        newForm.ShowDialog();
                    }
                }
                if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Кладовщики}"))
                {
                    if (dataGridView3.RowCount > 0)
                    {
                        User newForm = new User();
                        newForm.Owner = this;

                        var selectRowIndex = dataGridView3.SelectedCells[0].RowIndex;
                        var selectedKod = dataGridView3.Rows[selectRowIndex].Cells[0].Value.ToString();

                        String name = dataGridView3.Rows[selectRowIndex].Cells[1].Value.ToString();
                        String family = dataGridView3.Rows[selectRowIndex].Cells[2].Value.ToString();
                        String otch = dataGridView3.Rows[selectRowIndex].Cells[3].Value.ToString();
                        String pas = dataGridView3.Rows[selectRowIndex].Cells[4].Value.ToString();
                        String tel = dataGridView3.Rows[selectRowIndex].Cells[5].Value.ToString();
                        String adres = dataGridView3.Rows[selectRowIndex].Cells[6].Value.ToString();

                        newForm.Edit(selectedKod, name, family, otch, pas, tel, adres);
                        newForm.ShowDialog();
                    }
                }
               if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Ед. Из.}"))
                {
                    if (dataGridView4.RowCount > 0)
                    {
                        Unit newForm = new Unit();
                        newForm.Owner = this;

                        var selectRowIndex = dataGridView4.SelectedCells[0].RowIndex;
                        var selectedKod = dataGridView4.Rows[selectRowIndex].Cells[0].Value.ToString();


                        String name = dataGridView4.Rows[selectRowIndex].Cells[1].Value.ToString();
                        String name2 = dataGridView4.Rows[selectRowIndex].Cells[2].Value.ToString(); 

                        newForm.Edit(selectedKod, name, name2);
                        newForm.ShowDialog();
                    }
                }
                if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Накладные}"))
                {
                    if (dataGridView5.RowCount > 0)
                    {

                        Dok newForm = new Dok();
                        newForm.Owner = this;
                        var selectRowIndex = dataGridView5.SelectedCells[0].RowIndex;
                        var selectedKod = dataGridView5.Rows[selectRowIndex].Cells[0].Value.ToString();
                        var selectedDok = dataGridView5.Rows[selectRowIndex].Cells[1].Value.ToString();
                        RemoveDok(selectedKod);
                        RemoveNomenklatura(selectedDok);
                        // var selectRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                        // 

                        // newForm.Edit();
                        //newForm.ShowDialog();
                    }
                }
            }
        }

        public void setNewDok(string id, string date, string kodClient, string client, string adresClienta , string user, string summa)
        {
            InsertDok(id, date, kodClient, client, adresClienta, user, summa);

            LoadNomenklatura();
            LoadDok();
        }
        public void setNewUnit(String status, string id, String name, String name2)
        {
            

            if (status.Equals("read"))
            {//если было редактирование

                   UpdateUnit(id,name, name2);
            }
            else
            {//если просто добавляем новое значение
                InsertUnit(name,name);
            }
            
        }
        public void setNewUser(String status, string id, string name, string family, string otch, string pas, string tel, string adres)
        {
            
     
            if (status.Equals("read"))
            {//если было редактирование
               UpdateUser(id, name, family, otch,pas, tel, adres);
            }
            else
            {//если просто добавляем новое значение
                InsertUser(name, family, otch, pas, tel, adres);
            }
        }
        public void setNewGoods(String status, int id, int kodEd, String name, String har, String unit, String prise, String unitId)
        {//Работа с таблицей после закрытия диалога добавления товара
           
            if (status.Equals("read"))
            {//если было редактирование

               UpdateGoods(id.ToString(),name,har,unit,prise, unitId);
            }
            else
            {//если просто добавляем новое значение
                InsertGoods(name, har, unit, prise, unitId);
            }
        }
        public void setNewClient(String status, String kod, String name, String tel, String adres)
        {
           if (status.Equals("read"))
            {//если было редактирование
               
                UpdateClient(kod.ToString(), name, tel, adres);
            }
            else
            {//если просто добавляем новое значение
                InsertClient(name, tel, adres);
            }
            
        }

        



        public void butOutDok_Click(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Накладные}"))
            {
                if (dataGridView5.Rows.Count > 0)
                {
                     
                    var selectRowIndex = dataGridView5.SelectedCells[0].RowIndex;
                    var selectRow = dataGridView5.Rows[selectRowIndex];
                    var kodDok = selectRow.Cells[1].Value.ToString();
                   
                    var listDataRows = GetNomenklatura(kodDok);

                      Excel.Application exApp = new Excel.Application();

                      exApp.Workbooks.Open(Environment.CurrentDirectory + "\\" + "Накладная.xlsx");   //Add();
                      exApp.Visible = true;
                      Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
                    
                    workSheet.Cells[1, "E"] = selectRow.Cells[0].Value.ToString();
                    workSheet.Cells[2, "E"] = selectRow.Cells[1].Value.ToString();
                    workSheet.Cells[3, "E"] = selectRow.Cells[2].Value.ToString();
                    workSheet.Cells[4, "E"] = selectRow.Cells[3].Value.ToString();
                    workSheet.Cells[5, "E"] = selectRow.Cells[6].Value.ToString();
                    workSheet.Cells[6, "E"] = selectRow.Cells[0].Value.ToString();

                    int numberR = 12;//номер строки с которой заполняется наменклатура
                    int numberColm = 1;//номер в екселе строка с товаром
                    
                    int kol=0;
                    int sum = 0;
                    for (int i = 0; i <= listDataRows.Count - 1; i++)
                      {//заносим табличные значения
                          
                              kol=kol+Convert.ToInt32(listDataRows[i][2].ToString());
                              sum = sum + Convert.ToInt32(listDataRows[i][8].ToString());

                              workSheet.Rows[numberR].Insert(Excel.XlInsertShiftDirection.xlShiftDown);//вставляем новую строку
                              workSheet.Cells[numberR, "A"] = numberColm;//код нвкладной общий
                              workSheet.Cells[numberR, "B"] = listDataRows[i][1].ToString();
                              //workSheet.Cells[numberR, "С"] = listDataRows[i][5].ToString();
                              workSheet.Cells[numberR, "D"] = listDataRows[i][6].ToString();
                              workSheet.Cells[numberR, "E"] = listDataRows[i][2].ToString();
                              workSheet.Cells[numberR, "F"] = listDataRows[i][7].ToString();
                              workSheet.Cells[numberR, "G"] = listDataRows[i][3].ToString();
                              workSheet.Cells[numberR, "H"] = listDataRows[i][4].ToString();
                              workSheet.Cells[numberR, "I"] = listDataRows[i][8].ToString();
                              numberColm++;
                              numberR++;
                          
                      }
                        
                      workSheet.Cells[numberR, "E"] = kol.ToString();//общее колличевство
                      workSheet.Cells[numberR, "I"] = sum.ToString();//общая сумма
                      workSheet.Cells[numberR + 1, "G"] = selectRow.Cells[4].Value.ToString(); //кладовщик
                      
                }
            }
            
        }



        private void ShopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //устанавливает флаг отмены события в истину
                e.Cancel = true;
                //спрашивает стоит ли завершится
                if (MessageBox.Show("Вы уверены что хотите закрыть программу?", "Выйти?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
           
        }
    }
}
