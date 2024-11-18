namespace CarManagementApp
{
    partial class Form1
    {
        /// <summary>
        /// Требуемая переменная для конструктора компонента.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">Истинно, если управляемые ресурсы должны быть удалены; иначе Ложь.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором Windows Forms

        private void InitializeComponent()
        {
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.textBoxHorsePower = new System.Windows.Forms.TextBox();
            this.textBoxFuelConsumption = new System.Windows.Forms.TextBox();
            this.textBoxFuelTankCapacity = new System.Windows.Forms.TextBox();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonRemoveCar = new System.Windows.Forms.Button();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.textBoxFuelAmount = new System.Windows.Forms.TextBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.buttonStartEngine = new System.Windows.Forms.Button();
            this.buttonStopEngine = new System.Windows.Forms.Button();
            this.buttonRefuel = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonReplaceWheel = new System.Windows.Forms.Button();
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.listBoxActions = new System.Windows.Forms.ListBox();
            this.labelCarName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFuelPerKm = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.checkBoxFastMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Location = new System.Drawing.Point(177, 12);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarName.TabIndex = 0;
            // 
            // textBoxHorsePower
            // 
            this.textBoxHorsePower.Location = new System.Drawing.Point(177, 38);
            this.textBoxHorsePower.Name = "textBoxHorsePower";
            this.textBoxHorsePower.Size = new System.Drawing.Size(100, 20);
            this.textBoxHorsePower.TabIndex = 1;
            // 
            // textBoxFuelConsumption
            // 
            this.textBoxFuelConsumption.Location = new System.Drawing.Point(177, 64);
            this.textBoxFuelConsumption.Name = "textBoxFuelConsumption";
            this.textBoxFuelConsumption.Size = new System.Drawing.Size(100, 20);
            this.textBoxFuelConsumption.TabIndex = 2;
            // 
            // textBoxFuelTankCapacity
            // 
            this.textBoxFuelTankCapacity.Location = new System.Drawing.Point(177, 90);
            this.textBoxFuelTankCapacity.Name = "textBoxFuelTankCapacity";
            this.textBoxFuelTankCapacity.Size = new System.Drawing.Size(100, 20);
            this.textBoxFuelTankCapacity.TabIndex = 3;
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(177, 116);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(100, 23);
            this.buttonAddCar.TabIndex = 4;
            this.buttonAddCar.Text = "Создать авто";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonRemoveCar
            // 
            this.buttonRemoveCar.Location = new System.Drawing.Point(177, 145);
            this.buttonRemoveCar.Name = "buttonRemoveCar";
            this.buttonRemoveCar.Size = new System.Drawing.Size(100, 23);
            this.buttonRemoveCar.TabIndex = 5;
            this.buttonRemoveCar.Text = "Удалить авто";
            this.buttonRemoveCar.UseVisualStyleBackColor = true;
            this.buttonRemoveCar.Click += new System.EventHandler(this.buttonRemoveCar_Click);
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.Location = new System.Drawing.Point(177, 174);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(100, 108);
            this.listBoxCars.TabIndex = 6;
            // 
            // textBoxFuelAmount
            // 
            this.textBoxFuelAmount.Location = new System.Drawing.Point(391, 12);
            this.textBoxFuelAmount.Name = "textBoxFuelAmount";
            this.textBoxFuelAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxFuelAmount.TabIndex = 7;
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(391, 41);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistance.TabIndex = 8;
            // 
            // buttonStartEngine
            // 
            this.buttonStartEngine.Location = new System.Drawing.Point(497, 67);
            this.buttonStartEngine.Name = "buttonStartEngine";
            this.buttonStartEngine.Size = new System.Drawing.Size(100, 23);
            this.buttonStartEngine.TabIndex = 9;
            this.buttonStartEngine.Text = "Запустить двигатель";
            this.buttonStartEngine.UseVisualStyleBackColor = true;
            this.buttonStartEngine.Click += new System.EventHandler(this.buttonStartEngine_Click);
            // 
            // buttonStopEngine
            // 
            this.buttonStopEngine.Location = new System.Drawing.Point(497, 96);
            this.buttonStopEngine.Name = "buttonStopEngine";
            this.buttonStopEngine.Size = new System.Drawing.Size(100, 23);
            this.buttonStopEngine.TabIndex = 10;
            this.buttonStopEngine.Text = "Выключить двигатель";
            this.buttonStopEngine.UseVisualStyleBackColor = true;
            this.buttonStopEngine.Click += new System.EventHandler(this.buttonStopEngine_Click);
            // 
            // buttonRefuel
            // 
            this.buttonRefuel.Location = new System.Drawing.Point(497, 9);
            this.buttonRefuel.Name = "buttonRefuel";
            this.buttonRefuel.Size = new System.Drawing.Size(100, 23);
            this.buttonRefuel.TabIndex = 11;
            this.buttonRefuel.Text = "Заправка";
            this.buttonRefuel.UseVisualStyleBackColor = true;
            this.buttonRefuel.Click += new System.EventHandler(this.buttonRefuel_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(497, 38);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(100, 23);
            this.buttonMove.TabIndex = 12;
            this.buttonMove.Text = "Передвижение";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonReplaceWheel
            // 
            this.buttonReplaceWheel.Location = new System.Drawing.Point(497, 125);
            this.buttonReplaceWheel.Name = "buttonReplaceWheel";
            this.buttonReplaceWheel.Size = new System.Drawing.Size(100, 23);
            this.buttonReplaceWheel.TabIndex = 13;
            this.buttonReplaceWheel.Text = "Заменить колесо";
            this.buttonReplaceWheel.UseVisualStyleBackColor = true;
            this.buttonReplaceWheel.Click += new System.EventHandler(this.buttonReplaceWheel_Click);
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Location = new System.Drawing.Point(177, 288);
            this.buttonShowInfo.Name = "buttonShowInfo";
            this.buttonShowInfo.Size = new System.Drawing.Size(100, 23);
            this.buttonShowInfo.TabIndex = 14;
            this.buttonShowInfo.Text = "Показать информацию";
            this.buttonShowInfo.UseVisualStyleBackColor = true;
            this.buttonShowInfo.Click += new System.EventHandler(this.buttonShowInfo_Click);
            // 
            // listBoxActions
            // 
            this.listBoxActions.FormattingEnabled = true;
            this.listBoxActions.Location = new System.Drawing.Point(283, 64);
            this.listBoxActions.Name = "listBoxActions";
            this.listBoxActions.Size = new System.Drawing.Size(208, 251);
            this.listBoxActions.TabIndex = 15;
            // 
            // labelCarName
            // 
            this.labelCarName.AutoSize = true;
            this.labelCarName.Location = new System.Drawing.Point(52, 19);
            this.labelCarName.Name = "labelCarName";
            this.labelCarName.Size = new System.Drawing.Size(101, 13);
            this.labelCarName.TabIndex = 16;
            this.labelCarName.Text = "Введите имя авто:";
            this.labelCarName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Введите мощность  авто:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelFuelPerKm
            // 
            this.labelFuelPerKm.AutoSize = true;
            this.labelFuelPerKm.Location = new System.Drawing.Point(52, 72);
            this.labelFuelPerKm.Name = "labelFuelPerKm";
            this.labelFuelPerKm.Size = new System.Drawing.Size(119, 13);
            this.labelFuelPerKm.TabIndex = 18;
            this.labelFuelPerKm.Text = "Введите  расход авто:";
            this.labelFuelPerKm.Click += new System.EventHandler(this.labelFuelPerKm_Click);
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(52, 97);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(102, 13);
            this.labelFuel.TabIndex = 19;
            this.labelFuel.Text = "Введите  бак авто:";
            this.labelFuel.Click += new System.EventHandler(this.labelFuel_Click);
            // 
            // checkBoxFastMode
            // 
            this.checkBoxFastMode.AutoSize = true;
            this.checkBoxFastMode.Location = new System.Drawing.Point(603, 43);
            this.checkBoxFastMode.Name = "checkBoxFastMode";
            this.checkBoxFastMode.Size = new System.Drawing.Size(121, 17);
            this.checkBoxFastMode.TabIndex = 20;
            this.checkBoxFastMode.Text = "Высокая скорость";
            this.checkBoxFastMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(903, 467);
            this.Controls.Add(this.checkBoxFastMode);
            this.Controls.Add(this.labelFuel);
            this.Controls.Add(this.labelFuelPerKm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCarName);
            this.Controls.Add(this.listBoxActions);
            this.Controls.Add(this.buttonShowInfo);
            this.Controls.Add(this.buttonReplaceWheel);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonRefuel);
            this.Controls.Add(this.buttonStopEngine);
            this.Controls.Add(this.buttonStartEngine);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.textBoxFuelAmount);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.buttonRemoveCar);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.textBoxFuelTankCapacity);
            this.Controls.Add(this.textBoxFuelConsumption);
            this.Controls.Add(this.textBoxHorsePower);
            this.Controls.Add(this.textBoxCarName);
            this.Name = "Form1";
            this.Text = "Car Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCarName;
        private System.Windows.Forms.TextBox textBoxHorsePower;
        private System.Windows.Forms.TextBox textBoxFuelConsumption;
        private System.Windows.Forms.TextBox textBoxFuelTankCapacity;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonRemoveCar;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.TextBox textBoxFuelAmount;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Button buttonStartEngine;
        private System.Windows.Forms.Button buttonStopEngine;
        private System.Windows.Forms.Button buttonRefuel;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonReplaceWheel;
        private System.Windows.Forms.Button buttonShowInfo;
        private System.Windows.Forms.ListBox listBoxActions;
        private System.Windows.Forms.Label labelCarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFuelPerKm;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.CheckBox checkBoxFastMode;
    }
}
