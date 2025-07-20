namespace sofdesapp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            Datelbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 37);
            label1.Name = "label1";
            label1.Size = new Size(156, 37);
            label1.TabIndex = 0;
            label1.Text = "Main Form";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Palatino Linotype", 9F);
            button1.Location = new Point(114, 206);
            button1.Name = "button1";
            button1.Size = new Size(100, 56);
            button1.TabIndex = 1;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Palatino Linotype", 9F);
            button2.Location = new Point(220, 206);
            button2.Name = "button2";
            button2.Size = new Size(100, 56);
            button2.TabIndex = 2;
            button2.Text = "Slot";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Palatino Linotype", 9F);
            button3.Location = new Point(322, 206);
            button3.Name = "button3";
            button3.Size = new Size(100, 56);
            button3.TabIndex = 3;
            button3.Text = "Reservation";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Font = new Font("Palatino Linotype", 9F);
            button4.Location = new Point(8, 206);
            button4.Name = "button4";
            button4.Size = new Size(100, 56);
            button4.TabIndex = 4;
            button4.Text = "User";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLight;
            button6.Font = new Font("Palatino Linotype", 9F);
            button6.Location = new Point(12, 358);
            button6.Name = "button6";
            button6.Size = new Size(58, 32);
            button6.TabIndex = 6;
            button6.Text = "back";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(Datelbl);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-67, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 128);
            panel1.TabIndex = 12;
            // 
            // Datelbl
            // 
            Datelbl.AutoSize = true;
            Datelbl.Location = new Point(503, 81);
            Datelbl.Name = "Datelbl";
            Datelbl.Size = new Size(31, 15);
            Datelbl.TabIndex = 1;
            Datelbl.Text = "Date";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(437, 402);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Panel panel1;
        private Label Datelbl;
    }
}