using shop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

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
            this.nomenklaturaTableAdapter.Fill(this.dbDataSet1.nomenklatura);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.unit". При необходимости она может быть перемещена или удалена.
            this.unitTableAdapter.Fill(this.dbDataSet.unit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.dbDataSet.user);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.dbDataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.dbDataSet.goods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.dok". При необходимости она может быть перемещена или удалена.
            this.dokTableAdapter.Fill(this.dbDataSet.dok);

            Autoriz newForm = new Autoriz();
            newForm.Owner = this;

            newForm.ShowDialog();

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
                if (dbDataSet.goods.Rows.Count > 0)
                {
                    this.goodsTableAdapter.DeleteMyQuery(Convert.ToInt32(dbDataSet.goods.Rows[goodsBindingSource.Position][0]));
                    this.goodsTableAdapter.Update(this.dbDataSet.goods);
                    this.goodsTableAdapter.Fill(this.dbDataSet.goods);

                   
                }
            }
            if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Клиенты}"))
            {
                if (dbDataSet.client.Rows.Count > 0)
                {
                    this.clientTableAdapter.DeleteMyQuery(Convert.ToInt32(dbDataSet.client.Rows[clientBindingSource.Position][0]));
                    this.clientTableAdapter.Update(this.dbDataSet.client);
                    this.clientTableAdapter.Fill(this.dbDataSet.client);
                }
            }
            if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Кладовщики}"))
            {
                if (dbDataSet.user.Rows.Count > 0)
                {
                    this.userTableAdapter.DeleteMyQuery(Convert.ToInt32(dbDataSet.user.Rows[userBindingSource.Position][0]));
                    this.userTableAdapter.Update(this.dbDataSet.user);
                    this.userTableAdapter.Fill(this.dbDataSet.user);
                }
            }
            if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Ед. Из.}"))
            {
                if (dbDataSet.unit.Rows.Count > 0)
                {
                    this.unitTableAdapter.DeleteMyQuery(Convert.ToInt32(dbDataSet.unit.Rows[unitBindingSource.Position][0]));
                    this.unitTableAdapter.Update(this.dbDataSet.unit);
                    this.unitTableAdapter.Fill(this.dbDataSet.unit);
                }

            }
            if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Накладные}"))
            {
                if (dbDataSet.dok.Rows.Count > 0)
                {

                    this.nomenklaturaTableAdapter.DeleteMyQuery(Convert.ToInt32(dbDataSet.dok.Rows[dokBindingSource.Position][0]));
                    this.nomenklaturaTableAdapter.Update(this.dbDataSet1.nomenklatura);
                    this.nomenklaturaTableAdapter.Fill(this.dbDataSet1.nomenklatura);

                    this.dokTableAdapter.DeleteMyQuery(Convert.ToInt32(dbDataSet.dok.Rows[dokBindingSource.Position][0]));
                    this.dokTableAdapter.Update(this.dbDataSet.dok);
                    this.dokTableAdapter.Fill(this.dbDataSet.dok);

                  
                }
            }
        } 

        }

        private void button2_Click(object sender, EventArgs e)
        {//открываем на редактирование табличное значение

            {

                if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Товар}"))
                {
                    if (dbDataSet.goods.Rows.Count > 0)
                    {//проверка чтобы не пытаться открыть пустые значения
                        Goods newForm = new Goods();
                        newForm.Owner = this;

                        String name = dbDataSet.goods.Rows[goodsBindingSource.Position][1].ToString();
                        String har = dbDataSet.goods.Rows[goodsBindingSource.Position][2].ToString();
                        String unit = dbDataSet.goods.Rows[goodsBindingSource.Position][3].ToString();
                        String prise = dbDataSet.goods.Rows[goodsBindingSource.Position][4].ToString();

                        newForm.Edit(Convert.ToInt32(dbDataSet.goods.Rows[goodsBindingSource.Position][0]), name, har, unit, prise);
                        newForm.ShowDialog();
                    }
                }
                if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Клиенты}"))
                {
                    if (dbDataSet.client.Rows.Count > 0)
                    {
                        Client newForm = new Client();
                        newForm.Owner = this;

                        String name = dbDataSet.client.Rows[clientBindingSource.Position][1].ToString();
                        String tel = dbDataSet.client.Rows[clientBindingSource.Position][2].ToString();
                        String adres = dbDataSet.client.Rows[clientBindingSource.Position][3].ToString();

                        newForm.Edit(Convert.ToInt32(dbDataSet.client.Rows[clientBindingSource.Position][0]), name, tel, adres);
                        newForm.ShowDialog();
                    }
                }
                if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Кладовщики}"))
                {
                    if (dbDataSet.user.Rows.Count > 0)
                    {
                        User newForm = new User();
                        newForm.Owner = this;

                        String name = dbDataSet.user.Rows[userBindingSource.Position][1].ToString();
                        String family = dbDataSet.user.Rows[userBindingSource.Position][2].ToString();
                        String otch = dbDataSet.user.Rows[userBindingSource.Position][3].ToString();
                        String pas = dbDataSet.user.Rows[userBindingSource.Position][4].ToString();
                        String tel = dbDataSet.user.Rows[userBindingSource.Position][5].ToString();
                        String adres = dbDataSet.user.Rows[userBindingSource.Position][6].ToString();

                        newForm.Edit(Convert.ToInt32(dbDataSet.user.Rows[userBindingSource.Position][0]), name, family, otch, pas, tel, adres);
                        newForm.ShowDialog();
                    }
                }
                if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Ед. Из.}"))
                {
                    if (dbDataSet.unit.Rows.Count > 0)
                    {
                        Unit newForm = new Unit();
                        newForm.Owner = this;

                        String name = dbDataSet.unit.Rows[unitBindingSource.Position][1].ToString();
                        String name2 = dbDataSet.unit.Rows[unitBindingSource.Position][2].ToString();

                        newForm.Edit(Convert.ToInt32(dbDataSet.unit.Rows[unitBindingSource.Position][0]), name, name2);
                        newForm.ShowDialog();
                    }
                }
                if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Накладные}"))
                {
                    if (dbDataSet.dok.Rows.Count > 0)
                    {
                        dokBindingSource.RemoveCurrent();
                        this.dokTableAdapter.Update(this.dbDataSet.dok);
                        this.dokTableAdapter.Fill(this.dbDataSet.dok);
                    }
                }
            }
        }

        public void setNewDok(object id, object date,object kodClient, object client, object adresClienta ,object user, object summa)
        {
            DataRow r = dbDataSet.dok.NewRow();
            r["Ид"] = id;
            r["Дата"] = date;
            r["Код Кл"] = kodClient;
            r["Клиент"] = client;
            r["Адрес Кл"] = adresClienta;
            r["Кладовщик"] = user;
            r["Сумма"] = summa;


            dbDataSet.dok.Rows.Add(r);
            this.dokTableAdapter.Update(this.dbDataSet.dok);
            this.dokTableAdapter.Fill(this.dbDataSet.dok);

            this.nomenklaturaTableAdapter.Update(this.dbDataSet1.nomenklatura);
            this.nomenklaturaTableAdapter.Fill(this.dbDataSet1.nomenklatura);

        }
        public void setNewUnit(String status, int id, String s1, String s2)
        {


            if (status.Equals("read"))
            {//если было редактирование

                   this.unitTableAdapter.UpdateMyQuery(s1, s2, id);
            }
            else
            {//если просто добавляем новое значение
                DataRow r = dbDataSet.unit.NewRow();
                r["Название"] = s1;
                r["Сокращение"] = s2;
                dbDataSet.unit.Rows.Add(r);
            }
            // 

        // 
            this.unitTableAdapter.Update(this.dbDataSet.unit);
            this.unitTableAdapter.Fill(this.dbDataSet.unit);

        }
        public void setNewUser(String status, int id, String s1, String s2, String s3, String s4, String s5, String s6)
        {
            
     
            if (status.Equals("read"))
            {//если было редактирование
                this.userTableAdapter.UpdateMyQuery(s1, s2, s3, s4, s5, s6, id);
            }
            else
            {//если просто добавляем новое значение
                DataRow r = dbDataSet.user.NewRow();
                r["Имя"] = s1;
                r["Фамилия"] = s2;
                r["Отчество"] = s3;
                r["Пароль"] = s4;
                r["Тел"] = s5;
                r["Адрес"] = s6;
                dbDataSet.user.Rows.Add(r);     
            }
            this.userTableAdapter.Update(this.dbDataSet.user);
            this.userTableAdapter.Fill(this.dbDataSet.user);
       
        }
        public void setNewGoods(String status, int id, int kodEd, String s1, String s2, String s3, String s4)
        {//Работа с таблицей после закрытия диалога добавления товара
           
            if (status.Equals("read"))
            {//если было редактирование

                this.goodsTableAdapter.UpdateMyQuery(s1, s2, s3, s4, id);
            }
            else
            {//если просто добавляем новое значение
                DataRow r = dbDataSet.goods.NewRow();
                r["Название"] = s1;
                r["Хар-ка"] = s2;
                r["Код Ед ИЗ"] = kodEd;
                r["Ед Из"] = s3;
                r["Цена"] = s4;
                dbDataSet.goods.Rows.Add(r);     
            }
            this.goodsTableAdapter.Update(this.dbDataSet.goods);
            this.goodsTableAdapter.Fill(this.dbDataSet.goods);
        }
        public void setNewClient(String status, int id, String s1, String s2, String s3)
        {
            if (status.Equals("read"))
            {//если было редактирование
               
                this.clientTableAdapter.UpdateMyQuery(s1, s2, s3, id);
            }
            else
            {//если просто добавляем новое значение
                DataRow r = dbDataSet.client.NewRow();
                r["Наименование"] = s1;
                r["Телефон"] = s2;
                r["Адрес"] = s3;
                dbDataSet.client.Rows.Add(r);
            }
            this.clientTableAdapter.Update(this.dbDataSet.client);
            this.clientTableAdapter.Fill(this.dbDataSet.client);
        }


        public void ExportExсel(int id)
        {

            this.nomenklaturaTableAdapter.Update(this.dbDataSet1.nomenklatura);
            this.nomenklaturaTableAdapter.Fill(this.dbDataSet1.nomenklatura);
            /////////////////////////Выгружаем в exel/////////////////////////////////////////////////////////
            Excel.Application exApp = new Excel.Application();
            
            exApp.Workbooks.Open(Environment.CurrentDirectory + "\\" + "Накладная.xlsx");   //Add();
            exApp.Visible = true;
            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
 
        }


        private void unitBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableAdapter.Fill(this.dbDataSet.user);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butOutDok_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.ToString().Equals("TabPage: {Накладные}"))
            {
                if (dbDataSet.dok.Rows.Count > 0)
                {
                    //     ExportExel(Convert.ToInt32(dbDataSet.unit.Rows[unitBindingSource.Position][0]));
                    this.nomenklaturaTableAdapter.Update(this.dbDataSet.nomenklatura);
                    this.nomenklaturaTableAdapter.Fill(this.dbDataSet.nomenklatura);

                    Excel.Application exApp = new Excel.Application();

                    exApp.Workbooks.Open(Environment.CurrentDirectory + "\\" + "Накладная.xlsx");   //Add();
                    exApp.Visible = true;
                    Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
                    workSheet.Cells[1, "E"] = dbDataSet.dok.Rows[dokBindingSource.Position]["Код"];//код нвкладной общий
                    workSheet.Cells[2, "E"] = dbDataSet.dok.Rows[dokBindingSource.Position]["Ид"];
                    workSheet.Cells[3, "E"] = dbDataSet.dok.Rows[dokBindingSource.Position]["Дата"];
                    workSheet.Cells[4, "E"] = dbDataSet.dok.Rows[dokBindingSource.Position]["Клиент"];
                    workSheet.Cells[5, "E"] = dbDataSet.dok.Rows[dokBindingSource.Position]["Адрес Кл"];//адрес
                    workSheet.Cells[6, "E"] = dbDataSet.dok.Rows[dokBindingSource.Position]["Код Кл"];//код


                    int numberR = 12;//номер строки с которой заполняется наменклатура
                    int numberColm = 1;//номер в екселе строка с товаром
                    int id_dok = Convert.ToInt32(dbDataSet.dok.Rows[dokBindingSource.Position]["Код"]);
                    int kol=0;
                    int sum = 0;
                    for (int i = 0; i <= dbDataSet.nomenklatura.Rows.Count - 1; i++)
                    {//заносим табличные значения
                        int id_nom = Convert.ToInt32(dbDataSet.nomenklatura.Rows[i]["primary_sklad"]);
                        

                        if (id_dok == id_nom)
                        {
                            kol=kol+Convert.ToInt32(dbDataSet.nomenklatura.Rows[i]["Кол"]);
                            sum = sum + Convert.ToInt32(dbDataSet.nomenklatura.Rows[i]["Стоимость"]);

                            workSheet.Rows[numberR].Insert(Excel.XlInsertShiftDirection.xlShiftDown);//вставляем новую строку
                            workSheet.Cells[numberR, "A"] = numberColm;//код нвкладной общий
                            workSheet.Cells[numberR, "B"] = dbDataSet.nomenklatura.Rows[i]["Наименование"];
                          //  workSheet.Cells[numberR, "С"] = dbDataSet.nomenklatura.Rows[i][5].ToString();
                            workSheet.Cells[numberR, "D"] = dbDataSet.nomenklatura.Rows[i]["Хар-ка"];
                            workSheet.Cells[numberR, "E"] = dbDataSet.nomenklatura.Rows[i]["Кол"];
                            workSheet.Cells[numberR, "F"] = dbDataSet.nomenklatura.Rows[i]["Код Ед Из"];
                            workSheet.Cells[numberR, "G"] = dbDataSet.nomenklatura.Rows[i]["Ед Из"];
                            workSheet.Cells[numberR, "H"] = dbDataSet.nomenklatura.Rows[i]["Цена"];
                            workSheet.Cells[numberR, "I"] = dbDataSet.nomenklatura.Rows[i]["Стоимость"];
                            
                           

                           
                            numberColm++;
                            numberR++;
                        }
                    }//конец цыкла

                    workSheet.Cells[numberR, "E"] = kol.ToString();//общее колличевство
                    workSheet.Cells[numberR, "I"] = sum.ToString();//общая сумма
                    workSheet.Cells[numberR + 1, "G"] = dbDataSet.dok.Rows[dokBindingSource.Position]["Кладовщик"];

                }
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
