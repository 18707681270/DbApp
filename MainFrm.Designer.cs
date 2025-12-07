namespace DbApp
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.统计信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询学生ToolStripMenuItem,
            this.添加学生ToolStripMenuItem});
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            // 
            // 查询学生ToolStripMenuItem
            // 
            this.查询学生ToolStripMenuItem.Name = "查询学生ToolStripMenuItem";
            this.查询学生ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.查询学生ToolStripMenuItem.Text = "查询学生";
            this.查询学生ToolStripMenuItem.Click += new System.EventHandler(this.查询学生ToolStripMenuItem_Click);
            // 
            // 添加学生ToolStripMenuItem
            // 
            this.添加学生ToolStripMenuItem.Name = "添加学生ToolStripMenuItem";
            this.添加学生ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.添加学生ToolStripMenuItem.Text = "添加学生";
            this.添加学生ToolStripMenuItem.Click += new System.EventHandler(this.添加学生ToolStripMenuItem_Click);
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询课程ToolStripMenuItem,
            this.添加课程ToolStripMenuItem});
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            // 
            // 查询课程ToolStripMenuItem
            // 
            this.查询课程ToolStripMenuItem.Name = "查询课程ToolStripMenuItem";
            this.查询课程ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.查询课程ToolStripMenuItem.Text = "查询课程";
            this.查询课程ToolStripMenuItem.Click += new System.EventHandler(this.查询课程ToolStripMenuItem_Click);
            // 
            // 添加课程ToolStripMenuItem
            // 
            this.添加课程ToolStripMenuItem.Name = "添加课程ToolStripMenuItem";
            this.添加课程ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.添加课程ToolStripMenuItem.Text = "添加课程";
            this.添加课程ToolStripMenuItem.Click += new System.EventHandler(this.添加课程ToolStripMenuItem_Click);
            // 
            // 统计信息ToolStripMenuItem
            // 
            this.统计信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.统计ToolStripMenuItem});
            this.统计信息ToolStripMenuItem.Name = "统计信息ToolStripMenuItem";
            this.统计信息ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.统计信息ToolStripMenuItem.Text = "统计信息";
            // 
            // 统计ToolStripMenuItem
            // 
            this.统计ToolStripMenuItem.Name = "统计ToolStripMenuItem";
            this.统计ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.统计ToolStripMenuItem.Text = "统计";
            this.统计ToolStripMenuItem.Click += new System.EventHandler(this.统计ToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "学生信息管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加课程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
    }
}

