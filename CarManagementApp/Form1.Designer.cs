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
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.btnShowCarInfo = new System.Windows.Forms.Button();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCarPower = new System.Windows.Forms.TextBox();
            this.btnMoveCar = new System.Windows.Forms.Button();
            this.btnRefuelCar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFuelConsumption = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStopEngine = new System.Windows.Forms.Button();
            this.labelDistance = new System.Windows.Forms.Label();
            this.textBoxFuelTankCapacity = new System.Windows.Forms.TextBox();
            this.textBoxRefuelAmount = new System.Windows.Forms.TextBox();
            this.labelFuelTankCapacity = new System.Windows.Forms.Label();
            this.labelRefuelAmount = new System.Windows.Forms.Label();
            this.textBoxMoveDistance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите название авто:";
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(3, 4);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(126, 46);
            this.btnCreateCar.TabIndex = 4;
            this.btnCreateCar.Text = "Создать авто";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // btnStartEngine
            // 
            this.btnStartEngine.Location = new System.Drawing.Point(3, 248);
            this.btnStartEngine.Name = "btnStartEngine";
            this.btnStartEngine.Size = new System.Drawing.Size(126, 29);
            this.btnStartEngine.TabIndex = 5;
            this.btnStartEngine.Text = "Запустить двигатель";
            this.btnStartEngine.UseVisualStyleBackColor = true;
            this.btnStartEngine.Click += new System.EventHandler(this.btnStartEngine_Click);
            // 
            // btnReplaceWheel
            // 
            this.btnReplaceWheel.Location = new System.Drawing.Point(3, 324);
            this.btnReplaceWheel.Name = "btnReplaceWheel";
            this.btnReplaceWheel.Size = new System.Drawing.Size(126, 23);
            this.btnReplaceWheel.TabIndex = 6;
            this.btnReplaceWheel.Text = "Заменить колесо";
            this.btnReplaceWheel.UseVisualStyleBackColor = true;
            this.btnReplaceWheel.Click += new System.EventHandler(this.btnReplaceWheel_Click);
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Location = new System.Drawing.Point(270, 6);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.Size = new System.Drawing.Size(133, 20);
            this.textBoxCarName.TabIndex = 7;
            // 
            // listBoxActions
            // 
            this.listBoxActions.FormattingEnabled = true;
            this.listBoxActions.Location = new System.Drawing.Point(190, 222);
            this.listBoxActions.Name = "listBoxActions";
            this.listBoxActions.Size = new System.Drawing.Size(172, 160);
            this.listBoxActions.TabIndex = 8;
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Location = new System.Drawing.Point(3, 56);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(126, 46);
            this.btnRemoveCar.TabIndex = 10;
            this.btnRemoveCar.Text = "Удалить авто";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // btnShowCarInfo
            // 
            this.btnShowCarInfo.Location = new System.Drawing.Point(3, 353);
            this.btnShowCarInfo.Name = "btnShowCarInfo";
            this.btnShowCarInfo.Size = new System.Drawing.Size(126, 46);
            this.btnShowCarInfo.TabIndex = 11;
            this.btnShowCarInfo.Text = "Показать информацию";
            this.btnShowCarInfo.UseVisualStyleBackColor = true;
            this.btnShowCarInfo.Click += new System.EventHandler(this.btnShowCarInfo_Click);
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(3, 108);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(126, 121);
            this.listBoxCars.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Выберите действие с авто";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCarPower
            // 
            this.textBoxCarPower.Location = new System.Drawing.Point(270, 32);
            this.textBoxCarPower.Name = "textBoxCarPower";
            this.textBoxCarPower.Size = new System.Drawing.Size(133, 20);
            this.textBoxCarPower.TabIndex = 14;
            // 
            // btnMoveCar
            // 
            this.btnMoveCar.Location = new System.Drawing.Point(599, 170);
            this.btnMoveCar.Name = "btnMoveCar";
            this.btnMoveCar.Size = new System.Drawing.Size(133, 46);
            this.btnMoveCar.TabIndex = 15;
            this.btnMoveCar.Text = "Передвижение";
            this.btnMoveCar.UseVisualStyleBackColor = true;
            this.btnMoveCar.Click += new System.EventHandler(this.btnMoveCar_Click);
            // 
            // btnRefuelCar
            // 
            this.btnRefuelCar.Location = new System.Drawing.Point(595, 56);
            this.btnRefuelCar.Name = "btnRefuelCar";
            this.btnRefuelCar.Size = new System.Drawing.Size(133, 46);
            this.btnRefuelCar.TabIndex = 16;
            this.btnRefuelCar.Text = "Заправка";
            this.btnRefuelCar.UseVisualStyleBackColor = true;
            this.btnRefuelCar.Click += new System.EventHandler(this.btnRefuelCar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Введите мощность авто:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxFuelConsumption
            // 
            this.textBoxFuelConsumption.Location = new System.Drawing.Point(298, 84);
            this.textBoxFuelConsumption.Name = "textBoxFuelConsumption";
            this.textBoxFuelConsumption.Size = new System.Drawing.Size(105, 20);
            this.textBoxFuelConsumption.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Введите расход авто на 100км:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnStopEngine
            // 
            this.btnStopEngine.Location = new System.Drawing.Point(3, 283);
            this.btnStopEngine.Name = "btnStopEngine";
            this.btnStopEngine.Size = new System.Drawing.Size(126, 35);
            this.btnStopEngine.TabIndex = 20;
            this.btnStopEngine.Text = "Выключить двигатель";
            this.btnStopEngine.UseVisualStyleBackColor = true;
            this.btnStopEngine.Click += new System.EventHandler(this.btnStopEngine_Click);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(595, 125);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(137, 13);
            this.labelDistance.TabIndex = 22;
            this.labelDistance.Text = "Введите расстояние (км):";
            // 
            // textBoxFuelTankCapacity
            // 
            this.textBoxFuelTankCapacity.Location = new System.Drawing.Point(270, 58);
            this.textBoxFuelTankCapacity.Name = "textBoxFuelTankCapacity";
            this.textBoxFuelTankCapacity.Size = new System.Drawing.Size(133, 20);
            this.textBoxFuelTankCapacity.TabIndex = 23;
            // 
            // textBoxRefuelAmount
            // 
            this.textBoxRefuelAmount.Location = new System.Drawing.Point(595, 30);
            this.textBoxRefuelAmount.Name = "textBoxRefuelAmount";
            this.textBoxRefuelAmount.Size = new System.Drawing.Size(133, 20);
            this.textBoxRefuelAmount.TabIndex = 24;
            // 
            // labelFuelTankCapacity
            // 
            this.labelFuelTankCapacity.AutoSize = true;
            this.labelFuelTankCapacity.Location = new System.Drawing.Point(135, 61);
            this.labelFuelTankCapacity.Name = "labelFuelTankCapacity";
            this.labelFuelTankCapacity.Size = new System.Drawing.Size(133, 13);
            this.labelFuelTankCapacity.TabIndex = 25;
            this.labelFuelTankCapacity.Text = "Объем топливного бака:";
            // 
            // labelRefuelAmount
            // 
            this.labelRefuelAmount.AutoSize = true;
            this.labelRefuelAmount.Location = new System.Drawing.Point(595, 14);
            this.labelRefuelAmount.Name = "labelRefuelAmount";
            this.labelRefuelAmount.Size = new System.Drawing.Size(120, 13);
            this.labelRefuelAmount.TabIndex = 26;
            this.labelRefuelAmount.Text = "Количество заправки:";
            // 
            // textBoxMoveDistance
            // 
            this.textBoxMoveDistance.Location = new System.Drawing.Point(598, 144);
            this.textBoxMoveDistance.Name = "textBoxMoveDistance";
            this.textBoxMoveDistance.Size = new System.Drawing.Size(133, 20);
            this.textBoxMoveDistance.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMoveDistance);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.btnStopEngine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFuelConsumption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRefuelCar);
            this.Controls.Add(this.btnMoveCar);
            this.Controls.Add(this.textBoxCarPower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.btnShowCarInfo);
            this.Controls.Add(this.btnRemoveCar);
            this.Controls.Add(this.listBoxActions);
            this.Controls.Add(this.textBoxCarName);
            this.Controls.Add(this.btnReplaceWheel);
            this.Controls.Add(this.btnStartEngine);
            this.Controls.Add(this.btnCreateCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFuelTankCapacity);
            this.Controls.Add(this.textBoxRefuelAmount);
            this.Controls.Add(this.labelFuelTankCapacity);
            this.Controls.Add(this.labelRefuelAmount);
            this.Name = "Form1";
            this.Text = "Car Management";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.Button btnShowCarInfo;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCarPower;
        private System.Windows.Forms.Button btnMoveCar;
        private System.Windows.Forms.Button btnRefuelCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFuelConsumption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStopEngine;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.TextBox textBoxFuelTankCapacity;
        private System.Windows.Forms.TextBox textBoxRefuelAmount;
        private System.Windows.Forms.Label labelFuelTankCapacity;
        private System.Windows.Forms.Label labelRefuelAmount;
        private System.Windows.Forms.TextBox textBoxMoveDistance;
    }
}
