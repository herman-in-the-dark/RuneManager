﻿namespace RuneApp
{
	partial class StatColumn
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbHP = new System.Windows.Forms.Label();
			this.tbHP = new System.Windows.Forms.TextBox();
			this.lbTitle = new System.Windows.Forms.Label();
			this.tbATK = new System.Windows.Forms.TextBox();
			this.lbATK = new System.Windows.Forms.Label();
			this.tbDEF = new System.Windows.Forms.TextBox();
			this.lbDEF = new System.Windows.Forms.Label();
			this.tbSPD = new System.Windows.Forms.TextBox();
			this.lbSPD = new System.Windows.Forms.Label();
			this.tbCRate = new System.Windows.Forms.TextBox();
			this.lbCRate = new System.Windows.Forms.Label();
			this.tbCDam = new System.Windows.Forms.TextBox();
			this.lbCDam = new System.Windows.Forms.Label();
			this.tbRES = new System.Windows.Forms.TextBox();
			this.lbRES = new System.Windows.Forms.Label();
			this.tbACC = new System.Windows.Forms.TextBox();
			this.lbACC = new System.Windows.Forms.Label();
			this.tbEHP = new System.Windows.Forms.TextBox();
			this.lbEHP = new System.Windows.Forms.Label();
			this.tbEHPDB = new System.Windows.Forms.TextBox();
			this.lbEHPDB = new System.Windows.Forms.Label();
			this.tbDPS = new System.Windows.Forms.TextBox();
			this.lbDPS = new System.Windows.Forms.Label();
			this.tbAvDam = new System.Windows.Forms.TextBox();
			this.lbAvDam = new System.Windows.Forms.Label();
			this.tbMxDam = new System.Windows.Forms.TextBox();
			this.lbMxDam = new System.Windows.Forms.Label();
			this.tbSkill1 = new System.Windows.Forms.TextBox();
			this.tbSkill2 = new System.Windows.Forms.TextBox();
			this.tbSkill3 = new System.Windows.Forms.TextBox();
			this.tbSkill4 = new System.Windows.Forms.TextBox();
			this.lbSkill1 = new System.Windows.Forms.Label();
			this.lbSkill2 = new System.Windows.Forms.Label();
			this.lbSkill3 = new System.Windows.Forms.Label();
			this.lbSkill4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbHP
			// 
			this.lbHP.Location = new System.Drawing.Point(6, 19);
			this.lbHP.Name = "lbHP";
			this.lbHP.Size = new System.Drawing.Size(52, 13);
			this.lbHP.TabIndex = 0;
			this.lbHP.Text = "HP";
			this.lbHP.Tag = RuneOptim.Attr.HealthPercent;
			this.lbHP.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbHP
			// 
			this.tbHP.Location = new System.Drawing.Point(3, 16);
			this.tbHP.Name = "tbHP";
			this.tbHP.Size = new System.Drawing.Size(60, 20);
			this.tbHP.TabIndex = 1;
			this.tbHP.Tag = RuneOptim.Attr.HealthPercent;
			this.tbHP.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Location = new System.Drawing.Point(3, 0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(27, 13);
			this.lbTitle.TabIndex = 2;
			this.lbTitle.Text = "Title";
			// 
			// tbATK
			// 
			this.tbATK.Location = new System.Drawing.Point(3, 42);
			this.tbATK.Name = "tbATK";
			this.tbATK.Size = new System.Drawing.Size(60, 20);
			this.tbATK.TabIndex = 1;
			this.tbATK.Tag = RuneOptim.Attr.AttackPercent;
			this.tbATK.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbATK
			// 
			this.lbATK.Location = new System.Drawing.Point(6, 45);
			this.lbATK.Name = "lbATK";
			this.lbATK.Size = new System.Drawing.Size(52, 13);
			this.lbATK.TabIndex = 0;
			this.lbATK.Tag = RuneOptim.Attr.AttackPercent;
			this.lbATK.Text = "ATK";
			this.lbATK.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbDEF
			// 
			this.tbDEF.Location = new System.Drawing.Point(3, 68);
			this.tbDEF.Name = "tbDEF";
			this.tbDEF.Size = new System.Drawing.Size(60, 20);
			this.tbDEF.TabIndex = 1;
			this.tbDEF.Tag = RuneOptim.Attr.DefensePercent;
			this.tbDEF.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbDEF
			// 
			this.lbDEF.Location = new System.Drawing.Point(6, 71);
			this.lbDEF.Name = "lbDEF";
			this.lbDEF.Size = new System.Drawing.Size(52, 13);
			this.lbDEF.TabIndex = 0;
			this.lbDEF.Tag = RuneOptim.Attr.DefensePercent;
			this.lbDEF.Text = "DEF";
			this.lbDEF.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbSPD
			// 
			this.tbSPD.Location = new System.Drawing.Point(3, 94);
			this.tbSPD.Name = "tbSPD";
			this.tbSPD.Size = new System.Drawing.Size(60, 20);
			this.tbSPD.TabIndex = 1;
			this.tbSPD.Tag = RuneOptim.Attr.Speed;
			this.tbSPD.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbSPD
			// 
			this.lbSPD.Location = new System.Drawing.Point(6, 97);
			this.lbSPD.Name = "lbSPD";
			this.lbSPD.Size = new System.Drawing.Size(52, 13);
			this.lbSPD.TabIndex = 0;
			this.lbSPD.Tag = RuneOptim.Attr.Speed;
			this.lbSPD.Text = "SPD";
			this.lbSPD.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbCRate
			// 
			this.tbCRate.Location = new System.Drawing.Point(3, 131);
			this.tbCRate.Name = "tbCRate";
			this.tbCRate.Size = new System.Drawing.Size(60, 20);
			this.tbCRate.TabIndex = 1;
			this.tbCRate.Tag = RuneOptim.Attr.CritRate;
			this.tbCRate.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbCRate
			// 
			this.lbCRate.Location = new System.Drawing.Point(6, 134);
			this.lbCRate.Name = "lbCRate";
			this.lbCRate.Size = new System.Drawing.Size(52, 13);
			this.lbCRate.TabIndex = 0;
			this.lbCRate.Tag = RuneOptim.Attr.CritRate;
			this.lbCRate.Text = "C Rate";
			this.lbCRate.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbCDam
			// 
			this.tbCDam.Location = new System.Drawing.Point(3, 157);
			this.tbCDam.Name = "tbCDam";
			this.tbCDam.Size = new System.Drawing.Size(60, 20);
			this.tbCDam.TabIndex = 1;
			this.tbCDam.Tag = RuneOptim.Attr.CritDamage;
			this.tbCDam.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbCDam
			// 
			this.lbCDam.Location = new System.Drawing.Point(6, 160);
			this.lbCDam.Name = "lbCDam";
			this.lbCDam.Size = new System.Drawing.Size(52, 13);
			this.lbCDam.TabIndex = 0;
			this.lbCDam.Tag = RuneOptim.Attr.CritDamage;
			this.lbCDam.Text = "C Dam";
			this.lbCDam.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbRES
			// 
			this.tbRES.Location = new System.Drawing.Point(3, 183);
			this.tbRES.Name = "tbRES";
			this.tbRES.Size = new System.Drawing.Size(60, 20);
			this.tbRES.TabIndex = 1;
			this.tbRES.Tag = RuneOptim.Attr.Resistance;
			this.tbRES.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbRES
			// 
			this.lbRES.Location = new System.Drawing.Point(6, 186);
			this.lbRES.Name = "lbRES";
			this.lbRES.Size = new System.Drawing.Size(52, 13);
			this.lbRES.TabIndex = 0;
			this.lbRES.Tag = RuneOptim.Attr.Resistance;
			this.lbRES.Text = "RES";
			this.lbRES.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbACC
			// 
			this.tbACC.Location = new System.Drawing.Point(3, 209);
			this.tbACC.Name = "tbACC";
			this.tbACC.Size = new System.Drawing.Size(60, 20);
			this.tbACC.TabIndex = 1;
			this.tbACC.Tag = RuneOptim.Attr.Accuracy;
			this.tbACC.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbACC
			// 
			this.lbACC.Location = new System.Drawing.Point(6, 212);
			this.lbACC.Name = "lbACC";
			this.lbACC.Size = new System.Drawing.Size(52, 13);
			this.lbACC.TabIndex = 0;
			this.lbACC.Tag = RuneOptim.Attr.Accuracy;
			this.lbACC.Text = "ACC";
			this.lbACC.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbEHP
			// 
			this.tbEHP.Location = new System.Drawing.Point(3, 244);
			this.tbEHP.Name = "tbEHP";
			this.tbEHP.Size = new System.Drawing.Size(60, 20);
			this.tbEHP.TabIndex = 1;
			this.tbEHP.Tag = RuneOptim.Attr.EffectiveHP;
			this.tbEHP.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbEHP
			// 
			this.lbEHP.Location = new System.Drawing.Point(6, 247);
			this.lbEHP.Name = "lbEHP";
			this.lbEHP.Size = new System.Drawing.Size(52, 13);
			this.lbEHP.TabIndex = 0;
			this.lbEHP.Tag = RuneOptim.Attr.EffectiveHP;
			this.lbEHP.Text = "EHP";
			this.lbEHP.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbEHPDB
			// 
			this.tbEHPDB.Location = new System.Drawing.Point(3, 270);
			this.tbEHPDB.Name = "tbEHPDB";
			this.tbEHPDB.Size = new System.Drawing.Size(60, 20);
			this.tbEHPDB.TabIndex = 1;
			this.tbEHPDB.Tag = RuneOptim.Attr.EffectiveHPDefenseBreak;
			this.tbEHPDB.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbEHPDB
			// 
			this.lbEHPDB.Location = new System.Drawing.Point(6, 273);
			this.lbEHPDB.Name = "lbEHPDB";
			this.lbEHPDB.Size = new System.Drawing.Size(52, 13);
			this.lbEHPDB.TabIndex = 0;
			this.lbEHPDB.Tag = RuneOptim.Attr.EffectiveHPDefenseBreak;
			this.lbEHPDB.Text = "EHPDB";
			this.lbEHPDB.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbDPS
			// 
			this.tbDPS.Location = new System.Drawing.Point(3, 296);
			this.tbDPS.Name = "tbDPS";
			this.tbDPS.Size = new System.Drawing.Size(60, 20);
			this.tbDPS.TabIndex = 1;
			this.tbDPS.Tag = RuneOptim.Attr.DamagePerSpeed;
			this.tbDPS.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbDPS
			// 
			this.lbDPS.Location = new System.Drawing.Point(6, 299);
			this.lbDPS.Name = "lbDPS";
			this.lbDPS.Size = new System.Drawing.Size(52, 13);
			this.lbDPS.TabIndex = 0;
			this.lbDPS.Tag = RuneOptim.Attr.DamagePerSpeed;
			this.lbDPS.Text = "DPS";
			this.lbDPS.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbAvDam
			// 
			this.tbAvDam.Location = new System.Drawing.Point(3, 322);
			this.tbAvDam.Name = "tbAvDam";
			this.tbAvDam.Size = new System.Drawing.Size(60, 20);
			this.tbAvDam.TabIndex = 1;
			this.tbAvDam.Tag = RuneOptim.Attr.AverageDamage;
			this.tbAvDam.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbAvDam
			// 
			this.lbAvDam.Location = new System.Drawing.Point(6, 325);
			this.lbAvDam.Name = "lbAvDam";
			this.lbAvDam.Size = new System.Drawing.Size(52, 13);
			this.lbAvDam.TabIndex = 0;
			this.lbAvDam.Tag = RuneOptim.Attr.AverageDamage;
			this.lbAvDam.Text = "AvDam";
			this.lbAvDam.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbMxDam
			// 
			this.tbMxDam.Location = new System.Drawing.Point(3, 348);
			this.tbMxDam.Name = "tbMxDam";
			this.tbMxDam.Size = new System.Drawing.Size(60, 20);
			this.tbMxDam.TabIndex = 1;
			this.tbMxDam.Tag = RuneOptim.Attr.MaxDamage;
			this.tbMxDam.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbMxDam
			// 
			this.lbMxDam.Location = new System.Drawing.Point(6, 351);
			this.lbMxDam.Name = "lbMxDam";
			this.lbMxDam.Size = new System.Drawing.Size(52, 13);
			this.lbMxDam.TabIndex = 0;
			this.lbMxDam.Tag = RuneOptim.Attr.MaxDamage;
			this.lbMxDam.Text = "MxDam";
			this.lbMxDam.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbSkill1
			// 
			this.tbSkill1.Location = new System.Drawing.Point(3, 383);
			this.tbSkill1.Name = "tbSkill1";
			this.tbSkill1.Size = new System.Drawing.Size(60, 20);
			this.tbSkill1.TabIndex = 1;
			this.tbSkill1.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// tbSkill2
			// 
			this.tbSkill2.Location = new System.Drawing.Point(3, 409);
			this.tbSkill2.Name = "tbSkill2";
			this.tbSkill2.Size = new System.Drawing.Size(60, 20);
			this.tbSkill2.TabIndex = 1;
			this.tbSkill2.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// tbSkill3
			// 
			this.tbSkill3.Location = new System.Drawing.Point(3, 435);
			this.tbSkill3.Name = "tbSkill3";
			this.tbSkill3.Size = new System.Drawing.Size(60, 20);
			this.tbSkill3.TabIndex = 1;
			this.tbSkill3.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// tbSkill4
			// 
			this.tbSkill4.Location = new System.Drawing.Point(3, 461);
			this.tbSkill4.Name = "tbSkill4";
			this.tbSkill4.Size = new System.Drawing.Size(60, 20);
			this.tbSkill4.TabIndex = 1;
			this.tbSkill4.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// lbSkill1
			// 
			this.lbSkill1.Location = new System.Drawing.Point(6, 386);
			this.lbSkill1.Name = "lbSkill1";
			this.lbSkill1.Size = new System.Drawing.Size(52, 13);
			this.lbSkill1.TabIndex = 0;
			this.lbSkill1.Text = "Skill1";
			this.lbSkill1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lbSkill2
			// 
			this.lbSkill2.Location = new System.Drawing.Point(6, 412);
			this.lbSkill2.Name = "lbSkill2";
			this.lbSkill2.Size = new System.Drawing.Size(52, 13);
			this.lbSkill2.TabIndex = 0;
			this.lbSkill2.Text = "Skill2";
			this.lbSkill2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lbSkill3
			// 
			this.lbSkill3.Location = new System.Drawing.Point(6, 438);
			this.lbSkill3.Name = "lbSkill3";
			this.lbSkill3.Size = new System.Drawing.Size(52, 13);
			this.lbSkill3.TabIndex = 0;
			this.lbSkill3.Text = "Skill3";
			this.lbSkill3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lbSkill4
			// 
			this.lbSkill4.Location = new System.Drawing.Point(6, 464);
			this.lbSkill4.Name = "lbSkill4";
			this.lbSkill4.Size = new System.Drawing.Size(52, 13);
			this.lbSkill4.TabIndex = 0;
			this.lbSkill4.Text = "Skill4";
			this.lbSkill4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// StatColumn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.lbMxDam);
			this.Controls.Add(this.lbAvDam);
			this.Controls.Add(this.lbDPS);
			this.Controls.Add(this.lbEHPDB);
			this.Controls.Add(this.lbEHP);
			this.Controls.Add(this.lbSkill4);
			this.Controls.Add(this.lbACC);
			this.Controls.Add(this.lbSkill3);
			this.Controls.Add(this.lbRES);
			this.Controls.Add(this.lbSkill2);
			this.Controls.Add(this.lbCDam);
			this.Controls.Add(this.lbSkill1);
			this.Controls.Add(this.lbCRate);
			this.Controls.Add(this.lbSPD);
			this.Controls.Add(this.lbDEF);
			this.Controls.Add(this.lbATK);
			this.Controls.Add(this.lbHP);
			this.Controls.Add(this.tbMxDam);
			this.Controls.Add(this.tbAvDam);
			this.Controls.Add(this.tbDPS);
			this.Controls.Add(this.tbEHPDB);
			this.Controls.Add(this.tbEHP);
			this.Controls.Add(this.tbSkill4);
			this.Controls.Add(this.tbACC);
			this.Controls.Add(this.tbSkill3);
			this.Controls.Add(this.tbRES);
			this.Controls.Add(this.tbSkill2);
			this.Controls.Add(this.tbCDam);
			this.Controls.Add(this.tbSkill1);
			this.Controls.Add(this.tbCRate);
			this.Controls.Add(this.tbSPD);
			this.Controls.Add(this.tbDEF);
			this.Controls.Add(this.tbATK);
			this.Controls.Add(this.tbHP);
			this.Name = "StatColumn";
			this.Size = new System.Drawing.Size(69, 489);
			this.Load += new System.EventHandler(this.StatColumn_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbHP;
		private System.Windows.Forms.TextBox tbHP;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.TextBox tbATK;
		private System.Windows.Forms.Label lbATK;
		private System.Windows.Forms.TextBox tbDEF;
		private System.Windows.Forms.Label lbDEF;
		private System.Windows.Forms.TextBox tbSPD;
		private System.Windows.Forms.Label lbSPD;
		private System.Windows.Forms.TextBox tbCRate;
		private System.Windows.Forms.Label lbCRate;
		private System.Windows.Forms.TextBox tbCDam;
		private System.Windows.Forms.Label lbCDam;
		private System.Windows.Forms.TextBox tbRES;
		private System.Windows.Forms.Label lbRES;
		private System.Windows.Forms.TextBox tbACC;
		private System.Windows.Forms.Label lbACC;
		private System.Windows.Forms.TextBox tbEHP;
		private System.Windows.Forms.Label lbEHP;
		private System.Windows.Forms.TextBox tbEHPDB;
		private System.Windows.Forms.Label lbEHPDB;
		private System.Windows.Forms.TextBox tbDPS;
		private System.Windows.Forms.Label lbDPS;
		private System.Windows.Forms.TextBox tbAvDam;
		private System.Windows.Forms.Label lbAvDam;
		private System.Windows.Forms.TextBox tbMxDam;
		private System.Windows.Forms.Label lbMxDam;
		private System.Windows.Forms.TextBox tbSkill1;
		private System.Windows.Forms.TextBox tbSkill2;
		private System.Windows.Forms.TextBox tbSkill3;
		private System.Windows.Forms.TextBox tbSkill4;
		private System.Windows.Forms.Label lbSkill1;
		private System.Windows.Forms.Label lbSkill2;
		private System.Windows.Forms.Label lbSkill3;
		private System.Windows.Forms.Label lbSkill4;
	}
}