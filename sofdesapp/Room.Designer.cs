namespace sofdesapp
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            panel1 = new Panel();
            Datelbl = new Label();
            label1 = new Label();
            equipmentb = new TextBox();
            roomtb = new TextBox();
            label2 = new Label();
            yesradio = new RadioButton();
            label3 = new Label();
            noradio = new RadioButton();
            label4 = new Label();
            deleteroombtn = new Button();
            addroombtn = new Button();
            roomgridview = new DataGridView();
            roomsearchtb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomgridview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(Datelbl);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-7, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 106);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // Datelbl
            // 
            Datelbl.AutoSize = true;
            Datelbl.BackColor = Color.Transparent;
            Datelbl.Font = new Font("Palatino Linotype", 9F);
            Datelbl.Location = new Point(578, 78);
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
            label1.Location = new Point(190, 19);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 0;
            label1.Text = "Room Information";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // equipmentb
            // 
            equipmentb.Font = new Font("Palatino Linotype", 9F);
            equipmentb.Location = new Point(45, 193);
            equipmentb.Name = "equipmentb";
            equipmentb.Size = new Size(121, 24);
            equipmentb.TabIndex = 15;
            equipmentb.Text = "Room Equipment";
            equipmentb.TextChanged += adminnametb_TextChanged;
            // 
            // roomtb
            // 
            roomtb.Font = new Font("Palatino Linotype", 9F);
            roomtb.Location = new Point(45, 136);
            roomtb.Name = "roomtb";
            roomtb.Size = new Size(121, 24);
            roomtb.TabIndex = 16;
            roomtb.Text = "Room Number";
            roomtb.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F);
            label2.Location = new Point(45, 264);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 17;
            label2.Text = "Free";
            label2.Click += label2_Click;
            // 
            // yesradio
            // 
            yesradio.AutoSize = true;
            yesradio.Location = new Point(82, 265);
            yesradio.Name = "yesradio";
            yesradio.Size = new Size(14, 13);
            yesradio.TabIndex = 18;
            yesradio.TabStop = true;
            yesradio.UseVisualStyleBackColor = true;
            yesradio.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 9F);
            label3.Location = new Point(102, 263);
            label3.Name = "label3";
            label3.Size = new Size(28, 17);
            label3.TabIndex = 19;
            label3.Text = "Yes";
            label3.Click += label3_Click;
            // 
            // noradio
            // 
            noradio.AutoSize = true;
            noradio.Location = new Point(132, 264);
            noradio.Name = "noradio";
            noradio.Size = new Size(14, 13);
            noradio.TabIndex = 20;
            noradio.TabStop = true;
            noradio.UseVisualStyleBackColor = true;
            noradio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 9F);
            label4.Location = new Point(152, 264);
            label4.Name = "label4";
            label4.Size = new Size(24, 17);
            label4.TabIndex = 21;
            label4.Text = "No";
            label4.Click += label4_Click_1;
            // 
            // deleteroombtn
            // 
            deleteroombtn.Font = new Font("Palatino Linotype", 9F);
            deleteroombtn.Location = new Point(111, 306);
            deleteroombtn.Name = "deleteroombtn";
            deleteroombtn.Size = new Size(75, 23);
            deleteroombtn.TabIndex = 23;
            deleteroombtn.Text = "Delete";
            deleteroombtn.UseVisualStyleBackColor = true;
            deleteroombtn.Click += deleteroombtn_Click;
            // 
            // addroombtn
            // 
            addroombtn.Font = new Font("Palatino Linotype", 9F);
            addroombtn.Location = new Point(30, 306);
            addroombtn.Name = "addroombtn";
            addroombtn.Size = new Size(75, 23);
            addroombtn.TabIndex = 22;
            addroombtn.Text = "Add";
            addroombtn.UseVisualStyleBackColor = true;
            addroombtn.Click += addroombtn_Click;
            // 
            // roomgridview
            // 
            roomgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomgridview.Location = new Point(231, 149);
            roomgridview.Name = "roomgridview";
            roomgridview.Size = new Size(338, 250);
            roomgridview.TabIndex = 24;
            roomgridview.CellContentClick += admingridview_CellContentClick;
            // 
            // roomsearchtb
            // 
            roomsearchtb.Font = new Font("Palatino Linotype", 9F);
            roomsearchtb.Location = new Point(245, 119);
            roomsearchtb.Name = "roomsearchtb";
            roomsearchtb.Size = new Size(121, 24);
            roomsearchtb.TabIndex = 25;
            roomsearchtb.Text = "RoomSearch";
            roomsearchtb.TextChanged += adminsearchtb_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Palatino Linotype", 9F);
            button1.Location = new Point(372, 119);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Palatino Linotype", 9F);
            button2.Location = new Point(453, 120);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 27;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button3
            // 
            button3.Font = new Font("Palatino Linotype", 9F);
            button3.Location = new Point(71, 354);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 28;
            button3.Text = "Return";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Room
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(618, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(roomsearchtb);
            Controls.Add(roomgridview);
            Controls.Add(deleteroombtn);
            Controls.Add(addroombtn);
            Controls.Add(label4);
            Controls.Add(noradio);
            Controls.Add(label3);
            Controls.Add(yesradio);
            Controls.Add(label2);
            Controls.Add(roomtb);
            Controls.Add(equipmentb);
            Controls.Add(panel1);
            Name = "Room";
            Text = "Room";
            Load += Room_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomgridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Datelbl;
        private Label label1;
        private TextBox equipmentb;
        private TextBox roomtb;
        private Label label2;
        private RadioButton yesradio;
        private Label label3;
        private RadioButton noradio;
        private Label label4;
        private Button deleteroombtn;
        private Button addroombtn;
        private DataGridView roomgridview;
        private TextBox roomsearchtb;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
    }
}