using System.Windows.Forms;

namespace WhiteRabbit2
{
    partial class CreateNewOrder
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
            this.createOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addMain = new System.Windows.Forms.Button();
            this.addDrinks = new System.Windows.Forms.Button();
            this.addDeserts = new System.Windows.Forms.Button();
            this.addSnacks = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createOrder
            // 
            this.createOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createOrder.Location = new System.Drawing.Point(69, 412);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(165, 41);
            this.createOrder.TabIndex = 16;
            this.createOrder.Text = "Create order";
            this.createOrder.UseMnemonic = false;
            this.createOrder.UseVisualStyleBackColor = true;
            this.createOrder.Click += new System.EventHandler(this.CreateOrder);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(195, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Order #";
            // 
            // addMain
            // 
            this.addMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMain.Location = new System.Drawing.Point(147, 300);
            this.addMain.Name = "addMain";
            this.addMain.Size = new System.Drawing.Size(125, 37);
            this.addMain.TabIndex = 14;
            this.addMain.Text = "Add main courses";
            this.addMain.UseVisualStyleBackColor = true;
            this.addMain.Click += new System.EventHandler(this.AddMainCourses);
            // 
            // addDrinks
            // 
            this.addDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDrinks.Location = new System.Drawing.Point(278, 300);
            this.addDrinks.Name = "addDrinks";
            this.addDrinks.Size = new System.Drawing.Size(125, 37);
            this.addDrinks.TabIndex = 13;
            this.addDrinks.Text = "Add drinks";
            this.addDrinks.UseVisualStyleBackColor = true;
            this.addDrinks.Click += new System.EventHandler(this.AddDrinks);
            // 
            // addDeserts
            // 
            this.addDeserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDeserts.Location = new System.Drawing.Point(409, 300);
            this.addDeserts.Name = "addDeserts";
            this.addDeserts.Size = new System.Drawing.Size(125, 37);
            this.addDeserts.TabIndex = 12;
            this.addDeserts.Text = "Add deserts";
            this.addDeserts.UseVisualStyleBackColor = true;
            this.addDeserts.Click += new System.EventHandler(this.AddDeserts);
            // 
            // addSnacks
            // 
            this.addSnacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSnacks.Location = new System.Drawing.Point(16, 300);
            this.addSnacks.Name = "addSnacks";
            this.addSnacks.Size = new System.Drawing.Size(125, 37);
            this.addSnacks.TabIndex = 11;
            this.addSnacks.Text = "Add snacks";
            this.addSnacks.UseVisualStyleBackColor = true;
            this.addSnacks.Click += new System.EventHandler(this.AddSnacks);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(278, 412);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(161, 41);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseMnemonic = false;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(274, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "0";
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.Location = new System.Drawing.Point(16, 71);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(518, 212);
            this.listOrder.TabIndex = 19;
            // 
            // CreateNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 539);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addMain);
            this.Controls.Add(this.addDrinks);
            this.Controls.Add(this.addDeserts);
            this.Controls.Add(this.addSnacks);
            this.Controls.Add(this.cancel);
            this.Name = "CreateNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMain;
        private System.Windows.Forms.Button addDrinks;
        private System.Windows.Forms.Button addDeserts;
        private System.Windows.Forms.Button addSnacks;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listOrder;
    }
}