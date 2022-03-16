
namespace Laba2
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_maxTimeCooking = new System.Windows.Forms.TextBox();
            this.ClientLeftBtn = new System.Windows.Forms.Button();
            this.ClientRightBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Res1Kitchen1 = new System.Windows.Forms.TextBox();
            this.tb_Res1Kitchen2 = new System.Windows.Forms.TextBox();
            this.tb_Res1Kitchen3 = new System.Windows.Forms.TextBox();
            this.tb_Res1Kitchen4 = new System.Windows.Forms.TextBox();
            this.label_WorkloadRes1Kitchen4 = new System.Windows.Forms.Label();
            this.label_WorkloadRes1Kitchen3 = new System.Windows.Forms.Label();
            this.label_WorkloadRes1Kitchen2 = new System.Windows.Forms.Label();
            this.label_WorkloadRes1Kitchen1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Res2Kitchen1 = new System.Windows.Forms.TextBox();
            this.label_WorkloadRes2Kitchen4 = new System.Windows.Forms.Label();
            this.tb_Res2Kitchen2 = new System.Windows.Forms.TextBox();
            this.label_WorkloadRes2Kitchen3 = new System.Windows.Forms.Label();
            this.tb_Res2Kitchen3 = new System.Windows.Forms.TextBox();
            this.label_WorkloadRes2Kitchen2 = new System.Windows.Forms.Label();
            this.tb_Res2Kitchen4 = new System.Windows.Forms.TextBox();
            this.label_WorkloadRes2Kitchen1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.rtb_Res1 = new System.Windows.Forms.RichTextBox();
            this.rtb_Res2 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Incost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "БИСТРО-ЕДА";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "МАКСИМАЛЬНОЕ ВРЕМЯ ГОТОВКИ";
            // 
            // tb_maxTimeCooking
            // 
            this.tb_maxTimeCooking.Location = new System.Drawing.Point(347, 413);
            this.tb_maxTimeCooking.Name = "tb_maxTimeCooking";
            this.tb_maxTimeCooking.Size = new System.Drawing.Size(100, 20);
            this.tb_maxTimeCooking.TabIndex = 2;
            this.tb_maxTimeCooking.Text = "10";
            // 
            // ClientLeftBtn
            // 
            this.ClientLeftBtn.Location = new System.Drawing.Point(12, 392);
            this.ClientLeftBtn.Name = "ClientLeftBtn";
            this.ClientLeftBtn.Size = new System.Drawing.Size(154, 46);
            this.ClientLeftBtn.TabIndex = 5;
            this.ClientLeftBtn.Text = "Клиент";
            this.ClientLeftBtn.UseVisualStyleBackColor = true;
            this.ClientLeftBtn.Click += new System.EventHandler(this.ClientLeftBtn_Click);
            // 
            // ClientRightBtn
            // 
            this.ClientRightBtn.Location = new System.Drawing.Point(632, 392);
            this.ClientRightBtn.Name = "ClientRightBtn";
            this.ClientRightBtn.Size = new System.Drawing.Size(154, 46);
            this.ClientRightBtn.TabIndex = 6;
            this.ClientRightBtn.Text = "Клиент";
            this.ClientRightBtn.UseVisualStyleBackColor = true;
            this.ClientRightBtn.Click += new System.EventHandler(this.ClientRightBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Кухня 1 (Бургеры)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Кухня 2 (Картошка-фри)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Кухня 3 (Салаты, напитки)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Кухня 4 (Стрипсы, наггетсы)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(15, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Кухня";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(214, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Загруженность";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Res1Kitchen1);
            this.groupBox1.Controls.Add(this.tb_Res1Kitchen2);
            this.groupBox1.Controls.Add(this.tb_Res1Kitchen3);
            this.groupBox1.Controls.Add(this.tb_Res1Kitchen4);
            this.groupBox1.Controls.Add(this.label_WorkloadRes1Kitchen4);
            this.groupBox1.Controls.Add(this.label_WorkloadRes1Kitchen3);
            this.groupBox1.Controls.Add(this.label_WorkloadRes1Kitchen2);
            this.groupBox1.Controls.Add(this.label_WorkloadRes1Kitchen1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 181);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ПЕРВЫЙ РЕСТОРАН";
            // 
            // tb_Res1Kitchen1
            // 
            this.tb_Res1Kitchen1.Location = new System.Drawing.Point(184, 51);
            this.tb_Res1Kitchen1.Name = "tb_Res1Kitchen1";
            this.tb_Res1Kitchen1.Size = new System.Drawing.Size(54, 20);
            this.tb_Res1Kitchen1.TabIndex = 26;
            this.tb_Res1Kitchen1.Text = "0";
            // 
            // tb_Res1Kitchen2
            // 
            this.tb_Res1Kitchen2.Location = new System.Drawing.Point(184, 78);
            this.tb_Res1Kitchen2.Name = "tb_Res1Kitchen2";
            this.tb_Res1Kitchen2.Size = new System.Drawing.Size(54, 20);
            this.tb_Res1Kitchen2.TabIndex = 25;
            this.tb_Res1Kitchen2.Text = "0";
            // 
            // tb_Res1Kitchen3
            // 
            this.tb_Res1Kitchen3.Location = new System.Drawing.Point(184, 109);
            this.tb_Res1Kitchen3.Name = "tb_Res1Kitchen3";
            this.tb_Res1Kitchen3.Size = new System.Drawing.Size(54, 20);
            this.tb_Res1Kitchen3.TabIndex = 24;
            this.tb_Res1Kitchen3.Text = "0";
            // 
            // tb_Res1Kitchen4
            // 
            this.tb_Res1Kitchen4.Location = new System.Drawing.Point(184, 143);
            this.tb_Res1Kitchen4.Name = "tb_Res1Kitchen4";
            this.tb_Res1Kitchen4.Size = new System.Drawing.Size(54, 20);
            this.tb_Res1Kitchen4.TabIndex = 23;
            this.tb_Res1Kitchen4.Text = "0";
            // 
            // label_WorkloadRes1Kitchen4
            // 
            this.label_WorkloadRes1Kitchen4.AutoSize = true;
            this.label_WorkloadRes1Kitchen4.Location = new System.Drawing.Point(253, 146);
            this.label_WorkloadRes1Kitchen4.Name = "label_WorkloadRes1Kitchen4";
            this.label_WorkloadRes1Kitchen4.Size = new System.Drawing.Size(21, 13);
            this.label_WorkloadRes1Kitchen4.TabIndex = 16;
            this.label_WorkloadRes1Kitchen4.Text = "0%";
            // 
            // label_WorkloadRes1Kitchen3
            // 
            this.label_WorkloadRes1Kitchen3.AutoSize = true;
            this.label_WorkloadRes1Kitchen3.Location = new System.Drawing.Point(253, 116);
            this.label_WorkloadRes1Kitchen3.Name = "label_WorkloadRes1Kitchen3";
            this.label_WorkloadRes1Kitchen3.Size = new System.Drawing.Size(21, 13);
            this.label_WorkloadRes1Kitchen3.TabIndex = 15;
            this.label_WorkloadRes1Kitchen3.Text = "0%";
            // 
            // label_WorkloadRes1Kitchen2
            // 
            this.label_WorkloadRes1Kitchen2.AutoSize = true;
            this.label_WorkloadRes1Kitchen2.Location = new System.Drawing.Point(253, 85);
            this.label_WorkloadRes1Kitchen2.Name = "label_WorkloadRes1Kitchen2";
            this.label_WorkloadRes1Kitchen2.Size = new System.Drawing.Size(21, 13);
            this.label_WorkloadRes1Kitchen2.TabIndex = 14;
            this.label_WorkloadRes1Kitchen2.Text = "0%";
            // 
            // label_WorkloadRes1Kitchen1
            // 
            this.label_WorkloadRes1Kitchen1.AutoSize = true;
            this.label_WorkloadRes1Kitchen1.Location = new System.Drawing.Point(253, 54);
            this.label_WorkloadRes1Kitchen1.Name = "label_WorkloadRes1Kitchen1";
            this.label_WorkloadRes1Kitchen1.Size = new System.Drawing.Size(21, 13);
            this.label_WorkloadRes1Kitchen1.TabIndex = 13;
            this.label_WorkloadRes1Kitchen1.Text = "0%";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Res2Kitchen1);
            this.groupBox2.Controls.Add(this.label_WorkloadRes2Kitchen4);
            this.groupBox2.Controls.Add(this.tb_Res2Kitchen2);
            this.groupBox2.Controls.Add(this.label_WorkloadRes2Kitchen3);
            this.groupBox2.Controls.Add(this.tb_Res2Kitchen3);
            this.groupBox2.Controls.Add(this.label_WorkloadRes2Kitchen2);
            this.groupBox2.Controls.Add(this.tb_Res2Kitchen4);
            this.groupBox2.Controls.Add(this.label_WorkloadRes2Kitchen1);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(449, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 181);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ВТОРОЙ РЕСТОРАН";
            // 
            // tb_Res2Kitchen1
            // 
            this.tb_Res2Kitchen1.Location = new System.Drawing.Point(183, 51);
            this.tb_Res2Kitchen1.Name = "tb_Res2Kitchen1";
            this.tb_Res2Kitchen1.Size = new System.Drawing.Size(54, 20);
            this.tb_Res2Kitchen1.TabIndex = 30;
            this.tb_Res2Kitchen1.Text = "0";
            // 
            // label_WorkloadRes2Kitchen4
            // 
            this.label_WorkloadRes2Kitchen4.AutoSize = true;
            this.label_WorkloadRes2Kitchen4.Location = new System.Drawing.Point(253, 146);
            this.label_WorkloadRes2Kitchen4.Name = "label_WorkloadRes2Kitchen4";
            this.label_WorkloadRes2Kitchen4.Size = new System.Drawing.Size(21, 13);
            this.label_WorkloadRes2Kitchen4.TabIndex = 16;
            this.label_WorkloadRes2Kitchen4.Text = "0%";
            // 
            // tb_Res2Kitchen2
            // 
            this.tb_Res2Kitchen2.Location = new System.Drawing.Point(183, 78);
            this.tb_Res2Kitchen2.Name = "tb_Res2Kitchen2";
            this.tb_Res2Kitchen2.Size = new System.Drawing.Size(54, 20);
            this.tb_Res2Kitchen2.TabIndex = 29;
            this.tb_Res2Kitchen2.Text = "0";
            // 
            // label_WorkloadRes2Kitchen3
            // 
            this.label_WorkloadRes2Kitchen3.AutoSize = true;
            this.label_WorkloadRes2Kitchen3.Location = new System.Drawing.Point(253, 116);
            this.label_WorkloadRes2Kitchen3.Name = "label_WorkloadRes2Kitchen3";
            this.label_WorkloadRes2Kitchen3.Size = new System.Drawing.Size(21, 13);
            this.label_WorkloadRes2Kitchen3.TabIndex = 15;
            this.label_WorkloadRes2Kitchen3.Text = "0%";
            // 
            // tb_Res2Kitchen3
            // 
            this.tb_Res2Kitchen3.Location = new System.Drawing.Point(183, 109);
            this.tb_Res2Kitchen3.Name = "tb_Res2Kitchen3";
            this.tb_Res2Kitchen3.Size = new System.Drawing.Size(54, 20);
            this.tb_Res2Kitchen3.TabIndex = 28;
            this.tb_Res2Kitchen3.Text = "0";
            // 
            // label_WorkloadRes2Kitchen2
            // 
            this.label_WorkloadRes2Kitchen2.AutoSize = true;
            this.label_WorkloadRes2Kitchen2.Location = new System.Drawing.Point(253, 85);
            this.label_WorkloadRes2Kitchen2.Name = "label_WorkloadRes2Kitchen2";
            this.label_WorkloadRes2Kitchen2.Size = new System.Drawing.Size(21, 13);
            this.label_WorkloadRes2Kitchen2.TabIndex = 14;
            this.label_WorkloadRes2Kitchen2.Text = "0%";
            // 
            // tb_Res2Kitchen4
            // 
            this.tb_Res2Kitchen4.Location = new System.Drawing.Point(183, 143);
            this.tb_Res2Kitchen4.Name = "tb_Res2Kitchen4";
            this.tb_Res2Kitchen4.Size = new System.Drawing.Size(54, 20);
            this.tb_Res2Kitchen4.TabIndex = 27;
            this.tb_Res2Kitchen4.Text = "0";
            // 
            // label_WorkloadRes2Kitchen1
            // 
            this.label_WorkloadRes2Kitchen1.AutoSize = true;
            this.label_WorkloadRes2Kitchen1.Location = new System.Drawing.Point(253, 54);
            this.label_WorkloadRes2Kitchen1.Name = "label_WorkloadRes2Kitchen1";
            this.label_WorkloadRes2Kitchen1.Size = new System.Drawing.Size(21, 13);
            this.label_WorkloadRes2Kitchen1.TabIndex = 13;
            this.label_WorkloadRes2Kitchen1.Text = "0%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(15, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Кухня";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Кухня 1 (Бургеры)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Кухня 2 (Картошка-фри)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Кухня 3 (Салаты, напитки)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 146);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(151, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "Кухня 4 (Стрипсы, наггетсы)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(214, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Загруженность";
            // 
            // rtb_Res1
            // 
            this.rtb_Res1.Location = new System.Drawing.Point(15, 249);
            this.rtb_Res1.Name = "rtb_Res1";
            this.rtb_Res1.Size = new System.Drawing.Size(337, 137);
            this.rtb_Res1.TabIndex = 21;
            this.rtb_Res1.Text = "";
            // 
            // rtb_Res2
            // 
            this.rtb_Res2.Location = new System.Drawing.Point(449, 249);
            this.rtb_Res2.Name = "rtb_Res2";
            this.rtb_Res2.Size = new System.Drawing.Size(337, 137);
            this.rtb_Res2.TabIndex = 22;
            this.rtb_Res2.Text = "";
            // 
            // label_Incost
            // 
            this.label_Incost.AutoSize = true;
            this.label_Incost.Location = new System.Drawing.Point(592, 20);
            this.label_Incost.Name = "label_Incost";
            this.label_Incost.Size = new System.Drawing.Size(45, 13);
            this.label_Incost.TabIndex = 23;
            this.label_Incost.Text = "Доход: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Incost);
            this.Controls.Add(this.rtb_Res2);
            this.Controls.Add(this.rtb_Res1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClientRightBtn);
            this.Controls.Add(this.ClientLeftBtn);
            this.Controls.Add(this.tb_maxTimeCooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_maxTimeCooking;
        private System.Windows.Forms.Button ClientLeftBtn;
        private System.Windows.Forms.Button ClientRightBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_WorkloadRes1Kitchen4;
        private System.Windows.Forms.Label label_WorkloadRes1Kitchen3;
        private System.Windows.Forms.Label label_WorkloadRes1Kitchen2;
        private System.Windows.Forms.Label label_WorkloadRes1Kitchen1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_WorkloadRes2Kitchen4;
        private System.Windows.Forms.Label label_WorkloadRes2Kitchen3;
        private System.Windows.Forms.Label label_WorkloadRes2Kitchen2;
        private System.Windows.Forms.Label label_WorkloadRes2Kitchen1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox rtb_Res1;
        private System.Windows.Forms.RichTextBox rtb_Res2;
        private System.Windows.Forms.TextBox tb_Res1Kitchen1;
        private System.Windows.Forms.TextBox tb_Res1Kitchen2;
        private System.Windows.Forms.TextBox tb_Res1Kitchen3;
        private System.Windows.Forms.TextBox tb_Res1Kitchen4;
        private System.Windows.Forms.TextBox tb_Res2Kitchen1;
        private System.Windows.Forms.TextBox tb_Res2Kitchen2;
        private System.Windows.Forms.TextBox tb_Res2Kitchen3;
        private System.Windows.Forms.TextBox tb_Res2Kitchen4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Incost;
    }
}

