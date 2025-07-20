namespace sofdesapp
{
    partial class UserInfo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            panel1 = new Panel();
            Datelbl = new Label();
            label1 = new Label();
            useridtb = new TextBox();
            usernametb = new TextBox();
            usergridview = new DataGridView();
            AddBtn = new Button();
            DeleteBtn = new Button();
            clientsearchtb = new TextBox();
            button4 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usergridview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(Datelbl);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Palatino Linotype", 9F);
            panel1.Location = new Point(-12, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 97);
            panel1.TabIndex = 0;
            // 
            // Datelbl
            // 
            Datelbl.AutoSize = true;
            Datelbl.BackColor = Color.Transparent;
            Datelbl.Location = new Point(539, 70);
            Datelbl.Name = "Datelbl";
            Datelbl.Size = new Size(35, 17);
            Datelbl.TabIndex = 1;
            Datelbl.Text = "Date";
            Datelbl.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 19);
            label1.Name = "label1";
            label1.Size = new Size(234, 37);
            label1.TabIndex = 0;
            label1.Text = "User Information";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // useridtb
            // 
            useridtb.Font = new Font("Palatino Linotype", 9F);
            useridtb.Location = new Point(60, 195);
            useridtb.Name = "useridtb";
            useridtb.Size = new Size(121, 24);
            useridtb.TabIndex = 1;
            useridtb.Text = "UserId";
            // 
            // usernametb
            // 
            usernametb.Font = new Font("Palatino Linotype", 9F);
            usernametb.Location = new Point(60, 246);
            usernametb.Name = "usernametb";
            usernametb.Size = new Size(121, 24);
            usernametb.TabIndex = 2;
            usernametb.Text = "UserName";
            usernametb.TextChanged += textBox2_TextChanged;
            // 
            // usergridview
            // 
            usergridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usergridview.Location = new Point(254, 138);
            usergridview.Name = "usergridview";
            usergridview.Size = new Size(338, 250);
            usergridview.TabIndex = 5;
            usergridview.CellContentClick += usergridview_CellContentClick;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Palatino Linotype", 9F);
            AddBtn.Location = new Point(31, 302);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += button1_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Palatino Linotype", 9F);
            DeleteBtn.Location = new Point(130, 302);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 8;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // clientsearchtb
            // 
            clientsearchtb.Font = new Font("Palatino Linotype", 9F);
            clientsearchtb.Location = new Point(317, 109);
            clientsearchtb.Name = "clientsearchtb";
            clientsearchtb.Size = new Size(121, 24);
            clientsearchtb.TabIndex = 9;
            clientsearchtb.Text = "User ID";
            clientsearchtb.TextChanged += textBox4_TextChanged;
            // 
            // button4
            // 
            button4.Font = new Font("Palatino Linotype", 9F);
            button4.Location = new Point(446, 109);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 9F);
            button1.Location = new Point(527, 109);
            button1.Name = "button1";
            button1.Size = new Size(65, 23);
            button1.TabIndex = 11;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Palatino Linotype", 9F);
            button2.Location = new Point(12, 415);
            button2.Name = "button2";
            button2.Size = new Size(83, 23);
            button2.TabIndex = 12;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(614, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(clientsearchtb);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(usergridview);
            Controls.Add(usernametb);
            Controls.Add(useridtb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserInfo";
            Text = "UserInfo";
            Load += UserInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usergridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox useridtb;
        private TextBox usernametb;
        private DataGridView usergridview;
        private Button AddBtn;
        private Button DeleteBtn;
        private TextBox clientsearchtb;
        private Button button4;
        private Label Datelbl;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
    }
}