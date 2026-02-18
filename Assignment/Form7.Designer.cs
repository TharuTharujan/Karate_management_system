namespace Assignment
{
    partial class Form7
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coachingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofcoachingcreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athleteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athletenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofweeksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountforTrainingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privateCoachingHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privateCoachingStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privateCoachingEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountforCoachingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTrainingandCoachingAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofweeks1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingfeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privatecoachingfeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kickblast_Judo_Management_SystemDataSet10 = new Assignment.Kickblast_Judo_Management_SystemDataSet10();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.coachingTableAdapter = new Assignment.Kickblast_Judo_Management_SystemDataSet10TableAdapters.CoachingTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickblast_Judo_Management_SystemDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 479);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Assignment.Properties.Resources.pngtree_vector_back_icon_png_image_1023353;
            this.pictureBox1.Location = new System.Drawing.Point(14, 424);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Assignment.Properties.Resources.kick_last__3__removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(1002, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 137);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coachingIDDataGridViewTextBoxColumn,
            this.dateofcoachingcreationDataGridViewTextBoxColumn,
            this.athleteIDDataGridViewTextBoxColumn,
            this.athletenameDataGridViewTextBoxColumn,
            this.currentweightDataGridViewTextBoxColumn,
            this.weightcategoryDataGridViewTextBoxColumn,
            this.trainerIDDataGridViewTextBoxColumn,
            this.trainernameDataGridViewTextBoxColumn,
            this.trainingplanDataGridViewTextBoxColumn,
            this.trainingstartdateDataGridViewTextBoxColumn,
            this.trainingenddateDataGridViewTextBoxColumn,
            this.noofweeksDataGridViewTextBoxColumn,
            this.totalAmountforTrainingDataGridViewTextBoxColumn,
            this.privateCoachingHoursDataGridViewTextBoxColumn,
            this.privateCoachingStartDateDataGridViewTextBoxColumn,
            this.privateCoachingEndDateDataGridViewTextBoxColumn,
            this.totalAmountforCoachingDataGridViewTextBoxColumn,
            this.totalTrainingandCoachingAmountDataGridViewTextBoxColumn,
            this.noofweeks1DataGridViewTextBoxColumn,
            this.trainingfeesDataGridViewTextBoxColumn,
            this.privatecoachingfeesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coachingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 205);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // coachingIDDataGridViewTextBoxColumn
            // 
            this.coachingIDDataGridViewTextBoxColumn.DataPropertyName = "Coaching_ID";
            this.coachingIDDataGridViewTextBoxColumn.HeaderText = "Coaching_ID";
            this.coachingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coachingIDDataGridViewTextBoxColumn.Name = "coachingIDDataGridViewTextBoxColumn";
            this.coachingIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateofcoachingcreationDataGridViewTextBoxColumn
            // 
            this.dateofcoachingcreationDataGridViewTextBoxColumn.DataPropertyName = "Date_of_coaching_creation";
            this.dateofcoachingcreationDataGridViewTextBoxColumn.HeaderText = "Date_of_coaching_creation";
            this.dateofcoachingcreationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofcoachingcreationDataGridViewTextBoxColumn.Name = "dateofcoachingcreationDataGridViewTextBoxColumn";
            this.dateofcoachingcreationDataGridViewTextBoxColumn.Width = 125;
            // 
            // athleteIDDataGridViewTextBoxColumn
            // 
            this.athleteIDDataGridViewTextBoxColumn.DataPropertyName = "Athlete_ID";
            this.athleteIDDataGridViewTextBoxColumn.HeaderText = "Athlete_ID";
            this.athleteIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.athleteIDDataGridViewTextBoxColumn.Name = "athleteIDDataGridViewTextBoxColumn";
            this.athleteIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // athletenameDataGridViewTextBoxColumn
            // 
            this.athletenameDataGridViewTextBoxColumn.DataPropertyName = "Athlete_name";
            this.athletenameDataGridViewTextBoxColumn.HeaderText = "Athlete_name";
            this.athletenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.athletenameDataGridViewTextBoxColumn.Name = "athletenameDataGridViewTextBoxColumn";
            this.athletenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentweightDataGridViewTextBoxColumn
            // 
            this.currentweightDataGridViewTextBoxColumn.DataPropertyName = "Current_weight";
            this.currentweightDataGridViewTextBoxColumn.HeaderText = "Current_weight";
            this.currentweightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentweightDataGridViewTextBoxColumn.Name = "currentweightDataGridViewTextBoxColumn";
            this.currentweightDataGridViewTextBoxColumn.Width = 125;
            // 
            // weightcategoryDataGridViewTextBoxColumn
            // 
            this.weightcategoryDataGridViewTextBoxColumn.DataPropertyName = "Weight_category";
            this.weightcategoryDataGridViewTextBoxColumn.HeaderText = "Weight_category";
            this.weightcategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightcategoryDataGridViewTextBoxColumn.Name = "weightcategoryDataGridViewTextBoxColumn";
            this.weightcategoryDataGridViewTextBoxColumn.Width = 125;
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
            // trainingplanDataGridViewTextBoxColumn
            // 
            this.trainingplanDataGridViewTextBoxColumn.DataPropertyName = "Training_plan";
            this.trainingplanDataGridViewTextBoxColumn.HeaderText = "Training_plan";
            this.trainingplanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainingplanDataGridViewTextBoxColumn.Name = "trainingplanDataGridViewTextBoxColumn";
            this.trainingplanDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainingstartdateDataGridViewTextBoxColumn
            // 
            this.trainingstartdateDataGridViewTextBoxColumn.DataPropertyName = "Training_start_date";
            this.trainingstartdateDataGridViewTextBoxColumn.HeaderText = "Training_start_date";
            this.trainingstartdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainingstartdateDataGridViewTextBoxColumn.Name = "trainingstartdateDataGridViewTextBoxColumn";
            this.trainingstartdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainingenddateDataGridViewTextBoxColumn
            // 
            this.trainingenddateDataGridViewTextBoxColumn.DataPropertyName = "Training_end_date";
            this.trainingenddateDataGridViewTextBoxColumn.HeaderText = "Training_end_date";
            this.trainingenddateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainingenddateDataGridViewTextBoxColumn.Name = "trainingenddateDataGridViewTextBoxColumn";
            this.trainingenddateDataGridViewTextBoxColumn.Width = 125;
            // 
            // noofweeksDataGridViewTextBoxColumn
            // 
            this.noofweeksDataGridViewTextBoxColumn.DataPropertyName = "No_of_weeks";
            this.noofweeksDataGridViewTextBoxColumn.HeaderText = "No_of_weeks";
            this.noofweeksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noofweeksDataGridViewTextBoxColumn.Name = "noofweeksDataGridViewTextBoxColumn";
            this.noofweeksDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalAmountforTrainingDataGridViewTextBoxColumn
            // 
            this.totalAmountforTrainingDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount_for_Training";
            this.totalAmountforTrainingDataGridViewTextBoxColumn.HeaderText = "Total_Amount_for_Training";
            this.totalAmountforTrainingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalAmountforTrainingDataGridViewTextBoxColumn.Name = "totalAmountforTrainingDataGridViewTextBoxColumn";
            this.totalAmountforTrainingDataGridViewTextBoxColumn.Width = 125;
            // 
            // privateCoachingHoursDataGridViewTextBoxColumn
            // 
            this.privateCoachingHoursDataGridViewTextBoxColumn.DataPropertyName = "Private_Coaching_Hours";
            this.privateCoachingHoursDataGridViewTextBoxColumn.HeaderText = "Private_Coaching_Hours";
            this.privateCoachingHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.privateCoachingHoursDataGridViewTextBoxColumn.Name = "privateCoachingHoursDataGridViewTextBoxColumn";
            this.privateCoachingHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // privateCoachingStartDateDataGridViewTextBoxColumn
            // 
            this.privateCoachingStartDateDataGridViewTextBoxColumn.DataPropertyName = "Private_Coaching_Start_Date";
            this.privateCoachingStartDateDataGridViewTextBoxColumn.HeaderText = "Private_Coaching_Start_Date";
            this.privateCoachingStartDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.privateCoachingStartDateDataGridViewTextBoxColumn.Name = "privateCoachingStartDateDataGridViewTextBoxColumn";
            this.privateCoachingStartDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // privateCoachingEndDateDataGridViewTextBoxColumn
            // 
            this.privateCoachingEndDateDataGridViewTextBoxColumn.DataPropertyName = "Private_Coaching_End_Date";
            this.privateCoachingEndDateDataGridViewTextBoxColumn.HeaderText = "Private_Coaching_End_Date";
            this.privateCoachingEndDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.privateCoachingEndDateDataGridViewTextBoxColumn.Name = "privateCoachingEndDateDataGridViewTextBoxColumn";
            this.privateCoachingEndDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalAmountforCoachingDataGridViewTextBoxColumn
            // 
            this.totalAmountforCoachingDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount_for_Coaching";
            this.totalAmountforCoachingDataGridViewTextBoxColumn.HeaderText = "Total_Amount_for_Coaching";
            this.totalAmountforCoachingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalAmountforCoachingDataGridViewTextBoxColumn.Name = "totalAmountforCoachingDataGridViewTextBoxColumn";
            this.totalAmountforCoachingDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalTrainingandCoachingAmountDataGridViewTextBoxColumn
            // 
            this.totalTrainingandCoachingAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Training_and_Coaching_Amount ";
            this.totalTrainingandCoachingAmountDataGridViewTextBoxColumn.HeaderText = "Total_Training_and_Coaching_Amount ";
            this.totalTrainingandCoachingAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalTrainingandCoachingAmountDataGridViewTextBoxColumn.Name = "totalTrainingandCoachingAmountDataGridViewTextBoxColumn";
            this.totalTrainingandCoachingAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // noofweeks1DataGridViewTextBoxColumn
            // 
            this.noofweeks1DataGridViewTextBoxColumn.DataPropertyName = "No_of_weeks1";
            this.noofweeks1DataGridViewTextBoxColumn.HeaderText = "No_of_weeks1";
            this.noofweeks1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noofweeks1DataGridViewTextBoxColumn.Name = "noofweeks1DataGridViewTextBoxColumn";
            this.noofweeks1DataGridViewTextBoxColumn.Width = 125;
            // 
            // trainingfeesDataGridViewTextBoxColumn
            // 
            this.trainingfeesDataGridViewTextBoxColumn.DataPropertyName = "Training_fees";
            this.trainingfeesDataGridViewTextBoxColumn.HeaderText = "Training_fees";
            this.trainingfeesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainingfeesDataGridViewTextBoxColumn.Name = "trainingfeesDataGridViewTextBoxColumn";
            this.trainingfeesDataGridViewTextBoxColumn.Width = 125;
            // 
            // privatecoachingfeesDataGridViewTextBoxColumn
            // 
            this.privatecoachingfeesDataGridViewTextBoxColumn.DataPropertyName = "Private_coaching_fees";
            this.privatecoachingfeesDataGridViewTextBoxColumn.HeaderText = "Private_coaching_fees";
            this.privatecoachingfeesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.privatecoachingfeesDataGridViewTextBoxColumn.Name = "privatecoachingfeesDataGridViewTextBoxColumn";
            this.privatecoachingfeesDataGridViewTextBoxColumn.Width = 125;
            // 
            // coachingBindingSource
            // 
            this.coachingBindingSource.DataMember = "Coaching";
            this.coachingBindingSource.DataSource = this.kickblast_Judo_Management_SystemDataSet10;
            // 
            // kickblast_Judo_Management_SystemDataSet10
            // 
            this.kickblast_Judo_Management_SystemDataSet10.DataSetName = "Kickblast_Judo_Management_SystemDataSet10";
            this.kickblast_Judo_Management_SystemDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(20, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(352, 36);
            this.label10.TabIndex = 28;
            this.label10.Text = "Kick Blast Judo School ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 51);
            this.label1.TabIndex = 27;
            this.label1.Text = "Coaching Table";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 540);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Kick Blast Judo School ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(982, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Coaching Table";
            // 
            // coachingTableAdapter
            // 
            this.coachingTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.abstract_luxury_gradient_blue_background_smooth_dark_blue_with_black_vignette_studio_banner_1258_52393;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 582);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickblast_Judo_Management_SystemDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Kickblast_Judo_Management_SystemDataSet10 kickblast_Judo_Management_SystemDataSet10;
        private System.Windows.Forms.BindingSource coachingBindingSource;
        private Kickblast_Judo_Management_SystemDataSet10TableAdapters.CoachingTableAdapter coachingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofcoachingcreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athletenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingstartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofweeksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountforTrainingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privateCoachingHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privateCoachingStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privateCoachingEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountforCoachingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTrainingandCoachingAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofweeks1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingfeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privatecoachingfeesDataGridViewTextBoxColumn;
    }
}