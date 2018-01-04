namespace DB_System
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonBck = new System.Windows.Forms.Button();
            this.btndisp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonBck
            // 
            this.buttonBck.Location = new System.Drawing.Point(12, 387);
            this.buttonBck.Name = "buttonBck";
            this.buttonBck.Size = new System.Drawing.Size(75, 23);
            this.buttonBck.TabIndex = 1;
            this.buttonBck.Text = "Back";
            this.buttonBck.UseVisualStyleBackColor = true;
            this.buttonBck.Click += new System.EventHandler(this.buttonBck_Click);
            // 
            // btndisp
            // 
            this.btndisp.Location = new System.Drawing.Point(321, 387);
            this.btndisp.Name = "btndisp";
            this.btndisp.Size = new System.Drawing.Size(150, 23);
            this.btndisp.TabIndex = 2;
            this.btndisp.Text = "Display Archive Bug";
            this.btndisp.UseVisualStyleBackColor = true;
            this.btndisp.Click += new System.EventHandler(this.btndisp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Archived Bugs";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndisp);
            this.Controls.Add(this.buttonBck);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(500, 100);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBck;
        private System.Windows.Forms.Button btndisp;
        private System.Windows.Forms.Label label1;
    }
}