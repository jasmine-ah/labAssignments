namespace labEx2
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_prdid = new System.Windows.Forms.Label();
            this.lbl_prdn = new System.Windows.Forms.Label();
            this.lbl_am = new System.Windows.Forms.Label();
            this.lbl_pr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_prdid
            // 
            this.lbl_prdid.AutoSize = true;
            this.lbl_prdid.Location = new System.Drawing.Point(26, 34);
            this.lbl_prdid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prdid.Name = "lbl_prdid";
            this.lbl_prdid.Size = new System.Drawing.Size(94, 20);
            this.lbl_prdid.TabIndex = 0;
            this.lbl_prdid.Text = "Product Id";
            // 
            // lbl_prdn
            // 
            this.lbl_prdn.AutoSize = true;
            this.lbl_prdn.Location = new System.Drawing.Point(23, 84);
            this.lbl_prdn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prdn.Name = "lbl_prdn";
            this.lbl_prdn.Size = new System.Drawing.Size(121, 20);
            this.lbl_prdn.TabIndex = 1;
            this.lbl_prdn.Text = "Product Name";
            // 
            // lbl_am
            // 
            this.lbl_am.AutoSize = true;
            this.lbl_am.Location = new System.Drawing.Point(23, 136);
            this.lbl_am.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_am.Name = "lbl_am";
            this.lbl_am.Size = new System.Drawing.Size(71, 20);
            this.lbl_am.TabIndex = 2;
            this.lbl_am.Text = "Amount";
            // 
            // lbl_pr
            // 
            this.lbl_pr.AutoSize = true;
            this.lbl_pr.Location = new System.Drawing.Point(26, 196);
            this.lbl_pr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pr.Name = "lbl_pr";
            this.lbl_pr.Size = new System.Drawing.Size(51, 20);
            this.lbl_pr.TabIndex = 3;
            this.lbl_pr.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_pr);
            this.Controls.Add(this.lbl_am);
            this.Controls.Add(this.lbl_prdn);
            this.Controls.Add(this.lbl_prdid);
            this.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(374, 242);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_prdid;
        private System.Windows.Forms.Label lbl_prdn;
        private System.Windows.Forms.Label lbl_am;
        private System.Windows.Forms.Label lbl_pr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
