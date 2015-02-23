namespace LeHavre
{
    partial class PayEnergyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.totalEnergyPaid_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.coal_numeric = new System.Windows.Forms.NumericUpDown();
            this.charcoal_numeric = new System.Windows.Forms.NumericUpDown();
            this.coke_numeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.coal_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charcoal_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coke_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pay energy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // totalEnergyPaid_lbl
            // 
            this.totalEnergyPaid_lbl.AutoSize = true;
            this.totalEnergyPaid_lbl.Location = new System.Drawing.Point(92, 170);
            this.totalEnergyPaid_lbl.Name = "totalEnergyPaid_lbl";
            this.totalEnergyPaid_lbl.Size = new System.Drawing.Size(101, 13);
            this.totalEnergyPaid_lbl.TabIndex = 2;
            this.totalEnergyPaid_lbl.Text = "Total energy paid: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coal: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Charcoal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Coke:";
            // 
            // coal_numeric
            // 
            this.coal_numeric.Location = new System.Drawing.Point(95, 80);
            this.coal_numeric.Name = "coal_numeric";
            this.coal_numeric.Size = new System.Drawing.Size(56, 20);
            this.coal_numeric.TabIndex = 6;
            // 
            // charcoal_numeric
            // 
            this.charcoal_numeric.Location = new System.Drawing.Point(95, 106);
            this.charcoal_numeric.Name = "charcoal_numeric";
            this.charcoal_numeric.Size = new System.Drawing.Size(56, 20);
            this.charcoal_numeric.TabIndex = 7;
            // 
            // coke_numeric
            // 
            this.coke_numeric.Location = new System.Drawing.Point(95, 132);
            this.coke_numeric.Name = "coke_numeric";
            this.coke_numeric.Size = new System.Drawing.Size(56, 20);
            this.coke_numeric.TabIndex = 8;
            // 
            // PayEnergyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.coke_numeric);
            this.Controls.Add(this.charcoal_numeric);
            this.Controls.Add(this.coal_numeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalEnergyPaid_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "PayEnergyForm";
            this.Text = "PayEnergyForm";
            this.Load += new System.EventHandler(this.PayEnergyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coal_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charcoal_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coke_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalEnergyPaid_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown coal_numeric;
        private System.Windows.Forms.NumericUpDown charcoal_numeric;
        private System.Windows.Forms.NumericUpDown coke_numeric;
    }
}