namespace Entity_Framework_Demo
{
    partial class EmployeeDetails
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
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.lbEmployee = new System.Windows.Forms.Label();
            this.emp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(48, 115);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(611, 286);
            this.dataGridView4.TabIndex = 0;
            // 
            // lbEmployee
            // 
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployee.Location = new System.Drawing.Point(386, 64);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(120, 20);
            this.lbEmployee.TabIndex = 4;
            this.lbEmployee.Text = "DummyName";
            this.lbEmployee.Click += new System.EventHandler(this.lbCustomerName_Click);
            // 
            // emp
            // 
            this.emp.AutoSize = true;
            this.emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp.Location = new System.Drawing.Point(44, 64);
            this.emp.Name = "emp";
            this.emp.Size = new System.Drawing.Size(248, 20);
            this.emp.TabIndex = 3;
            this.emp.Text = "Full Data for Employee For :";
            this.emp.Click += new System.EventHandler(this.Customers_Click);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 452);
            this.Controls.Add(this.lbEmployee);
            this.Controls.Add(this.emp);
            this.Controls.Add(this.dataGridView4);
            this.Name = "EmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label lbEmployee;
        private System.Windows.Forms.Label emp;
    }
}