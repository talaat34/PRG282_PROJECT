namespace PRG282_PROJECT_Military_Simulations
{
    partial class Welcome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.surnamelbl = new System.Windows.Forms.Label();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flashingLabel = new System.Windows.Forms.Label();
            this.loadinglbl = new System.Windows.Forms.Label();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PRG282_PROJECT_Military_Simulations.Properties.Resources.loading_gif;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(179, 104);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(127, 28);
            this.namelbl.TabIndex = 35;
            this.namelbl.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(389, 101);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(232, 31);
            this.nameTxt.TabIndex = 36;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(314, 212);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(173, 64);
            this.btnDone.TabIndex = 37;
            this.btnDone.Text = "Enter";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // surnamelbl
            // 
            this.surnamelbl.AutoSize = true;
            this.surnamelbl.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnamelbl.Location = new System.Drawing.Point(179, 145);
            this.surnamelbl.Name = "surnamelbl";
            this.surnamelbl.Size = new System.Drawing.Size(206, 28);
            this.surnamelbl.TabIndex = 35;
            this.surnamelbl.Text = "Surname";
            // 
            // surnameTxt
            // 
            this.surnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTxt.Location = new System.Drawing.Point(389, 142);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(232, 31);
            this.surnameTxt.TabIndex = 36;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // flashingLabel
            // 
            this.flashingLabel.AutoSize = true;
            this.flashingLabel.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flashingLabel.Location = new System.Drawing.Point(232, 42);
            this.flashingLabel.Name = "flashingLabel";
            this.flashingLabel.Size = new System.Drawing.Size(337, 28);
            this.flashingLabel.TabIndex = 35;
            this.flashingLabel.Text = "Enter Details";
            // 
            // loadinglbl
            // 
            this.loadinglbl.BackColor = System.Drawing.Color.Transparent;
            this.loadinglbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadinglbl.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadinglbl.ForeColor = System.Drawing.Color.LawnGreen;
            this.loadinglbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadinglbl.Location = new System.Drawing.Point(0, 0);
            this.loadinglbl.Name = "loadinglbl";
            this.loadinglbl.Size = new System.Drawing.Size(739, 450);
            this.loadinglbl.TabIndex = 38;
            this.loadinglbl.Text = "Loading";
            this.loadinglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingTimer
            // 
            this.loadingTimer.Enabled = true;
            this.loadingTimer.Interval = 2000;
            this.loadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.loadinglbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.surnamelbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.flashingLabel);
            this.Controls.Add(this.namelbl);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label surnamelbl;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label flashingLabel;
        public System.Windows.Forms.Timer loadingTimer;
        private System.Windows.Forms.Label loadinglbl;
    }
}