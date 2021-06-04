using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProj
{
    public partial class AddWalletForm : Form
    {
        public AddWalletForm()
        {
            InitializeComponent();
        }

        private void cashCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cashCheck.Checked == true)
                cardCheck.Checked = false;
        }

        private void cardCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cardCheck.Checked == true)
                cashCheck.Checked = false;
        }

        private void sumField_Leave(object sender, EventArgs e)
        {
            if (sumField.Text == "")
            {
                sumField.Text = "Сумма";
            }
        }

        private void sumField_Enter(object sender, EventArgs e)
        {
            sumField.ForeColor = Color.Black;
            if (sumField.Text == "Сумма")
            {
                sumField.Text = "";
            }
        }

        private void walletNameField_Leave(object sender, EventArgs e)
        {
            if (walletNameField.Text == "")
            {
                walletNameField.Text = "Название кошелька";
            }
        }

        private void walletNameField_Enter(object sender, EventArgs e)
        {
            walletNameField.ForeColor = Color.Black;
            if (walletNameField.Text == "Название кошелька")
            {
                walletNameField.Text = "";
            }
        }

        private void backToWalletForm_Click(object sender, EventArgs e)
        {
            this.Hide();//Обращемся к текущему окну и скрываем его
            WalletForm LF = new WalletForm();
            LF.Show();
        }

        public int valuesCheck(string walletName, string sum)
        {

            //Проверка кошелька
            if (walletName == "" || walletName == "Название кошелька") 
            {
                return 1;
            }
            else if (walletName.Length > 20)
            {
                walletNameField.Text = walletNameField.Text.Substring(0, 20);
            }

            //Проверка cуммы
            if (sum == "Сумма" || sum == "")
            {
                return 2;
            }
            else
                try
                {
                    if (sum.Contains('.'))
                    {
                        sumField.Text = sum.Replace('.', ',');
                    }
                    Convert.ToDouble(sumField.Text);

                    return 0;
                }
                catch (FormatException)
                {
                    return 3;
                }
        }

        internal void addIncomeButton_Click(object sender, EventArgs e)
        {

            dataBase DB = new dataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `wallets` (`money_type`, `name`, `sum`, `user_id`) VALUES (@money_type, @sum, @user_id);", DB.getConnection());

            if (cardCheck.Checked == true)
                command.Parameters.Add("@money_type", MySqlDbType.VarChar).Value = "card";
            else
                command.Parameters.Add("@money_type", MySqlDbType.VarChar).Value = "cash";



            switch (valuesCheck(walletNameField.Text, sumField.Text))
            {

                case 1:
                    MessageBox.Show("Название кошелька не введено!");
                    walletNameField.ForeColor = Color.Red;
                    break;

                case 2:
                    MessageBox.Show("Сумма была введена некорректно!");
                    sumField.ForeColor = Color.Red;
                    break;

                case 0:
                    /*Добавление суммы в базу данных*/
                    command.Parameters.Add("@sum", MySqlDbType.Decimal).Value = sumField.Text;

                    /*Добавление кошелька в базу данных*/
                    command.Parameters.Add("@wallet", MySqlDbType.VarChar).Value = walletNameField.Text;

                    /*Добавление id пользователя в базу данных*/
                    command.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = User.applicationUser.id;

                    DB.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Кошелёк был успешно добавлен");
                    }
                    else
                        MessageBox.Show("Кошелёк не был добавлен");

                    DB.closeConnection();

                    this.Hide();//Обращемся к текущему окну и скрываем его
                    WalletForm LF = new WalletForm();
                    LF.Show();
                    break;
            }
        }

        private void AddWalletForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
