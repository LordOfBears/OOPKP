using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace PlaningTasks
{
    public partial class Form1 : Form
    {
        //Инициализация
        public Form1()
        {
            InitializeComponent();
        }

        bool areSeting = false;
        int countTasks = 0;
        List<Task> tasks = new List<Task>();
        DataTable table = new DataTable();
        private SqlConnection sqlConnection = null;

        //Обработчики событий
        private void addButton_Click(object sender, EventArgs e)
        {
            string taskNameStr = taskName.Text;
            string taskDescriptionStr = taskDescription.Text;
            DateTime deadLine = dateTimePicker.Value.Date;
            int status = CheckStatus();

            if (taskNameStr != "")
            {
                string deadLine_date = Convert.ToString(deadLine.Month + "/" + deadLine.Day + "/" + deadLine.Year);
                SqlCommand insert_command = new SqlCommand(
                    $"INSERT INTO [Tasks] (TaskName, TaskDescription, TaskDeadLine, TaskStatus) VALUES (N'{taskNameStr}', N'{taskDescriptionStr}', '{deadLine_date}', {status})", sqlConnection);

                insert_command.ExecuteNonQuery();

                tasks.Add(new Task(taskNameStr, taskDescriptionStr, deadLine, status));
                countTasks++;

                TaskHandler.SortTasksByDate(tasks);
                DisplayTable(tasks);

                taskName.Clear();
                taskDescription.Clear();
                checkStatus.Checked = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TaskDB"].ConnectionString);
            sqlConnection.Open();

            SqlCommand select_command = new SqlCommand(
                "SELECT * FROM [Tasks]", sqlConnection);

            SqlDataReader dataReader = null;
            try
            {
                dataReader = select_command.ExecuteReader();

                while (dataReader.Read())
                {
                    string date_value = Convert.ToString(dataReader["TaskDeadLine"]);
                    string date_t_value = "";

                    date_t_value += date_value[3];
                    date_t_value += date_value[4];
                    date_t_value += date_value[2];
                    date_t_value += date_value[0];
                    date_t_value += date_value[1];
                    date_t_value += date_value[5];
                    date_t_value += date_value[6];
                    date_t_value += date_value[7];
                    date_t_value += date_value[8];
                    date_t_value += date_value[9];

                    DateTime deadLine_date = Convert.ToDateTime(date_t_value);

                    tasks.Add(new Task(Convert.ToString(dataReader["TaskName"]),
                        Convert.ToString(dataReader["TaskDescription"]),
                        deadLine_date,
                        Convert.ToInt32(dataReader["TaskStatus"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }


            table.Columns.Add("Название задачи", typeof(string));
            table.Columns.Add("Описание задачи", typeof(string));
            table.Columns.Add("Крайняя дата", typeof(string));
            table.Columns.Add("Статус", typeof(string));

            taskList.DataSource = table;

            DisplayTable(tasks);

            dateTimePicker.MinDate = DateTime.Today;

            taskList.MultiSelect = false;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tasks.Count > 0)
            {
                int a = taskList.CurrentRow.Index;
                string name = taskList.Rows[a].Cells[0].Value.ToString();
                string description = taskList.Rows[a].Cells[1].Value.ToString();
                string deadLine = taskList.Rows[a].Cells[2].Value.ToString();

                SqlCommand delete_command = new SqlCommand(
                    $"DELETE [Tasks] WHERE TaskName = N'{name}' AND TaskDescription = N'{description}'", sqlConnection);

                delete_command.ExecuteNonQuery();

                int index = -1;
                foreach (var item in tasks)
                {
                    index++;
                    if ((item.GetName() == name) && (item.GetDescription() == description) && (item.GetDeadLine().ToString("dd.MM.yyyy") == deadLine))
                    {
                        if (index == countTasks)
                        {
                            tasks.RemoveAt(index);
                            break;
                        }
                        else
                        {
                            for (int i = index; i < tasks.Count() - 1; i++)
                            {
                                int j = i + 1;
                                tasks[i].SetName(tasks[j].GetName());
                                tasks[i].SetDescription(tasks[j].GetDescription());
                                tasks[i].SetDeadLine(tasks[j].GetDeadLine());
                                tasks[i].SetStatus(tasks[j].GetStatus());
                            }
                            tasks.RemoveAt(tasks.Count() - 1);
                            break;
                        }
                    }
                }
                taskList.Rows.Remove(taskList.Rows[a]);
            }
        }
        private void setButton_Click(object sender, EventArgs e)
        {
            if (tasks.Count > 0)
            {
                int a = taskList.CurrentRow.Index;

                string taskNameStr = taskList.Rows[a].Cells[0].Value.ToString();
                string taskDescriptionStr = taskList.Rows[a].Cells[1].Value.ToString();

                int index = TaskHandler.FindIndexTask(tasks, taskNameStr, taskDescriptionStr);

                if (!areSeting)
                {
                    if (tasks[index].GetStatus() == 0)
                        checkStatus.Checked = true;
                    taskName.Text = taskNameStr;
                    taskDescription.Text = taskDescriptionStr;

                    areSeting = true;

                    setButton.Text = "Сохранить изменения";
                }
                else
                {
                    taskNameStr = taskName.Text;
                    taskDescriptionStr = taskDescription.Text;
                    DateTime deadLine = dateTimePicker.Value.Date;

                    tasks[index].SetName(taskNameStr);
                    tasks[index].SetDescription(taskDescriptionStr);
                    tasks[index].SetDeadLine(deadLine);
                    tasks[index].SetStatus(CheckStatus());

                    string deadLine_date = Convert.ToString(deadLine.Month + "/" + deadLine.Day + "/" + deadLine.Year);

                    SqlCommand update_command = new SqlCommand(
                    $"UPDATE [Tasks] SET TaskName = N'{taskNameStr}', TaskDescription = N'{taskDescriptionStr}', TaskDeadLine = '{deadLine_date}', TaskStatus = {CheckStatus()}", sqlConnection);

                    update_command.ExecuteNonQuery();

                    taskList.Rows.Remove(taskList.Rows[a]);
                    TaskHandler.SortTasksByDate(tasks);
                    DisplayTable(tasks);
                    areSeting = false;

                    taskName.Clear();
                    taskDescription.Clear();
                    checkStatus.Checked = false;

                    setButton.Text = "Изменить";
                }
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            listLabel.Text = String.Format("Список задач на {0}", monthCalendar1.SelectionStart.ToString("dd.MM.yyyy"));
            List<Task> todayTasks = TaskHandler.FindTasksByDate(tasks, monthCalendar1.SelectionStart);
            DisplayTable(todayTasks);
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            listLabel.Text = "Список задач";
            DisplayTable(tasks);
        }

        //Методы для работы с формой
        private void DisplayTable(List<Task> list)
        {
            table.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string statusStr = "";
                
                switch (list[i].GetStatus())
                {
                    case 0:
                        statusStr += "Выполнено";
                        break;
                    case 1:
                        if (list[i].GetDeadLine().CompareTo(DateTime.Today) < 0)
                            statusStr += "Не выполнено";
                        else
                            statusStr += "В процессе";
                        break;
                }
                table.Rows.Add(list[i].GetName(), list[i].GetDescription(), list[i].GetDeadLine().ToString("dd.MM.yyyy"), statusStr);
                if (statusStr == "Выполнено")
                {
                    for (int j = 0; j < 4; j++)
                        taskList.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.LightGreen;
                }
                if (statusStr == "Не выполнено")
                {
                    for (int j = 0; j < 4; j++)
                        taskList.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Pink;
                }
            }
        }
        private int CheckStatus()
        {
            if (checkStatus.Checked)
                return 0;
            else
                return 1;
        }
    }
}