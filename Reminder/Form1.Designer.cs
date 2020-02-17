namespace Reminder
{
    partial class mainform
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
            this.repeatit = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.alarmsets = new System.Windows.Forms.DateTimePicker();
            this.alname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aldescr = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ե՞րբ";
            // 
            // repeatit
            // 
            this.repeatit.AutoSize = true;
            this.repeatit.Location = new System.Drawing.Point(260, 22);
            this.repeatit.Name = "repeatit";
            this.repeatit.Size = new System.Drawing.Size(59, 17);
            this.repeatit.TabIndex = 3;
            this.repeatit.Text = "կրկնել";
            this.repeatit.UseVisualStyleBackColor = true;
            this.repeatit.CheckedChanged += new System.EventHandler(this.repeatit_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ստեղծել";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alarmsets
            // 
            this.alarmsets.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.alarmsets.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.alarmsets.Location = new System.Drawing.Point(49, 20);
            this.alarmsets.Name = "alarmsets";
            this.alarmsets.Size = new System.Drawing.Size(177, 20);
            this.alarmsets.TabIndex = 5;
            this.alarmsets.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // alname
            // 
            this.alname.Location = new System.Drawing.Point(49, 60);
            this.alname.Name = "alname";
            this.alname.Size = new System.Drawing.Size(100, 20);
            this.alname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Անուն";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ավել";
            // 
            // aldescr
            // 
            this.aldescr.Location = new System.Drawing.Point(49, 86);
            this.aldescr.Name = "aldescr";
            this.aldescr.Size = new System.Drawing.Size(100, 20);
            this.aldescr.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Երգ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 132);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aldescr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alname);
            this.Controls.Add(this.alarmsets);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.repeatit);
            this.Controls.Add(this.label1);
            this.Name = "mainform";
            this.Text = "Զարթուցիչ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox repeatit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker alarmsets;
        private System.Windows.Forms.TextBox alname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aldescr;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}

