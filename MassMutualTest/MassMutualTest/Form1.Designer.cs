namespace MassMutualTest
{
    partial class FrmMassMutual
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
            this.lblVal1 = new System.Windows.Forms.Label();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.lblVal3 = new System.Windows.Forms.Label();
            this.lblVal4 = new System.Windows.Forms.Label();
            this.lblVal5 = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtTotalVal = new System.Windows.Forms.TextBox();
            this.txtVal5 = new System.Windows.Forms.TextBox();
            this.txtVal4 = new System.Windows.Forms.TextBox();
            this.txtVal3 = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.Location = new System.Drawing.Point(253, 127);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(74, 25);
            this.lblVal1.TabIndex = 0;
            this.lblVal1.Text = "Value1";
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.Location = new System.Drawing.Point(253, 185);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(74, 25);
            this.lblVal2.TabIndex = 1;
            this.lblVal2.Text = "Value2";
            // 
            // lblVal3
            // 
            this.lblVal3.AutoSize = true;
            this.lblVal3.Location = new System.Drawing.Point(253, 241);
            this.lblVal3.Name = "lblVal3";
            this.lblVal3.Size = new System.Drawing.Size(74, 25);
            this.lblVal3.TabIndex = 2;
            this.lblVal3.Text = "Value3";
            // 
            // lblVal4
            // 
            this.lblVal4.AutoSize = true;
            this.lblVal4.Location = new System.Drawing.Point(253, 305);
            this.lblVal4.Name = "lblVal4";
            this.lblVal4.Size = new System.Drawing.Size(74, 25);
            this.lblVal4.TabIndex = 3;
            this.lblVal4.Text = "Value4";
            // 
            // lblVal5
            // 
            this.lblVal5.AutoSize = true;
            this.lblVal5.Location = new System.Drawing.Point(253, 359);
            this.lblVal5.Name = "lblVal5";
            this.lblVal5.Size = new System.Drawing.Size(74, 25);
            this.lblVal5.TabIndex = 4;
            this.lblVal5.Text = "Value5";
            // 
            // lblTotalVal
            // 
            this.lblTotalVal.AutoSize = true;
            this.lblTotalVal.Location = new System.Drawing.Point(236, 438);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(132, 25);
            this.lblTotalVal.TabIndex = 5;
            this.lblTotalVal.Text = "Total Balance";
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(422, 127);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(241, 29);
            this.txtVal1.TabIndex = 6;
            this.txtVal1.TextChanged += new System.EventHandler(this.txtVal1_TextChanged);
            // 
            // txtTotalVal
            // 
            this.txtTotalVal.Location = new System.Drawing.Point(422, 438);
            this.txtTotalVal.Name = "txtTotalVal";
            this.txtTotalVal.Size = new System.Drawing.Size(300, 29);
            this.txtTotalVal.TabIndex = 7;
            // 
            // txtVal5
            // 
            this.txtVal5.Location = new System.Drawing.Point(422, 359);
            this.txtVal5.Name = "txtVal5";
            this.txtVal5.Size = new System.Drawing.Size(241, 29);
            this.txtVal5.TabIndex = 8;
            this.txtVal5.TextChanged += new System.EventHandler(this.txtVal5_TextChanged);
            // 
            // txtVal4
            // 
            this.txtVal4.Location = new System.Drawing.Point(422, 301);
            this.txtVal4.Name = "txtVal4";
            this.txtVal4.Size = new System.Drawing.Size(241, 29);
            this.txtVal4.TabIndex = 9;
            this.txtVal4.TextChanged += new System.EventHandler(this.txtVal4_TextChanged);
            // 
            // txtVal3
            // 
            this.txtVal3.Location = new System.Drawing.Point(422, 238);
            this.txtVal3.Name = "txtVal3";
            this.txtVal3.Size = new System.Drawing.Size(241, 29);
            this.txtVal3.TabIndex = 10;
            this.txtVal3.TextChanged += new System.EventHandler(this.txtVal3_TextChanged);
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(422, 185);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(241, 29);
            this.txtVal2.TabIndex = 11;
            this.txtVal2.TextChanged += new System.EventHandler(this.txtVal2_TextChanged);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(422, 516);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(200, 63);
            this.btnTotal.TabIndex = 12;
            this.btnTotal.Text = "Calculate Sum";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // FrmMassMutual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1723, 981);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.txtVal3);
            this.Controls.Add(this.txtVal4);
            this.Controls.Add(this.txtVal5);
            this.Controls.Add(this.txtTotalVal);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.lblTotalVal);
            this.Controls.Add(this.lblVal5);
            this.Controls.Add(this.lblVal4);
            this.Controls.Add(this.lblVal3);
            this.Controls.Add(this.lblVal2);
            this.Controls.Add(this.lblVal1);
            this.Name = "FrmMassMutual";
            this.Text = "Mass Mutual Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.Label lblVal3;
        private System.Windows.Forms.Label lblVal4;
        private System.Windows.Forms.Label lblVal5;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtTotalVal;
        private System.Windows.Forms.TextBox txtVal5;
        private System.Windows.Forms.TextBox txtVal4;
        private System.Windows.Forms.TextBox txtVal3;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Button btnTotal;
    }
}

