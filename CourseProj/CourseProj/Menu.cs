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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            dataBase DB = new dataBase();
            MySqlCommand countCategoriesCommand = new MySqlCommand("SELECT COUNT(DISTINCT category) FROM operations WHERE type = 'expence' AND user_id = @user_id", DB.getConnection());//Возврат количества уникальных категорий
            MySqlCommand categoriesCommand = new MySqlCommand("SELECT DISTINCT category FROM operations WHERE type = 'expence' AND user_id = @user_id", DB.getConnection());//Возврат уникальных категорий
            MySqlCommand sumCategoriesCommand = new MySqlCommand("SELECT SUM(sum) FROM operations WHERE type = 'expence' AND category = @category AND user_id = @user_id", DB.getConnection());//Возврат суммы для каждой категории 
            DB.openConnection();
            countCategoriesCommand.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = User.applicationUser.id;
            categoriesCommand.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = User.applicationUser.id;
            sumCategoriesCommand.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = User.applicationUser.id;
            var countReader = countCategoriesCommand.ExecuteReader();//Объявление ридера для счетчика уникальных категорий
            if (countReader.HasRows)//Если есть хоть одна категория (для первого запроса)
            {
                countReader.Read();//Считывание результата запроса
                int numberOfCategories = countReader.GetInt32(0);//Инициализация переменной для хранения количества категорий
                DB.closeConnection();
                string[] categories = new string[numberOfCategories];//Массив строк для хранения уникальных категорий с указанием размера - numberOfCategories
                DB.openConnection();
                var categoriesReader = categoriesCommand.ExecuteReader();//Объявление ридера для категорий
                string[] categorySum = new string[numberOfCategories]; //Массив строк для хранения суммы для каждой категории с указанием размера -numberOfCategories
                    int j = 0;
                    while (categoriesReader.Read())//Цикл для заполнения массива категорий
                    {
                        categories[j] = categoriesReader.GetString(0);
                        j++;
                    }
                    DB.closeConnection();
                    for (j = 0; j < numberOfCategories; j++)
                    {
                        DB.openConnection();
                        sumCategoriesCommand.Parameters.Add("@category", MySqlDbType.VarChar).Value = categories[j];//Вставка в 3-ий запрос категорий
                        var sumCategoriesReader = sumCategoriesCommand.ExecuteReader();//Объявление ридера для вычисления суммы
                        sumCategoriesReader.Read();
                        categorySum[j] = sumCategoriesReader.GetString(0);
                        sumCategoriesCommand.Parameters.Clear();
                        sumCategoriesCommand.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = User.applicationUser.id;
                        DB.closeConnection();
                    }
                    expencesChart.Series["expences"].IsValueShownAsLabel = true;

                for (int i = 0; i < numberOfCategories; i++)
                    {
                    if (categorySum[i].Contains(",")) // Проверка на вещественное число
                    {
                        string[] buf = categorySum[i].Split(new char[] { ',' });
                        string correctSum = String.Concat(buf[0], '.', buf[1]);
                        expencesChart.Series["expences"].Points.AddXY(categories[i], correctSum); //Ввод корректного числа в диаграмму
                    }
                    else
                        expencesChart.Series["expences"].Points.AddXY(categories[i],categorySum[i]);
                    }
            }
        }


        private void incomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();//Обращемся к текущему окну и скрываем его
            IncomeForm IF = new IncomeForm();
            IF.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void expencesButton_Click(object sender, EventArgs e)
        {
            this.Hide();//Обращемся к текущему окну и скрываем его
            ExpenceForm EF = new ExpenceForm();
            EF.Show();
        }

        private void backToLoginFromMenu_Click(object sender, EventArgs e)
        {
            this.Hide();//Обращемся к текущему окну и скрываем его
            LoginForm LF = new LoginForm();
            LF.Show();
        }

        private void walletsButton_Click(object sender, EventArgs e)
        {
            this.Hide();//Обращемся к текущему окну и скрываем его
            WalletForm WF = new WalletForm();
            WF.Show();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            this.Hide();//Обращемся к текущему окну и скрываем его
            StatisticsForm SF = new StatisticsForm();
            SF.Show();
        }

        private void backToLoginFromMenu_MouseEnter(object sender, EventArgs e)
        {
            backToLoginFromMenu.ForeColor = Color.Black;
        }

        private void backToLoginFromMenu_MouseLeave(object sender, EventArgs e)
        {
            backToLoginFromMenu.ForeColor = Color.Gray;
        }
    }
}
