namespace ColorPr
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOldColor = new System.Windows.Forms.Button();
            this.pbinput = new System.Windows.Forms.PictureBox();
            this.pboutput = new System.Windows.Forms.PictureBox();
            this.buttonNewColor = new System.Windows.Forms.Button();
            this.pboldcolor = new System.Windows.Forms.PictureBox();
            this.pbnewcolor = new System.Windows.Forms.PictureBox();
            this.buttonBW = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAreaChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboldcolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbnewcolor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(144, 22);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 40);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(144, 22);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOldColor
            // 
            this.buttonOldColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOldColor.Location = new System.Drawing.Point(940, 18);
            this.buttonOldColor.Name = "buttonOldColor";
            this.buttonOldColor.Size = new System.Drawing.Size(144, 22);
            this.buttonOldColor.TabIndex = 2;
            this.buttonOldColor.Text = "Выбрать старый цвет";
            this.buttonOldColor.UseVisualStyleBackColor = true;
            this.buttonOldColor.Click += new System.EventHandler(this.buttonOldColor_Click);
            // 
            // pbinput
            // 
            this.pbinput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbinput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbinput.Location = new System.Drawing.Point(12, 155);
            this.pbinput.Name = "pbinput";
            this.pbinput.Size = new System.Drawing.Size(520, 492);
            this.pbinput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbinput.TabIndex = 3;
            this.pbinput.TabStop = false;
            this.pbinput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbinput_MouseClick);
            // 
            // pboutput
            // 
            this.pboutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboutput.Location = new System.Drawing.Point(565, 155);
            this.pboutput.Name = "pboutput";
            this.pboutput.Size = new System.Drawing.Size(520, 492);
            this.pboutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboutput.TabIndex = 4;
            this.pboutput.TabStop = false;
            // 
            // buttonNewColor
            // 
            this.buttonNewColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewColor.Location = new System.Drawing.Point(940, 72);
            this.buttonNewColor.Name = "buttonNewColor";
            this.buttonNewColor.Size = new System.Drawing.Size(144, 22);
            this.buttonNewColor.TabIndex = 5;
            this.buttonNewColor.Text = "Выбрать новый цвет";
            this.buttonNewColor.UseVisualStyleBackColor = true;
            this.buttonNewColor.Click += new System.EventHandler(this.buttonNewColor_Click);
            // 
            // pboldcolor
            // 
            this.pboldcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboldcolor.Location = new System.Drawing.Point(940, 46);
            this.pboldcolor.Name = "pboldcolor";
            this.pboldcolor.Size = new System.Drawing.Size(144, 20);
            this.pboldcolor.TabIndex = 6;
            this.pboldcolor.TabStop = false;
            this.pboldcolor.Paint += new System.Windows.Forms.PaintEventHandler(this.pboldcolor_Paint);
            // 
            // pbnewcolor
            // 
            this.pbnewcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbnewcolor.Location = new System.Drawing.Point(940, 100);
            this.pbnewcolor.Name = "pbnewcolor";
            this.pbnewcolor.Size = new System.Drawing.Size(144, 20);
            this.pbnewcolor.TabIndex = 7;
            this.pbnewcolor.TabStop = false;
            this.pbnewcolor.Paint += new System.Windows.Forms.PaintEventHandler(this.pbnewcolor_Paint);
            // 
            // buttonBW
            // 
            this.buttonBW.Location = new System.Drawing.Point(252, 12);
            this.buttonBW.Name = "buttonBW";
            this.buttonBW.Size = new System.Drawing.Size(144, 22);
            this.buttonBW.TabIndex = 8;
            this.buttonBW.Text = "Сделать черно-белым";
            this.buttonBW.UseVisualStyleBackColor = true;
            this.buttonBW.Click += new System.EventHandler(this.buttonBW_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChange.Location = new System.Drawing.Point(760, 18);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(144, 22);
            this.buttonChange.TabIndex = 9;
            this.buttonChange.Text = "Покрасить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(760, 77);
            this.hScrollBar1.Maximum = 765;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(144, 17);
            this.hScrollBar1.TabIndex = 10;
            this.hScrollBar1.Value = 30;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ширина диапозона";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "30%";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChoose.BackColor = System.Drawing.Color.Gray;
            this.buttonChoose.Location = new System.Drawing.Point(910, 18);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(24, 22);
            this.buttonChoose.TabIndex = 13;
            this.buttonChoose.UseVisualStyleBackColor = false;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(66, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(475, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "<-----------";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAreaChoose
            // 
            this.buttonAreaChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAreaChoose.Location = new System.Drawing.Point(610, 18);
            this.buttonAreaChoose.Name = "buttonAreaChoose";
            this.buttonAreaChoose.Size = new System.Drawing.Size(144, 22);
            this.buttonAreaChoose.TabIndex = 16;
            this.buttonAreaChoose.Text = "Выбрать область";
            this.buttonAreaChoose.UseVisualStyleBackColor = true;
            this.buttonAreaChoose.Click += new System.EventHandler(this.buttonAreaChoose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 659);
            this.Controls.Add(this.buttonAreaChoose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonBW);
            this.Controls.Add(this.pbnewcolor);
            this.Controls.Add(this.pboldcolor);
            this.Controls.Add(this.buttonNewColor);
            this.Controls.Add(this.pboutput);
            this.Controls.Add(this.pbinput);
            this.Controls.Add(this.buttonOldColor);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboldcolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbnewcolor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOldColor;
        private System.Windows.Forms.PictureBox pbinput;
        private System.Windows.Forms.PictureBox pboutput;
        private System.Windows.Forms.Button buttonNewColor;
        private System.Windows.Forms.PictureBox pboldcolor;
        private System.Windows.Forms.PictureBox pbnewcolor;
        private System.Windows.Forms.Button buttonBW;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAreaChoose;
    }
}

