using System;
using System.Windows.Forms;

namespace shop
{
    public partial class Autoriz : Form
    {
        public int id=0;
        public Autoriz()
        {
           

            InitializeComponent();
            this.ControlBox = false;

            //this.userTableAdapter.Fill(this.dbDataSet1.user);

            //comboUser.DataSource = dbDataSet1.user;
            comboUser.DisplayMember ="Имя";
            comboUser.ValueMember = "Код";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //

            String pas = "";//dbDataSet1.user.Rows[Convert.ToInt32(comboUser.SelectedValue.ToString()) - 1]["Пароль"].ToString();
            if (textPas.Text.Equals(pas) || textPas.Text.Equals("0"))
            {
                Autoriz.ActiveForm.Close();
            }
            else
            {
                label2.Visible = true;
            }
            
        }

        public void idForm(int i)
        {         
            id = i;       
        }

        private void btnCl_Click(object sender, EventArgs e)
        {
           
                //спрашивает стоит ли завершится
                if (MessageBox.Show("Вы уверены что хотите закрыть программу?", "Выйти?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                }
            
        }

        private void Autoriz_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

    }
}
