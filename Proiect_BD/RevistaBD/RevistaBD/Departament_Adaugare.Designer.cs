namespace RevistaBD
{
    partial class Departament_Adaugare
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.departamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.revista_ProiectBDDataSet3 = new RevistaBD.Revista_ProiectBDDataSet3();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDRevistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDepartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articolePropuseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentTableAdapter = new RevistaBD.Revista_ProiectBDDataSet3TableAdapters.DepartamentTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revista_ProiectBDDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(639, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentBindingSource, "Articole_Propuse", true));
            this.textBox3.Location = new System.Drawing.Point(21, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 22);
            this.textBox3.TabIndex = 7;
            // 
            // departamentBindingSource
            // 
            this.departamentBindingSource.DataMember = "Departament";
            this.departamentBindingSource.DataSource = this.revista_ProiectBDDataSet3;
            // 
            // revista_ProiectBDDataSet3
            // 
            this.revista_ProiectBDDataSet3.DataSetName = "Revista_ProiectBDDataSet3";
            this.revista_ProiectBDDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Articole Propuse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentBindingSource, "Nume_Departament", true));
            this.textBox2.Location = new System.Drawing.Point(21, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume Departament";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentBindingSource, "ID_Revista", true));
            this.textBox1.Location = new System.Drawing.Point(21, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revista";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(891, 505);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 27);
            this.button4.TabIndex = 7;
            this.button4.Text = "Inapoi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "Actualizare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 505);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 26);
            this.button3.TabIndex = 11;
            this.button3.Text = "Stergere";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRevistaDataGridViewTextBoxColumn,
            this.numeDepartamentDataGridViewTextBoxColumn,
            this.articolePropuseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departamentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 213);
            this.dataGridView1.TabIndex = 12;
            // 
            // iDRevistaDataGridViewTextBoxColumn
            // 
            this.iDRevistaDataGridViewTextBoxColumn.DataPropertyName = "ID_Revista";
            this.iDRevistaDataGridViewTextBoxColumn.HeaderText = "ID_Revista";
            this.iDRevistaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRevistaDataGridViewTextBoxColumn.Name = "iDRevistaDataGridViewTextBoxColumn";
            this.iDRevistaDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeDepartamentDataGridViewTextBoxColumn
            // 
            this.numeDepartamentDataGridViewTextBoxColumn.DataPropertyName = "Nume_Departament";
            this.numeDepartamentDataGridViewTextBoxColumn.HeaderText = "Nume_Departament";
            this.numeDepartamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDepartamentDataGridViewTextBoxColumn.Name = "numeDepartamentDataGridViewTextBoxColumn";
            this.numeDepartamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // articolePropuseDataGridViewTextBoxColumn
            // 
            this.articolePropuseDataGridViewTextBoxColumn.DataPropertyName = "Articole_Propuse";
            this.articolePropuseDataGridViewTextBoxColumn.HeaderText = "Articole_Propuse";
            this.articolePropuseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.articolePropuseDataGridViewTextBoxColumn.Name = "articolePropuseDataGridViewTextBoxColumn";
            this.articolePropuseDataGridViewTextBoxColumn.Width = 125;
            // 
            // departamentTableAdapter
            // 
            this.departamentTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(630, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "In aceasta sectiune puteti aduce modificari asupra departamentelor.";
            // 
            // Departament_Adaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(985, 544);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Departament_Adaugare";
            this.Text = "Adaugare Departament";
            this.Load += new System.EventHandler(this.Departament_Adaugare_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revista_ProiectBDDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Revista_ProiectBDDataSet3 revista_ProiectBDDataSet3;
        private System.Windows.Forms.BindingSource departamentBindingSource;
        private Revista_ProiectBDDataSet3TableAdapters.DepartamentTableAdapter departamentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRevistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDepartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articolePropuseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
    }
}