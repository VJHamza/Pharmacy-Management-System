namespace Pharmacy
{
    partial class StockManagerMEdicine
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
            this.SearchMedTextBox = new System.Windows.Forms.TextBox();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchMedTextBox
            // 
            this.SearchMedTextBox.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMedTextBox.Location = new System.Drawing.Point(494, 25);
            this.SearchMedTextBox.Name = "SearchMedTextBox";
            this.SearchMedTextBox.Size = new System.Drawing.Size(211, 30);
            this.SearchMedTextBox.TabIndex = 14;
            this.SearchMedTextBox.TextChanged += new System.EventHandler(this.SearchMedTextBox_TextChanged);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SearchComboBox.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            "MedName",
            "MedGenericName",
            "MedCatagory"});
            this.SearchComboBox.Location = new System.Drawing.Point(248, 25);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(204, 31);
            this.SearchComboBox.TabIndex = 13;
            this.SearchComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchComboBox_SelectedIndexChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(42, 28);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(170, 23);
            this.SearchLabel.TabIndex = 12;
            this.SearchLabel.Text = "Search Medicine";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1027, 438);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(945, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 15;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StockManagerMEdicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1077, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchMedTextBox);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StockManagerMEdicine";
            this.Text = "StockManagerMEdicine";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchMedTextBox;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}