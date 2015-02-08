namespace LeHavre
{
    partial class HarvestForm
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
            this.done_btn = new System.Windows.Forms.Button();
            this.player_lbl = new System.Windows.Forms.Label();
            this.foodToPay_lbl = new System.Windows.Forms.Label();
            this.foodFromBoats_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.francsSelector = new System.Windows.Forms.NumericUpDown();
            this.totalFood_lbl = new System.Windows.Forms.Label();
            this.fishSelector = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.smokedFishSelector = new System.Windows.Forms.NumericUpDown();
            this.breadSelector = new System.Windows.Forms.NumericUpDown();
            this.Bread = new System.Windows.Forms.Label();
            this.meatselector = new System.Windows.Forms.NumericUpDown();
            this.Meat = new System.Windows.Forms.Label();
            this.maxFood_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.francsSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smokedFishSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meatselector)).BeginInit();
            this.SuspendLayout();
            // 
            // done_btn
            // 
            this.done_btn.Location = new System.Drawing.Point(31, 186);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(98, 60);
            this.done_btn.TabIndex = 0;
            this.done_btn.Text = "Time to lunch!";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // player_lbl
            // 
            this.player_lbl.AutoSize = true;
            this.player_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_lbl.Location = new System.Drawing.Point(80, 38);
            this.player_lbl.Name = "player_lbl";
            this.player_lbl.Size = new System.Drawing.Size(66, 24);
            this.player_lbl.TabIndex = 1;
            this.player_lbl.Text = "label1";
            this.player_lbl.Click += new System.EventHandler(this.player1Harve_Click);
            // 
            // foodToPay_lbl
            // 
            this.foodToPay_lbl.AutoSize = true;
            this.foodToPay_lbl.Location = new System.Drawing.Point(28, 94);
            this.foodToPay_lbl.Name = "foodToPay_lbl";
            this.foodToPay_lbl.Size = new System.Drawing.Size(35, 13);
            this.foodToPay_lbl.TabIndex = 2;
            this.foodToPay_lbl.Text = "label1";
            // 
            // foodFromBoats_lbl
            // 
            this.foodFromBoats_lbl.AutoSize = true;
            this.foodFromBoats_lbl.Location = new System.Drawing.Point(28, 123);
            this.foodFromBoats_lbl.Name = "foodFromBoats_lbl";
            this.foodFromBoats_lbl.Size = new System.Drawing.Size(35, 13);
            this.foodFromBoats_lbl.TabIndex = 3;
            this.foodFromBoats_lbl.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Francs";
            // 
            // francsSelector
            // 
            this.francsSelector.Location = new System.Drawing.Point(167, 95);
            this.francsSelector.Name = "francsSelector";
            this.francsSelector.Size = new System.Drawing.Size(53, 20);
            this.francsSelector.TabIndex = 6;
            // 
            // totalFood_lbl
            // 
            this.totalFood_lbl.AutoSize = true;
            this.totalFood_lbl.Location = new System.Drawing.Point(164, 233);
            this.totalFood_lbl.Name = "totalFood_lbl";
            this.totalFood_lbl.Size = new System.Drawing.Size(35, 13);
            this.totalFood_lbl.TabIndex = 7;
            this.totalFood_lbl.Text = "label1";
            // 
            // fishSelector
            // 
            this.fishSelector.Location = new System.Drawing.Point(167, 138);
            this.fishSelector.Name = "fishSelector";
            this.fishSelector.Size = new System.Drawing.Size(53, 20);
            this.fishSelector.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Smoked Fish";
            // 
            // smokedFishSelector
            // 
            this.smokedFishSelector.Location = new System.Drawing.Point(240, 138);
            this.smokedFishSelector.Name = "smokedFishSelector";
            this.smokedFishSelector.Size = new System.Drawing.Size(53, 20);
            this.smokedFishSelector.TabIndex = 12;
            // 
            // breadSelector
            // 
            this.breadSelector.Location = new System.Drawing.Point(240, 95);
            this.breadSelector.Name = "breadSelector";
            this.breadSelector.Size = new System.Drawing.Size(53, 20);
            this.breadSelector.TabIndex = 11;
            // 
            // Bread
            // 
            this.Bread.AutoSize = true;
            this.Bread.Location = new System.Drawing.Point(237, 78);
            this.Bread.Name = "Bread";
            this.Bread.Size = new System.Drawing.Size(35, 13);
            this.Bread.TabIndex = 10;
            this.Bread.Text = "Bread";
            // 
            // meatselector
            // 
            this.meatselector.Location = new System.Drawing.Point(167, 186);
            this.meatselector.Name = "meatselector";
            this.meatselector.Size = new System.Drawing.Size(53, 20);
            this.meatselector.TabIndex = 15;
            // 
            // Meat
            // 
            this.Meat.AutoSize = true;
            this.Meat.Location = new System.Drawing.Point(164, 169);
            this.Meat.Name = "Meat";
            this.Meat.Size = new System.Drawing.Size(31, 13);
            this.Meat.TabIndex = 14;
            this.Meat.Text = "Meat";
            // 
            // maxFood_lbl
            // 
            this.maxFood_lbl.AutoSize = true;
            this.maxFood_lbl.Location = new System.Drawing.Point(28, 154);
            this.maxFood_lbl.Name = "maxFood_lbl";
            this.maxFood_lbl.Size = new System.Drawing.Size(35, 13);
            this.maxFood_lbl.TabIndex = 16;
            this.maxFood_lbl.Text = "label1";
            // 
            // HarvestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 269);
            this.Controls.Add(this.maxFood_lbl);
            this.Controls.Add(this.meatselector);
            this.Controls.Add(this.Meat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.smokedFishSelector);
            this.Controls.Add(this.breadSelector);
            this.Controls.Add(this.Bread);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fishSelector);
            this.Controls.Add(this.totalFood_lbl);
            this.Controls.Add(this.francsSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foodFromBoats_lbl);
            this.Controls.Add(this.foodToPay_lbl);
            this.Controls.Add(this.player_lbl);
            this.Controls.Add(this.done_btn);
            this.Name = "HarvestForm";
            this.Text = "Harvest";
            ((System.ComponentModel.ISupportInitialize)(this.francsSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smokedFishSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meatselector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Label player_lbl;
        private System.Windows.Forms.Label foodToPay_lbl;
        private System.Windows.Forms.Label foodFromBoats_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown francsSelector;
        private System.Windows.Forms.Label totalFood_lbl;
        private System.Windows.Forms.NumericUpDown fishSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown smokedFishSelector;
        private System.Windows.Forms.NumericUpDown breadSelector;
        private System.Windows.Forms.Label Bread;
        private System.Windows.Forms.NumericUpDown meatselector;
        private System.Windows.Forms.Label Meat;
        private System.Windows.Forms.Label maxFood_lbl;
    }
}