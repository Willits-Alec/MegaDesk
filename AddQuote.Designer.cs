namespace MegaDesk_Willits
{
    partial class AddQuote
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
            this.close = new System.Windows.Forms.Button();
            this.CustomerFirstName = new System.Windows.Forms.TextBox();
            this.CustomerLastName = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBoxDesk = new System.Windows.Forms.GroupBox();
            this.SurfaceMaterials = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DrawerCount = new System.Windows.Forms.NumericUpDown();
            this.GroupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rushFastest = new System.Windows.Forms.RadioButton();
            this.rushFaster = new System.Windows.Forms.RadioButton();
            this.rushFast = new System.Windows.Forms.RadioButton();
            this.standard = new System.Windows.Forms.RadioButton();
            this.SaveQuote = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calculatedCostLabel = new System.Windows.Forms.Label();
            this.CalculateCost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            this.GroupBoxDesk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerCount)).BeginInit();
            this.GroupBoxCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Castellar", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(629, 492);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(151, 52);
            this.close.TabIndex = 0;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // CustomerFirstName
            // 
            this.CustomerFirstName.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFirstName.Location = new System.Drawing.Point(11, 31);
            this.CustomerFirstName.Name = "CustomerFirstName";
            this.CustomerFirstName.Size = new System.Drawing.Size(182, 32);
            this.CustomerFirstName.TabIndex = 1;
            this.CustomerFirstName.Text = "First Name";
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLastName.Location = new System.Drawing.Point(199, 31);
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.Size = new System.Drawing.Size(182, 32);
            this.CustomerLastName.TabIndex = 2;
            this.CustomerLastName.Text = "Last Name";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(24, 67);
            this.width.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.width.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(84, 32);
            this.width.TabIndex = 4;
            this.width.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.width.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width Of The Desk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Depth Of The Desk";
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(24, 138);
            this.depth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(84, 32);
            this.depth.TabIndex = 7;
            this.depth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Drawers \r\n";
            // 
            // GroupBoxDesk
            // 
            this.GroupBoxDesk.AutoSize = true;
            this.GroupBoxDesk.Controls.Add(this.SurfaceMaterials);
            this.GroupBoxDesk.Controls.Add(this.label7);
            this.GroupBoxDesk.Controls.Add(this.label6);
            this.GroupBoxDesk.Controls.Add(this.label5);
            this.GroupBoxDesk.Controls.Add(this.label4);
            this.GroupBoxDesk.Controls.Add(this.DrawerCount);
            this.GroupBoxDesk.Controls.Add(this.label1);
            this.GroupBoxDesk.Controls.Add(this.label3);
            this.GroupBoxDesk.Controls.Add(this.width);
            this.GroupBoxDesk.Controls.Add(this.depth);
            this.GroupBoxDesk.Controls.Add(this.label2);
            this.GroupBoxDesk.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxDesk.Location = new System.Drawing.Point(12, 112);
            this.GroupBoxDesk.Name = "GroupBoxDesk";
            this.GroupBoxDesk.Size = new System.Drawing.Size(317, 349);
            this.GroupBoxDesk.TabIndex = 9;
            this.GroupBoxDesk.TabStop = false;
            this.GroupBoxDesk.Text = "Desk Specifications";
            // 
            // SurfaceMaterials
            // 
            this.SurfaceMaterials.FormattingEnabled = true;
            this.SurfaceMaterials.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.SurfaceMaterials.Location = new System.Drawing.Point(20, 285);
            this.SurfaceMaterials.Name = "SurfaceMaterials";
            this.SurfaceMaterials.Size = new System.Drawing.Size(224, 33);
            this.SurfaceMaterials.TabIndex = 14;
            this.SurfaceMaterials.SelectedIndexChanged += new System.EventHandler(this.SurfaceMaterials_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Surface Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "24  - 96 Inches";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "12  -  48 INCHES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "0 - 7 TOTAL";
            // 
            // DrawerCount
            // 
            this.DrawerCount.Location = new System.Drawing.Point(24, 208);
            this.DrawerCount.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DrawerCount.Name = "DrawerCount";
            this.DrawerCount.Size = new System.Drawing.Size(84, 32);
            this.DrawerCount.TabIndex = 9;
            this.DrawerCount.ValueChanged += new System.EventHandler(this.DrawerCount_ValueChanged);
            // 
            // GroupBoxCustomer
            // 
            this.GroupBoxCustomer.AutoSize = true;
            this.GroupBoxCustomer.Controls.Add(this.CustomerFirstName);
            this.GroupBoxCustomer.Controls.Add(this.CustomerLastName);
            this.GroupBoxCustomer.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCustomer.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxCustomer.Name = "GroupBoxCustomer";
            this.GroupBoxCustomer.Size = new System.Drawing.Size(397, 94);
            this.GroupBoxCustomer.TabIndex = 10;
            this.GroupBoxCustomer.TabStop = false;
            this.GroupBoxCustomer.Text = "Customer Information";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.rushFastest);
            this.groupBox1.Controls.Add(this.rushFaster);
            this.groupBox1.Controls.Add(this.rushFast);
            this.groupBox1.Controls.Add(this.standard);
            this.groupBox1.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(365, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 195);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rush Order";
            // 
            // rushFastest
            // 
            this.rushFastest.AutoSize = true;
            this.rushFastest.Location = new System.Drawing.Point(6, 135);
            this.rushFastest.Name = "rushFastest";
            this.rushFastest.Size = new System.Drawing.Size(292, 29);
            this.rushFastest.TabIndex = 3;
            this.rushFastest.TabStop = true;
            this.rushFastest.Text = "Rush Order (3 Days)";
            this.rushFastest.UseVisualStyleBackColor = true;
            // 
            // rushFaster
            // 
            this.rushFaster.AutoSize = true;
            this.rushFaster.Location = new System.Drawing.Point(6, 100);
            this.rushFaster.Name = "rushFaster";
            this.rushFaster.Size = new System.Drawing.Size(291, 29);
            this.rushFaster.TabIndex = 2;
            this.rushFaster.TabStop = true;
            this.rushFaster.Text = "Rush Order (5 Days)";
            this.rushFaster.UseVisualStyleBackColor = true;
            // 
            // rushFast
            // 
            this.rushFast.AutoSize = true;
            this.rushFast.Location = new System.Drawing.Point(6, 65);
            this.rushFast.Name = "rushFast";
            this.rushFast.Size = new System.Drawing.Size(292, 29);
            this.rushFast.TabIndex = 1;
            this.rushFast.TabStop = true;
            this.rushFast.Text = "Rush Order (7 Days)";
            this.rushFast.UseVisualStyleBackColor = true;
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Location = new System.Drawing.Point(6, 31);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(403, 29);
            this.standard.TabIndex = 0;
            this.standard.TabStop = true;
            this.standard.Text = "Standard Delivery (14 days)";
            this.standard.UseVisualStyleBackColor = true;
            // 
            // SaveQuote
            // 
            this.SaveQuote.Font = new System.Drawing.Font("Castellar", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveQuote.Location = new System.Drawing.Point(391, 492);
            this.SaveQuote.Name = "SaveQuote";
            this.SaveQuote.Size = new System.Drawing.Size(232, 52);
            this.SaveQuote.TabIndex = 16;
            this.SaveQuote.Text = "Save Quote";
            this.SaveQuote.UseVisualStyleBackColor = true;
            this.SaveQuote.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.calculatedCostLabel);
            this.groupBox2.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(365, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 134);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Cost";
            // 
            // calculatedCostLabel
            // 
            this.calculatedCostLabel.AutoSize = true;
            this.calculatedCostLabel.Location = new System.Drawing.Point(6, 28);
            this.calculatedCostLabel.Name = "calculatedCostLabel";
            this.calculatedCostLabel.Size = new System.Drawing.Size(20, 25);
            this.calculatedCostLabel.TabIndex = 0;
            this.calculatedCostLabel.Text = " ";
            // 
            // CalculateCost
            // 
            this.CalculateCost.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateCost.Location = new System.Drawing.Point(143, 492);
            this.CalculateCost.Name = "CalculateCost";
            this.CalculateCost.Size = new System.Drawing.Size(242, 52);
            this.CalculateCost.TabIndex = 1;
            this.CalculateCost.Text = "Calculate Cost";
            this.CalculateCost.UseVisualStyleBackColor = true;
            this.CalculateCost.Click += new System.EventHandler(this.CalculateCost_Click_1);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 560);
            this.Controls.Add(this.CalculateCost);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SaveQuote);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBoxCustomer);
            this.Controls.Add(this.GroupBoxDesk);
            this.Controls.Add(this.close);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega Desk - Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            this.GroupBoxDesk.ResumeLayout(false);
            this.GroupBoxDesk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerCount)).EndInit();
            this.GroupBoxCustomer.ResumeLayout(false);
            this.GroupBoxCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox CustomerFirstName;
        private System.Windows.Forms.TextBox CustomerLastName;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupBoxDesk;
        private System.Windows.Forms.NumericUpDown DrawerCount;
        private System.Windows.Forms.GroupBox GroupBoxCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SurfaceMaterials;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rushFastest;
        private System.Windows.Forms.RadioButton rushFaster;
        private System.Windows.Forms.RadioButton rushFast;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.Button SaveQuote;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label calculatedCostLabel;
        private System.Windows.Forms.Button CalculateCost;
    }
}