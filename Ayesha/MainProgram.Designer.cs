namespace Ayesha
{
    partial class MainProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.textBox = new System.Windows.Forms.TextBox();
            this.sentbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ScreenPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.micbox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.micbtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.button2 = new System.Windows.Forms.Button();
            this.textualbox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.switchbtn = new System.Windows.Forms.Button();
            this.voicetimer = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ScreenPanel.SuspendLayout();
            this.micbox.SuspendLayout();
            this.textualbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(14, 11);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(304, 40);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // sentbtn
            // 
            this.sentbtn.BackColor = System.Drawing.Color.Transparent;
            this.sentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentbtn.ForeColor = System.Drawing.Color.SlateBlue;
            this.sentbtn.Location = new System.Drawing.Point(318, 9);
            this.sentbtn.Name = "sentbtn";
            this.sentbtn.Size = new System.Drawing.Size(40, 42);
            this.sentbtn.TabIndex = 1;
            this.sentbtn.Text = "▶️";
            this.sentbtn.UseVisualStyleBackColor = false;
            this.sentbtn.Click += new System.EventHandler(this.sentbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ayesha: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 366);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 58);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Specialty", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "________________________________________________";
            // 
            // ScreenPanel
            // 
            this.ScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ScreenPanel.Controls.Add(this.flowLayoutPanel1);
            this.ScreenPanel.Controls.Add(this.micbox);
            this.ScreenPanel.Controls.Add(this.pictureBox1);
            this.ScreenPanel.Controls.Add(this.label3);
            this.ScreenPanel.Controls.Add(this.button2);
            this.ScreenPanel.Controls.Add(this.textualbox);
            this.ScreenPanel.Controls.Add(this.switchbtn);
            this.ScreenPanel.FillColor = System.Drawing.Color.SlateBlue;
            this.ScreenPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ScreenPanel.Location = new System.Drawing.Point(13, 11);
            this.ScreenPanel.Name = "ScreenPanel";
            this.ScreenPanel.ShadowDecoration.Parent = this.ScreenPanel;
            this.ScreenPanel.Size = new System.Drawing.Size(396, 522);
            this.ScreenPanel.TabIndex = 5;
            // 
            // micbox
            // 
            this.micbox.BackColor = System.Drawing.Color.Transparent;
            this.micbox.BorderRadius = 35;
            this.micbox.Controls.Add(this.micbtn);
            this.micbox.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.micbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.micbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.micbox.Location = new System.Drawing.Point(156, 432);
            this.micbox.Name = "micbox";
            this.micbox.ShadowDecoration.Parent = this.micbox;
            this.micbox.Size = new System.Drawing.Size(94, 118);
            this.micbox.TabIndex = 3;
            // 
            // micbtn
            // 
            this.micbtn.BackColor = System.Drawing.Color.Transparent;
            this.micbtn.CheckedState.Parent = this.micbtn;
            this.micbtn.CustomImages.Parent = this.micbtn;
            this.micbtn.FillColor = System.Drawing.Color.Green;
            this.micbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.micbtn.ForeColor = System.Drawing.Color.White;
            this.micbtn.HoverState.Parent = this.micbtn;
            this.micbtn.Location = new System.Drawing.Point(17, 17);
            this.micbtn.Name = "micbtn";
            this.micbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.micbtn.ShadowDecoration.Parent = this.micbtn;
            this.micbtn.Size = new System.Drawing.Size(60, 60);
            this.micbtn.TabIndex = 6;
            this.micbtn.Click += new System.EventHandler(this.micbtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(4, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "❌";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textualbox
            // 
            this.textualbox.BackColor = System.Drawing.Color.Transparent;
            this.textualbox.BorderColor = System.Drawing.Color.SlateBlue;
            this.textualbox.BorderRadius = 30;
            this.textualbox.Controls.Add(this.textBox);
            this.textualbox.Controls.Add(this.sentbtn);
            this.textualbox.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.textualbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textualbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textualbox.Location = new System.Drawing.Point(10, 464);
            this.textualbox.Name = "textualbox";
            this.textualbox.ShadowDecoration.Parent = this.textualbox;
            this.textualbox.Size = new System.Drawing.Size(374, 87);
            this.textualbox.TabIndex = 7;
            this.textualbox.UseTransparentBackground = true;
            // 
            // switchbtn
            // 
            this.switchbtn.BackColor = System.Drawing.Color.Transparent;
            this.switchbtn.FlatAppearance.BorderSize = 0;
            this.switchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchbtn.ForeColor = System.Drawing.Color.White;
            this.switchbtn.Location = new System.Drawing.Point(3, 427);
            this.switchbtn.Name = "switchbtn";
            this.switchbtn.Size = new System.Drawing.Size(44, 36);
            this.switchbtn.TabIndex = 5;
            this.switchbtn.Text = "🔁";
            this.switchbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.switchbtn.UseVisualStyleBackColor = false;
            this.switchbtn.Click += new System.EventHandler(this.switchbtn_Click);
            // 
            // voicetimer
            // 
            this.voicetimer.Enabled = true;
            this.voicetimer.Interval = 1000;
            this.voicetimer.Tick += new System.EventHandler(this.voicetimer_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.ScreenPanel;
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 546);
            this.Controls.Add(this.ScreenPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainProgram";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Ayesha";
            this.Load += new System.EventHandler(this.Ayesha_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ScreenPanel.ResumeLayout(false);
            this.ScreenPanel.PerformLayout();
            this.micbox.ResumeLayout(false);
            this.textualbox.ResumeLayout(false);
            this.textualbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button sentbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientPanel ScreenPanel;
        private System.Windows.Forms.Button switchbtn;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2GroupBox micbox;
        private Guna.UI2.WinForms.Guna2CircleButton micbtn;
        private System.Windows.Forms.Timer voicetimer;
        private Guna.UI2.WinForms.Guna2GroupBox textualbox;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

