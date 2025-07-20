namespace sofdesapp
{
    partial class Reservationinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservationinfo));
            panel1 = new Panel();
            Datelbl = new Label();
            label1 = new Label();
            reservationidtb = new TextBox();
            timein = new DateTimePicker();
            timeout = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button4 = new Button();
            reservationsearchtb = new TextBox();
            reservationgridview = new DataGridView();
            DeleteBtn = new Button();
            AddBtn = new Button();
            username = new ComboBox();
            roomnum = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservationgridview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(Datelbl);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-7, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 104);
            panel1.TabIndex = 13;
            // 
            // Datelbl
            // 
            Datelbl.AutoSize = true;
            Datelbl.BackColor = Color.Transparent;
            Datelbl.Font = new Font("Palatino Linotype", 9F);
            Datelbl.Location = new Point(742, 76);
            Datelbl.Name = "Datelbl";
            Datelbl.Size = new Size(35, 17);
            Datelbl.TabIndex = 1;
            Datelbl.Text = "Date";
            Datelbl.Click += Datelbl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 13);
            label1.Name = "label1";
            label1.Size = new Size(324, 37);
            label1.TabIndex = 0;
            label1.Text = "Reservation Information";
            label1.Click += label1_Click;
            // 
            // reservationidtb
            // 
            reservationidtb.Font = new Font("Palatino Linotype", 9F);
            reservationidtb.Location = new Point(27, 148);
            reservationidtb.Name = "reservationidtb";
            reservationidtb.Size = new Size(121, 24);
            reservationidtb.TabIndex = 14;
            reservationidtb.Text = "Reservation Id";
            reservationidtb.TextChanged += adminidtb_TextChanged;
            // 
            // timein
            // 
            timein.Location = new Point(62, 265);
            timein.Name = "timein";
            timein.Size = new Size(134, 23);
            timein.TabIndex = 17;
            timein.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // timeout
            // 
            timeout.Location = new Point(62, 303);
            timeout.Name = "timeout";
            timeout.Size = new Size(134, 23);
            timeout.TabIndex = 18;
            timeout.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 271);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 19;
            label2.Text = "TimeIn";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 311);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 20;
            label3.Text = "TimeOut";
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 9F);
            button1.Location = new Point(458, 119);
            button1.Name = "button1";
            button1.Size = new Size(65, 23);
            button1.TabIndex = 24;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Palatino Linotype", 9F);
            button4.Location = new Point(377, 119);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 23;
            button4.Text = "SEARCH";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // reservationsearchtb
            // 
            reservationsearchtb.Font = new Font("Palatino Linotype", 9F);
            reservationsearchtb.Location = new Point(227, 119);
            reservationsearchtb.Name = "reservationsearchtb";
            reservationsearchtb.Size = new Size(121, 24);
            reservationsearchtb.TabIndex = 22;
            reservationsearchtb.Text = "Reservation Search";
            // 
            // reservationgridview
            // 
            reservationgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservationgridview.Location = new Point(202, 148);
            reservationgridview.Name = "reservationgridview";
            reservationgridview.Size = new Size(547, 250);
            reservationgridview.TabIndex = 21;
            reservationgridview.CellContentClick += reservationgridview_CellContentClick;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Palatino Linotype", 9F);
            DeleteBtn.Location = new Point(103, 347);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 26;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click_1;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Palatino Linotype", 9F);
            AddBtn.Location = new Point(12, 347);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 25;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click_1;
            // 
            // username
            // 
            username.FormattingEnabled = true;
            username.Location = new Point(62, 187);
            username.Name = "username";
            username.Size = new Size(121, 23);
            username.TabIndex = 27;
            username.SelectedIndexChanged += username_SelectedIndexChanged;
            // 
            // roomnum
            // 
            roomnum.FormattingEnabled = true;
            roomnum.Location = new Point(62, 225);
            roomnum.Name = "roomnum";
            roomnum.Size = new Size(121, 23);
            roomnum.TabIndex = 28;
            roomnum.SelectedIndexChanged += roomnum_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 190);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 29;
            label4.Text = "User";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 228);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 30;
            label5.Text = "Room";
            label5.Click += label5_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Palatino Linotype", 9F);
            button2.Location = new Point(12, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 31;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Reservationinfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(roomnum);
            Controls.Add(username);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(reservationsearchtb);
            Controls.Add(reservationgridview);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(timeout);
            Controls.Add(timein);
            Controls.Add(reservationidtb);
            Controls.Add(panel1);
            Name = "Reservationinfo";
            Text = "Reservation id";
            Load += Reservationinfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reservationgridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Datelbl;
        private Label label1;
        private TextBox reservationidtb;
        private DateTimePicker timein;
        private DateTimePicker timeout;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button4;
        private TextBox reservationsearchtb;
        private DataGridView reservationgridview;
        private Button DeleteBtn;
        private Button AddBtn;
        private ComboBox username;
        private ComboBox roomnum;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}