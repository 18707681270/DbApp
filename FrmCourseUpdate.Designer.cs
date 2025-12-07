namespace DbApp
{
    partial class FrmCourseUpdate
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
            this.tbCno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCpno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCcredit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程号";
            // 
            // tbCno
            // 
            this.tbCno.Location = new System.Drawing.Point(123, 24);
            this.tbCno.Name = "tbCno";
            this.tbCno.ReadOnly = true;
            this.tbCno.Size = new System.Drawing.Size(220, 28);
            this.tbCno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "课程名";
            // 
            // tbCname
            // 
            this.tbCname.Location = new System.Drawing.Point(123, 58);
            this.tbCname.Name = "tbCname";
            this.tbCname.Size = new System.Drawing.Size(220, 28);
            this.tbCname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "先修课程";
            // 
            // tbCpno
            // 
            this.tbCpno.Location = new System.Drawing.Point(123, 92);
            this.tbCpno.Name = "tbCpno";
            this.tbCpno.Size = new System.Drawing.Size(220, 28);
            this.tbCpno.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "学分";
            // 
            // tbCcredit
            // 
            this.tbCcredit.Location = new System.Drawing.Point(123, 126);
            this.tbCcredit.Name = "tbCcredit";
            this.tbCcredit.Size = new System.Drawing.Size(220, 28);
            this.tbCcredit.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCourseUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCcredit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCpno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCno);
            this.Controls.Add(this.label1);
            this.Name = "FrmCourseUpdate";
            this.Text = "FrmCourseUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbCno;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbCname;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbCpno;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbCcredit;
        private System.Windows.Forms.Button button1;
    }
}