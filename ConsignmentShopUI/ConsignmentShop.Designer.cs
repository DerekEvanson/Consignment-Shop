namespace ConsignmentShopUI
{
    partial class ConsignmentShopDemo
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
            this.headerText = new System.Windows.Forms.Label();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.vendorListbox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.addToChart = new System.Windows.Forms.Button();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.shoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(6, 8);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(344, 31);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListboxLabel.Location = new System.Drawing.Point(13, 478);
            this.vendorListboxLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(76, 20);
            this.vendorListboxLabel.TabIndex = 7;
            this.vendorListboxLabel.Text = "Vendors";
            // 
            // vendorListbox
            // 
            this.vendorListbox.FormattingEnabled = true;
            this.vendorListbox.ItemHeight = 16;
            this.vendorListbox.Location = new System.Drawing.Point(17, 510);
            this.vendorListbox.Name = "vendorListbox";
            this.vendorListbox.Size = new System.Drawing.Size(311, 164);
            this.vendorListbox.TabIndex = 8;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.Location = new System.Drawing.Point(362, 478);
            this.storeProfitLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(106, 20);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Store Profit:";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(470, 478);
            this.storeProfitValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(54, 20);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$0.00";
            // 
            // itemsListbox
            // 
            this.itemsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 20;
            this.itemsListbox.Location = new System.Drawing.Point(10, 88);
            this.itemsListbox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(318, 304);
            this.itemsListbox.TabIndex = 1;
            this.itemsListbox.SelectedIndexChanged += new System.EventHandler(this.itemsListbox_SelectedIndexChanged);
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListboxLabel.Location = new System.Drawing.Point(8, 63);
            this.itemsListboxLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(119, 20);
            this.itemsListboxLabel.TabIndex = 2;
            this.itemsListboxLabel.Text = "Board Games";
            // 
            // addToChart
            // 
            this.addToChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToChart.Location = new System.Drawing.Point(212, 402);
            this.addToChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToChart.Name = "addToChart";
            this.addToChart.Size = new System.Drawing.Size(116, 28);
            this.addToChart.TabIndex = 3;
            this.addToChart.Text = "Add To Chart ";
            this.addToChart.UseVisualStyleBackColor = true;
            this.addToChart.Click += new System.EventHandler(this.AddToChart_Click);
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 20;
            this.shoppingCartListbox.Location = new System.Drawing.Point(353, 88);
            this.shoppingCartListbox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(331, 304);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // shoppingCartListboxLabel
            // 
            this.shoppingCartListboxLabel.AutoSize = true;
            this.shoppingCartListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListboxLabel.Location = new System.Drawing.Point(350, 63);
            this.shoppingCartListboxLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
            this.shoppingCartListboxLabel.Size = new System.Drawing.Size(134, 20);
            this.shoppingCartListboxLabel.TabIndex = 5;
            this.shoppingCartListboxLabel.Text = "Shopping Chart";
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(568, 402);
            this.makePurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(116, 28);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // ConsignmentShopDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 691);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListbox);
            this.Controls.Add(this.vendorListboxLabel);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListboxLabel);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.addToChart);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsignmentShopDemo";
            this.Text = "Consignment Shop Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.ListBox vendorListbox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.Button addToChart;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Label shoppingCartListboxLabel;
        private System.Windows.Forms.Button makePurchase;
    }
}

