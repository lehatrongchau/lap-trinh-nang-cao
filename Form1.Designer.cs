namespace Quanlisothu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstThumoi = new System.Windows.Forms.ListBox();
            this.lstDanhsach = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblthoigian = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnupaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstThumoi
            // 
            this.lstThumoi.AllowDrop = true;
            this.lstThumoi.FormattingEnabled = true;
            this.lstThumoi.Items.AddRange(new object[] {
            "Hổ ",
            "Báo",
            "Cáo",
            "Chồn",
            "Hươu",
            "Voi"});
            this.lstThumoi.Location = new System.Drawing.Point(12, 69);
            this.lstThumoi.Name = "lstThumoi";
            this.lstThumoi.Size = new System.Drawing.Size(124, 199);
            this.lstThumoi.TabIndex = 0;
            // 
            // lstDanhsach
            // 
            this.lstDanhsach.FormattingEnabled = true;
            this.lstDanhsach.Location = new System.Drawing.Point(190, 69);
            this.lstDanhsach.Name = "lstDanhsach";
            this.lstDanhsach.Size = new System.Drawing.Size(117, 199);
            this.lstDanhsach.TabIndex = 1;
            this.lstDanhsach.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thumoi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danhsachthu";
            // 
            // btnluu
            // 
            this.btnluu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.ImageIndex = 0;
            this.btnluu.ImageList = this.imageList1;
            this.btnluu.Location = new System.Drawing.Point(213, 310);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(123, 23);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu Danh Sách";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnluu, "Lưu danh sách thù vào file danh sách thú.txt");
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.Save_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save-icon-20.png");
            this.imageList1.Images.SetKeyName(1, "power-128.png");
            // 
            // lblthoigian
            // 
            this.lblthoigian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblthoigian.AutoSize = true;
            this.lblthoigian.Location = new System.Drawing.Point(16, 310);
            this.lblthoigian.Name = "lblthoigian";
            this.lblthoigian.Size = new System.Drawing.Size(35, 13);
            this.lblthoigian.TabIndex = 5;
            this.lblthoigian.Text = "label3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơToolStripMenuItem,
            this.sửaĐổiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoad,
            this.Save,
            this.mnuClose});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.hồSơToolStripMenuItem.Text = "Hồ Sơ";
            // 
            // mnuLoad
            // 
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(153, 22);
            this.mnuLoad.Text = "Tải Danh Sách";
            this.mnuLoad.Click += new System.EventHandler(this.mnuLoad_Click);
            // 
            // Save
            // 
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(153, 22);
            this.Save.Text = "Lưu Danh Sách";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Image = ((System.Drawing.Image)(resources.GetObject("mnuClose.Image")));
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(153, 22);
            this.mnuClose.Text = "Kết Thúc";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // sửaĐổiToolStripMenuItem
            // 
            this.sửaĐổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnucopy,
            this.mnucut,
            this.mnupaste});
            this.sửaĐổiToolStripMenuItem.Name = "sửaĐổiToolStripMenuItem";
            this.sửaĐổiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sửaĐổiToolStripMenuItem.Text = "Sửa Đổi";
            // 
            // mnucopy
            // 
            this.mnucopy.Name = "mnucopy";
            this.mnucopy.ShortcutKeyDisplayString = "Ctrl+C";
            this.mnucopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnucopy.Size = new System.Drawing.Size(136, 22);
            this.mnucopy.Text = "Sao";
            // 
            // mnucut
            // 
            this.mnucut.Name = "mnucut";
            this.mnucut.ShortcutKeyDisplayString = "Ctrl+X";
            this.mnucut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnucut.Size = new System.Drawing.Size(136, 22);
            this.mnucut.Text = "Cắt ";
            // 
            // mnupaste
            // 
            this.mnupaste.Name = "mnupaste";
            this.mnupaste.ShortcutKeyDisplayString = "Ctrl+V";
            this.mnupaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnupaste.Size = new System.Drawing.Size(136, 22);
            this.mnupaste.Text = "Dán";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 345);
            this.Controls.Add(this.lblthoigian);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDanhsach);
            this.Controls.Add(this.lstThumoi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstThumoi;
        private System.Windows.Forms.ListBox lstDanhsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblthoigian;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem sửaĐổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnucopy;
        private System.Windows.Forms.ToolStripMenuItem mnucut;
        private System.Windows.Forms.ToolStripMenuItem mnupaste;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuLoad;
    }
}

