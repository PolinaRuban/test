using System.Windows.Forms;

namespace WhiteRabbit2
{
    partial class Main
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
            this.allOrders = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allOrders
            // 
            this.allOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allOrders.Location = new System.Drawing.Point(29, 63);
            this.allOrders.Name = "allOrders";
            this.allOrders.Size = new System.Drawing.Size(147, 51);
            this.allOrders.TabIndex = 0;
            this.allOrders.Text = "All orders";
            this.allOrders.UseVisualStyleBackColor = true;
            this.allOrders.Click += new System.EventHandler(this.ShowAllOrders);
            // 
            // newOrder
            // 
            this.newOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newOrder.Location = new System.Drawing.Point(193, 63);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(147, 51);
            this.newOrder.TabIndex = 1;
            this.newOrder.Text = "Create new order";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.CreateNewOrder);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 188);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.allOrders);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

  }

        #endregion

        private System.Windows.Forms.Button allOrders;
        private System.Windows.Forms.Button newOrder;
    }
}