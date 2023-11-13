namespace Do
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            pictureBox3 = new PictureBox();
            button7 = new Button();
            button8 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            timer6 = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            button5 = new Button();
            groupBox2 = new GroupBox();
            button10 = new Button();
            button11 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer7 = new System.Windows.Forms.Timer(components);
            timer8 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = Properties.Resources.ldoor;
            pictureBox1.Location = new Point(131, 471);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "LeftDoor";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveBorder;
            pictureBox2.Image = Properties.Resources.rdoor;
            pictureBox2.Location = new Point(222, 471);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 206);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "RightDoor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(581, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 303);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lift Control Panel";
            // 
            // button6
            // 
            button6.Location = new Point(100, 185);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 4;
            button6.Text = "Floor 0";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(58, 243);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Stop";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(100, 214);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(19, 185);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Floor 1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(19, 214);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "open";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 20;
            timer3.Tick += timer3_Tick;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.MediumSlateBlue;
            pictureBox3.Image = Properties.Resources.lift;
            pictureBox3.Location = new Point(141, 482);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(181, 195);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "FloorDisplay";
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.up;
            button7.Location = new Point(475, 558);
            button7.Name = "button7";
            button7.Size = new Size(60, 61);
            button7.TabIndex = 7;
            button7.Text = ".";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackgroundImage = Properties.Resources.down;
            button8.Location = new Point(472, 178);
            button8.Name = "button8";
            button8.Size = new Size(63, 57);
            button8.TabIndex = 8;
            button8.Text = ".";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveBorder;
            pictureBox4.Image = Properties.Resources.ldoor;
            pictureBox4.Location = new Point(131, 87);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 206);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "opened";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ActiveBorder;
            pictureBox5.Image = Properties.Resources.rdoor;
            pictureBox5.Location = new Point(222, 87);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 206);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "Closed";
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // timer5
            // 
            timer5.Tick += timer5_Tick;
            // 
            // timer6
            // 
            timer6.Tick += timer6_Tick;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(624, 448);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(1085, 543);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 13;
            button5.Text = "Display";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(802, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(630, 470);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Event logs";
            // 
            // button10
            // 
            button10.Location = new Point(1206, 543);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 15;
            button10.Text = "Clear";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(1335, 543);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 16;
            button11.Text = "Delete All";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // timer7
            // 
            timer7.Tick += timer7_Tick;
            // 
            // timer8
            // 
            timer8.Tick += timer8_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1519, 810);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(groupBox2);
            Controls.Add(button5);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private PictureBox pictureBox3;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private DataGridView dataGridView1;
        private Button button5;
        private GroupBox groupBox2;
        private Button button10;
        private Button button11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
    }
}