using System.Windows.Forms;

namespace WhiteRabbit2
{
    partial class AllOrders
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
            this.listView = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minutes = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.printCheck = new System.Windows.Forms.Button();
            this.listCourses = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(24, 31);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(170, 484);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minutes);
            this.panel1.Controls.Add(this.totalLabel);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.printCheck);
            this.panel1.Controls.Add(this.listCourses);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(214, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 532);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // minutes
            // 
            this.minutes.Location = new System.Drawing.Point(203, 358);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(90, 20);
            this.minutes.TabIndex = 9;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.Location = new System.Drawing.Point(131, 358);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(52, 20);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total: ";
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(187, 448);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(106, 35);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel order";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // printCheck
            // 
            this.printCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printCheck.Location = new System.Drawing.Point(43, 448);
            this.printCheck.Name = "printCheck";
            this.printCheck.Size = new System.Drawing.Size(104, 36);
            this.printCheck.TabIndex = 4;
            this.printCheck.Text = "Print check";
            this.printCheck.UseVisualStyleBackColor = true;
            this.printCheck.Click += new System.EventHandler(this.PrintCheck);
            // 
            // listCourses
            // 
            this.listCourses.Location = new System.Drawing.Point(28, 58);
            this.listCourses.Name = "listCourses";
            this.listCourses.Size = new System.Drawing.Size(265, 273);
            this.listCourses.TabIndex = 2;
            this.listCourses.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(172, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order # ";
            // 
            // AllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView);
            this.Name = "AllOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllOrders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button printCheck;
        private System.Windows.Forms.ListView listCourses;
        private System.Windows.Forms.TextBox minutes;
        private System.Windows.Forms.Label totalLabel;
    }
}