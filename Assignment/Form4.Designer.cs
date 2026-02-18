namespace Assignment
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kickblast_Judo_Management_SystemDataSet4 = new Assignment.Kickblast_Judo_Management_SystemDataSet4();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbqual = new System.Windows.Forms.TextBox();
            this.Tbsal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tbexp = new System.Windows.Forms.TextBox();
            this.Tbcon = new System.Windows.Forms.TextBox();
            this.Tbadd = new System.Windows.Forms.TextBox();
            this.Tbnic = new System.Windows.Forms.TextBox();
            this.Tbname = new System.Windows.Forms.TextBox();
            this.TbId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trainerTableAdapter = new Assignment.Kickblast_Judo_Management_SystemDataSet4TableAdapters.TrainerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickblast_Judo_Management_SystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Tbqual);
            this.panel1.Controls.Add(this.Tbsal);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Tbexp);
            this.panel1.Controls.Add(this.Tbcon);
            this.panel1.Controls.Add(this.Tbadd);
            this.panel1.Controls.Add(this.Tbnic);
            this.panel1.Controls.Add(this.Tbname);
            this.panel1.Controls.Add(this.TbId);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-8, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 509);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainerIDDataGridViewTextBoxColumn,
            this.trainernameDataGridViewTextBoxColumn,
            this.nICNoDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.qualificationDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trainerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(866, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(382, 236);
            this.dataGridView1.TabIndex = 27;
            // 
            // trainerIDDataGridViewTextBoxColumn
            // 
            this.trainerIDDataGridViewTextBoxColumn.DataPropertyName = "Trainer_ID";
            this.trainerIDDataGridViewTextBoxColumn.HeaderText = "Trainer_ID";
            this.trainerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainerIDDataGridViewTextBoxColumn.Name = "trainerIDDataGridViewTextBoxColumn";
            this.trainerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainernameDataGridViewTextBoxColumn
            // 
            this.trainernameDataGridViewTextBoxColumn.DataPropertyName = "Trainer_name";
            this.trainernameDataGridViewTextBoxColumn.HeaderText = "Trainer_name";
            this.trainernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainernameDataGridViewTextBoxColumn.Name = "trainernameDataGridViewTextBoxColumn";
            this.trainernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nICNoDataGridViewTextBoxColumn
            // 
            this.nICNoDataGridViewTextBoxColumn.DataPropertyName = "NIC_No";
            this.nICNoDataGridViewTextBoxColumn.HeaderText = "NIC_No";
            this.nICNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nICNoDataGridViewTextBoxColumn.Name = "nICNoDataGridViewTextBoxColumn";
            this.nICNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // qualificationDataGridViewTextBoxColumn
            // 
            this.qualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.HeaderText = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qualificationDataGridViewTextBoxColumn.Name = "qualificationDataGridViewTextBoxColumn";
            this.qualificationDataGridViewTextBoxColumn.Width = 125;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataMember = "Trainer";
            this.trainerBindingSource.DataSource = this.kickblast_Judo_Management_SystemDataSet4;
            // 
            // kickblast_Judo_Management_SystemDataSet4
            // 
            this.kickblast_Judo_Management_SystemDataSet4.DataSetName = "Kickblast_Judo_Management_SystemDataSet4";
            this.kickblast_Judo_Management_SystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Assignment.Properties.Resources.pngtree_vector_back_icon_png_image_1023353;
            this.pictureBox7.Location = new System.Drawing.Point(30, 443);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 39);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(733, 448);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Delete Trainer";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(507, 450);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Update Trainer";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(297, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Add Trainer";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Assignment.Properties.Resources.image_processing20220226_1450_14qeapr_removebg_preview;
            this.pictureBox6.Location = new System.Drawing.Point(680, 439);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Assignment.Properties.Resources._204_2047577_view_refresh_gion_simple_update_button_logo_png_removebg_preview;
            this.pictureBox5.Location = new System.Drawing.Point(448, 443);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Assignment.Properties.Resources._0145ceff_a6bc_463a_a58c_f396688bca5f1;
            this.pictureBox4.Location = new System.Drawing.Point(251, 443);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(127, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(352, 36);
            this.label10.TabIndex = 19;
            this.label10.Text = "Kick Blast Judo School ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Assignment.Properties.Resources.kick_last__3__removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(1096, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 137);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Assignment.Properties.Resources.png_clipart_computer_icons_android_web_search_engine_google_search_search_box_google_search_bar_blue_trademark_thumbnail;
            this.pictureBox2.Location = new System.Drawing.Point(343, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(118, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trainer Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tbqual
            // 
            this.Tbqual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tbqual.Location = new System.Drawing.Point(626, 268);
            this.Tbqual.Multiline = true;
            this.Tbqual.Name = "Tbqual";
            this.Tbqual.Size = new System.Drawing.Size(190, 35);
            this.Tbqual.TabIndex = 15;
            this.Tbqual.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // Tbsal
            // 
            this.Tbsal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tbsal.Location = new System.Drawing.Point(626, 316);
            this.Tbsal.Multiline = true;
            this.Tbsal.Name = "Tbsal";
            this.Tbsal.Size = new System.Drawing.Size(190, 32);
            this.Tbsal.TabIndex = 14;
            this.Tbsal.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Assignment.Properties.Resources.bbf5d260_7486_4fb1_b421_f812d99f8df1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tbexp
            // 
            this.Tbexp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tbexp.Location = new System.Drawing.Point(626, 220);
            this.Tbexp.Multiline = true;
            this.Tbexp.Name = "Tbexp";
            this.Tbexp.Size = new System.Drawing.Size(190, 34);
            this.Tbexp.TabIndex = 13;
            this.Tbexp.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Tbcon
            // 
            this.Tbcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tbcon.Location = new System.Drawing.Point(626, 171);
            this.Tbcon.Multiline = true;
            this.Tbcon.Name = "Tbcon";
            this.Tbcon.Size = new System.Drawing.Size(190, 33);
            this.Tbcon.TabIndex = 12;
            this.Tbcon.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Tbadd
            // 
            this.Tbadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tbadd.Location = new System.Drawing.Point(165, 313);
            this.Tbadd.Multiline = true;
            this.Tbadd.Name = "Tbadd";
            this.Tbadd.Size = new System.Drawing.Size(209, 90);
            this.Tbadd.TabIndex = 11;
            this.Tbadd.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Tbnic
            // 
            this.Tbnic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tbnic.Location = new System.Drawing.Point(165, 267);
            this.Tbnic.Multiline = true;
            this.Tbnic.Name = "Tbnic";
            this.Tbnic.Size = new System.Drawing.Size(209, 35);
            this.Tbnic.TabIndex = 10;
            this.Tbnic.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Tbname
            // 
            this.Tbname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tbname.Location = new System.Drawing.Point(165, 219);
            this.Tbname.Multiline = true;
            this.Tbname.Name = "Tbname";
            this.Tbname.Size = new System.Drawing.Size(209, 33);
            this.Tbname.TabIndex = 9;
            this.Tbname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TbId
            // 
            this.TbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbId.Location = new System.Drawing.Point(165, 170);
            this.TbId.Multiline = true;
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(172, 29);
            this.TbId.TabIndex = 8;
            this.TbId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(478, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Contact No";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(479, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Experience";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Trainer Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "NIC Number";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Salary";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Qualification";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trainer ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 572);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Kick Blast Judo School ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(1022, 572);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "Trainer Management";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // trainerTableAdapter
            // 
            this.trainerTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.abstract_luxury_gradient_blue_background_smooth_dark_blue_with_black_vignette_studio_banner_1258_52393;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 618);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickblast_Judo_Management_SystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbqual;
        private System.Windows.Forms.TextBox Tbsal;
        private System.Windows.Forms.TextBox Tbexp;
        private System.Windows.Forms.TextBox Tbcon;
        private System.Windows.Forms.TextBox Tbadd;
        private System.Windows.Forms.TextBox Tbnic;
        private System.Windows.Forms.TextBox Tbname;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Kickblast_Judo_Management_SystemDataSet4 kickblast_Judo_Management_SystemDataSet4;
        private System.Windows.Forms.BindingSource trainerBindingSource;
        private Kickblast_Judo_Management_SystemDataSet4TableAdapters.TrainerTableAdapter trainerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nICNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
    }
}