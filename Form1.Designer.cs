namespace pomodoro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSec = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHoursEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecEdit = new System.Windows.Forms.TextBox();
            this.txtMinEdit = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.countUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.picTomatoLogo = new System.Windows.Forms.PictureBox();
            this.minutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTomatoLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.Red;
            this.lblSec.Location = new System.Drawing.Point(257, 13);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(68, 52);
            this.lblSec.TabIndex = 1;
            this.lblSec.Text = "00";
            this.lblSec.Click += new System.EventHandler(this.lblSec_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.Red;
            this.lblMin.Location = new System.Drawing.Point(127, 13);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(68, 52);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "00";
            this.lblMin.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(76, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.Red;
            this.lblHour.Location = new System.Drawing.Point(2, 13);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(68, 52);
            this.lblHour.TabIndex = 5;
            this.lblHour.Text = "00";
            this.lblHour.Click += new System.EventHandler(this.lblHour_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHoursEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSecEdit);
            this.panel1.Controls.Add(this.lblSec);
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Controls.Add(this.lblHour);
            this.panel1.Controls.Add(this.txtMinEdit);
            this.panel1.Location = new System.Drawing.Point(217, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 65);
            this.panel1.TabIndex = 6;
            // 
            // txtHoursEdit
            // 
            this.txtHoursEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoursEdit.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursEdit.ForeColor = System.Drawing.Color.Red;
            this.txtHoursEdit.Location = new System.Drawing.Point(3, 13);
            this.txtHoursEdit.Name = "txtHoursEdit";
            this.txtHoursEdit.Size = new System.Drawing.Size(55, 47);
            this.txtHoursEdit.TabIndex = 11;
            this.txtHoursEdit.Visible = false;
            this.txtHoursEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllTimeTextBoxes_KeyDown);
            this.txtHoursEdit.Leave += new System.EventHandler(this.AllTimeTextBoxes_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(206, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // txtSecEdit
            // 
            this.txtSecEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecEdit.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecEdit.ForeColor = System.Drawing.Color.Red;
            this.txtSecEdit.Location = new System.Drawing.Point(257, 13);
            this.txtSecEdit.Name = "txtSecEdit";
            this.txtSecEdit.Size = new System.Drawing.Size(55, 47);
            this.txtSecEdit.TabIndex = 7;
            this.txtSecEdit.Visible = false;
            this.txtSecEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllTimeTextBoxes_KeyDown);
            this.txtSecEdit.Leave += new System.EventHandler(this.AllTimeTextBoxes_Leave);
            // 
            // txtMinEdit
            // 
            this.txtMinEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinEdit.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinEdit.ForeColor = System.Drawing.Color.Red;
            this.txtMinEdit.Location = new System.Drawing.Point(127, 13);
            this.txtMinEdit.Name = "txtMinEdit";
            this.txtMinEdit.Size = new System.Drawing.Size(55, 47);
            this.txtMinEdit.TabIndex = 10;
            this.txtMinEdit.Visible = false;
            this.txtMinEdit.TextChanged += new System.EventHandler(this.txtMinEdit_TextChanged);
            this.txtMinEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllTimeTextBoxes_KeyDown);
            this.txtMinEdit.Leave += new System.EventHandler(this.AllTimeTextBoxes_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countUpToolStripMenuItem,
            this.countDownToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 68);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // countUpToolStripMenuItem
            // 
            this.countUpToolStripMenuItem.Name = "countUpToolStripMenuItem";
            this.countUpToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.countUpToolStripMenuItem.Text = "Count-Up";
            this.countUpToolStripMenuItem.Click += new System.EventHandler(this.countUpToolStripMenuItem_Click);
            // 
            // countDownToolStripMenuItem
            // 
            this.countDownToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minutesToolStripMenuItem2,
            this.minutesToolStripMenuItem3,
            this.customToolStripMenuItem});
            this.countDownToolStripMenuItem.Name = "countDownToolStripMenuItem";
            this.countDownToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.countDownToolStripMenuItem.Text = "Count Down";
            // 
            // minutesToolStripMenuItem2
            // 
            this.minutesToolStripMenuItem2.Name = "minutesToolStripMenuItem2";
            this.minutesToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.minutesToolStripMenuItem2.Text = "25 Minutes";
            this.minutesToolStripMenuItem2.Click += new System.EventHandler(this.minutesToolStripMenuItem25_Click);
            // 
            // minutesToolStripMenuItem3
            // 
            this.minutesToolStripMenuItem3.Name = "minutesToolStripMenuItem3";
            this.minutesToolStripMenuItem3.Size = new System.Drawing.Size(270, 34);
            this.minutesToolStripMenuItem3.Text = "50 Minutes";
            this.minutesToolStripMenuItem3.Click += new System.EventHandler(this.minutesToolStripMenuItem50_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackgroundImage = global::pomodoro.Properties.Resources.Skip_End_Fill__Streamline_Bootstrap;
            this.btnSkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSkip.FlatAppearance.BorderSize = 0;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkip.Location = new System.Drawing.Point(683, 12);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(116, 43);
            this.btnSkip.TabIndex = 22;
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Visible = false;
            this.btnSkip.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Window;
            this.btnReset.BackgroundImage = global::pomodoro.Properties.Resources.reset_50_removebg_preview;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(462, 379);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 80);
            this.btnReset.TabIndex = 9;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.BackgroundImage = global::pomodoro.Properties.Resources.play_64_removebg_preview;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(237, 379);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 80);
            this.btnStart.TabIndex = 20;
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picTomatoLogo
            // 
            this.picTomatoLogo.BackgroundImage = global::pomodoro.Properties.Resources.Toamato_removebg_preview;
            this.picTomatoLogo.ContextMenuStrip = this.contextMenuStrip1;
            this.picTomatoLogo.InitialImage = null;
            this.picTomatoLogo.Location = new System.Drawing.Point(237, 3);
            this.picTomatoLogo.Name = "picTomatoLogo";
            this.picTomatoLogo.Size = new System.Drawing.Size(317, 282);
            this.picTomatoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTomatoLogo.TabIndex = 0;
            this.picTomatoLogo.TabStop = false;
            // 
            // minutesToolStripMenuItem
            // 
            this.minutesToolStripMenuItem.Name = "minutesToolStripMenuItem";
            this.minutesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.minutesToolStripMenuItem.Text = "25minutes";
            this.minutesToolStripMenuItem.Click += new System.EventHandler(this.minutesToolStripMenuItem25_Click);
            // 
            // minutesToolStripMenuItem1
            // 
            this.minutesToolStripMenuItem1.Name = "minutesToolStripMenuItem1";
            this.minutesToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.minutesToolStripMenuItem1.Text = "50minutes";
            this.minutesToolStripMenuItem1.Click += new System.EventHandler(this.minutesToolStripMenuItem50_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picTomatoLogo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pomodoro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTomatoLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTomatoLogo;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecEdit;
        private System.Windows.Forms.TextBox txtHoursEdit;
        private System.Windows.Forms.TextBox txtMinEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.ToolStripMenuItem countUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
    }
}

