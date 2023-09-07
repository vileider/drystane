namespace drystane
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnAnalytics = new Button();
            btnDashboard = new Button();
            btnReset = new Button();
            btnBrief = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelNav = new Panel();
            label3 = new Label();
            label4 = new Label();
            calculateBtn = new Button();
            lenghtBox = new TextBox();
            textBox2 = new TextBox();
            outputPanel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(btnAnalytics);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnBrief);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 0;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Dock = DockStyle.Top;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnalytics.ForeColor = Color.FromArgb(0, 126, 249);
            btnAnalytics.Image = (Image)resources.GetObject("btnAnalytics.Image");
            btnAnalytics.Location = new Point(0, 228);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(186, 42);
            btnAnalytics.TabIndex = 7;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAnalytics.UseVisualStyleBackColor = true;
            btnAnalytics.Click += btnAnalytics_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.Location = new Point(0, 186);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(186, 42);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.FromArgb(0, 126, 249);
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.Location = new Point(0, 535);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(186, 42);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnBrief
            // 
            btnBrief.Dock = DockStyle.Top;
            btnBrief.FlatAppearance.BorderSize = 0;
            btnBrief.FlatStyle = FlatStyle.Flat;
            btnBrief.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrief.ForeColor = Color.FromArgb(0, 126, 249);
            btnBrief.Image = (Image)resources.GetObject("btnBrief.Image");
            btnBrief.Location = new Point(0, 144);
            btnBrief.Name = "btnBrief";
            btnBrief.Size = new Size(186, 42);
            btnBrief.TabIndex = 1;
            btnBrief.Text = "Briefing";
            btnBrief.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBrief.UseVisualStyleBackColor = true;
            btnBrief.Click += BtnDashboard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 156, 149);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(169, 15);
            label2.TabIndex = 2;
            label2.Text = "Welomes to DRYSTANE project";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 156, 149);
            label1.Location = new Point(41, 88);
            label1.Name = "label1";
            label1.Size = new Size(104, 16);
            label1.TabIndex = 1;
            label1.Text = "B. A. Todorow";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(0, 126, 249);
            panelNav.Location = new Point(0, 156);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(3, 100);
            panelNav.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 156, 149);
            label3.Location = new Point(553, 64);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "lenght";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(0, 156, 149);
            label4.Location = new Point(553, 195);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 4;
            label4.Text = "width";
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(543, 331);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(75, 23);
            calculateBtn.TabIndex = 5;
            calculateBtn.Text = "calculate";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += button1_Click_1;
            // 
            // lenghtBox
            // 
            lenghtBox.Location = new Point(320, 64);
            lenghtBox.Name = "lenghtBox";
            lenghtBox.Size = new Size(165, 23);
            lenghtBox.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 7;
            // 
            // outputPanel
            // 
            outputPanel.AutoSize = true;
            outputPanel.BackColor = Color.Blue;
            outputPanel.ForeColor = SystemColors.ButtonFace;
            outputPanel.Location = new Point(320, 355);
            outputPanel.MinimumSize = new Size(200, 100);
            outputPanel.Name = "outputPanel";
            outputPanel.Size = new Size(200, 100);
            outputPanel.TabIndex = 0;
            outputPanel.Text = ">";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(outputPanel);
            Controls.Add(textBox2);
            Controls.Add(lenghtBox);
            Controls.Add(calculateBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panelNav);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnBrief;
        private Button btnReset;
        private Button btnAnalytics;
        private Button btnDashboard;
        private Panel panelNav;
        private Label label3;
        private Label label4;
        private Button calculateBtn;
        private TextBox lenghtBox;
        private TextBox textBox2;
        private Label outputPanel;
    }
}