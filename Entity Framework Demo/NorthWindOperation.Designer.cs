namespace Entity_Framework_Demo
{
    partial class NorthWindOperation
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
            this.Customers = new System.Windows.Forms.Label();
            this.lbCustomers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.compoEmployees = new System.Windows.Forms.ComboBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProduct = new System.Windows.Forms.ListBox();
            this.unitprice = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNumberOfOrders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Customers
            // 
            this.Customers.AutoSize = true;
            this.Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.Location = new System.Drawing.Point(91, 30);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(100, 20);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            // 
            // lbCustomers
            // 
            this.lbCustomers.FormattingEnabled = true;
            this.lbCustomers.ItemHeight = 16;
            this.lbCustomers.Location = new System.Drawing.Point(53, 69);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(190, 356);
            this.lbCustomers.TabIndex = 2;
            this.lbCustomers.SelectedIndexChanged += new System.EventHandler(this.lbCustomers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // compoEmployees
            // 
            this.compoEmployees.FormattingEnabled = true;
            this.compoEmployees.Location = new System.Drawing.Point(53, 475);
            this.compoEmployees.Name = "compoEmployees";
            this.compoEmployees.Size = new System.Drawing.Size(190, 24);
            this.compoEmployees.TabIndex = 3;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(533, 69);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(313, 236);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Customer Orders";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(298, 479);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(173, 20);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Employee Full Data";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(712, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Detail";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(928, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1749, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Products";
            // 
            // lbProduct
            // 
            this.lbProduct.FormattingEnabled = true;
            this.lbProduct.ItemHeight = 16;
            this.lbProduct.Location = new System.Drawing.Point(878, 69);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(190, 356);
            this.lbProduct.TabIndex = 7;
            this.lbProduct.SelectedIndexChanged += new System.EventHandler(this.lbProduct_SelectedIndexChanged);
            // 
            // unitprice
            // 
            this.unitprice.Location = new System.Drawing.Point(878, 463);
            this.unitprice.Name = "unitprice";
            this.unitprice.Size = new System.Drawing.Size(190, 22);
            this.unitprice.TabIndex = 8;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(878, 505);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(190, 22);
            this.quantity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(748, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unit Price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(756, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total numbers of orders";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbNumberOfOrders
            // 
            this.lbNumberOfOrders.AutoSize = true;
            this.lbNumberOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfOrders.Location = new System.Drawing.Point(378, 187);
            this.lbNumberOfOrders.Name = "lbNumberOfOrders";
            this.lbNumberOfOrders.Size = new System.Drawing.Size(19, 20);
            this.lbNumberOfOrders.TabIndex = 0;
            this.lbNumberOfOrders.Text = "0";
            this.lbNumberOfOrders.Click += new System.EventHandler(this.label6_Click);
            // 
            // NorthWindOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 582);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.unitprice);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.compoEmployees);
            this.Controls.Add(this.lbCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNumberOfOrders);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Customers);
            this.Name = "NorthWindOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NorthWindOperation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Customers;
        private System.Windows.Forms.ListBox lbCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox compoEmployees;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.TextBox unitprice;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNumberOfOrders;
    }
}