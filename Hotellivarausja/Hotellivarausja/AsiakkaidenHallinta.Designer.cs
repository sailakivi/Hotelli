﻿namespace Hotellivarausja
{
    partial class AsiakkaidenHallinta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.KayttajaLB = new System.Windows.Forms.Label();
            this.TyhjennaPainike = new System.Windows.Forms.Button();
            this.PoistaPainike = new System.Windows.Forms.Button();
            this.MuokkaPainike = new System.Windows.Forms.Button();
            this.UusiAsiakasPainike = new System.Windows.Forms.Button();
            this.AsiakkaatDG = new System.Windows.Forms.DataGridView();
            this.PostitoimiTB = new System.Windows.Forms.TextBox();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PostinumeroTB = new System.Windows.Forms.TextBox();
            this.PostinumeroLB = new System.Windows.Forms.Label();
            this.OsoiteTB = new System.Windows.Forms.TextBox();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.SukunimiTB = new System.Windows.Forms.TextBox();
            this.SukunimiLB = new System.Windows.Forms.Label();
            this.EtunimiTB = new System.Windows.Forms.TextBox();
            this.EtunimiLB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakkaatDG)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.SalasanaTB);
            this.panel1.Controls.Add(this.SalasanaLB);
            this.panel1.Controls.Add(this.KayttajaTB);
            this.panel1.Controls.Add(this.KayttajaLB);
            this.panel1.Controls.Add(this.TyhjennaPainike);
            this.panel1.Controls.Add(this.PoistaPainike);
            this.panel1.Controls.Add(this.MuokkaPainike);
            this.panel1.Controls.Add(this.UusiAsiakasPainike);
            this.panel1.Controls.Add(this.AsiakkaatDG);
            this.panel1.Controls.Add(this.PostitoimiTB);
            this.panel1.Controls.Add(this.PostitoimipaikkaLB);
            this.panel1.Controls.Add(this.PostinumeroTB);
            this.panel1.Controls.Add(this.PostinumeroLB);
            this.panel1.Controls.Add(this.OsoiteTB);
            this.panel1.Controls.Add(this.OsoiteLB);
            this.panel1.Controls.Add(this.SukunimiTB);
            this.panel1.Controls.Add(this.SukunimiLB);
            this.panel1.Controls.Add(this.EtunimiTB);
            this.panel1.Controls.Add(this.EtunimiLB);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 450);
            this.panel1.TabIndex = 0;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.BackColor = System.Drawing.Color.White;
            this.SalasanaTB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.SalasanaTB.Location = new System.Drawing.Point(214, 326);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(190, 29);
            this.SalasanaTB.TabIndex = 14;
            this.SalasanaTB.UseSystemPasswordChar = true;
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.BackColor = System.Drawing.Color.PapayaWhip;
            this.SalasanaLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.SalasanaLB.Location = new System.Drawing.Point(89, 326);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SalasanaLB.Size = new System.Drawing.Size(115, 27);
            this.SalasanaLB.TabIndex = 18;
            this.SalasanaLB.Text = "Salasana:";
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.BackColor = System.Drawing.Color.White;
            this.KayttajaTB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.KayttajaTB.Location = new System.Drawing.Point(214, 291);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(190, 29);
            this.KayttajaTB.TabIndex = 12;
            // 
            // KayttajaLB
            // 
            this.KayttajaLB.AutoSize = true;
            this.KayttajaLB.BackColor = System.Drawing.Color.PapayaWhip;
            this.KayttajaLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.KayttajaLB.Location = new System.Drawing.Point(27, 291);
            this.KayttajaLB.Name = "KayttajaLB";
            this.KayttajaLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KayttajaLB.Size = new System.Drawing.Size(179, 27);
            this.KayttajaLB.TabIndex = 16;
            this.KayttajaLB.Text = "Käyttäjätunnus:";
            this.KayttajaLB.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // TyhjennaPainike
            // 
            this.TyhjennaPainike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TyhjennaPainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennaPainike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.TyhjennaPainike.Location = new System.Drawing.Point(297, 374);
            this.TyhjennaPainike.Name = "TyhjennaPainike";
            this.TyhjennaPainike.Size = new System.Drawing.Size(107, 52);
            this.TyhjennaPainike.TabIndex = 15;
            this.TyhjennaPainike.Text = "Tyhjennä \r\nkentät";
            this.TyhjennaPainike.UseVisualStyleBackColor = false;
            this.TyhjennaPainike.Click += new System.EventHandler(this.TyhjennaPainike_Click);
            // 
            // PoistaPainike
            // 
            this.PoistaPainike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PoistaPainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaPainike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.PoistaPainike.Location = new System.Drawing.Point(213, 374);
            this.PoistaPainike.Name = "PoistaPainike";
            this.PoistaPainike.Size = new System.Drawing.Size(78, 52);
            this.PoistaPainike.TabIndex = 14;
            this.PoistaPainike.Text = "Poista";
            this.PoistaPainike.UseVisualStyleBackColor = false;
            this.PoistaPainike.Click += new System.EventHandler(this.PoistaPainike_Click);
            // 
            // MuokkaPainike
            // 
            this.MuokkaPainike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MuokkaPainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuokkaPainike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.MuokkaPainike.Location = new System.Drawing.Point(121, 374);
            this.MuokkaPainike.Name = "MuokkaPainike";
            this.MuokkaPainike.Size = new System.Drawing.Size(83, 52);
            this.MuokkaPainike.TabIndex = 13;
            this.MuokkaPainike.Text = "Muokkaa";
            this.MuokkaPainike.UseVisualStyleBackColor = false;
            this.MuokkaPainike.Click += new System.EventHandler(this.MuokkaPainike_Click);
            // 
            // UusiAsiakasPainike
            // 
            this.UusiAsiakasPainike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UusiAsiakasPainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiAsiakasPainike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.UusiAsiakasPainike.Location = new System.Drawing.Point(17, 374);
            this.UusiAsiakasPainike.Name = "UusiAsiakasPainike";
            this.UusiAsiakasPainike.Size = new System.Drawing.Size(96, 52);
            this.UusiAsiakasPainike.TabIndex = 12;
            this.UusiAsiakasPainike.Text = "Lisää uusi \r\nasiakas";
            this.UusiAsiakasPainike.UseVisualStyleBackColor = false;
            this.UusiAsiakasPainike.Click += new System.EventHandler(this.UusiAsiakasPainike_Click);
            // 
            // AsiakkaatDG
            // 
            this.AsiakkaatDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(182)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AsiakkaatDG.DefaultCellStyle = dataGridViewCellStyle1;
            this.AsiakkaatDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.AsiakkaatDG.Location = new System.Drawing.Point(422, 116);
            this.AsiakkaatDG.Name = "AsiakkaatDG";
            this.AsiakkaatDG.Size = new System.Drawing.Size(545, 331);
            this.AsiakkaatDG.TabIndex = 11;
            this.AsiakkaatDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AsiakkaatDG_CellClick);
            // 
            // PostitoimiTB
            // 
            this.PostitoimiTB.BackColor = System.Drawing.Color.White;
            this.PostitoimiTB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostitoimiTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.PostitoimiTB.Location = new System.Drawing.Point(213, 256);
            this.PostitoimiTB.Name = "PostitoimiTB";
            this.PostitoimiTB.Size = new System.Drawing.Size(190, 29);
            this.PostitoimiTB.TabIndex = 10;
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.BackColor = System.Drawing.Color.PapayaWhip;
            this.PostitoimipaikkaLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostitoimipaikkaLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(12, 256);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(194, 27);
            this.PostitoimipaikkaLB.TabIndex = 9;
            this.PostitoimipaikkaLB.Text = "Postitoimipaikka:";
            // 
            // PostinumeroTB
            // 
            this.PostinumeroTB.BackColor = System.Drawing.Color.White;
            this.PostinumeroTB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostinumeroTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.PostinumeroTB.Location = new System.Drawing.Point(213, 221);
            this.PostinumeroTB.Name = "PostinumeroTB";
            this.PostinumeroTB.Size = new System.Drawing.Size(190, 29);
            this.PostinumeroTB.TabIndex = 8;
            // 
            // PostinumeroLB
            // 
            this.PostinumeroLB.AutoSize = true;
            this.PostinumeroLB.BackColor = System.Drawing.Color.PapayaWhip;
            this.PostinumeroLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostinumeroLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PostinumeroLB.Location = new System.Drawing.Point(56, 221);
            this.PostinumeroLB.Name = "PostinumeroLB";
            this.PostinumeroLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PostinumeroLB.Size = new System.Drawing.Size(150, 27);
            this.PostinumeroLB.TabIndex = 7;
            this.PostinumeroLB.Text = "Postinumero:";
            // 
            // OsoiteTB
            // 
            this.OsoiteTB.BackColor = System.Drawing.Color.White;
            this.OsoiteTB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsoiteTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.OsoiteTB.Location = new System.Drawing.Point(213, 186);
            this.OsoiteTB.Name = "OsoiteTB";
            this.OsoiteTB.Size = new System.Drawing.Size(190, 29);
            this.OsoiteTB.TabIndex = 6;
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.BackColor = System.Drawing.Color.PapayaWhip;
            this.OsoiteLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsoiteLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.OsoiteLB.Location = new System.Drawing.Point(78, 186);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OsoiteLB.Size = new System.Drawing.Size(128, 27);
            this.OsoiteLB.TabIndex = 5;
            this.OsoiteLB.Text = "Lähiosoite:";
            // 
            // SukunimiTB
            // 
            this.SukunimiTB.BackColor = System.Drawing.Color.White;
            this.SukunimiTB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SukunimiTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.SukunimiTB.Location = new System.Drawing.Point(213, 151);
            this.SukunimiTB.Name = "SukunimiTB";
            this.SukunimiTB.Size = new System.Drawing.Size(190, 29);
            this.SukunimiTB.TabIndex = 4;
            // 
            // SukunimiLB
            // 
            this.SukunimiLB.AutoSize = true;
            this.SukunimiLB.BackColor = System.Drawing.Color.PapayaWhip;
            this.SukunimiLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SukunimiLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.SukunimiLB.Location = new System.Drawing.Point(91, 151);
            this.SukunimiLB.Name = "SukunimiLB";
            this.SukunimiLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SukunimiLB.Size = new System.Drawing.Size(115, 27);
            this.SukunimiLB.TabIndex = 3;
            this.SukunimiLB.Text = "Sukunimi:";
            // 
            // EtunimiTB
            // 
            this.EtunimiTB.BackColor = System.Drawing.Color.White;
            this.EtunimiTB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtunimiTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.EtunimiTB.Location = new System.Drawing.Point(213, 116);
            this.EtunimiTB.Name = "EtunimiTB";
            this.EtunimiTB.Size = new System.Drawing.Size(190, 29);
            this.EtunimiTB.TabIndex = 2;
            // 
            // EtunimiLB
            // 
            this.EtunimiLB.AutoSize = true;
            this.EtunimiLB.BackColor = System.Drawing.Color.PapayaWhip;
            this.EtunimiLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtunimiLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.EtunimiLB.Location = new System.Drawing.Point(109, 116);
            this.EtunimiLB.Name = "EtunimiLB";
            this.EtunimiLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EtunimiLB.Size = new System.Drawing.Size(97, 27);
            this.EtunimiLB.TabIndex = 1;
            this.EtunimiLB.Text = "Etunimi:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 81);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(974, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asiakkaiden hallinta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AsiakkaidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AsiakkaidenHallinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsiakkaidenHallinta";
            this.Load += new System.EventHandler(this.AsiakkaidenHallinta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsiakkaatDG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PostitoimiTB;
        private System.Windows.Forms.Label PostitoimipaikkaLB;
        private System.Windows.Forms.TextBox PostinumeroTB;
        private System.Windows.Forms.Label PostinumeroLB;
        private System.Windows.Forms.TextBox OsoiteTB;
        private System.Windows.Forms.Label OsoiteLB;
        private System.Windows.Forms.TextBox SukunimiTB;
        private System.Windows.Forms.Label SukunimiLB;
        private System.Windows.Forms.TextBox EtunimiTB;
        private System.Windows.Forms.Label EtunimiLB;
        private System.Windows.Forms.DataGridView AsiakkaatDG;
        private System.Windows.Forms.Button UusiAsiakasPainike;
        private System.Windows.Forms.Button TyhjennaPainike;
        private System.Windows.Forms.Button PoistaPainike;
        private System.Windows.Forms.Button MuokkaPainike;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.Label KayttajaLB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}