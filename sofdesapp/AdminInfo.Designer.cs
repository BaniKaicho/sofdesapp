namespace sofdesapp
{
    partial class AdminInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInfo));
            button4 = new Button();
            adminsearchtb = new TextBox();
            DeleteBtn = new Button();
            AddBtn = new Button();
            admingridview = new DataGridView();
            adminnametb = new TextBox();
            adminidtb = new TextBox();
            panel1 = new Panel();
            Datelbl = new Label();
            label1 = new Label();
            button1 = new Button();
            passwordtb = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)admingridview).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Font = new Font("Palatino Linotype", 8.25F);
            button4.Location = new Point(368, 129);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 18;
            button4.Text = "SEARCH";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // adminsearchtb
            // 
            adminsearchtb.BackColor = SystemColors.ControlLight;
            adminsearchtb.Font = new Font("Palatino Linotype", 8.25F);
            adminsearchtb.Location = new Point(217, 129);
            adminsearchtb.Name = "adminsearchtb";
            adminsearchtb.Size = new Size(121, 22);
            adminsearchtb.TabIndex = 17;
            adminsearchtb.Text = "AdminSearch";
            adminsearchtb.TextChanged += clientsearchtb_TextChanged;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = SystemColors.ControlLight;
            DeleteBtn.Font = new Font("Palatino Linotype", 8.25F);
            DeleteBtn.Location = new Point(93, 311);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 16;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ControlLight;
            AddBtn.Font = new Font("Palatino Linotype", 8.25F);
            AddBtn.Location = new Point(12, 311);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 15;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // admingridview
            // 
            admingridview.BackgroundColor = SystemColors.ActiveBorder;
            admingridview.BorderStyle = BorderStyle.Fixed3D;
            admingridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            admingridview.GridColor = SystemColors.InactiveBorder;
            admingridview.Location = new Point(202, 158);
            admingridview.Name = "admingridview";
            admingridview.Size = new Size(338, 250);
            admingridview.TabIndex = 14;
            admingridview.CellContentClick += usergridview_CellContentClick;
            // 
            // adminnametb
            // 
            adminnametb.BackColor = SystemColors.ControlLight;
            adminnametb.Font = new Font("Palatino Linotype", 8.25F);
            adminnametb.Location = new Point(33, 210);
            adminnametb.Name = "adminnametb";
            adminnametb.Size = new Size(121, 22);
            adminnametb.TabIndex = 13;
            adminnametb.Text = "AdminName";
            adminnametb.TextChanged += usernametb_TextChanged;
            // 
            // adminidtb
            // 
            adminidtb.BackColor = SystemColors.ControlLight;
            adminidtb.Font = new Font("Palatino Linotype", 8.25F);
            adminidtb.Location = new Point(33, 171);
            adminidtb.Name = "adminidtb";
            adminidtb.Size = new Size(121, 22);
            adminidtb.TabIndex = 12;
            adminidtb.Text = "AdminId";
            adminidtb.TextChanged += useridtb_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(Datelbl);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 107);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // Datelbl
            // 
            Datelbl.AutoSize = true;
            Datelbl.BackColor = Color.Transparent;
            Datelbl.Font = new Font("Palatino Linotype", 8.25F);
            Datelbl.Location = new Point(503, 81);
            Datelbl.Name = "Datelbl";
            Datelbl.Size = new Size(30, 16);
            Datelbl.TabIndex = 1;
            Datelbl.Text = "Date";
            Datelbl.Click += Datelbl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 30);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 0;
            label1.Text = "Admin Information";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Palatino Linotype", 8.25F);
            button1.Location = new Point(449, 129);
            button1.Name = "button1";
            button1.Size = new Size(65, 23);
            button1.TabIndex = 19;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // passwordtb
            // 
            passwordtb.BackColor = SystemColors.ControlLight;
            passwordtb.Font = new Font("Palatino Linotype", 8.25F);
            passwordtb.Location = new Point(33, 253);
            passwordtb.Name = "passwordtb";
            passwordtb.Size = new Size(121, 22);
            passwordtb.TabIndex = 20;
            passwordtb.Text = "Password";
            passwordtb.TextChanged += textBox1_TextChanged_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Palatino Linotype", 8.25F);
            button2.Location = new Point(12, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 21;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AdminInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(562, 450);
            Controls.Add(button2);
            Controls.Add(passwordtb);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(adminsearchtb);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(admingridview);
            Controls.Add(adminnametb);
            Controls.Add(adminidtb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AdminInfo";
            Text = "AdminInfo";
            Load += AdminInfo_Load;
            ((System.ComponentModel.ISupportInitialize)admingridview).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private TextBox adminsearchtb;
        private Button DeleteBtn;
        private Button AddBtn;
        private DataGridView admingridview;
        private TextBox adminnametb;
        private TextBox adminidtb;
        private Panel panel1;
        private Label Datelbl;
        private Label label1;
        private Button button1;
        private TextBox passwordtb;
        private Button button2;
    }
}