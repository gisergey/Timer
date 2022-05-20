
namespace Timer
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
            this.ActiveTimer = new System.Windows.Forms.Timer(this.components);
            this.LabelHour = new System.Windows.Forms.Label();
            this.LabelMinute = new System.Windows.Forms.Label();
            this.LabelSecond = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelhou = new System.Windows.Forms.Label();
            this.labelmin = new System.Windows.Forms.Label();
            this.labelsec = new System.Windows.Forms.Label();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.NOButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActiveTimer
            // 
            this.ActiveTimer.Interval = 1000;
            this.ActiveTimer.Tick += new System.EventHandler(this.ActiveTimer_Tick);
            // 
            // LabelHour
            // 
            this.LabelHour.AutoSize = true;
            this.LabelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHour.Location = new System.Drawing.Point(89, 56);
            this.LabelHour.Name = "LabelHour";
            this.LabelHour.Size = new System.Drawing.Size(96, 69);
            this.LabelHour.TabIndex = 0;
            this.LabelHour.Text = "00";
            // 
            // LabelMinute
            // 
            this.LabelMinute.AutoSize = true;
            this.LabelMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMinute.Location = new System.Drawing.Point(244, 56);
            this.LabelMinute.Name = "LabelMinute";
            this.LabelMinute.Size = new System.Drawing.Size(96, 69);
            this.LabelMinute.TabIndex = 1;
            this.LabelMinute.Text = "00";
            // 
            // LabelSecond
            // 
            this.LabelSecond.AutoSize = true;
            this.LabelSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSecond.Location = new System.Drawing.Point(399, 56);
            this.LabelSecond.Name = "LabelSecond";
            this.LabelSecond.Size = new System.Drawing.Size(96, 69);
            this.LabelSecond.TabIndex = 2;
            this.LabelSecond.Text = "00";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(24, 269);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(322, 101);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(191, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(346, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 69);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // labelhou
            // 
            this.labelhou.AutoSize = true;
            this.labelhou.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelhou.Location = new System.Drawing.Point(57, 79);
            this.labelhou.Name = "labelhou";
            this.labelhou.Size = new System.Drawing.Size(168, 69);
            this.labelhou.TabIndex = 6;
            this.labelhou.Text = "часы";
            // 
            // labelmin
            // 
            this.labelmin.AutoSize = true;
            this.labelmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmin.Location = new System.Drawing.Point(276, 79);
            this.labelmin.Name = "labelmin";
            this.labelmin.Size = new System.Drawing.Size(240, 69);
            this.labelmin.TabIndex = 7;
            this.labelmin.Text = "минуты";
            // 
            // labelsec
            // 
            this.labelsec.AutoSize = true;
            this.labelsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelsec.Location = new System.Drawing.Point(524, 79);
            this.labelsec.Name = "labelsec";
            this.labelsec.Size = new System.Drawing.Size(264, 69);
            this.labelsec.TabIndex = 8;
            this.labelsec.Text = "секунды";
            this.labelsec.Click += new System.EventHandler(this.labelsec_Click);
            // 
            // textBoxHour
            // 
            this.textBoxHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHour.Location = new System.Drawing.Point(69, 163);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(138, 75);
            this.textBoxHour.TabIndex = 9;
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMinute.Location = new System.Drawing.Point(326, 163);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(138, 75);
            this.textBoxMinute.TabIndex = 10;
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecond.Location = new System.Drawing.Point(557, 163);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(138, 75);
            this.textBoxSecond.TabIndex = 11;
            // 
            // NOButton
            // 
            this.NOButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NOButton.Location = new System.Drawing.Point(394, 269);
            this.NOButton.Name = "NOButton";
            this.NOButton.Size = new System.Drawing.Size(322, 101);
            this.NOButton.TabIndex = 12;
            this.NOButton.Text = "Отмена";
            this.NOButton.UseVisualStyleBackColor = true;
            this.NOButton.Click += new System.EventHandler(this.NObutton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(24, 295);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(322, 101);
            this.StopButton.TabIndex = 13;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.NOButton);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.textBoxMinute);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.labelsec);
            this.Controls.Add(this.labelmin);
            this.Controls.Add(this.labelhou);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LabelSecond);
            this.Controls.Add(this.LabelMinute);
            this.Controls.Add(this.LabelHour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ActiveTimer;
        private System.Windows.Forms.Label LabelHour;
        private System.Windows.Forms.Label LabelMinute;
        private System.Windows.Forms.Label LabelSecond;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelhou;
        private System.Windows.Forms.Label labelmin;
        private System.Windows.Forms.Label labelsec;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.Button NOButton;
        private System.Windows.Forms.Button StopButton;
    }
}

