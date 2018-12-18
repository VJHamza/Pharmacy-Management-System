namespace Pharmacy
{
    partial class SearchMedicine
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
            this.SearchMedLabel = new System.Windows.Forms.Label();
            this.SearchMedOptionComboBox = new System.Windows.Forms.ComboBox();
            this.MedicineNameBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchMedLabel
            // 
            this.SearchMedLabel.AutoSize = true;
            this.SearchMedLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMedLabel.Location = new System.Drawing.Point(49, 46);
            this.SearchMedLabel.Name = "SearchMedLabel";
            this.SearchMedLabel.Size = new System.Drawing.Size(170, 23);
            this.SearchMedLabel.TabIndex = 0;
            this.SearchMedLabel.Text = "Search Medicine";
            // 
            // SearchMedOptionComboBox
            // 
            this.SearchMedOptionComboBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SearchMedOptionComboBox.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMedOptionComboBox.FormattingEnabled = true;
            this.SearchMedOptionComboBox.Items.AddRange(new object[] {
            "MedName",
            "MedGenericName",
            "MedCatagory"});
            this.SearchMedOptionComboBox.Location = new System.Drawing.Point(274, 38);
            this.SearchMedOptionComboBox.Name = "SearchMedOptionComboBox";
            this.SearchMedOptionComboBox.Size = new System.Drawing.Size(204, 31);
            this.SearchMedOptionComboBox.TabIndex = 1;
            this.SearchMedOptionComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchMedOptionComboBox_SelectedIndexChanged);
            // 
            // MedicineNameBox
            // 
            this.MedicineNameBox.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineNameBox.Location = new System.Drawing.Point(513, 38);
            this.MedicineNameBox.Name = "MedicineNameBox";
            this.MedicineNameBox.Size = new System.Drawing.Size(211, 30);
            this.MedicineNameBox.TabIndex = 2;
            this.MedicineNameBox.TextChanged += new System.EventHandler(this.MedicineNameBox_TextChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Maroon;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 434);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(768, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MedicineNameBox);
            this.Controls.Add(this.SearchMedOptionComboBox);
            this.Controls.Add(this.SearchMedLabel);
            this.Name = "SearchMedicine";
            this.Text = "SearchMedicine";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchMedLabel;
        private System.Windows.Forms.ComboBox SearchMedOptionComboBox;
        private System.Windows.Forms.TextBox MedicineNameBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}