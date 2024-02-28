namespace Cash_register
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Burgernumbertext = new System.Windows.Forms.TextBox();
            this.Friesnumbertext = new System.Windows.Forms.TextBox();
            this.Drinksnumbertext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tenderdtext = new System.Windows.Forms.TextBox();
            this.Calculatechange = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.subtotallabel = new System.Windows.Forms.Label();
            this.taxlabel = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.changelabel = new System.Windows.Forms.Label();
            this.receiptlabel = new System.Windows.Forms.Label();
            this.neworder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(343, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "McDaniel\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Burgers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fries";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Drinks";
            // 
            // Burgernumbertext
            // 
            this.Burgernumbertext.Location = new System.Drawing.Point(191, 48);
            this.Burgernumbertext.Name = "Burgernumbertext";
            this.Burgernumbertext.Size = new System.Drawing.Size(100, 20);
            this.Burgernumbertext.TabIndex = 4;
            // 
            // Friesnumbertext
            // 
            this.Friesnumbertext.Location = new System.Drawing.Point(191, 83);
            this.Friesnumbertext.Name = "Friesnumbertext";
            this.Friesnumbertext.Size = new System.Drawing.Size(100, 20);
            this.Friesnumbertext.TabIndex = 5;
            // 
            // Drinksnumbertext
            // 
            this.Drinksnumbertext.Location = new System.Drawing.Point(191, 114);
            this.Drinksnumbertext.Name = "Drinksnumbertext";
            this.Drinksnumbertext.Size = new System.Drawing.Size(100, 20);
            this.Drinksnumbertext.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sub Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(137, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 10);
            this.label8.TabIndex = 14;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(117, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tenderd";
            // 
            // Tenderdtext
            // 
            this.Tenderdtext.Location = new System.Drawing.Point(183, 309);
            this.Tenderdtext.Name = "Tenderdtext";
            this.Tenderdtext.Size = new System.Drawing.Size(100, 20);
            this.Tenderdtext.TabIndex = 16;
            // 
            // Calculatechange
            // 
            this.Calculatechange.Enabled = false;
            this.Calculatechange.Location = new System.Drawing.Point(163, 331);
            this.Calculatechange.Name = "Calculatechange";
            this.Calculatechange.Size = new System.Drawing.Size(128, 23);
            this.Calculatechange.TabIndex = 17;
            this.Calculatechange.Text = "Calculate Change";
            this.Calculatechange.UseVisualStyleBackColor = true;
            this.Calculatechange.Click += new System.EventHandler(this.Calculatechange_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(116, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Change";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(137, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 10);
            this.label11.TabIndex = 20;
            this.label11.Text = "label11";
            // 
            // print
            // 
            this.print.Enabled = false;
            this.print.Location = new System.Drawing.Point(163, 406);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(128, 23);
            this.print.TabIndex = 21;
            this.print.Text = "Print Recipt";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // subtotallabel
            // 
            this.subtotallabel.AutoSize = true;
            this.subtotallabel.Location = new System.Drawing.Point(198, 186);
            this.subtotallabel.Name = "subtotallabel";
            this.subtotallabel.Size = new System.Drawing.Size(16, 13);
            this.subtotallabel.TabIndex = 23;
            this.subtotallabel.Text = "...";
            // 
            // taxlabel
            // 
            this.taxlabel.AutoSize = true;
            this.taxlabel.Location = new System.Drawing.Point(198, 210);
            this.taxlabel.Name = "taxlabel";
            this.taxlabel.Size = new System.Drawing.Size(16, 13);
            this.taxlabel.TabIndex = 24;
            this.taxlabel.Text = "...";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Location = new System.Drawing.Point(198, 238);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(16, 13);
            this.totallabel.TabIndex = 25;
            this.totallabel.Text = "...";
            // 
            // changelabel
            // 
            this.changelabel.AutoSize = true;
            this.changelabel.Location = new System.Drawing.Point(180, 362);
            this.changelabel.Name = "changelabel";
            this.changelabel.Size = new System.Drawing.Size(16, 13);
            this.changelabel.TabIndex = 26;
            this.changelabel.Text = "...";
            // 
            // receiptlabel
            // 
            this.receiptlabel.BackColor = System.Drawing.Color.Snow;
            this.receiptlabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptlabel.Location = new System.Drawing.Point(483, 83);
            this.receiptlabel.Name = "receiptlabel";
            this.receiptlabel.Size = new System.Drawing.Size(216, 271);
            this.receiptlabel.TabIndex = 27;
            // 
            // neworder
            // 
            this.neworder.Location = new System.Drawing.Point(525, 370);
            this.neworder.Name = "neworder";
            this.neworder.Size = new System.Drawing.Size(128, 23);
            this.neworder.TabIndex = 28;
            this.neworder.Text = "New Order";
            this.neworder.UseVisualStyleBackColor = true;
            this.neworder.Click += new System.EventHandler(this.neworder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.neworder);
            this.Controls.Add(this.receiptlabel);
            this.Controls.Add(this.changelabel);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.taxlabel);
            this.Controls.Add(this.subtotallabel);
            this.Controls.Add(this.print);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Calculatechange);
            this.Controls.Add(this.Tenderdtext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Drinksnumbertext);
            this.Controls.Add(this.Friesnumbertext);
            this.Controls.Add(this.Burgernumbertext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Burgernumbertext;
        private System.Windows.Forms.TextBox Friesnumbertext;
        private System.Windows.Forms.TextBox Drinksnumbertext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tenderdtext;
        private System.Windows.Forms.Button Calculatechange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label subtotallabel;
        private System.Windows.Forms.Label taxlabel;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Label changelabel;
        private System.Windows.Forms.Label receiptlabel;
        private System.Windows.Forms.Button neworder;
    }
}

