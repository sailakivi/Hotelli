﻿namespace Hotellivarausja
{
    partial class VaraustenHallinta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.UlosLB = new System.Windows.Forms.Label();
            this.TyhjennaVarausPainike = new System.Windows.Forms.Button();
            this.PoistaVarausPainike = new System.Windows.Forms.Button();
            this.MuokkaaVaraustaPainike = new System.Windows.Forms.Button();
            this.UusiVarausPainike = new System.Windows.Forms.Button();
            this.VarauksetDG = new System.Windows.Forms.DataGridView();
            this.SisaanLB = new System.Windows.Forms.Label();
            this.HuoneenNroLB = new System.Windows.Forms.Label();
            this.HuonetyyppiLB = new System.Windows.Forms.Label();
            this.AsiakasNroLB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VarausNroTB = new System.Windows.Forms.TextBox();
            this.VarausNroLB = new System.Windows.Forms.Label();
            this.AsiakasCB = new System.Windows.Forms.ComboBox();
            this.UlosDTP = new System.Windows.Forms.DateTimePicker();
            this.SisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.HuoneNroCB = new System.Windows.Forms.ComboBox();
            this.HuonetyyppiCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(974, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varausten hallinta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UlosLB
            // 
            this.UlosLB.AutoSize = true;
            this.UlosLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UlosLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.UlosLB.Location = new System.Drawing.Point(142, 302);
            this.UlosLB.Name = "UlosLB";
            this.UlosLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UlosLB.Size = new System.Drawing.Size(65, 27);
            this.UlosLB.TabIndex = 16;
            this.UlosLB.Text = "Ulos:";
            // 
            // TyhjennaVarausPainike
            // 
            this.TyhjennaVarausPainike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TyhjennaVarausPainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennaVarausPainike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.TyhjennaVarausPainike.Location = new System.Drawing.Point(314, 374);
            this.TyhjennaVarausPainike.Name = "TyhjennaVarausPainike";
            this.TyhjennaVarausPainike.Size = new System.Drawing.Size(90, 47);
            this.TyhjennaVarausPainike.TabIndex = 15;
            this.TyhjennaVarausPainike.Text = "Tyhjennä \r\nkentät";
            this.TyhjennaVarausPainike.UseVisualStyleBackColor = false;
            this.TyhjennaVarausPainike.Click += new System.EventHandler(this.TyhjennaVarausPainike_Click);
            // 
            // PoistaVarausPainike
            // 
            this.PoistaVarausPainike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PoistaVarausPainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaVarausPainike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.PoistaVarausPainike.Location = new System.Drawing.Point(220, 374);
            this.PoistaVarausPainike.Name = "PoistaVarausPainike";
            this.PoistaVarausPainike.Size = new System.Drawing.Size(88, 47);
            this.PoistaVarausPainike.TabIndex = 14;
            this.PoistaVarausPainike.Text = "Poista";
            this.PoistaVarausPainike.UseVisualStyleBackColor = false;
            this.PoistaVarausPainike.Click += new System.EventHandler(this.PoistaVarausPainike_Click);
            // 
            // MuokkaaVaraustaPainike
            // 
            this.MuokkaaVaraustaPainike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MuokkaaVaraustaPainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuokkaaVaraustaPainike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.MuokkaaVaraustaPainike.Location = new System.Drawing.Point(131, 374);
            this.MuokkaaVaraustaPainike.Name = "MuokkaaVaraustaPainike";
            this.MuokkaaVaraustaPainike.Size = new System.Drawing.Size(83, 47);
            this.MuokkaaVaraustaPainike.TabIndex = 13;
            this.MuokkaaVaraustaPainike.Text = "Muokkaa";
            this.MuokkaaVaraustaPainike.UseVisualStyleBackColor = false;
            this.MuokkaaVaraustaPainike.Click += new System.EventHandler(this.MuokkaaVaraustaPainike_Click);
            // 
            // UusiVarausPainike
            // 
            this.UusiVarausPainike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UusiVarausPainike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UusiVarausPainike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.UusiVarausPainike.Location = new System.Drawing.Point(29, 374);
            this.UusiVarausPainike.Name = "UusiVarausPainike";
            this.UusiVarausPainike.Size = new System.Drawing.Size(96, 47);
            this.UusiVarausPainike.TabIndex = 12;
            this.UusiVarausPainike.Text = "Lisää uusi \r\nvaraus";
            this.UusiVarausPainike.UseVisualStyleBackColor = false;
            this.UusiVarausPainike.Click += new System.EventHandler(this.UusiVarausPainike_Click);
            // 
            // VarauksetDG
            // 
            this.VarauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(182)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VarauksetDG.DefaultCellStyle = dataGridViewCellStyle3;
            this.VarauksetDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.VarauksetDG.Location = new System.Drawing.Point(422, 116);
            this.VarauksetDG.Name = "VarauksetDG";
            this.VarauksetDG.Size = new System.Drawing.Size(545, 331);
            this.VarauksetDG.TabIndex = 11;
            this.VarauksetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VarauksetDG_CellClick);
            this.VarauksetDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VarauksetDG_CellContentClick);
            // 
            // SisaanLB
            // 
            this.SisaanLB.AutoSize = true;
            this.SisaanLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SisaanLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.SisaanLB.Location = new System.Drawing.Point(118, 264);
            this.SisaanLB.Name = "SisaanLB";
            this.SisaanLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SisaanLB.Size = new System.Drawing.Size(89, 27);
            this.SisaanLB.TabIndex = 9;
            this.SisaanLB.Text = "Sisään:";
            // 
            // HuoneenNroLB
            // 
            this.HuoneenNroLB.AutoSize = true;
            this.HuoneenNroLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneenNroLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.HuoneenNroLB.Location = new System.Drawing.Point(55, 230);
            this.HuoneenNroLB.Name = "HuoneenNroLB";
            this.HuoneenNroLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HuoneenNroLB.Size = new System.Drawing.Size(152, 27);
            this.HuoneenNroLB.TabIndex = 7;
            this.HuoneenNroLB.Text = "Huoneen nro:";
            // 
            // HuonetyyppiLB
            // 
            this.HuonetyyppiLB.AutoSize = true;
            this.HuonetyyppiLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuonetyyppiLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.HuonetyyppiLB.Location = new System.Drawing.Point(55, 196);
            this.HuonetyyppiLB.Name = "HuonetyyppiLB";
            this.HuonetyyppiLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HuonetyyppiLB.Size = new System.Drawing.Size(156, 27);
            this.HuonetyyppiLB.TabIndex = 5;
            this.HuonetyyppiLB.Text = "Huonetyyppi: ";
            // 
            // AsiakasNroLB
            // 
            this.AsiakasNroLB.AutoSize = true;
            this.AsiakasNroLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasNroLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AsiakasNroLB.Location = new System.Drawing.Point(65, 160);
            this.AsiakasNroLB.Name = "AsiakasNroLB";
            this.AsiakasNroLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AsiakasNroLB.Size = new System.Drawing.Size(142, 27);
            this.AsiakasNroLB.TabIndex = 1;
            this.AsiakasNroLB.Text = "Asiakas nro:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 81);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.VarausNroTB);
            this.panel1.Controls.Add(this.VarausNroLB);
            this.panel1.Controls.Add(this.AsiakasCB);
            this.panel1.Controls.Add(this.UlosDTP);
            this.panel1.Controls.Add(this.SisaanDTP);
            this.panel1.Controls.Add(this.HuoneNroCB);
            this.panel1.Controls.Add(this.HuonetyyppiCB);
            this.panel1.Controls.Add(this.UlosLB);
            this.panel1.Controls.Add(this.TyhjennaVarausPainike);
            this.panel1.Controls.Add(this.PoistaVarausPainike);
            this.panel1.Controls.Add(this.MuokkaaVaraustaPainike);
            this.panel1.Controls.Add(this.UusiVarausPainike);
            this.panel1.Controls.Add(this.VarauksetDG);
            this.panel1.Controls.Add(this.SisaanLB);
            this.panel1.Controls.Add(this.HuoneenNroLB);
            this.panel1.Controls.Add(this.HuonetyyppiLB);
            this.panel1.Controls.Add(this.AsiakasNroLB);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 454);
            this.panel1.TabIndex = 1;
            // 
            // VarausNroTB
            // 
            this.VarausNroTB.BackColor = System.Drawing.Color.White;
            this.VarausNroTB.Enabled = false;
            this.VarausNroTB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausNroTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.VarausNroTB.Location = new System.Drawing.Point(214, 121);
            this.VarausNroTB.Name = "VarausNroTB";
            this.VarausNroTB.Size = new System.Drawing.Size(190, 29);
            this.VarausNroTB.TabIndex = 24;
            // 
            // VarausNroLB
            // 
            this.VarausNroLB.AutoSize = true;
            this.VarausNroLB.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausNroLB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.VarausNroLB.Location = new System.Drawing.Point(76, 121);
            this.VarausNroLB.Name = "VarausNroLB";
            this.VarausNroLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VarausNroLB.Size = new System.Drawing.Size(131, 27);
            this.VarausNroLB.TabIndex = 23;
            this.VarausNroLB.Text = "Varaus nro:";
            // 
            // AsiakasCB
            // 
            this.AsiakasCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(182)))), ((int)(((byte)(130)))));
            this.AsiakasCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AsiakasCB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.AsiakasCB.FormattingEnabled = true;
            this.AsiakasCB.Location = new System.Drawing.Point(214, 157);
            this.AsiakasCB.Name = "AsiakasCB";
            this.AsiakasCB.Size = new System.Drawing.Size(190, 30);
            this.AsiakasCB.TabIndex = 22;
            // 
            // UlosDTP
            // 
            this.UlosDTP.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UlosDTP.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.UlosDTP.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(182)))), ((int)(((byte)(130)))));
            this.UlosDTP.CustomFormat = "dd.MM.yyyy";
            this.UlosDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UlosDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UlosDTP.Location = new System.Drawing.Point(213, 302);
            this.UlosDTP.Name = "UlosDTP";
            this.UlosDTP.Size = new System.Drawing.Size(190, 29);
            this.UlosDTP.TabIndex = 21;
            this.UlosDTP.ValueChanged += new System.EventHandler(this.UlosDTP_ValueChanged);
            // 
            // SisaanDTP
            // 
            this.SisaanDTP.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SisaanDTP.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.SisaanDTP.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(182)))), ((int)(((byte)(130)))));
            this.SisaanDTP.CustomFormat = "dd.MM.yyyy";
            this.SisaanDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SisaanDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SisaanDTP.Location = new System.Drawing.Point(214, 264);
            this.SisaanDTP.Name = "SisaanDTP";
            this.SisaanDTP.Size = new System.Drawing.Size(190, 29);
            this.SisaanDTP.TabIndex = 20;
            // 
            // HuoneNroCB
            // 
            this.HuoneNroCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(182)))), ((int)(((byte)(130)))));
            this.HuoneNroCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuoneNroCB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneNroCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.HuoneNroCB.FormattingEnabled = true;
            this.HuoneNroCB.Location = new System.Drawing.Point(213, 227);
            this.HuoneNroCB.Name = "HuoneNroCB";
            this.HuoneNroCB.Size = new System.Drawing.Size(190, 30);
            this.HuoneNroCB.TabIndex = 19;
            // 
            // HuonetyyppiCB
            // 
            this.HuonetyyppiCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(182)))), ((int)(((byte)(130)))));
            this.HuonetyyppiCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HuonetyyppiCB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuonetyyppiCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(102)))), ((int)(((byte)(42)))));
            this.HuonetyyppiCB.FormattingEnabled = true;
            this.HuonetyyppiCB.Location = new System.Drawing.Point(214, 193);
            this.HuonetyyppiCB.Name = "HuonetyyppiCB";
            this.HuonetyyppiCB.Size = new System.Drawing.Size(190, 30);
            this.HuonetyyppiCB.TabIndex = 18;
            this.HuonetyyppiCB.SelectedIndexChanged += new System.EventHandler(this.HuonetyyppiCB_SelectedIndexChanged);
            // 
            // VaraustenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 454);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VaraustenHallinta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VaraustenHallinta";
            this.Load += new System.EventHandler(this.VaraustenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UlosLB;
        private System.Windows.Forms.Button TyhjennaVarausPainike;
        private System.Windows.Forms.Button PoistaVarausPainike;
        private System.Windows.Forms.Button MuokkaaVaraustaPainike;
        private System.Windows.Forms.Button UusiVarausPainike;
        private System.Windows.Forms.DataGridView VarauksetDG;
        private System.Windows.Forms.Label SisaanLB;
        private System.Windows.Forms.Label HuoneenNroLB;
        private System.Windows.Forms.Label HuonetyyppiLB;
        private System.Windows.Forms.Label AsiakasNroLB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker UlosDTP;
        private System.Windows.Forms.DateTimePicker SisaanDTP;
        private System.Windows.Forms.ComboBox HuoneNroCB;
        private System.Windows.Forms.ComboBox HuonetyyppiCB;
        private System.Windows.Forms.ComboBox AsiakasCB;
        private System.Windows.Forms.Label VarausNroLB;
        private System.Windows.Forms.TextBox VarausNroTB;
    }
}