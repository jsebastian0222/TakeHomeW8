namespace ADTakeHomeW8
{
    partial class Form2
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
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelteam = new System.Windows.Forms.Label();
            this.labelpos = new System.Windows.Forms.Label();
            this.labelnum = new System.Windows.Forms.Label();
            this.labelpenalty = new System.Windows.Forms.Label();
            this.labelredcard = new System.Windows.Forms.Label();
            this.labelgoal = new System.Windows.Forms.Label();
            this.labelnationality = new System.Windows.Forms.Label();
            this.labelyellowcard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(23, 37);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(166, 28);
            this.comboBoxTeam.TabIndex = 0;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Location = new System.Drawing.Point(23, 95);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(166, 28);
            this.comboBoxPlayer.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(567, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Yellow Card";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(416, 41);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(14, 20);
            this.labelname.TabIndex = 13;
            this.labelname.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(567, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Red Card";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(567, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Penalty Missed";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(567, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "Goal";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(218, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "Nationality";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(218, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "Num";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(218, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "Pos";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(218, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 20);
            this.label20.TabIndex = 22;
            this.label20.Text = "Team";
            // 
            // labelteam
            // 
            this.labelteam.AutoSize = true;
            this.labelteam.Location = new System.Drawing.Point(416, 72);
            this.labelteam.Name = "labelteam";
            this.labelteam.Size = new System.Drawing.Size(14, 20);
            this.labelteam.TabIndex = 23;
            this.labelteam.Text = "-";
            // 
            // labelpos
            // 
            this.labelpos.AutoSize = true;
            this.labelpos.Location = new System.Drawing.Point(416, 104);
            this.labelpos.Name = "labelpos";
            this.labelpos.Size = new System.Drawing.Size(14, 20);
            this.labelpos.TabIndex = 24;
            this.labelpos.Text = "-";
            // 
            // labelnum
            // 
            this.labelnum.AutoSize = true;
            this.labelnum.Location = new System.Drawing.Point(416, 135);
            this.labelnum.Name = "labelnum";
            this.labelnum.Size = new System.Drawing.Size(14, 20);
            this.labelnum.TabIndex = 25;
            this.labelnum.Text = "-";
            // 
            // labelpenalty
            // 
            this.labelpenalty.AutoSize = true;
            this.labelpenalty.Location = new System.Drawing.Point(761, 72);
            this.labelpenalty.Name = "labelpenalty";
            this.labelpenalty.Size = new System.Drawing.Size(14, 20);
            this.labelpenalty.TabIndex = 26;
            this.labelpenalty.Text = "-";
            // 
            // labelredcard
            // 
            this.labelredcard.AutoSize = true;
            this.labelredcard.Location = new System.Drawing.Point(761, 104);
            this.labelredcard.Name = "labelredcard";
            this.labelredcard.Size = new System.Drawing.Size(14, 20);
            this.labelredcard.TabIndex = 27;
            this.labelredcard.Text = "-";
            // 
            // labelgoal
            // 
            this.labelgoal.AutoSize = true;
            this.labelgoal.Location = new System.Drawing.Point(761, 41);
            this.labelgoal.Name = "labelgoal";
            this.labelgoal.Size = new System.Drawing.Size(14, 20);
            this.labelgoal.TabIndex = 28;
            this.labelgoal.Text = "-";
            // 
            // labelnationality
            // 
            this.labelnationality.AutoSize = true;
            this.labelnationality.Location = new System.Drawing.Point(416, 168);
            this.labelnationality.Name = "labelnationality";
            this.labelnationality.Size = new System.Drawing.Size(14, 20);
            this.labelnationality.TabIndex = 29;
            this.labelnationality.Text = "-";
            // 
            // labelyellowcard
            // 
            this.labelyellowcard.AutoSize = true;
            this.labelyellowcard.Location = new System.Drawing.Point(761, 135);
            this.labelyellowcard.Name = "labelyellowcard";
            this.labelyellowcard.Size = new System.Drawing.Size(14, 20);
            this.labelyellowcard.TabIndex = 30;
            this.labelyellowcard.Text = "-";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 219);
            this.Controls.Add(this.labelyellowcard);
            this.Controls.Add(this.labelnationality);
            this.Controls.Add(this.labelgoal);
            this.Controls.Add(this.labelredcard);
            this.Controls.Add(this.labelpenalty);
            this.Controls.Add(this.labelnum);
            this.Controls.Add(this.labelpos);
            this.Controls.Add(this.labelteam);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxPlayer);
            this.Controls.Add(this.comboBoxTeam);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.ComboBox comboBoxPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelteam;
        private System.Windows.Forms.Label labelpos;
        private System.Windows.Forms.Label labelnum;
        private System.Windows.Forms.Label labelpenalty;
        private System.Windows.Forms.Label labelredcard;
        private System.Windows.Forms.Label labelgoal;
        private System.Windows.Forms.Label labelnationality;
        private System.Windows.Forms.Label labelyellowcard;
    }
}