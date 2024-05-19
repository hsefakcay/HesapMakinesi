using System;
using System.Windows.Forms;

namespace HesapMakinesi
{
    partial class HesapMakinesi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapMakinesi));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SoyadTextBox = new System.Windows.Forms.TextBox();
            this.DogumTarihiPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.CarpmaButton = new System.Windows.Forms.Button();
            this.ToplamaButton = new System.Windows.Forms.Button();
            this.CikarmaButton = new System.Windows.Forms.Button();
            this.HesaplaButton = new System.Windows.Forms.Button();
            this.BolmeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yasLabel = new System.Windows.Forms.Label();
            this.dogumGunuLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Sayi1TextBox = new System.Windows.Forms.TextBox();
            this.SonucLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SilButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(6, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SayiButtonClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(56, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.SayiButtonClick);
            // 
            // AdTextBox
            // 
            this.AdTextBox.Location = new System.Drawing.Point(118, 36);
            this.AdTextBox.Multiline = true;
            this.AdTextBox.Name = "AdTextBox";
            this.AdTextBox.Size = new System.Drawing.Size(143, 26);
            this.AdTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = " Adı  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyadı : ";
            // 
            // SoyadTextBox
            // 
            this.SoyadTextBox.Location = new System.Drawing.Point(118, 78);
            this.SoyadTextBox.Multiline = true;
            this.SoyadTextBox.Name = "SoyadTextBox";
            this.SoyadTextBox.Size = new System.Drawing.Size(143, 25);
            this.SoyadTextBox.TabIndex = 5;
            // 
            // DogumTarihiPicker
            // 
            this.DogumTarihiPicker.Location = new System.Drawing.Point(297, 39);
            this.DogumTarihiPicker.Name = "DogumTarihiPicker";
            this.DogumTarihiPicker.Size = new System.Drawing.Size(121, 24);
            this.DogumTarihiPicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(297, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(441, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = " Yaşı :";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(381, 78);
            this.EmailTextBox.Multiline = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(197, 25);
            this.EmailTextBox.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chocolate;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(106, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 38);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SayiButtonClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Chocolate;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(6, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 38);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.SayiButtonClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Chocolate;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(56, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 38);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.SayiButtonClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Chocolate;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(106, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 38);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.SayiButtonClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Chocolate;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(6, 23);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 38);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.SayiButtonClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Chocolate;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(56, 23);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 38);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.SayiButtonClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Chocolate;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(106, 22);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 38);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.SayiButtonClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Chocolate;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Location = new System.Drawing.Point(6, 155);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 38);
            this.button10.TabIndex = 18;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.SayiButtonClick);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Sienna;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Location = new System.Drawing.Point(106, 154);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(44, 38);
            this.button11.TabIndex = 19;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.SayiButtonClick);
            // 
            // CarpmaButton
            // 
            this.CarpmaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CarpmaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarpmaButton.Location = new System.Drawing.Point(6, 23);
            this.CarpmaButton.Name = "CarpmaButton";
            this.CarpmaButton.Size = new System.Drawing.Size(44, 38);
            this.CarpmaButton.TabIndex = 20;
            this.CarpmaButton.Text = "x";
            this.CarpmaButton.UseVisualStyleBackColor = false;
            this.CarpmaButton.Click += new System.EventHandler(this.CarpmaButton_Click);
            // 
            // ToplamaButton
            // 
            this.ToplamaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToplamaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToplamaButton.Location = new System.Drawing.Point(6, 67);
            this.ToplamaButton.Name = "ToplamaButton";
            this.ToplamaButton.Size = new System.Drawing.Size(44, 38);
            this.ToplamaButton.TabIndex = 21;
            this.ToplamaButton.Text = "+";
            this.ToplamaButton.UseVisualStyleBackColor = false;
            this.ToplamaButton.Click += new System.EventHandler(this.ToplamaButton_Click);
            // 
            // CikarmaButton
            // 
            this.CikarmaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CikarmaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CikarmaButton.Location = new System.Drawing.Point(56, 67);
            this.CikarmaButton.Name = "CikarmaButton";
            this.CikarmaButton.Size = new System.Drawing.Size(44, 38);
            this.CikarmaButton.TabIndex = 22;
            this.CikarmaButton.Text = "-";
            this.CikarmaButton.UseVisualStyleBackColor = false;
            this.CikarmaButton.Click += new System.EventHandler(this.CikarmaButton_Click);
            // 
            // HesaplaButton
            // 
            this.HesaplaButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.HesaplaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HesaplaButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HesaplaButton.Location = new System.Drawing.Point(21, 111);
            this.HesaplaButton.Name = "HesaplaButton";
            this.HesaplaButton.Size = new System.Drawing.Size(79, 38);
            this.HesaplaButton.TabIndex = 23;
            this.HesaplaButton.Text = "Hesapla";
            this.HesaplaButton.UseVisualStyleBackColor = false;
            this.HesaplaButton.Click += new System.EventHandler(this.HesapButton_Click);
            // 
            // BolmeButton
            // 
            this.BolmeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BolmeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BolmeButton.Location = new System.Drawing.Point(56, 23);
            this.BolmeButton.Name = "BolmeButton";
            this.BolmeButton.Size = new System.Drawing.Size(44, 38);
            this.BolmeButton.TabIndex = 24;
            this.BolmeButton.Text = "/";
            this.BolmeButton.UseVisualStyleBackColor = false;
            this.BolmeButton.Click += new System.EventHandler(this.BolmeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.yasLabel);
            this.groupBox1.Controls.Add(this.dogumGunuLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AdTextBox);
            this.groupBox1.Controls.Add(this.SoyadTextBox);
            this.groupBox1.Controls.Add(this.DogumTarihiPicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Location = new System.Drawing.Point(55, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 116);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // yasLabel
            // 
            this.yasLabel.AutoSize = true;
            this.yasLabel.BackColor = System.Drawing.SystemColors.Control;
            this.yasLabel.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.yasLabel.Location = new System.Drawing.Point(506, 37);
            this.yasLabel.Name = "yasLabel";
            this.yasLabel.Size = new System.Drawing.Size(0, 28);
            this.yasLabel.TabIndex = 12;
            // 
            // dogumGunuLabel
            // 
            this.dogumGunuLabel.AutoSize = true;
            this.dogumGunuLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dogumGunuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dogumGunuLabel.Location = new System.Drawing.Point(297, 17);
            this.dogumGunuLabel.Name = "dogumGunuLabel";
            this.dogumGunuLabel.Size = new System.Drawing.Size(134, 20);
            this.dogumGunuLabel.TabIndex = 11;
            this.dogumGunuLabel.Text = "Doğum Tarihi :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(55, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 198);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.CarpmaButton);
            this.groupBox3.Controls.Add(this.BolmeButton);
            this.groupBox3.Controls.Add(this.ToplamaButton);
            this.groupBox3.Controls.Add(this.HesaplaButton);
            this.groupBox3.Controls.Add(this.CikarmaButton);
            this.groupBox3.Location = new System.Drawing.Point(239, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 158);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Controls.Add(this.Sayi1TextBox);
            this.groupBox4.Controls.Add(this.SonucLabel);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(389, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 125);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            // 
            // Sayi1TextBox
            // 
            this.Sayi1TextBox.Location = new System.Drawing.Point(113, 34);
            this.Sayi1TextBox.Multiline = true;
            this.Sayi1TextBox.Name = "Sayi1TextBox";
            this.Sayi1TextBox.Size = new System.Drawing.Size(81, 24);
            this.Sayi1TextBox.TabIndex = 11;
            // 
            // SonucLabel
            // 
            this.SonucLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.SonucLabel.AutoSize = true;
            this.SonucLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SonucLabel.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SonucLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SonucLabel.Location = new System.Drawing.Point(113, 74);
            this.SonucLabel.Name = "SonucLabel";
            this.SonucLabel.Size = new System.Drawing.Size(0, 28);
            this.SonucLabel.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sonuç :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Veri Giriş:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.SayiButtonClick);
            // 
            // SilButton
            // 
            this.SilButton.BackColor = System.Drawing.Color.DarkRed;
            this.SilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SilButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SilButton.Location = new System.Drawing.Point(239, 133);
            this.SilButton.Name = "SilButton";
            this.SilButton.Size = new System.Drawing.Size(50, 38);
            this.SilButton.TabIndex = 20;
            this.SilButton.Text = "C";
            this.SilButton.UseVisualStyleBackColor = false;
            this.SilButton.Click += new System.EventHandler(this.SilButton_Click);
            // 
            // HesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::HesapMakinesi.Properties.Resources.calculator_a_background_EMD5HM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(700, 347);
            this.Controls.Add(this.SilButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HesapMakinesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox AdTextBox;
        private Label label1;
        private Label label2;
        private TextBox SoyadTextBox;
        private DateTimePicker DogumTarihiPicker;
        private Label label3;
        private Label label4;
        private TextBox EmailTextBox;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button CarpmaButton;
        private Button ToplamaButton;
        private Button CikarmaButton;
        private Button HesaplaButton;
        private Button BolmeButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label6;
        private Label label5;
        private Label SonucLabel;
        private TextBox Sayi1TextBox;
        private Button SilButton;
        private Label dogumGunuLabel;
        private Label yasLabel;
    }
}