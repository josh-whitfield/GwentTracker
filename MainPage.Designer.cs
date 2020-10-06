using System.Drawing;
using System.Windows.Forms;

namespace GwentTracker
{
    sealed partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.lblEndRound = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerOneHeroRange = new System.Windows.Forms.RichTextBox();
            this.txtPlayerOneRegRange = new System.Windows.Forms.RichTextBox();
            this.txtPlayerOneHeroMelee = new System.Windows.Forms.RichTextBox();
            this.txtPlayerOneRegMelee = new System.Windows.Forms.RichTextBox();
            this.txtPlayerOneHeroSiege = new System.Windows.Forms.RichTextBox();
            this.txtPlayerOneRegSiege = new System.Windows.Forms.RichTextBox();
            this.txtPlayerTwoRegMelee = new System.Windows.Forms.RichTextBox();
            this.txtPlayerTwoHeroMelee = new System.Windows.Forms.RichTextBox();
            this.txtPlayerTwoRegSiege = new System.Windows.Forms.RichTextBox();
            this.txtPlayerTwoHeroSiege = new System.Windows.Forms.RichTextBox();
            this.txtPlayerTwoRegRange = new System.Windows.Forms.RichTextBox();
            this.txtPlayerTwoHeroRange = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblPlayerOneSect = new System.Windows.Forms.Label();
            this.lblPlayerOneHeroCol = new System.Windows.Forms.Label();
            this.lblPlayerOneRegCol = new System.Windows.Forms.Label();
            this.lblPlayerTwoRegCol = new System.Windows.Forms.Label();
            this.lblPlayerTwoHeroCol = new System.Windows.Forms.Label();
            this.lblPlayerTwoSect = new System.Windows.Forms.Label();
            this.lblPlayerTwoMeleeTotal = new System.Windows.Forms.Label();
            this.lblPlayerTwoRangeTotal = new System.Windows.Forms.Label();
            this.lblPlayerTwoSiegeTotal = new System.Windows.Forms.Label();
            this.lblPlayerTwoTotal = new System.Windows.Forms.Label();
            this.lblPlayerOneTotal = new System.Windows.Forms.Label();
            this.lblPlayerOneMeleeTotal = new System.Windows.Forms.Label();
            this.lblPlayerOneRangeTotal = new System.Windows.Forms.Label();
            this.lblPlayerOneSiegeTotal = new System.Windows.Forms.Label();
            this.lblCalculate = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Turquoise;
            this.lblVersion.Location = new System.Drawing.Point(12, 115);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(51, 24);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "v0.0.1";
            this.lblVersion.UseCompatibleTextRendering = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Algerian", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Turquoise;
            this.lblScore.Location = new System.Drawing.Point(237, 19);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(120, 46);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "SCORE";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblScore.UseCompatibleTextRendering = true;
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOne.Font = new System.Drawing.Font("Algerian", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerOne.Location = new System.Drawing.Point(218, 62);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(167, 30);
            this.lblPlayerOne.TabIndex = 3;
            this.lblPlayerOne.Text = "PLAYER ONE : 0";
            this.lblPlayerOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerOne.UseCompatibleTextRendering = true;
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwo.Font = new System.Drawing.Font("Algerian", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerTwo.Location = new System.Drawing.Point(218, 92);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(170, 30);
            this.lblPlayerTwo.TabIndex = 4;
            this.lblPlayerTwo.Text = "PLAYER TWO : 0";
            this.lblPlayerTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerTwo.UseCompatibleTextRendering = true;
            // 
            // lblEndRound
            // 
            this.lblEndRound.ActiveLinkColor = System.Drawing.Color.Teal;
            this.lblEndRound.AutoSize = true;
            this.lblEndRound.BackColor = System.Drawing.Color.Transparent;
            this.lblEndRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndRound.LinkColor = System.Drawing.Color.Yellow;
            this.lblEndRound.Location = new System.Drawing.Point(438, 73);
            this.lblEndRound.Name = "lblEndRound";
            this.lblEndRound.Size = new System.Drawing.Size(117, 30);
            this.lblEndRound.TabIndex = 5;
            this.lblEndRound.TabStop = true;
            this.lblEndRound.Text = "End Round";
            this.lblEndRound.UseCompatibleTextRendering = true;
            this.lblEndRound.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEndRound_LinkClicked);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(7, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 2);
            this.label1.TabIndex = 6;
            // 
            // txtPlayerOneHeroRange
            // 
            this.txtPlayerOneHeroRange.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerOneHeroRange.Location = new System.Drawing.Point(268, 326);
            this.txtPlayerOneHeroRange.Multiline = false;
            this.txtPlayerOneHeroRange.Name = "txtPlayerOneHeroRange";
            this.txtPlayerOneHeroRange.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPlayerOneHeroRange.Size = new System.Drawing.Size(120, 75);
            this.txtPlayerOneHeroRange.TabIndex = 24;
            this.txtPlayerOneHeroRange.Text = "";
            this.txtPlayerOneHeroRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerOneHeroRange_KeyPress);
            // 
            // txtPlayerOneRegRange
            // 
            this.txtPlayerOneRegRange.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerOneRegRange.Location = new System.Drawing.Point(394, 326);
            this.txtPlayerOneRegRange.Multiline = false;
            this.txtPlayerOneRegRange.Name = "txtPlayerOneRegRange";
            this.txtPlayerOneRegRange.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPlayerOneRegRange.Size = new System.Drawing.Size(119, 75);
            this.txtPlayerOneRegRange.TabIndex = 25;
            this.txtPlayerOneRegRange.Text = "";
            this.txtPlayerOneRegRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerOneRegRange_KeyPress);
            // 
            // txtPlayerOneHeroMelee
            // 
            this.txtPlayerOneHeroMelee.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerOneHeroMelee.Location = new System.Drawing.Point(268, 407);
            this.txtPlayerOneHeroMelee.Multiline = false;
            this.txtPlayerOneHeroMelee.Name = "txtPlayerOneHeroMelee";
            this.txtPlayerOneHeroMelee.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPlayerOneHeroMelee.Size = new System.Drawing.Size(120, 75);
            this.txtPlayerOneHeroMelee.TabIndex = 26;
            this.txtPlayerOneHeroMelee.Text = "";
            this.txtPlayerOneHeroMelee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerOneHeroMelee_KeyPress);
            // 
            // txtPlayerOneRegMelee
            // 
            this.txtPlayerOneRegMelee.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerOneRegMelee.Location = new System.Drawing.Point(394, 407);
            this.txtPlayerOneRegMelee.Multiline = false;
            this.txtPlayerOneRegMelee.Name = "txtPlayerOneRegMelee";
            this.txtPlayerOneRegMelee.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPlayerOneRegMelee.Size = new System.Drawing.Size(119, 75);
            this.txtPlayerOneRegMelee.TabIndex = 27;
            this.txtPlayerOneRegMelee.Text = "";
            this.txtPlayerOneRegMelee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerOneRegMelee_KeyPress);
            // 
            // txtPlayerOneHeroSiege
            // 
            this.txtPlayerOneHeroSiege.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerOneHeroSiege.Location = new System.Drawing.Point(268, 245);
            this.txtPlayerOneHeroSiege.Multiline = false;
            this.txtPlayerOneHeroSiege.Name = "txtPlayerOneHeroSiege";
            this.txtPlayerOneHeroSiege.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPlayerOneHeroSiege.Size = new System.Drawing.Size(120, 75);
            this.txtPlayerOneHeroSiege.TabIndex = 28;
            this.txtPlayerOneHeroSiege.Text = "";
            this.txtPlayerOneHeroSiege.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerOneHeroSiege_KeyPress);
            // 
            // txtPlayerOneRegSiege
            // 
            this.txtPlayerOneRegSiege.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerOneRegSiege.Location = new System.Drawing.Point(394, 245);
            this.txtPlayerOneRegSiege.Multiline = false;
            this.txtPlayerOneRegSiege.Name = "txtPlayerOneRegSiege";
            this.txtPlayerOneRegSiege.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPlayerOneRegSiege.Size = new System.Drawing.Size(119, 75);
            this.txtPlayerOneRegSiege.TabIndex = 29;
            this.txtPlayerOneRegSiege.Text = "";
            this.txtPlayerOneRegSiege.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerOneRegSiege_KeyPress);
            // 
            // txtPlayerTwoRegMelee
            // 
            this.txtPlayerTwoRegMelee.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerTwoRegMelee.Location = new System.Drawing.Point(394, 583);
            this.txtPlayerTwoRegMelee.Multiline = false;
            this.txtPlayerTwoRegMelee.Name = "txtPlayerTwoRegMelee";
            this.txtPlayerTwoRegMelee.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPlayerTwoRegMelee.Size = new System.Drawing.Size(120, 75);
            this.txtPlayerTwoRegMelee.TabIndex = 42;
            this.txtPlayerTwoRegMelee.Text = "";
            this.txtPlayerTwoRegMelee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerTwoRegMelee_KeyPress);
            // 
            // txtPlayerTwoHeroMelee
            // 
            this.txtPlayerTwoHeroMelee.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerTwoHeroMelee.Location = new System.Drawing.Point(268, 583);
            this.txtPlayerTwoHeroMelee.Multiline = false;
            this.txtPlayerTwoHeroMelee.Name = "txtPlayerTwoHeroMelee";
            this.txtPlayerTwoHeroMelee.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPlayerTwoHeroMelee.Size = new System.Drawing.Size(120, 75);
            this.txtPlayerTwoHeroMelee.TabIndex = 41;
            this.txtPlayerTwoHeroMelee.Text = "";
            this.txtPlayerTwoHeroMelee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerTwoHeroMelee_KeyPress);
            // 
            // txtPlayerTwoRegSiege
            // 
            this.txtPlayerTwoRegSiege.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerTwoRegSiege.Location = new System.Drawing.Point(394, 745);
            this.txtPlayerTwoRegSiege.Multiline = false;
            this.txtPlayerTwoRegSiege.Name = "txtPlayerTwoRegSiege";
            this.txtPlayerTwoRegSiege.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPlayerTwoRegSiege.Size = new System.Drawing.Size(119, 75);
            this.txtPlayerTwoRegSiege.TabIndex = 40;
            this.txtPlayerTwoRegSiege.Text = "";
            this.txtPlayerTwoRegSiege.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerTwoRegSiege_KeyPress);
            // 
            // txtPlayerTwoHeroSiege
            // 
            this.txtPlayerTwoHeroSiege.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerTwoHeroSiege.Location = new System.Drawing.Point(268, 745);
            this.txtPlayerTwoHeroSiege.Multiline = false;
            this.txtPlayerTwoHeroSiege.Name = "txtPlayerTwoHeroSiege";
            this.txtPlayerTwoHeroSiege.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPlayerTwoHeroSiege.Size = new System.Drawing.Size(120, 75);
            this.txtPlayerTwoHeroSiege.TabIndex = 39;
            this.txtPlayerTwoHeroSiege.Text = "";
            this.txtPlayerTwoHeroSiege.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerTwoHeroSiege_KeyPress);
            // 
            // txtPlayerTwoRegRange
            // 
            this.txtPlayerTwoRegRange.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerTwoRegRange.Location = new System.Drawing.Point(394, 664);
            this.txtPlayerTwoRegRange.Multiline = false;
            this.txtPlayerTwoRegRange.Name = "txtPlayerTwoRegRange";
            this.txtPlayerTwoRegRange.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPlayerTwoRegRange.Size = new System.Drawing.Size(119, 75);
            this.txtPlayerTwoRegRange.TabIndex = 38;
            this.txtPlayerTwoRegRange.Text = "";
            this.txtPlayerTwoRegRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerTwoRegRange_KeyPress);
            // 
            // txtPlayerTwoHeroRange
            // 
            this.txtPlayerTwoHeroRange.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerTwoHeroRange.Location = new System.Drawing.Point(268, 664);
            this.txtPlayerTwoHeroRange.Multiline = false;
            this.txtPlayerTwoHeroRange.Name = "txtPlayerTwoHeroRange";
            this.txtPlayerTwoHeroRange.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPlayerTwoHeroRange.Size = new System.Drawing.Size(120, 75);
            this.txtPlayerTwoHeroRange.TabIndex = 37;
            this.txtPlayerTwoHeroRange.Text = "";
            this.txtPlayerTwoHeroRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerTwoHeroRange_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(7, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(610, 2);
            this.label2.TabIndex = 45;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::GwentTracker.Properties.Resources.MeleeSymbol;
            this.pictureBox4.Location = new System.Drawing.Point(529, 583);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::GwentTracker.Properties.Resources.RangedSymbol;
            this.pictureBox5.Location = new System.Drawing.Point(529, 664);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 75);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::GwentTracker.Properties.Resources.SiegeSymbol;
            this.pictureBox6.Location = new System.Drawing.Point(529, 745);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 75);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 32;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GwentTracker.Properties.Resources.SiegeSymbol;
            this.pictureBox2.Location = new System.Drawing.Point(529, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GwentTracker.Properties.Resources.RangedSymbol;
            this.pictureBox1.Location = new System.Drawing.Point(529, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GwentTracker.Properties.Resources.MeleeSymbol;
            this.pictureBox3.Location = new System.Drawing.Point(529, 407);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblPlayerOneSect
            // 
            this.lblPlayerOneSect.AutoSize = true;
            this.lblPlayerOneSect.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOneSect.Font = new System.Drawing.Font("Algerian", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneSect.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerOneSect.Location = new System.Drawing.Point(202, 157);
            this.lblPlayerOneSect.Name = "lblPlayerOneSect";
            this.lblPlayerOneSect.Size = new System.Drawing.Size(222, 46);
            this.lblPlayerOneSect.TabIndex = 46;
            this.lblPlayerOneSect.Text = "PLAYER ONE";
            this.lblPlayerOneSect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerOneSect.UseCompatibleTextRendering = true;
            // 
            // lblPlayerOneHeroCol
            // 
            this.lblPlayerOneHeroCol.AutoSize = true;
            this.lblPlayerOneHeroCol.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOneHeroCol.Font = new System.Drawing.Font("Algerian", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneHeroCol.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerOneHeroCol.Location = new System.Drawing.Point(302, 212);
            this.lblPlayerOneHeroCol.Name = "lblPlayerOneHeroCol";
            this.lblPlayerOneHeroCol.Size = new System.Drawing.Size(69, 30);
            this.lblPlayerOneHeroCol.TabIndex = 47;
            this.lblPlayerOneHeroCol.Text = "HERO:";
            this.lblPlayerOneHeroCol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerOneHeroCol.UseCompatibleTextRendering = true;
            // 
            // lblPlayerOneRegCol
            // 
            this.lblPlayerOneRegCol.AutoSize = true;
            this.lblPlayerOneRegCol.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOneRegCol.Font = new System.Drawing.Font("Algerian", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneRegCol.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerOneRegCol.Location = new System.Drawing.Point(429, 212);
            this.lblPlayerOneRegCol.Name = "lblPlayerOneRegCol";
            this.lblPlayerOneRegCol.Size = new System.Drawing.Size(56, 30);
            this.lblPlayerOneRegCol.TabIndex = 48;
            this.lblPlayerOneRegCol.Text = "REG:";
            this.lblPlayerOneRegCol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerOneRegCol.UseCompatibleTextRendering = true;
            // 
            // lblPlayerTwoRegCol
            // 
            this.lblPlayerTwoRegCol.AutoSize = true;
            this.lblPlayerTwoRegCol.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwoRegCol.Font = new System.Drawing.Font("Algerian", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoRegCol.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerTwoRegCol.Location = new System.Drawing.Point(429, 550);
            this.lblPlayerTwoRegCol.Name = "lblPlayerTwoRegCol";
            this.lblPlayerTwoRegCol.Size = new System.Drawing.Size(56, 30);
            this.lblPlayerTwoRegCol.TabIndex = 50;
            this.lblPlayerTwoRegCol.Text = "REG:";
            this.lblPlayerTwoRegCol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerTwoRegCol.UseCompatibleTextRendering = true;
            // 
            // lblPlayerTwoHeroCol
            // 
            this.lblPlayerTwoHeroCol.AutoSize = true;
            this.lblPlayerTwoHeroCol.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwoHeroCol.Font = new System.Drawing.Font("Algerian", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoHeroCol.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerTwoHeroCol.Location = new System.Drawing.Point(302, 550);
            this.lblPlayerTwoHeroCol.Name = "lblPlayerTwoHeroCol";
            this.lblPlayerTwoHeroCol.Size = new System.Drawing.Size(69, 30);
            this.lblPlayerTwoHeroCol.TabIndex = 49;
            this.lblPlayerTwoHeroCol.Text = "HERO:";
            this.lblPlayerTwoHeroCol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerTwoHeroCol.UseCompatibleTextRendering = true;
            // 
            // lblPlayerTwoSect
            // 
            this.lblPlayerTwoSect.AutoSize = true;
            this.lblPlayerTwoSect.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwoSect.Font = new System.Drawing.Font("Algerian", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoSect.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerTwoSect.Location = new System.Drawing.Point(196, 506);
            this.lblPlayerTwoSect.Name = "lblPlayerTwoSect";
            this.lblPlayerTwoSect.Size = new System.Drawing.Size(228, 46);
            this.lblPlayerTwoSect.TabIndex = 51;
            this.lblPlayerTwoSect.Text = "PLAYER TWO";
            this.lblPlayerTwoSect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerTwoSect.UseCompatibleTextRendering = true;
            // 
            // lblPlayerTwoMeleeTotal
            // 
            this.lblPlayerTwoMeleeTotal.AutoSize = true;
            this.lblPlayerTwoMeleeTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwoMeleeTotal.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoMeleeTotal.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerTwoMeleeTotal.Location = new System.Drawing.Point(155, 590);
            this.lblPlayerTwoMeleeTotal.Name = "lblPlayerTwoMeleeTotal";
            this.lblPlayerTwoMeleeTotal.Size = new System.Drawing.Size(57, 78);
            this.lblPlayerTwoMeleeTotal.TabIndex = 52;
            this.lblPlayerTwoMeleeTotal.Text = "0";
            this.lblPlayerTwoMeleeTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerTwoMeleeTotal.UseCompatibleTextRendering = true;
            // 
            // lblPlayerTwoRangeTotal
            // 
            this.lblPlayerTwoRangeTotal.AutoSize = true;
            this.lblPlayerTwoRangeTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwoRangeTotal.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoRangeTotal.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerTwoRangeTotal.Location = new System.Drawing.Point(155, 674);
            this.lblPlayerTwoRangeTotal.Name = "lblPlayerTwoRangeTotal";
            this.lblPlayerTwoRangeTotal.Size = new System.Drawing.Size(57, 78);
            this.lblPlayerTwoRangeTotal.TabIndex = 53;
            this.lblPlayerTwoRangeTotal.Text = "0";
            this.lblPlayerTwoRangeTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerTwoRangeTotal.UseCompatibleTextRendering = true;
            // 
            // lblPlayerTwoSiegeTotal
            // 
            this.lblPlayerTwoSiegeTotal.AutoSize = true;
            this.lblPlayerTwoSiegeTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwoSiegeTotal.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoSiegeTotal.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerTwoSiegeTotal.Location = new System.Drawing.Point(155, 753);
            this.lblPlayerTwoSiegeTotal.Name = "lblPlayerTwoSiegeTotal";
            this.lblPlayerTwoSiegeTotal.Size = new System.Drawing.Size(57, 78);
            this.lblPlayerTwoSiegeTotal.TabIndex = 54;
            this.lblPlayerTwoSiegeTotal.Text = "0";
            this.lblPlayerTwoSiegeTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerTwoSiegeTotal.UseCompatibleTextRendering = true;
            // 
            // lblPlayerTwoTotal
            // 
            this.lblPlayerTwoTotal.AutoSize = true;
            this.lblPlayerTwoTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTwoTotal.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoTotal.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerTwoTotal.Location = new System.Drawing.Point(12, 672);
            this.lblPlayerTwoTotal.Name = "lblPlayerTwoTotal";
            this.lblPlayerTwoTotal.Size = new System.Drawing.Size(57, 78);
            this.lblPlayerTwoTotal.TabIndex = 55;
            this.lblPlayerTwoTotal.Text = "0";
            this.lblPlayerTwoTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerTwoTotal.UseCompatibleTextRendering = true;
            // 
            // lblPlayerOneTotal
            // 
            this.lblPlayerOneTotal.AutoSize = true;
            this.lblPlayerOneTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOneTotal.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneTotal.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerOneTotal.Location = new System.Drawing.Point(12, 326);
            this.lblPlayerOneTotal.Name = "lblPlayerOneTotal";
            this.lblPlayerOneTotal.Size = new System.Drawing.Size(57, 78);
            this.lblPlayerOneTotal.TabIndex = 59;
            this.lblPlayerOneTotal.Text = "0";
            this.lblPlayerOneTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerOneTotal.UseCompatibleTextRendering = true;
            // 
            // lblPlayerOneMeleeTotal
            // 
            this.lblPlayerOneMeleeTotal.AutoSize = true;
            this.lblPlayerOneMeleeTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOneMeleeTotal.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneMeleeTotal.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerOneMeleeTotal.Location = new System.Drawing.Point(155, 420);
            this.lblPlayerOneMeleeTotal.Name = "lblPlayerOneMeleeTotal";
            this.lblPlayerOneMeleeTotal.Size = new System.Drawing.Size(57, 78);
            this.lblPlayerOneMeleeTotal.TabIndex = 58;
            this.lblPlayerOneMeleeTotal.Text = "0";
            this.lblPlayerOneMeleeTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerOneMeleeTotal.UseCompatibleTextRendering = true;
            // 
            // lblPlayerOneRangeTotal
            // 
            this.lblPlayerOneRangeTotal.AutoSize = true;
            this.lblPlayerOneRangeTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOneRangeTotal.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneRangeTotal.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerOneRangeTotal.Location = new System.Drawing.Point(155, 339);
            this.lblPlayerOneRangeTotal.Name = "lblPlayerOneRangeTotal";
            this.lblPlayerOneRangeTotal.Size = new System.Drawing.Size(57, 78);
            this.lblPlayerOneRangeTotal.TabIndex = 57;
            this.lblPlayerOneRangeTotal.Text = "0";
            this.lblPlayerOneRangeTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerOneRangeTotal.UseCompatibleTextRendering = true;
            // 
            // lblPlayerOneSiegeTotal
            // 
            this.lblPlayerOneSiegeTotal.AutoSize = true;
            this.lblPlayerOneSiegeTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerOneSiegeTotal.Font = new System.Drawing.Font("Algerian", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneSiegeTotal.ForeColor = System.Drawing.Color.Turquoise;
            this.lblPlayerOneSiegeTotal.Location = new System.Drawing.Point(155, 256);
            this.lblPlayerOneSiegeTotal.Name = "lblPlayerOneSiegeTotal";
            this.lblPlayerOneSiegeTotal.Size = new System.Drawing.Size(57, 78);
            this.lblPlayerOneSiegeTotal.TabIndex = 56;
            this.lblPlayerOneSiegeTotal.Text = "0";
            this.lblPlayerOneSiegeTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPlayerOneSiegeTotal.UseCompatibleTextRendering = true;
            // 
            // lblCalculate
            // 
            this.lblCalculate.ActiveLinkColor = System.Drawing.Color.Teal;
            this.lblCalculate.AutoSize = true;
            this.lblCalculate.BackColor = System.Drawing.Color.Transparent;
            this.lblCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculate.LinkColor = System.Drawing.Color.Yellow;
            this.lblCalculate.Location = new System.Drawing.Point(441, 35);
            this.lblCalculate.Name = "lblCalculate";
            this.lblCalculate.Size = new System.Drawing.Size(99, 30);
            this.lblCalculate.TabIndex = 60;
            this.lblCalculate.TabStop = true;
            this.lblCalculate.Text = "Calculate";
            this.lblCalculate.UseCompatibleTextRendering = true;
            this.lblCalculate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCalculate_LinkClicked);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 835);
            this.Controls.Add(this.lblCalculate);
            this.Controls.Add(this.lblPlayerOneTotal);
            this.Controls.Add(this.lblPlayerOneMeleeTotal);
            this.Controls.Add(this.lblPlayerOneRangeTotal);
            this.Controls.Add(this.lblPlayerOneSiegeTotal);
            this.Controls.Add(this.lblPlayerTwoTotal);
            this.Controls.Add(this.lblPlayerTwoSiegeTotal);
            this.Controls.Add(this.lblPlayerTwoRangeTotal);
            this.Controls.Add(this.lblPlayerTwoMeleeTotal);
            this.Controls.Add(this.lblPlayerTwoSect);
            this.Controls.Add(this.lblPlayerTwoRegCol);
            this.Controls.Add(this.lblPlayerTwoHeroCol);
            this.Controls.Add(this.lblPlayerOneRegCol);
            this.Controls.Add(this.lblPlayerOneHeroCol);
            this.Controls.Add(this.lblPlayerOneSect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtPlayerTwoRegMelee);
            this.Controls.Add(this.txtPlayerTwoHeroMelee);
            this.Controls.Add(this.txtPlayerTwoRegSiege);
            this.Controls.Add(this.txtPlayerTwoHeroSiege);
            this.Controls.Add(this.txtPlayerTwoRegRange);
            this.Controls.Add(this.txtPlayerTwoHeroRange);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPlayerOneRegSiege);
            this.Controls.Add(this.txtPlayerOneHeroSiege);
            this.Controls.Add(this.txtPlayerOneRegMelee);
            this.Controls.Add(this.txtPlayerOneHeroMelee);
            this.Controls.Add(this.txtPlayerOneRegRange);
            this.Controls.Add(this.txtPlayerOneHeroRange);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEndRound);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.LinkLabel lblEndRound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RichTextBox txtPlayerOneHeroRange;
        private System.Windows.Forms.RichTextBox txtPlayerOneRegRange;
        private System.Windows.Forms.RichTextBox txtPlayerOneHeroMelee;
        private System.Windows.Forms.RichTextBox txtPlayerOneRegMelee;
        private System.Windows.Forms.RichTextBox txtPlayerOneHeroSiege;
        private System.Windows.Forms.RichTextBox txtPlayerOneRegSiege;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RichTextBox txtPlayerTwoRegMelee;
        private System.Windows.Forms.RichTextBox txtPlayerTwoHeroMelee;
        private System.Windows.Forms.RichTextBox txtPlayerTwoRegSiege;
        private System.Windows.Forms.RichTextBox txtPlayerTwoHeroSiege;
        private System.Windows.Forms.RichTextBox txtPlayerTwoRegRange;
        private System.Windows.Forms.RichTextBox txtPlayerTwoHeroRange;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerOneSect;
        private System.Windows.Forms.Label lblPlayerOneHeroCol;
        private System.Windows.Forms.Label lblPlayerOneRegCol;
        private System.Windows.Forms.Label lblPlayerTwoRegCol;
        private System.Windows.Forms.Label lblPlayerTwoHeroCol;
        private System.Windows.Forms.Label lblPlayerTwoSect;
        private System.Windows.Forms.Label lblPlayerTwoMeleeTotal;
        private System.Windows.Forms.Label lblPlayerTwoRangeTotal;
        private System.Windows.Forms.Label lblPlayerTwoSiegeTotal;
        private System.Windows.Forms.Label lblPlayerTwoTotal;
        private System.Windows.Forms.Label lblPlayerOneTotal;
        private System.Windows.Forms.Label lblPlayerOneMeleeTotal;
        private System.Windows.Forms.Label lblPlayerOneRangeTotal;
        private System.Windows.Forms.Label lblPlayerOneSiegeTotal;
        private LinkLabel lblCalculate;
    }
}

