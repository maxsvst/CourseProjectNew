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
    public partial class IncomeForm : Form
    {
       

        public IncomeForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            dataBase DB = new dataBase();
            MySqlCommand countDistinctIncomeCategory = new MySqlCommand("SELECT COUNT(DISTINCT category) FROM operations WHERE type = 'income' AND user_id = @user_id AND category <> 'ЗП' AND category <> 'Активы' AND category <> 'Подарок'", DB.getConnection());
            MySqlCommand distinctIncomeCategory = new MySqlCommand("SELECT DISTINCT category FROM operations WHERE type = 'income' AND user_id = @user_id AND category <> 'ЗП' AND category <> 'Активы' AND category <> 'Подарок'", DB.getConnection());
            DB.openConnection();
            countDistinctIncomeCategory.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = User.applicationUser.id;
            distinctIncomeCategory.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = User.applicationUser.id;
           

            var countReader = countDistinctIncomeCategory.ExecuteReader();//Объявление ридера для счетчика уникальных категорий
            if (countReader.HasRows)
            {
                countReader.Read();
                int numberOfCategories = countReader.GetInt32(0);//Инициализация переменной для хранения количества категорий
                DB.closeConnection();
                DB.openConnection();
                var categoriesReader = distinctIncomeCategory.ExecuteReader();
                string[] categories = new string[numberOfCategories + 3];
                categories[0] = "ЗП"; categories[1] = "Активы"; categories[2] = "Подарок";
                int j = 3;
                while (categoriesReader.Read())
                {
                    categories[j] = categoriesReader.GetString(0);
                    j++;
                }
                DB.closeConnection();
                sourceField.Items.AddRange(categories);
            }
        }

        private void IncomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void sumField_Enter(object sender, EventArgs e)
        {
            sumField.ForeColor = Color.Black;
            if (sumField.Text == "Сумма")
            {
                sumField.Text = "";
            }
        }

        private void sumField_Leave(object sender, EventArgs e)
        {
            if (sumField.Text == "")
            {
                sumField.Text = "Сумма";
            }
        }

        private void commentField_Leave(object sender, EventArgs e)
        {
            if (commentField.Text == "")
            {
                commentField.Text = "Комментарий";
            }
        }

        private void commentField_Enter(object sender, EventArgs e)
        {
            if (commentField.Text == "Комментарий")
            {
                commentField.Text = "";
            }
        }

        private void sourceField_Enter(object sender, EventArgs e)
        {
            sourceField.ForeColor = Color.Black;
            if (sourceField.Text == "Источник")
            {
                sourceField.Text = "";
            }
        }

        private void sourceField_Leave(object sender, EventArgs e)
        {
            if (sourceField.Text == "")
            {
                sourceField.Text = "Источник";
            }
        }

        internal void addIncomeButton_Click(object sender, EventArgs e)
        {
            dataBase DB = new dataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `operations` (`money_type`, `type`, `sum`, `date`, `category`, `comment`,`user_id`, `wallet`) VALUES (@money_type, @type, @sum, @date, @category, @comment, @user_id, @wallet);", DB.getConnection());

            if (cardCheck.Checked == true)
                command.Parameters.Add("@money_type", MySqlDbType.VarChar).Value = "card";
            else
                command.Parameters.Add("@money_type", MySqlDbType.VarChar).Value = "cash";


            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = "income";


            switch (valuesCheck(walletField.Text, sourceField.Text, sumField.Text, commentField.Text))
            {

                case 1:
                    MessageBox.Show("Кошелёк не был выбран");
                    break;

                case 2:
                    MessageBox.Show("Источник не был выбран");
                    sourceField.ForeColor = Color.Red;
                    break;

                case 3:
                    MessageBox.Show("Сумма была введена некорректно!");
                    sumField.ForeColor = Color.Red;
                    break;

                case 0:
                    /*Добавление суммы в базу данных*/
                    command.Parameters.Add("@sum", MySqlDbType.Decimal).Value = sumField.Text;

                    /*Добавление кошелька в базу данных*/
                    command.Parameters.Add("@wallet", MySqlDbType.VarChar).Value = walletField.Text;

                    /*Добавление даты в базу данных*/
                    string wrongDate = dateField.Value.ToShortDateString();
                    string[] buffertDate = wrongDate.Split(new char[] { '.' });
                    string correctDate = String.Concat(buffertDate[2], '.', buffertDate[1], '.', buffertDate[0]);
                    command.Parameters.Add("@date", MySqlDbType.VarChar).Value = correctDate;

                    /*Добавление категории в базу данных*/
                    command.Parameters.Add("@category", MySqlDbType.VarChar).Value = sourceField.Text;

                    /*Добавление комментария в базу данных*/
                    if (commentField.Text == "Комментарий")
                        commentField.Text = "";
                    command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = commentField.Text;

                    /*Добавление id пользователя в базу данных*/
                    command.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = User.applicationUser.id;

                        DB.openConnection();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            string item = sourceField.Text.ToString();
                            sourceField.Items.Add(item);
                            MessageBox.Show("Доход был успешно добавлен");
                        }
                        else
                            MessageBox.Show("Доход не был добавлен");

                        DB.closeConnection();

                        this.Hide();//Обращемся к текущему окну и скрываем его
                        Menu LF = new Menu();
                        LF.Show();
                        break;
            }
        }
        public int valuesCheck(string wallet, string category, string sum, string comment)
        {

            bool sum_check = false;

            //Проверка кошелька
            if (wallet == "")
            {
                return 1;
            }

            //Проверка категории
            if (category == "Источник")
            {
                return 2;
            }
            else if (category.Length > 35)
            {
                sourceField.Text = sourceField.Text.Substring(0, 35);
            }

            //Проверка комментария
            if (comment.Length > 100)
            {
                commentField.Text = commentField.Text.Substring(0, 100);
            }

            //Проверка cуммы
            if (sum == "Сумма")
            {
                return 3;
            }
            else
                try
                {
                    if (sum.Contains('.'))
                    {
                        sumField.Text = sum.Replace('.', ',');
                    }
                    Convert.ToDouble(sumField.Text);
                    sum_check = true;

                    return 0;
                }
                catch (FormatException)
                {
                    sum_check = false;
                    return 3;
                }
        }
        private void cardCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cardCheck.Checked == true)
            cashCheck.Checked = false;
        }

        private void cashCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cashCheck.Checked == true)
            cardCheck.Checked = false;
        }

        private void backToMenuFromIncome_Click(object sender, EventArgs e)
        {
            this.Hide();//Обращемся к текущему окну и скрываем его
            Menu LF = new Menu();
            LF.Show();
        }

        private void backToMenuFromIncome_MouseEnter(object sender, EventArgs e)
        {
            backToWalletForm.ForeColor = Color.Black;
        }

        private void backToMenuFromIncome_MouseLeave(object sender, EventArgs e)
        {
            backToWalletForm.ForeColor = Color.Gray;
        }
    }
}
