namespace sofdesapp
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
            Slot = new Label();
            usernametb = new TextBox();
            passwordtb = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Slot
            // 
            Slot.AutoSize = true;
            Slot.BackColor = Color.Transparent;
            Slot.Cursor = Cursors.No;
            Slot.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            Slot.Location = new Point(119, 29);
            Slot.Name = "Slot";
            Slot.Size = new Size(320, 37);
            Slot.TabIndex = 0;
            Slot.Text = "Slot Reservation System";
            Slot.Click += Slot_Click;
            // 
            // usernametb
            // 
            usernametb.Location = new Point(211, 139);
            usernametb.Name = "usernametb";
            usernametb.Size = new Size(100, 23);
            usernametb.TabIndex = 1;
            usernametb.TextChanged += textBox1_TextChanged;
            // 
            // passwordtb
            // 
            passwordtb.Location = new Point(211, 195);
            passwordtb.Name = "passwordtb";
            passwordtb.Size = new Size(100, 23);
            passwordtb.TabIndex = 2;
            passwordtb.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(211, 248);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(Slot);
            panel1.Location = new Point(-11, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 112);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(532, 401);
            Controls.Add(button1);
            Controls.Add(passwordtb);
            Controls.Add(usernametb);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Slot;
        private TextBox usernametb;
        private TextBox passwordtb;
        private Button button1;
        private Panel panel1;
    }
}
