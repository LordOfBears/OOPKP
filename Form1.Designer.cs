namespace PlaningTasks
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.taskList = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.taskName = new System.Windows.Forms.TextBox();
            this.taskDescription = new System.Windows.Forms.TextBox();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listLabel = new System.Windows.Forms.Label();
            this.setButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.checkStatus = new System.Windows.Forms.CheckBox();
            this.showButton = new System.Windows.Forms.Button();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.taskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // taskList
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.taskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taskList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.taskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskList.DefaultCellStyle = dataGridViewCellStyle8;
            this.taskList.Location = new System.Drawing.Point(12, 44);
            this.taskList.Name = "taskList";
            this.taskList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.taskList.RowTemplate.Height = 50;
            this.taskList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.taskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskList.Size = new System.Drawing.Size(561, 435);
            this.taskList.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(390, 485);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(183, 59);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // taskName
            // 
            this.taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskName.Location = new System.Drawing.Point(755, 103);
            this.taskName.Multiline = true;
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(262, 70);
            this.taskName.TabIndex = 2;
            // 
            // taskDescription
            // 
            this.taskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskDescription.Location = new System.Drawing.Point(755, 203);
            this.taskDescription.Multiline = true;
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(262, 276);
            this.taskDescription.TabIndex = 3;
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskName.Location = new System.Drawing.Point(800, 76);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(165, 24);
            this.labelTaskName.TabIndex = 4;
            this.labelTaskName.Text = "Название задачи";
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskDescription.Location = new System.Drawing.Point(800, 176);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(168, 24);
            this.labelTaskDescription.TabIndex = 5;
            this.labelTaskDescription.Text = "Описание задачи";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(755, 44);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(262, 29);
            this.dateTimePicker.TabIndex = 6;
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listLabel.Location = new System.Drawing.Point(226, 17);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(132, 24);
            this.listLabel.TabIndex = 7;
            this.listLabel.Text = "Список задач";
            // 
            // setButton
            // 
            this.setButton.BackColor = System.Drawing.Color.White;
            this.setButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setButton.Location = new System.Drawing.Point(201, 485);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(183, 59);
            this.setButton.TabIndex = 8;
            this.setButton.Text = "Изменить";
            this.setButton.UseVisualStyleBackColor = false;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(12, 485);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(183, 59);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(579, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(814, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Крайняя дата";
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkStatus.Location = new System.Drawing.Point(757, 485);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(208, 28);
            this.checkStatus.TabIndex = 12;
            this.checkStatus.Text = "Задача выполнена?";
            this.checkStatus.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.White;
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.Location = new System.Drawing.Point(579, 485);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(164, 59);
            this.showButton.TabIndex = 13;
            this.showButton.Text = "Показать полный список";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 556);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.checkStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelTaskDescription);
            this.Controls.Add(this.labelTaskName);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.taskName);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.taskList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView taskList;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox taskName;
        private System.Windows.Forms.TextBox taskDescription;
        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkStatus;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.BindingSource tasksBindingSource;
    }
}

