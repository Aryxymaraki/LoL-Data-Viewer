namespace LoL_Data_Viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.goButton = new System.Windows.Forms.Button();
            this.filterBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addFilterButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filterBox1FilterValue = new System.Windows.Forms.ComboBox();
            this.filterBox1Filter = new System.Windows.Forms.ComboBox();
            this.filterBox6 = new System.Windows.Forms.ComboBox();
            this.filterBox5 = new System.Windows.Forms.ComboBox();
            this.filterBox4 = new System.Windows.Forms.ComboBox();
            this.filterBox3 = new System.Windows.Forms.ComboBox();
            this.filterBox2 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.filterBox2Filter = new System.Windows.Forms.ComboBox();
            this.filterBox3Filter = new System.Windows.Forms.ComboBox();
            this.filterBox4Filter = new System.Windows.Forms.ComboBox();
            this.filterBox5Filter = new System.Windows.Forms.ComboBox();
            this.filterBox6Filter = new System.Windows.Forms.ComboBox();
            this.filterBox2FilterValue = new System.Windows.Forms.ComboBox();
            this.filterBox3FilterValue = new System.Windows.Forms.ComboBox();
            this.filterBox4FilterValue = new System.Windows.Forms.ComboBox();
            this.filterBox5FilterValue = new System.Windows.Forms.ComboBox();
            this.filterBox6FilterValue = new System.Windows.Forms.ComboBox();
            this.championOutputView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.championOutputView)).BeginInit();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(26, 325);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(86, 53);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // filterBox1
            // 
            this.filterBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox1.FormattingEnabled = true;
            this.filterBox1.Location = new System.Drawing.Point(53, 6);
            this.filterBox1.Name = "filterBox1";
            this.filterBox1.Size = new System.Drawing.Size(175, 24);
            this.filterBox1.TabIndex = 2;
            this.filterBox1.SelectedIndexChanged += new System.EventHandler(this.filterBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter";
            // 
            // addFilterButton
            // 
            this.addFilterButton.Location = new System.Drawing.Point(184, 325);
            this.addFilterButton.Name = "addFilterButton";
            this.addFilterButton.Size = new System.Drawing.Size(117, 53);
            this.addFilterButton.TabIndex = 4;
            this.addFilterButton.Text = "Add Filter";
            this.addFilterButton.UseVisualStyleBackColor = true;
            this.addFilterButton.Click += new System.EventHandler(this.addFilterButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 427);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filterBox6FilterValue);
            this.tabPage1.Controls.Add(this.filterBox5FilterValue);
            this.tabPage1.Controls.Add(this.filterBox4FilterValue);
            this.tabPage1.Controls.Add(this.filterBox3FilterValue);
            this.tabPage1.Controls.Add(this.filterBox2FilterValue);
            this.tabPage1.Controls.Add(this.filterBox6Filter);
            this.tabPage1.Controls.Add(this.filterBox5Filter);
            this.tabPage1.Controls.Add(this.filterBox4Filter);
            this.tabPage1.Controls.Add(this.filterBox3Filter);
            this.tabPage1.Controls.Add(this.filterBox2Filter);
            this.tabPage1.Controls.Add(this.filterBox1FilterValue);
            this.tabPage1.Controls.Add(this.filterBox1Filter);
            this.tabPage1.Controls.Add(this.filterBox6);
            this.tabPage1.Controls.Add(this.filterBox5);
            this.tabPage1.Controls.Add(this.filterBox4);
            this.tabPage1.Controls.Add(this.filterBox3);
            this.tabPage1.Controls.Add(this.filterBox2);
            this.tabPage1.Controls.Add(this.goButton);
            this.tabPage1.Controls.Add(this.addFilterButton);
            this.tabPage1.Controls.Add(this.filterBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // filterBox1FilterValue
            // 
            this.filterBox1FilterValue.FormattingEnabled = true;
            this.filterBox1FilterValue.Location = new System.Drawing.Point(306, 6);
            this.filterBox1FilterValue.Name = "filterBox1FilterValue";
            this.filterBox1FilterValue.Size = new System.Drawing.Size(105, 24);
            this.filterBox1FilterValue.TabIndex = 11;
            // 
            // filterBox1Filter
            // 
            this.filterBox1Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox1Filter.FormattingEnabled = true;
            this.filterBox1Filter.Location = new System.Drawing.Point(234, 6);
            this.filterBox1Filter.Name = "filterBox1Filter";
            this.filterBox1Filter.Size = new System.Drawing.Size(66, 24);
            this.filterBox1Filter.TabIndex = 10;
            // 
            // filterBox6
            // 
            this.filterBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox6.Enabled = false;
            this.filterBox6.FormattingEnabled = true;
            this.filterBox6.Location = new System.Drawing.Point(53, 156);
            this.filterBox6.Name = "filterBox6";
            this.filterBox6.Size = new System.Drawing.Size(175, 24);
            this.filterBox6.TabIndex = 9;
            this.filterBox6.Visible = false;
            this.filterBox6.SelectedIndexChanged += new System.EventHandler(this.filterBox6_SelectedIndexChanged);
            // 
            // filterBox5
            // 
            this.filterBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox5.Enabled = false;
            this.filterBox5.FormattingEnabled = true;
            this.filterBox5.Location = new System.Drawing.Point(53, 126);
            this.filterBox5.Name = "filterBox5";
            this.filterBox5.Size = new System.Drawing.Size(175, 24);
            this.filterBox5.TabIndex = 8;
            this.filterBox5.Visible = false;
            this.filterBox5.SelectedIndexChanged += new System.EventHandler(this.filterBox5_SelectedIndexChanged);
            // 
            // filterBox4
            // 
            this.filterBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox4.Enabled = false;
            this.filterBox4.FormattingEnabled = true;
            this.filterBox4.Location = new System.Drawing.Point(53, 96);
            this.filterBox4.Name = "filterBox4";
            this.filterBox4.Size = new System.Drawing.Size(175, 24);
            this.filterBox4.TabIndex = 7;
            this.filterBox4.Visible = false;
            this.filterBox4.SelectedIndexChanged += new System.EventHandler(this.filterBox4_SelectedIndexChanged);
            // 
            // filterBox3
            // 
            this.filterBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox3.Enabled = false;
            this.filterBox3.FormattingEnabled = true;
            this.filterBox3.Location = new System.Drawing.Point(53, 66);
            this.filterBox3.Name = "filterBox3";
            this.filterBox3.Size = new System.Drawing.Size(175, 24);
            this.filterBox3.TabIndex = 6;
            this.filterBox3.Visible = false;
            this.filterBox3.SelectedIndexChanged += new System.EventHandler(this.filterBox3_SelectedIndexChanged);
            // 
            // filterBox2
            // 
            this.filterBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox2.Enabled = false;
            this.filterBox2.FormattingEnabled = true;
            this.filterBox2.Location = new System.Drawing.Point(53, 36);
            this.filterBox2.Name = "filterBox2";
            this.filterBox2.Size = new System.Drawing.Size(175, 24);
            this.filterBox2.TabIndex = 5;
            this.filterBox2.Visible = false;
            this.filterBox2.SelectedIndexChanged += new System.EventHandler(this.filterBox2_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.championOutputView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // filterBox2Filter
            // 
            this.filterBox2Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox2Filter.Enabled = false;
            this.filterBox2Filter.FormattingEnabled = true;
            this.filterBox2Filter.Location = new System.Drawing.Point(235, 36);
            this.filterBox2Filter.Name = "filterBox2Filter";
            this.filterBox2Filter.Size = new System.Drawing.Size(66, 24);
            this.filterBox2Filter.TabIndex = 12;
            this.filterBox2Filter.Visible = false;
            // 
            // filterBox3Filter
            // 
            this.filterBox3Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox3Filter.Enabled = false;
            this.filterBox3Filter.FormattingEnabled = true;
            this.filterBox3Filter.Location = new System.Drawing.Point(235, 66);
            this.filterBox3Filter.Name = "filterBox3Filter";
            this.filterBox3Filter.Size = new System.Drawing.Size(66, 24);
            this.filterBox3Filter.TabIndex = 13;
            this.filterBox3Filter.Visible = false;
            // 
            // filterBox4Filter
            // 
            this.filterBox4Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox4Filter.Enabled = false;
            this.filterBox4Filter.FormattingEnabled = true;
            this.filterBox4Filter.Location = new System.Drawing.Point(235, 96);
            this.filterBox4Filter.Name = "filterBox4Filter";
            this.filterBox4Filter.Size = new System.Drawing.Size(66, 24);
            this.filterBox4Filter.TabIndex = 14;
            this.filterBox4Filter.Visible = false;
            // 
            // filterBox5Filter
            // 
            this.filterBox5Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox5Filter.Enabled = false;
            this.filterBox5Filter.FormattingEnabled = true;
            this.filterBox5Filter.Location = new System.Drawing.Point(235, 126);
            this.filterBox5Filter.Name = "filterBox5Filter";
            this.filterBox5Filter.Size = new System.Drawing.Size(66, 24);
            this.filterBox5Filter.TabIndex = 15;
            this.filterBox5Filter.Visible = false;
            // 
            // filterBox6Filter
            // 
            this.filterBox6Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBox6Filter.Enabled = false;
            this.filterBox6Filter.FormattingEnabled = true;
            this.filterBox6Filter.Location = new System.Drawing.Point(235, 156);
            this.filterBox6Filter.Name = "filterBox6Filter";
            this.filterBox6Filter.Size = new System.Drawing.Size(66, 24);
            this.filterBox6Filter.TabIndex = 16;
            this.filterBox6Filter.Visible = false;
            // 
            // filterBox2FilterValue
            // 
            this.filterBox2FilterValue.Enabled = false;
            this.filterBox2FilterValue.FormattingEnabled = true;
            this.filterBox2FilterValue.Location = new System.Drawing.Point(307, 36);
            this.filterBox2FilterValue.Name = "filterBox2FilterValue";
            this.filterBox2FilterValue.Size = new System.Drawing.Size(105, 24);
            this.filterBox2FilterValue.TabIndex = 17;
            this.filterBox2FilterValue.Visible = false;
            // 
            // filterBox3FilterValue
            // 
            this.filterBox3FilterValue.Enabled = false;
            this.filterBox3FilterValue.FormattingEnabled = true;
            this.filterBox3FilterValue.Location = new System.Drawing.Point(306, 66);
            this.filterBox3FilterValue.Name = "filterBox3FilterValue";
            this.filterBox3FilterValue.Size = new System.Drawing.Size(105, 24);
            this.filterBox3FilterValue.TabIndex = 18;
            this.filterBox3FilterValue.Visible = false;
            // 
            // filterBox4FilterValue
            // 
            this.filterBox4FilterValue.Enabled = false;
            this.filterBox4FilterValue.FormattingEnabled = true;
            this.filterBox4FilterValue.Location = new System.Drawing.Point(306, 96);
            this.filterBox4FilterValue.Name = "filterBox4FilterValue";
            this.filterBox4FilterValue.Size = new System.Drawing.Size(105, 24);
            this.filterBox4FilterValue.TabIndex = 19;
            this.filterBox4FilterValue.Visible = false;
            // 
            // filterBox5FilterValue
            // 
            this.filterBox5FilterValue.Enabled = false;
            this.filterBox5FilterValue.FormattingEnabled = true;
            this.filterBox5FilterValue.Location = new System.Drawing.Point(307, 126);
            this.filterBox5FilterValue.Name = "filterBox5FilterValue";
            this.filterBox5FilterValue.Size = new System.Drawing.Size(105, 24);
            this.filterBox5FilterValue.TabIndex = 20;
            this.filterBox5FilterValue.Visible = false;
            // 
            // filterBox6FilterValue
            // 
            this.filterBox6FilterValue.Enabled = false;
            this.filterBox6FilterValue.FormattingEnabled = true;
            this.filterBox6FilterValue.Location = new System.Drawing.Point(306, 156);
            this.filterBox6FilterValue.Name = "filterBox6FilterValue";
            this.filterBox6FilterValue.Size = new System.Drawing.Size(105, 24);
            this.filterBox6FilterValue.TabIndex = 21;
            this.filterBox6FilterValue.Visible = false;
            // 
            // championOutputView
            // 
            this.championOutputView.AllowUserToAddRows = false;
            this.championOutputView.AllowUserToOrderColumns = true;
            this.championOutputView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.championOutputView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.championOutputView.Location = new System.Drawing.Point(3, 3);
            this.championOutputView.Name = "championOutputView";
            this.championOutputView.ReadOnly = true;
            this.championOutputView.RowTemplate.Height = 24;
            this.championOutputView.Size = new System.Drawing.Size(476, 392);
            this.championOutputView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 427);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LoL Data Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.championOutputView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ComboBox filterBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addFilterButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox filterBox6;
        private System.Windows.Forms.ComboBox filterBox5;
        private System.Windows.Forms.ComboBox filterBox4;
        private System.Windows.Forms.ComboBox filterBox3;
        private System.Windows.Forms.ComboBox filterBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox filterBox1Filter;
        private System.Windows.Forms.ComboBox filterBox1FilterValue;
        private System.Windows.Forms.ComboBox filterBox6Filter;
        private System.Windows.Forms.ComboBox filterBox5Filter;
        private System.Windows.Forms.ComboBox filterBox4Filter;
        private System.Windows.Forms.ComboBox filterBox3Filter;
        private System.Windows.Forms.ComboBox filterBox2Filter;
        private System.Windows.Forms.ComboBox filterBox6FilterValue;
        private System.Windows.Forms.ComboBox filterBox5FilterValue;
        private System.Windows.Forms.ComboBox filterBox4FilterValue;
        private System.Windows.Forms.ComboBox filterBox3FilterValue;
        private System.Windows.Forms.ComboBox filterBox2FilterValue;
        private System.Windows.Forms.DataGridView championOutputView;
    }
}

