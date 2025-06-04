namespace лаба_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBoxScenario = new System.Windows.Forms.TextBox();
            this.textBoxMontage = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxAgeRestriction = new System.Windows.Forms.TextBox();
            this.textBoxAudience = new System.Windows.Forms.TextBox();
            this.textBoxField = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelScenario = new System.Windows.Forms.Label();
            this.labelMontage = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelAgeRestriction = new System.Windows.Forms.Label();
            this.labelField = new System.Windows.Forms.Label();
            this.labelAudience = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(139, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите, какой фильм хотите создать";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(72, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Развлекательный";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(473, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Научный";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBoxScenario
            // 
            this.textBoxScenario.Location = new System.Drawing.Point(273, 178);
            this.textBoxScenario.Name = "textBoxScenario";
            this.textBoxScenario.Size = new System.Drawing.Size(235, 22);
            this.textBoxScenario.TabIndex = 3;
            // 
            // textBoxMontage
            // 
            this.textBoxMontage.Location = new System.Drawing.Point(273, 241);
            this.textBoxMontage.Name = "textBoxMontage";
            this.textBoxMontage.Size = new System.Drawing.Size(235, 22);
            this.textBoxMontage.TabIndex = 4;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(273, 307);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(235, 22);
            this.textBoxType.TabIndex = 5;
            // 
            // textBoxAgeRestriction
            // 
            this.textBoxAgeRestriction.Location = new System.Drawing.Point(273, 372);
            this.textBoxAgeRestriction.Name = "textBoxAgeRestriction";
            this.textBoxAgeRestriction.Size = new System.Drawing.Size(235, 22);
            this.textBoxAgeRestriction.TabIndex = 6;
            // 
            // textBoxAudience
            // 
            this.textBoxAudience.Location = new System.Drawing.Point(273, 372);
            this.textBoxAudience.Name = "textBoxAudience";
            this.textBoxAudience.Size = new System.Drawing.Size(235, 22);
            this.textBoxAudience.TabIndex = 10;
            // 
            // textBoxField
            // 
            this.textBoxField.Location = new System.Drawing.Point(273, 307);
            this.textBoxField.Name = "textBoxField";
            this.textBoxField.Size = new System.Drawing.Size(235, 22);
            this.textBoxField.TabIndex = 9;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(116, 425);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(238, 48);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "Создать фильм";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelScenario
            // 
            this.labelScenario.AutoSize = true;
            this.labelScenario.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScenario.Location = new System.Drawing.Point(299, 151);
            this.labelScenario.Name = "labelScenario";
            this.labelScenario.Size = new System.Drawing.Size(194, 24);
            this.labelScenario.TabIndex = 12;
            this.labelScenario.Text = "Введите сценариста:";
            // 
            // labelMontage
            // 
            this.labelMontage.AutoSize = true;
            this.labelMontage.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMontage.Location = new System.Drawing.Point(255, 214);
            this.labelMontage.Name = "labelMontage";
            this.labelMontage.Size = new System.Drawing.Size(273, 24);
            this.labelMontage.TabIndex = 13;
            this.labelMontage.Text = "Введите режиссёра монтажа:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(299, 280);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(189, 24);
            this.labelType.TabIndex = 14;
            this.labelType.Text = "Введите тип (жанр):";
            // 
            // labelAgeRestriction
            // 
            this.labelAgeRestriction.AutoSize = true;
            this.labelAgeRestriction.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAgeRestriction.Location = new System.Drawing.Point(236, 345);
            this.labelAgeRestriction.Name = "labelAgeRestriction";
            this.labelAgeRestriction.Size = new System.Drawing.Size(313, 24);
            this.labelAgeRestriction.TabIndex = 15;
            this.labelAgeRestriction.Text = "Введите возрастное ограничение:";
            // 
            // labelField
            // 
            this.labelField.AutoSize = true;
            this.labelField.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelField.Location = new System.Drawing.Point(269, 280);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(247, 24);
            this.labelField.TabIndex = 16;
            this.labelField.Text = "Введите научную область:";
            // 
            // labelAudience
            // 
            this.labelAudience.AutoSize = true;
            this.labelAudience.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAudience.Location = new System.Drawing.Point(296, 345);
            this.labelAudience.Name = "labelAudience";
            this.labelAudience.Size = new System.Drawing.Size(192, 24);
            this.labelAudience.TabIndex = 17;
            this.labelAudience.Text = "Введите аудиторию:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(438, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 48);
            this.button3.TabIndex = 18;
            this.button3.Text = "Не создавать фильм";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 499);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelAudience);
            this.Controls.Add(this.labelField);
            this.Controls.Add(this.labelAgeRestriction);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelMontage);
            this.Controls.Add(this.labelScenario);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxAudience);
            this.Controls.Add(this.textBoxField);
            this.Controls.Add(this.textBoxAgeRestriction);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxMontage);
            this.Controls.Add(this.textBoxScenario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Фильмы";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxAudience;
        private System.Windows.Forms.TextBox textBoxField;
        private System.Windows.Forms.TextBox textBoxAgeRestriction;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxMontage;
        private System.Windows.Forms.TextBox textBoxScenario;
        private System.Windows.Forms.Label labelAgeRestriction;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelMontage;
        private System.Windows.Forms.Label labelScenario;
        private System.Windows.Forms.Label labelAudience;
        private System.Windows.Forms.Label labelField;
        private System.Windows.Forms.Button button3;
    }
}

