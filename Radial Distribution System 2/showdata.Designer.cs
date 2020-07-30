namespace Radial_Distribution_System_2
{
    partial class showdata
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.busesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMUDataSet2 = new Radial_Distribution_System_2.PMUDataSet2();
            this.feederBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMUDataSet = new Radial_Distribution_System_2.PMUDataSet();
            this.feederTableAdapter = new Radial_Distribution_System_2.PMUDataSetTableAdapters.FeederTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.busesTableAdapter = new Radial_Distribution_System_2.PMUDataSet2TableAdapters.busesTableAdapter();
            this.busesTableAdapter1 = new Radial_Distribution_System_2.PMUDataSet1TableAdapters.busesTableAdapter();
            this.Bid = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.busdata = new System.Windows.Forms.ComboBox();
            this.busesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pMUDataSet3 = new Radial_Distribution_System_2.PMUDataSet3();
            this.busesTableAdapter2 = new Radial_Distribution_System_2.PMUDataSet3TableAdapters.busesTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMUDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feederBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMUDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 161);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 571);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(986, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 132);
            this.button1.TabIndex = 1;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // busesBindingSource
            // 
            this.busesBindingSource.DataMember = "buses";
            this.busesBindingSource.DataSource = this.pMUDataSet2;
            // 
            // pMUDataSet2
            // 
            this.pMUDataSet2.DataSetName = "PMUDataSet2";
            this.pMUDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feederBindingSource
            // 
            this.feederBindingSource.DataMember = "Feeder";
            this.feederBindingSource.DataSource = this.pMUDataSet;
            // 
            // pMUDataSet
            // 
            this.pMUDataSet.DataSetName = "PMUDataSet";
            this.pMUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feederTableAdapter
            // 
            this.feederTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Feeder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buses Id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.feederBindingSource, "Fname", true));
            this.comboBox2.DataSource = this.feederBindingSource;
            this.comboBox2.DisplayMember = "Fname";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 32);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "Fname";
            // 
            // busesTableAdapter
            // 
            this.busesTableAdapter.ClearBeforeFill = true;
            // 
            // busesTableAdapter1
            // 
            this.busesTableAdapter1.ClearBeforeFill = true;
            // 
            // Bid
            // 
            this.Bid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.busesBindingSource, "busID", true));
            this.Bid.DataSource = this.busesBindingSource;
            this.Bid.DisplayMember = "busID";
            this.Bid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Bid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bid.FormattingEnabled = true;
            this.Bid.Location = new System.Drawing.Point(430, 20);
            this.Bid.Name = "Bid";
            this.Bid.Size = new System.Drawing.Size(198, 32);
            this.Bid.TabIndex = 6;
            this.Bid.ValueMember = "busID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(664, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buses data";
            // 
            // busdata
            // 
            this.busdata.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.busesBindingSource1, "frequency", true));
            this.busdata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.busdata.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busdata.FormattingEnabled = true;
            this.busdata.Items.AddRange(new object[] {
            "type",
            "voltage",
            "frequency",
            "lenght",
            "Zm",
            "Zn",
            "Ys",
            "mutual",
            "insulation",
            "VArating",
            "Vp",
            "Vs",
            "Primary",
            "seconadry",
            "cooling",
            "connection",
            "impedence"});
            this.busdata.Location = new System.Drawing.Point(790, 20);
            this.busdata.Name = "busdata";
            this.busdata.Size = new System.Drawing.Size(176, 32);
            this.busdata.TabIndex = 8;
            this.busdata.SelectedIndexChanged += new System.EventHandler(this.busdata_SelectedIndexChanged);
            // 
            // busesBindingSource1
            // 
            this.busesBindingSource1.DataMember = "buses";
            this.busesBindingSource1.DataSource = this.pMUDataSet3;
            // 
            // pMUDataSet3
            // 
            this.pMUDataSet3.DataSetName = "PMUDataSet3";
            this.pMUDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // busesTableAdapter2
            // 
            this.busesTableAdapter2.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(15, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 28);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Phase A";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(15, 92);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(112, 28);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Phase B";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(15, 120);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(111, 28);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Phase C";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phase data";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "VhM",
            "VhA",
            "VIM",
            "VIA",
            "IhM",
            "IhA",
            "IlM",
            "IlA",
            "Ph",
            "Qh",
            "Pl",
            "Ql",
            "Plosscable",
            "Qlosscable",
            "Plosstr",
            "Qlosstr"});
            this.comboBox4.Location = new System.Drawing.Point(275, 88);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(172, 32);
            this.comboBox4.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(553, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 24);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(780, 92);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 24);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(733, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "To:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1119, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 305);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1119, 405);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 335);
            this.textBox2.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1115, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Buses data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1115, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Phase data";
            // 
            // showdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 752);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.busdata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "showdata";
            this.Text = "showdata";
            this.Load += new System.EventHandler(this.showdata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMUDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feederBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMUDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private PMUDataSet pMUDataSet;
        private System.Windows.Forms.BindingSource feederBindingSource;
        private PMUDataSetTableAdapters.FeederTableAdapter feederTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private PMUDataSet2 pMUDataSet2;
        private System.Windows.Forms.BindingSource busesBindingSource;
        private PMUDataSet2TableAdapters.busesTableAdapter busesTableAdapter;
        private PMUDataSet1TableAdapters.busesTableAdapter busesTableAdapter1;
        private System.Windows.Forms.ComboBox Bid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox busdata;
        private PMUDataSet3 pMUDataSet3;
        private System.Windows.Forms.BindingSource busesBindingSource1;
        private PMUDataSet3TableAdapters.busesTableAdapter busesTableAdapter2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}