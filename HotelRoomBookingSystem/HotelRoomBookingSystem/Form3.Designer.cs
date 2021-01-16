namespace HotelRoomBookingSystem
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadioSingle = new System.Windows.Forms.RadioButton();
            this.RadioDouble = new System.Windows.Forms.RadioButton();
            this.RadioFamily = new System.Windows.Forms.RadioButton();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(77, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome to Ella Rest House";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ceylon Hotel Coparation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Room Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(95, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Check-in Date";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Check-out Date";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // RadioSingle
            // 
            this.RadioSingle.AutoSize = true;
            this.RadioSingle.Location = new System.Drawing.Point(248, 127);
            this.RadioSingle.Name = "RadioSingle";
            this.RadioSingle.Size = new System.Drawing.Size(107, 17);
            this.RadioSingle.TabIndex = 11;
            this.RadioSingle.TabStop = true;
            this.RadioSingle.Text = "Single Bed Room";
            this.RadioSingle.UseVisualStyleBackColor = true;
            this.RadioSingle.CheckedChanged += new System.EventHandler(this.RadioSingle_CheckedChanged);
            // 
            // RadioDouble
            // 
            this.RadioDouble.AutoSize = true;
            this.RadioDouble.Location = new System.Drawing.Point(248, 162);
            this.RadioDouble.Name = "RadioDouble";
            this.RadioDouble.Size = new System.Drawing.Size(112, 17);
            this.RadioDouble.TabIndex = 12;
            this.RadioDouble.TabStop = true;
            this.RadioDouble.Text = "Double Bed Room";
            this.RadioDouble.UseVisualStyleBackColor = true;
            this.RadioDouble.CheckedChanged += new System.EventHandler(this.RadioDouble_CheckedChanged);
            // 
            // RadioFamily
            // 
            this.RadioFamily.AutoSize = true;
            this.RadioFamily.Location = new System.Drawing.Point(248, 195);
            this.RadioFamily.Name = "RadioFamily";
            this.RadioFamily.Size = new System.Drawing.Size(107, 17);
            this.RadioFamily.TabIndex = 13;
            this.RadioFamily.TabStop = true;
            this.RadioFamily.Text = "Family Bed Room";
            this.RadioFamily.UseVisualStyleBackColor = true;
            this.RadioFamily.CheckedChanged += new System.EventHandler(this.RadioFamily_CheckedChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(194, 230);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 14;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(295, 230);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.RadioFamily);
            this.Controls.Add(this.RadioDouble);
            this.Controls.Add(this.RadioSingle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Availability Checker";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton RadioSingle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.RadioButton RadioDouble;
        private System.Windows.Forms.RadioButton RadioFamily;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnBack;
    }
}