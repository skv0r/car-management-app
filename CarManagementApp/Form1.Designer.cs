namespace CarManagementApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.btnStartEngine = new System.Windows.Forms.Button();
            this.btnReplaceWheel = new System.Windows.Forms.Button();
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.listBoxActions = new System.Windows.Forms.ListBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.btnShowCarInfo = new System.Windows.Forms.Button();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите название авто:";
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(294, 82);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(126, 46);
            this.btnCreateCar.TabIndex = 4;
            this.btnCreateCar.Text = "Создать авто";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // btnStartEngine
            // 
            this.btnStartEngine.Location = new System.Drawing.Point(294, 134);
            this.btnStartEngine.Name = "btnStartEngine";
            this.btnStartEngine.Size = new System.Drawing.Size(126, 29);
            this.btnStartEngine.TabIndex = 5;
            this.btnStartEngine.Text = "Запустить двигатель";
            this.btnStartEngine.UseVisualStyleBackColor = true;
            this.btnStartEngine.Click += new System.EventHandler(this.btnStartEngine_Click);
            // 
            // btnReplaceWheel
            // 
            this.btnReplaceWheel.Location = new System.Drawing.Point(294, 169);
            this.btnReplaceWheel.Name = "btnReplaceWheel";
            this.btnReplaceWheel.Size = new System.Drawing.Size(126, 31);
            this.btnReplaceWheel.TabIndex = 6;
            this.btnReplaceWheel.Text = "Заменить колесо";
            this.btnReplaceWheel.UseVisualStyleBackColor = true;
            this.btnReplaceWheel.Click += new System.EventHandler(this.btnReplaceWheel_Click);
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Location = new System.Drawing.Point(294, 56);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.Size = new System.Drawing.Size(126, 20);
            this.textBoxCarName.TabIndex = 7;
            // 
            // listBoxActions
            // 
            this.listBoxActions.FormattingEnabled = true;
            this.listBoxActions.Location = new System.Drawing.Point(294, 206);
            this.listBoxActions.Name = "listBoxActions";
            this.listBoxActions.Size = new System.Drawing.Size(126, 95);
            this.listBoxActions.TabIndex = 8;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(469, 82);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(115, 46);
            this.btnAddCar.TabIndex = 9;
            this.btnAddCar.Text = "Добавить авто";
            this.btnAddCar.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Location = new System.Drawing.Point(469, 134);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(115, 46);
            this.btnRemoveCar.TabIndex = 10;
            this.btnRemoveCar.Text = "Удалить авто";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // btnShowCarInfo
            // 
            this.btnShowCarInfo.Location = new System.Drawing.Point(469, 186);
            this.btnShowCarInfo.Name = "btnShowCarInfo";
            this.btnShowCarInfo.Size = new System.Drawing.Size(115, 46);
            this.btnShowCarInfo.TabIndex = 11;
            this.btnShowCarInfo.Text = "Показать информацию";
            this.btnShowCarInfo.UseVisualStyleBackColor = true;
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(469, 238);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(201, 95);
            this.listBoxCars.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.btnShowCarInfo);
            this.Controls.Add(this.btnRemoveCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.listBoxActions);
            this.Controls.Add(this.textBoxCarName);
            this.Controls.Add(this.btnReplaceWheel);
            this.Controls.Add(this.btnStartEngine);
            this.Controls.Add(this.btnCreateCar);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateCar;
        private System.Windows.Forms.Button btnStartEngine;
        private System.Windows.Forms.Button btnReplaceWheel;
        private System.Windows.Forms.TextBox textBoxCarName;
        private System.Windows.Forms.ListBox listBoxActions;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.Button btnShowCarInfo;
        private System.Windows.Forms.ListBox listBoxCars;
    }
}
