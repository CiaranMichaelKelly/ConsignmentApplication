
namespace ConsignmentApplication
{
    partial class demo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingcartListBoxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerText.Location = new System.Drawing.Point(29, 38);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(387, 45);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 25;
            this.itemsListBox.Location = new System.Drawing.Point(29, 155);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(272, 179);
            this.itemsListBox.TabIndex = 1;
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Location = new System.Drawing.Point(29, 107);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(105, 25);
            this.itemsListboxLabel.TabIndex = 2;
            this.itemsListboxLabel.Text = "Store Items";
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(361, 218);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(137, 35);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add to cart";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingcartListBoxLabel
            // 
            this.shoppingcartListBoxLabel.AutoSize = true;
            this.shoppingcartListBoxLabel.Location = new System.Drawing.Point(561, 107);
            this.shoppingcartListBoxLabel.Name = "shoppingcartListBoxLabel";
            this.shoppingcartListBoxLabel.Size = new System.Drawing.Size(133, 25);
            this.shoppingcartListBoxLabel.TabIndex = 5;
            this.shoppingcartListBoxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 25;
            this.shoppingCartListBox.Location = new System.Drawing.Point(561, 155);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(272, 179);
            this.shoppingCartListBox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(874, 218);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(137, 35);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Add to cart";
            this.makePurchase.UseVisualStyleBackColor = true;
            // 
            // demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 750);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingcartListBoxLabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "demo";
            this.Text = "demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label shoppingcartListBoxLabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button makePurchase;
    }
}

