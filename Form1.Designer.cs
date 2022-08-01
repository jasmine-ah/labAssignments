namespace labEx2
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;

       
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
            this.components = new System.ComponentModel.Container();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_in = new System.Windows.Forms.Label();
            this.txt_in = new System.Windows.Forms.TextBox();
            this.txt_cnt = new System.Windows.Forms.TextBox();
            this.txt_pr = new System.Windows.Forms.TextBox();
            this.txt_on = new System.Windows.Forms.TextBox();
            this.lbl_obj = new System.Windows.Forms.Label();
            this.lbl_co = new System.Windows.Forms.Label();
            this.lbl_pr = new System.Windows.Forms.Label();
            this.btn_can = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.isAvailable = new System.Windows.Forms.CheckBox();
            this.chk_list = new System.Windows.Forms.CheckedListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(74, 9);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(103, 30);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "Number";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(234, 9);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(66, 30);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            // 
            // txt_number
            // 
            this.txt_number.BackColor = System.Drawing.SystemColors.Info;
            this.txt_number.Location = new System.Drawing.Point(77, 55);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 22);
            this.txt_number.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(79, 279);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(193, 47);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_in
            // 
            this.lbl_in.AutoSize = true;
            this.lbl_in.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_in.Location = new System.Drawing.Point(540, 9);
            this.lbl_in.Name = "lbl_in";
            this.lbl_in.Size = new System.Drawing.Size(217, 30);
            this.lbl_in.TabIndex = 5;
            this.lbl_in.Text = "Inventory number";
            // 
            // txt_in
            // 
            this.txt_in.BackColor = System.Drawing.SystemColors.Info;
            this.txt_in.Location = new System.Drawing.Point(545, 55);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(214, 22);
            this.txt_in.TabIndex = 6;
            // 
            // txt_cnt
            // 
            this.txt_cnt.BackColor = System.Drawing.SystemColors.Info;
            this.txt_cnt.Location = new System.Drawing.Point(79, 219);
            this.txt_cnt.Name = "txt_cnt";
            this.txt_cnt.Size = new System.Drawing.Size(178, 22);
            this.txt_cnt.TabIndex = 7;
            // 
            // txt_pr
            // 
            this.txt_pr.BackColor = System.Drawing.SystemColors.Info;
            this.txt_pr.Location = new System.Drawing.Point(545, 219);
            this.txt_pr.Name = "txt_pr";
            this.txt_pr.Size = new System.Drawing.Size(122, 22);
            this.txt_pr.TabIndex = 8;
            this.txt_pr.Text = "0.0";
            // 
            // txt_on
            // 
            this.txt_on.BackColor = System.Drawing.SystemColors.Info;
            this.txt_on.Location = new System.Drawing.Point(77, 134);
            this.txt_on.Name = "txt_on";
            this.txt_on.Size = new System.Drawing.Size(639, 22);
            this.txt_on.TabIndex = 9;
            // 
            // lbl_obj
            // 
            this.lbl_obj.AutoSize = true;
            this.lbl_obj.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obj.Location = new System.Drawing.Point(74, 91);
            this.lbl_obj.Name = "lbl_obj";
            this.lbl_obj.Size = new System.Drawing.Size(151, 30);
            this.lbl_obj.TabIndex = 10;
            this.lbl_obj.Text = "Object name";
            // 
            // lbl_co
            // 
            this.lbl_co.AutoSize = true;
            this.lbl_co.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_co.Location = new System.Drawing.Point(74, 174);
            this.lbl_co.Name = "lbl_co";
            this.lbl_co.Size = new System.Drawing.Size(80, 30);
            this.lbl_co.TabIndex = 11;
            this.lbl_co.Text = "Count";
            // 
            // lbl_pr
            // 
            this.lbl_pr.AutoSize = true;
            this.lbl_pr.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pr.Location = new System.Drawing.Point(540, 174);
            this.lbl_pr.Name = "lbl_pr";
            this.lbl_pr.Size = new System.Drawing.Size(73, 30);
            this.lbl_pr.TabIndex = 12;
            this.lbl_pr.Text = "Price";
            // 
            // btn_can
            // 
            this.btn_can.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_can.Location = new System.Drawing.Point(627, 290);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(130, 47);
            this.btn_can.TabIndex = 13;
            this.btn_can.Text = "Cancel";
            this.btn_can.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dgvAdd
            // 
            this.dgvAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Location = new System.Drawing.Point(0, 380);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.RowHeadersWidth = 51;
            this.dgvAdd.RowTemplate.Height = 24;
            this.dgvAdd.Size = new System.Drawing.Size(1261, 176);
            this.dgvAdd.TabIndex = 15;
            this.dgvAdd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdd_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // isAvailable
            // 
            this.isAvailable.AutoSize = true;
            this.isAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAvailable.Location = new System.Drawing.Point(751, 134);
            this.isAvailable.Name = "isAvailable";
            this.isAvailable.Size = new System.Drawing.Size(106, 24);
            this.isAvailable.TabIndex = 16;
            this.isAvailable.Text = "Availablity";
            this.isAvailable.UseVisualStyleBackColor = true;
            this.isAvailable.CheckedChanged += new System.EventHandler(this.isAvailable_CheckedChanged);
            // 
            // chk_list
            // 
            this.chk_list.FormattingEnabled = true;
            this.chk_list.Items.AddRange(new object[] {
            "Availability",
            "a",
            "b",
            "c"});
            this.chk_list.Location = new System.Drawing.Point(989, 53);
            this.chk_list.Name = "chk_list";
            this.chk_list.Size = new System.Drawing.Size(120, 89);
            this.chk_list.TabIndex = 17;
            this.chk_list.SelectedIndexChanged += new System.EventHandler(this.chk_list_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 20);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "simple";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 20);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "variable";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(922, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Product type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(1029, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gbx1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(787, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "gbx2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_list);
            this.Controls.Add(this.isAvailable);
            this.Controls.Add(this.dgvAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.lbl_pr);
            this.Controls.Add(this.lbl_co);
            this.Controls.Add(this.lbl_obj);
            this.Controls.Add(this.txt_on);
            this.Controls.Add(this.txt_pr);
            this.Controls.Add(this.txt_cnt);
            this.Controls.Add(this.txt_in);
            this.Controls.Add(this.lbl_in);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_number);
            this.Name = "Form1";
            this.Text = "Add Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_in;
        private System.Windows.Forms.TextBox txt_in;
        private System.Windows.Forms.TextBox txt_cnt;
        private System.Windows.Forms.TextBox txt_pr;
        private System.Windows.Forms.TextBox txt_on;
        private System.Windows.Forms.Label lbl_obj;
        private System.Windows.Forms.Label lbl_co;
        private System.Windows.Forms.Label lbl_pr;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox isAvailable;
        private System.Windows.Forms.CheckedListBox chk_list;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


            
            
            
            
     
