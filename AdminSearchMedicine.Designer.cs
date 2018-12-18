namespace Pharmacy
{
    partial class AdminSearchMedicine
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
            this.button1 = new System.Windows.Forms.Button();
            this.SearchMedTextBox = new System.Windows.Forms.TextBox();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(853, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 49);
            this.button1.TabIndex = 20;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchMedTextBox
            // 
            this.SearchMedTextBox.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMedTextBox.Location = new System.Drawing.Point(472, 12);
            this.SearchMedTextBox.Name = "SearchMedTextBox";
            this.SearchMedTextBox.Size = new System.Drawing.Size(211, 30);
            this.SearchMedTextBox.TabIndex = 19;
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
            this.SearchComboBox.Location = new System.Drawing.Point(233, 12);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(204, 31);
            this.SearchComboBox.TabIndex = 18;
            this.SearchComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchComboBox_SelectedIndexChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(20, 15);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(165, 22);
            this.SearchLabel.TabIndex = 17;
            this.SearchLabel.Text = "Search Medicine";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(24, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(923, 445);
            this.dataGridView1.TabIndex = 16;
            // 
            // AdminSearchMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchMedTextBox);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminSearchMedicine";
            this.Text = "AdminSearchMedicine";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchMedTextBox;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}