﻿
namespace Student_service
{
    partial class Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.List2 = new System.Windows.Forms.DataGridView();
            this.UpdateBox = new System.Windows.Forms.ComboBox();
            this.GradeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.degreeprojectDataSet = new Student_service.degreeprojectDataSet();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new Student_service.degreeprojectDataSetTableAdapters.subjectTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.GradeAdd = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.AddBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.List2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // List2
            // 
            this.List2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List2.Location = new System.Drawing.Point(461, 44);
            this.List2.Name = "List2";
            this.List2.Size = new System.Drawing.Size(238, 178);
            this.List2.TabIndex = 0;
            this.List2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.List2_CellContentClick);
            this.List2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.List2_RowHeaderMouseClick);
            // 
            // UpdateBox
            // 
            this.UpdateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateBox.FormattingEnabled = true;
            this.UpdateBox.Location = new System.Drawing.Point(119, 72);
            this.UpdateBox.Name = "UpdateBox";
            this.UpdateBox.Size = new System.Drawing.Size(138, 21);
            this.UpdateBox.TabIndex = 1;
            // 
            // GradeBox
            // 
            this.GradeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradeBox.FormattingEnabled = true;
            this.GradeBox.Items.AddRange(new object[] {
            "none",
            "2",
            "3+",
            "4",
            "4+",
            "5"});
            this.GradeBox.Location = new System.Drawing.Point(117, 183);
            this.GradeBox.Name = "GradeBox";
            this.GradeBox.Size = new System.Drawing.Size(138, 21);
            this.GradeBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grade";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(129, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(698, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 38);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // degreeprojectDataSet
            // 
            this.degreeprojectDataSet.DataSetName = "degreeprojectDataSet";
            this.degreeprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "subject";
            this.subjectBindingSource.DataSource = this.degreeprojectDataSet;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GradeAdd
            // 
            this.GradeAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradeAdd.FormattingEnabled = true;
            this.GradeAdd.Items.AddRange(new object[] {
            "2",
            "3+",
            "4",
            "4+",
            "5"});
            this.GradeAdd.Location = new System.Drawing.Point(306, 183);
            this.GradeAdd.Name = "GradeAdd";
            this.GradeAdd.Size = new System.Drawing.Size(138, 21);
            this.GradeAdd.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(529, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 38);
            this.button4.TabIndex = 12;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddBox
            // 
            this.AddBox.FormattingEnabled = true;
            this.AddBox.Location = new System.Drawing.Point(306, 71);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(140, 21);
            this.AddBox.TabIndex = 13;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(740, 279);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.GradeAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GradeBox);
            this.Controls.Add(this.UpdateBox);
            this.Controls.Add(this.List2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Subjects";
            this.Text = "Grades";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.W_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.W_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.W_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.List2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView List2;
        private System.Windows.Forms.ComboBox UpdateBox;
        private System.Windows.Forms.ComboBox GradeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private degreeprojectDataSet degreeprojectDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private degreeprojectDataSetTableAdapters.subjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox GradeAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox AddBox;
    }
}