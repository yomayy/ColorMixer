namespace ColorMixer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RedBar = new System.Windows.Forms.TrackBar();
            this.RedLabel = new System.Windows.Forms.Label();
            this.GreenLable = new System.Windows.Forms.Label();
            this.GreenBar = new System.Windows.Forms.TrackBar();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.BlueBar = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BlueLabel);
            this.groupBox1.Controls.Add(this.BlueBar);
            this.groupBox1.Controls.Add(this.GreenLable);
            this.groupBox1.Controls.Add(this.GreenBar);
            this.groupBox1.Controls.Add(this.RedLabel);
            this.groupBox1.Controls.Add(this.RedBar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Регулировка";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(435, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 450);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Просмотр";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 343);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "RGB-code:";
            // 
            // RedBar
            // 
            this.RedBar.BackColor = System.Drawing.Color.Red;
            this.RedBar.Location = new System.Drawing.Point(12, 73);
            this.RedBar.Maximum = 255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RedBar.Size = new System.Drawing.Size(56, 365);
            this.RedBar.TabIndex = 0;
            this.RedBar.TickFrequency = 10;
            this.RedBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.RedBar.Value = 150;
            this.RedBar.ValueChanged += new System.EventHandler(this.RedBar_ValueChanged);
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RedLabel.ForeColor = System.Drawing.Color.Red;
            this.RedLabel.Location = new System.Drawing.Point(6, 40);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(63, 32);
            this.RedLabel.TabIndex = 1;
            this.RedLabel.Text = "150";
            // 
            // GreenLable
            // 
            this.GreenLable.AutoSize = true;
            this.GreenLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreenLable.ForeColor = System.Drawing.Color.Lime;
            this.GreenLable.Location = new System.Drawing.Point(80, 40);
            this.GreenLable.Name = "GreenLable";
            this.GreenLable.Size = new System.Drawing.Size(63, 32);
            this.GreenLable.TabIndex = 3;
            this.GreenLable.Text = "150";
            // 
            // GreenBar
            // 
            this.GreenBar.BackColor = System.Drawing.Color.Green;
            this.GreenBar.Location = new System.Drawing.Point(86, 73);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.GreenBar.Size = new System.Drawing.Size(56, 365);
            this.GreenBar.TabIndex = 2;
            this.GreenBar.TickFrequency = 10;
            this.GreenBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.GreenBar.Value = 150;
            this.GreenBar.Scroll += new System.EventHandler(this.GreenBar_Scroll);
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.BlueLabel.Location = new System.Drawing.Point(153, 40);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(63, 32);
            this.BlueLabel.TabIndex = 5;
            this.BlueLabel.Text = "150";
            // 
            // BlueBar
            // 
            this.BlueBar.BackColor = System.Drawing.Color.Blue;
            this.BlueBar.Location = new System.Drawing.Point(159, 73);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BlueBar.Size = new System.Drawing.Size(56, 365);
            this.BlueBar.TabIndex = 4;
            this.BlueBar.TickFrequency = 10;
            this.BlueBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.BlueBar.Value = 150;
            this.BlueBar.Scroll += new System.EventHandler(this.BlueBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор цветовой палитры";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.TrackBar BlueBar;
        private System.Windows.Forms.Label GreenLable;
        private System.Windows.Forms.TrackBar GreenBar;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.TrackBar RedBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

