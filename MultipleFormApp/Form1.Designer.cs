namespace MultipleFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.number1tBox = new System.Windows.Forms.TextBox();
            this.number2tBox = new System.Windows.Forms.TextBox();
            this.number3tBox = new System.Windows.Forms.TextBox();
            this.resultTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.İşlev1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnZigZag = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxMultTable = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShowMultTable = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.carpimSayi = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.btnEditFile = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelShowFiboResult = new System.Windows.Forms.Label();
            this.buttonCalcFibo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFiboNumber = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.İşlev1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // number1tBox
            // 
            this.number1tBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number1tBox.Location = new System.Drawing.Point(201, 47);
            this.number1tBox.MinimumSize = new System.Drawing.Size(110, 30);
            this.number1tBox.Name = "number1tBox";
            this.number1tBox.Size = new System.Drawing.Size(110, 27);
            this.number1tBox.TabIndex = 0;
            this.number1tBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number1Tbox_KeyPress);
            // 
            // number2tBox
            // 
            this.number2tBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number2tBox.Location = new System.Drawing.Point(201, 101);
            this.number2tBox.MinimumSize = new System.Drawing.Size(110, 30);
            this.number2tBox.Name = "number2tBox";
            this.number2tBox.Size = new System.Drawing.Size(110, 27);
            this.number2tBox.TabIndex = 1;
            this.number2tBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number2tBox_KeyPress);
            // 
            // number3tBox
            // 
            this.number3tBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number3tBox.Location = new System.Drawing.Point(201, 161);
            this.number3tBox.MinimumSize = new System.Drawing.Size(110, 30);
            this.number3tBox.Name = "number3tBox";
            this.number3tBox.Size = new System.Drawing.Size(110, 27);
            this.number3tBox.TabIndex = 2;
            this.number3tBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number3tBox_KeyPress);
            // 
            // resultTbox
            // 
            this.resultTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultTbox.Location = new System.Drawing.Point(201, 253);
            this.resultTbox.MinimumSize = new System.Drawing.Size(110, 30);
            this.resultTbox.Name = "resultTbox";
            this.resultTbox.ReadOnly = true;
            this.resultTbox.Size = new System.Drawing.Size(110, 27);
            this.resultTbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(241, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(242, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(241, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "=";
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(42, 253);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(128, 30);
            this.buttonResult.TabIndex = 9;
            this.buttonResult.Text = "Sonucu Göster";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(110, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sayı 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(110, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sayı 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(110, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sayı 3:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.İşlev1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 580);
            this.tabControl1.TabIndex = 13;
            // 
            // İşlev1
            // 
            this.İşlev1.Controls.Add(this.number1tBox);
            this.İşlev1.Controls.Add(this.label5);
            this.İşlev1.Controls.Add(this.label4);
            this.İşlev1.Controls.Add(this.label6);
            this.İşlev1.Controls.Add(this.label1);
            this.İşlev1.Controls.Add(this.number2tBox);
            this.İşlev1.Controls.Add(this.label3);
            this.İşlev1.Controls.Add(this.number3tBox);
            this.İşlev1.Controls.Add(this.label2);
            this.İşlev1.Controls.Add(this.resultTbox);
            this.İşlev1.Controls.Add(this.buttonResult);
            this.İşlev1.Location = new System.Drawing.Point(4, 25);
            this.İşlev1.Name = "İşlev1";
            this.İşlev1.Padding = new System.Windows.Forms.Padding(3);
            this.İşlev1.Size = new System.Drawing.Size(1036, 551);
            this.İşlev1.TabIndex = 0;
            this.İşlev1.Text = "İşlev1";
            this.İşlev1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.btnZigZag);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1036, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İşlev2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(886, 469);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnZigZag
            // 
            this.btnZigZag.Location = new System.Drawing.Point(26, 23);
            this.btnZigZag.Name = "btnZigZag";
            this.btnZigZag.Size = new System.Drawing.Size(75, 23);
            this.btnZigZag.TabIndex = 0;
            this.btnZigZag.Text = "Çalıştır";
            this.btnZigZag.UseVisualStyleBackColor = true;
            this.btnZigZag.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnZigZag_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxMultTable);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btnShowMultTable);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.carpimSayi);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1130, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "İşlev3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxMultTable
            // 
            this.textBoxMultTable.Location = new System.Drawing.Point(19, 72);
            this.textBoxMultTable.Multiline = true;
            this.textBoxMultTable.Name = "textBoxMultTable";
            this.textBoxMultTable.ReadOnly = true;
            this.textBoxMultTable.Size = new System.Drawing.Size(1089, 459);
            this.textBoxMultTable.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(25, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 3;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShowMultTable
            // 
            this.btnShowMultTable.Location = new System.Drawing.Point(427, 9);
            this.btnShowMultTable.Name = "btnShowMultTable";
            this.btnShowMultTable.Size = new System.Drawing.Size(143, 44);
            this.btnShowMultTable.TabIndex = 2;
            this.btnShowMultTable.Text = "Çarpım Tablosunu Göster";
            this.btnShowMultTable.UseVisualStyleBackColor = true;
            this.btnShowMultTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnShowMultTbl_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sayıyı giriniz:";
            // 
            // carpimSayi
            // 
            this.carpimSayi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carpimSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpimSayi.Location = new System.Drawing.Point(155, 19);
            this.carpimSayi.Name = "carpimSayi";
            this.carpimSayi.Size = new System.Drawing.Size(266, 34);
            this.carpimSayi.TabIndex = 0;
            this.carpimSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberMult_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxFilePath);
            this.tabPage1.Controls.Add(this.btnEditFile);
            this.tabPage1.Controls.Add(this.btnChooseFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1036, 551);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "İşlev4";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(23, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 3;
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFilePath.Location = new System.Drawing.Point(23, 58);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(406, 27);
            this.textBoxFilePath.TabIndex = 2;
            // 
            // btnEditFile
            // 
            this.btnEditFile.Location = new System.Drawing.Point(439, 110);
            this.btnEditFile.Name = "btnEditFile";
            this.btnEditFile.Size = new System.Drawing.Size(128, 36);
            this.btnEditFile.TabIndex = 1;
            this.btnEditFile.Text = "Dosyayı Düzenle";
            this.btnEditFile.UseVisualStyleBackColor = true;
            this.btnEditFile.Click += new System.EventHandler(this.btnEditFile_Click);
            this.btnEditFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEditFile_MouseClick);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(471, 58);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(96, 32);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Dosya Seç";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelShowFiboResult);
            this.tabPage4.Controls.Add(this.buttonCalcFibo);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.textBoxFiboNumber);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1036, 551);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "İşlev5";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelShowFiboResult
            // 
            this.labelShowFiboResult.AutoSize = true;
            this.labelShowFiboResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelShowFiboResult.Location = new System.Drawing.Point(121, 102);
            this.labelShowFiboResult.Name = "labelShowFiboResult";
            this.labelShowFiboResult.Size = new System.Drawing.Size(0, 22);
            this.labelShowFiboResult.TabIndex = 3;
            // 
            // buttonCalcFibo
            // 
            this.buttonCalcFibo.Location = new System.Drawing.Point(244, 35);
            this.buttonCalcFibo.Name = "buttonCalcFibo";
            this.buttonCalcFibo.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcFibo.TabIndex = 2;
            this.buttonCalcFibo.Text = "Hesapla";
            this.buttonCalcFibo.UseVisualStyleBackColor = true;
            this.buttonCalcFibo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCalcFibo_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.9F);
            this.label9.Location = new System.Drawing.Point(26, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sayı giriniz:";
            // 
            // textBoxFiboNumber
            // 
            this.textBoxFiboNumber.Location = new System.Drawing.Point(121, 37);
            this.textBoxFiboNumber.Name = "textBoxFiboNumber";
            this.textBoxFiboNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxFiboNumber.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 614);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.İşlev1.ResumeLayout(false);
            this.İşlev1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox number1tBox;
        private System.Windows.Forms.TextBox number2tBox;
        private System.Windows.Forms.TextBox number3tBox;
        private System.Windows.Forms.TextBox resultTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage İşlev1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnZigZag;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnShowMultTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox carpimSayi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button btnEditFile;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelShowFiboResult;
        private System.Windows.Forms.Button buttonCalcFibo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFiboNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMultTable;
    }
}

