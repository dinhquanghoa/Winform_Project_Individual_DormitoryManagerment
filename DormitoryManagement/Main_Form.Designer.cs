namespace DormitoryManagement
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhanvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sINHVIÊNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_type = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanvienToolStripMenuItem,
            this.phongToolStripMenuItem,
            this.sINHVIÊNToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1329, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhanvienToolStripMenuItem
            // 
            this.nhanvienToolStripMenuItem.Name = "nhanvienToolStripMenuItem";
            this.nhanvienToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.nhanvienToolStripMenuItem.Text = "NHÂN VIÊN";
            this.nhanvienToolStripMenuItem.Click += new System.EventHandler(this.nhanvienToolStripMenuItem_Click);
            // 
            // phongToolStripMenuItem
            // 
            this.phongToolStripMenuItem.Name = "phongToolStripMenuItem";
            this.phongToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.phongToolStripMenuItem.Text = "PHÒNG";
            this.phongToolStripMenuItem.Click += new System.EventHandler(this.phongToolStripMenuItem_Click_1);
            // 
            // sINHVIÊNToolStripMenuItem
            // 
            this.sINHVIÊNToolStripMenuItem.Name = "sINHVIÊNToolStripMenuItem";
            this.sINHVIÊNToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.sINHVIÊNToolStripMenuItem.Text = "SINH VIÊN";
            this.sINHVIÊNToolStripMenuItem.Click += new System.EventHandler(this.sINHVIÊNToolStripMenuItem_Click);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.Location = new System.Drawing.Point(1116, 6);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(45, 16);
            this.label_type.TabIndex = 3;
            this.label_type.Text = "label1";
            this.label_type.Click += new System.EventHandler(this.label_type_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1253, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng xuất";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1329, 721);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ký túc xá";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhanvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sINHVIÊNToolStripMenuItem;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}