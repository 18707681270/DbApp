namespace DbApp
{
    partial class FrmStuUpdate
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbSno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSsex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSdept = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "修改学生信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSno
            // 
            this.tbSno.Location = new System.Drawing.Point(93, 46);
            this.tbSno.Name = "tbSno";
            this.tbSno.Size = new System.Drawing.Size(252, 28);
            this.tbSno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名";
            // 
            // tbSname
            // 
            this.tbSname.Location = new System.Drawing.Point(93, 80);
            this.tbSname.Name = "tbSname";
            this.tbSname.Size = new System.Drawing.Size(252, 28);
            this.tbSname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "性别";
            // 
            // tbSsex
            // 
            this.tbSsex.Location = new System.Drawing.Point(93, 114);
            this.tbSsex.Name = "tbSsex";
            this.tbSsex.Size = new System.Drawing.Size(252, 28);
            this.tbSsex.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "年龄";
            // 
            // tbSage
            // 
            this.tbSage.Location = new System.Drawing.Point(93, 148);
            this.tbSage.Name = "tbSage";
            this.tbSage.Size = new System.Drawing.Size(252, 28);
            this.tbSage.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "所在系";
            // 
            // tbSdept
            // 
            this.tbSdept.Location = new System.Drawing.Point(93, 182);
            this.tbSdept.Name = "tbSdept";
            this.tbSdept.Size = new System.Drawing.Size(252, 28);
            this.tbSdept.TabIndex = 2;
            // 
            // FrmStuUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 270);
            this.Controls.Add(this.tbSname);
            this.Controls.Add(this.tbSdept);
            this.Controls.Add(this.tbSage);
            this.Controls.Add(this.tbSsex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FrmStuUpdate";
            this.Text = "FrmStuUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbSno;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbSname;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbSsex;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbSage;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbSdept;
    }
}