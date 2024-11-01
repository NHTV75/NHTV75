namespace Views
{
    partial class CEO_Main
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
            this.pnlChinh = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.buttonTranslate = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCaNhan = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BtnQuanLyNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.buttonThoat = new Guna.UI2.WinForms.Guna2Button();
            this.BtnQuanLyTruyCap = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPhongBan = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDuAn = new Guna.UI2.WinForms.Guna2Button();
            this.BtnThongBao = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelLogo.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChinh
            // 
            this.pnlChinh.BackColor = System.Drawing.Color.White;
            this.pnlChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChinh.Location = new System.Drawing.Point(184, 81);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Size = new System.Drawing.Size(794, 515);
            this.pnlChinh.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(310, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "GIÁM ĐỐC";
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.guna2PictureBox2);
            this.panelLogo.Controls.Add(this.guna2PictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(184, 115);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(668, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lê Văn A";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.buttonTranslate);
            this.panelTop.Controls.Add(this.BtnCaNhan);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(184, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(794, 81);
            this.panelTop.TabIndex = 6;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(205)))), ((int)(((byte)(250)))));
            this.panelSidebar.Controls.Add(this.BtnQuanLyNhanVien);
            this.panelSidebar.Controls.Add(this.buttonThoat);
            this.panelSidebar.Controls.Add(this.BtnQuanLyTruyCap);
            this.panelSidebar.Controls.Add(this.BtnPhongBan);
            this.panelSidebar.Controls.Add(this.BtnDuAn);
            this.panelSidebar.Controls.Add(this.BtnThongBao);
            this.panelSidebar.Controls.Add(this.btnTrangChu);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(184, 596);
            this.panelSidebar.TabIndex = 5;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTranslate.Animated = true;
            this.buttonTranslate.AutoRoundedCorners = true;
            this.buttonTranslate.BackColor = System.Drawing.Color.Transparent;
            this.buttonTranslate.BorderRadius = 11;
            this.buttonTranslate.BorderThickness = 1;
            this.buttonTranslate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonTranslate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonTranslate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonTranslate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonTranslate.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTranslate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonTranslate.ForeColor = System.Drawing.Color.Black;
            this.buttonTranslate.Image = global::Views.Properties.Resources.world;
            this.buttonTranslate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonTranslate.ImageSize = new System.Drawing.Size(17, 17);
            this.buttonTranslate.Location = new System.Drawing.Point(724, 53);
            this.buttonTranslate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(68, 24);
            this.buttonTranslate.TabIndex = 10;
            this.buttonTranslate.Text = "VN";
            this.buttonTranslate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCaNhan
            // 
            this.BtnCaNhan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCaNhan.Animated = true;
            this.BtnCaNhan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnCaNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCaNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCaNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCaNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCaNhan.FillColor = System.Drawing.Color.White;
            this.BtnCaNhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCaNhan.ForeColor = System.Drawing.Color.White;
            this.BtnCaNhan.Image = global::Views.Properties.Resources.cat;
            this.BtnCaNhan.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnCaNhan.Location = new System.Drawing.Point(730, 2);
            this.BtnCaNhan.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCaNhan.Name = "BtnCaNhan";
            this.BtnCaNhan.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnCaNhan.Size = new System.Drawing.Size(54, 48);
            this.BtnCaNhan.TabIndex = 4;
            this.BtnCaNhan.Click += new System.EventHandler(this.BtnCaNhan_Click);
            // 
            // BtnQuanLyNhanVien
            // 
            this.BtnQuanLyNhanVien.Animated = true;
            this.BtnQuanLyNhanVien.AutoRoundedCorners = true;
            this.BtnQuanLyNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.BtnQuanLyNhanVien.BorderRadius = 22;
            this.BtnQuanLyNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnQuanLyNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnQuanLyNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnQuanLyNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnQuanLyNhanVien.FillColor = System.Drawing.Color.Azure;
            this.BtnQuanLyNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnQuanLyNhanVien.ForeColor = System.Drawing.Color.DimGray;
            this.BtnQuanLyNhanVien.Image = global::Views.Properties.Resources.access_control;
            this.BtnQuanLyNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnQuanLyNhanVien.ImageOffset = new System.Drawing.Point(4, 2);
            this.BtnQuanLyNhanVien.ImageSize = new System.Drawing.Size(23, 23);
            this.BtnQuanLyNhanVien.Location = new System.Drawing.Point(0, 491);
            this.BtnQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.BtnQuanLyNhanVien.Name = "BtnQuanLyNhanVien";
            this.BtnQuanLyNhanVien.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnQuanLyNhanVien.Size = new System.Drawing.Size(184, 46);
            this.BtnQuanLyNhanVien.TabIndex = 9;
            this.BtnQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.BtnQuanLyNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnQuanLyNhanVien.TextOffset = new System.Drawing.Point(-2, 0);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonThoat.Animated = true;
            this.buttonThoat.AutoRoundedCorners = true;
            this.buttonThoat.BorderColor = System.Drawing.Color.DimGray;
            this.buttonThoat.BorderRadius = 16;
            this.buttonThoat.BorderThickness = 1;
            this.buttonThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonThoat.FillColor = System.Drawing.Color.Azure;
            this.buttonThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonThoat.ForeColor = System.Drawing.Color.DimGray;
            this.buttonThoat.Image = global::Views.Properties.Resources.logout;
            this.buttonThoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonThoat.Location = new System.Drawing.Point(80, 552);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(99, 35);
            this.buttonThoat.TabIndex = 8;
            this.buttonThoat.Text = "Thoát ";
            this.buttonThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnQuanLyTruyCap
            // 
            this.BtnQuanLyTruyCap.Animated = true;
            this.BtnQuanLyTruyCap.AutoRoundedCorners = true;
            this.BtnQuanLyTruyCap.BackColor = System.Drawing.Color.Transparent;
            this.BtnQuanLyTruyCap.BorderRadius = 22;
            this.BtnQuanLyTruyCap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnQuanLyTruyCap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnQuanLyTruyCap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnQuanLyTruyCap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnQuanLyTruyCap.FillColor = System.Drawing.Color.Azure;
            this.BtnQuanLyTruyCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnQuanLyTruyCap.ForeColor = System.Drawing.Color.DimGray;
            this.BtnQuanLyTruyCap.Image = global::Views.Properties.Resources.access_control;
            this.BtnQuanLyTruyCap.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnQuanLyTruyCap.ImageOffset = new System.Drawing.Point(4, 2);
            this.BtnQuanLyTruyCap.ImageSize = new System.Drawing.Size(23, 23);
            this.BtnQuanLyTruyCap.Location = new System.Drawing.Point(0, 425);
            this.BtnQuanLyTruyCap.Margin = new System.Windows.Forms.Padding(2);
            this.BtnQuanLyTruyCap.Name = "BtnQuanLyTruyCap";
            this.BtnQuanLyTruyCap.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnQuanLyTruyCap.Size = new System.Drawing.Size(184, 46);
            this.BtnQuanLyTruyCap.TabIndex = 7;
            this.BtnQuanLyTruyCap.Text = "Quản lý truy cập";
            this.BtnQuanLyTruyCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnQuanLyTruyCap.TextOffset = new System.Drawing.Point(-2, 0);
            this.BtnQuanLyTruyCap.Click += new System.EventHandler(this.BtnQuanLyTruyCap_Click);
            // 
            // BtnPhongBan
            // 
            this.BtnPhongBan.Animated = true;
            this.BtnPhongBan.AutoRoundedCorners = true;
            this.BtnPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.BtnPhongBan.BorderRadius = 22;
            this.BtnPhongBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPhongBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPhongBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPhongBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPhongBan.FillColor = System.Drawing.Color.Azure;
            this.BtnPhongBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnPhongBan.ForeColor = System.Drawing.Color.DimGray;
            this.BtnPhongBan.Image = global::Views.Properties.Resources.networking;
            this.BtnPhongBan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPhongBan.ImageOffset = new System.Drawing.Point(4, 2);
            this.BtnPhongBan.ImageSize = new System.Drawing.Size(23, 23);
            this.BtnPhongBan.Location = new System.Drawing.Point(0, 355);
            this.BtnPhongBan.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPhongBan.Name = "BtnPhongBan";
            this.BtnPhongBan.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnPhongBan.Size = new System.Drawing.Size(184, 46);
            this.BtnPhongBan.TabIndex = 6;
            this.BtnPhongBan.Text = "Phòng ban";
            this.BtnPhongBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPhongBan.Click += new System.EventHandler(this.BtnPhongBan_Click);
            // 
            // BtnDuAn
            // 
            this.BtnDuAn.Animated = true;
            this.BtnDuAn.AutoRoundedCorners = true;
            this.BtnDuAn.BackColor = System.Drawing.Color.Transparent;
            this.BtnDuAn.BorderRadius = 22;
            this.BtnDuAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDuAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDuAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDuAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDuAn.FillColor = System.Drawing.Color.Azure;
            this.BtnDuAn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnDuAn.ForeColor = System.Drawing.Color.DimGray;
            this.BtnDuAn.Image = global::Views.Properties.Resources.document;
            this.BtnDuAn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDuAn.ImageOffset = new System.Drawing.Point(4, 2);
            this.BtnDuAn.ImageSize = new System.Drawing.Size(23, 23);
            this.BtnDuAn.Location = new System.Drawing.Point(0, 284);
            this.BtnDuAn.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDuAn.Name = "BtnDuAn";
            this.BtnDuAn.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnDuAn.Size = new System.Drawing.Size(184, 46);
            this.BtnDuAn.TabIndex = 5;
            this.BtnDuAn.Text = "Dự án hồ sơ ";
            this.BtnDuAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDuAn.Click += new System.EventHandler(this.BtnDuAn_Click);
            // 
            // BtnThongBao
            // 
            this.BtnThongBao.Animated = true;
            this.BtnThongBao.AutoRoundedCorners = true;
            this.BtnThongBao.BackColor = System.Drawing.Color.Transparent;
            this.BtnThongBao.BorderRadius = 22;
            this.BtnThongBao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnThongBao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnThongBao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnThongBao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnThongBao.FillColor = System.Drawing.Color.Azure;
            this.BtnThongBao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnThongBao.ForeColor = System.Drawing.Color.DimGray;
            this.BtnThongBao.Image = global::Views.Properties.Resources.announcement;
            this.BtnThongBao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnThongBao.ImageOffset = new System.Drawing.Point(4, 2);
            this.BtnThongBao.ImageSize = new System.Drawing.Size(23, 23);
            this.BtnThongBao.Location = new System.Drawing.Point(0, 214);
            this.BtnThongBao.Margin = new System.Windows.Forms.Padding(2);
            this.BtnThongBao.Name = "BtnThongBao";
            this.BtnThongBao.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnThongBao.Size = new System.Drawing.Size(184, 46);
            this.BtnThongBao.TabIndex = 4;
            this.BtnThongBao.Text = "Thông báo";
            this.BtnThongBao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnThongBao.Click += new System.EventHandler(this.BtnThongBao_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Animated = true;
            this.btnTrangChu.AutoRoundedCorners = true;
            this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.BorderRadius = 22;
            this.btnTrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrangChu.FillColor = System.Drawing.Color.Azure;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTrangChu.ForeColor = System.Drawing.Color.DimGray;
            this.btnTrangChu.Image = global::Views.Properties.Resources.home;
            this.btnTrangChu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrangChu.ImageOffset = new System.Drawing.Point(4, 2);
            this.btnTrangChu.ImageSize = new System.Drawing.Size(23, 23);
            this.btnTrangChu.Location = new System.Drawing.Point(0, 141);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(184, 46);
            this.btnTrangChu.TabIndex = 3;
            this.btnTrangChu.Text = "Trang chủ ";
            this.btnTrangChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Views.Properties.Resources.Thêm_tiêu_đề;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(19, 94);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(146, 33);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Views.Properties.Resources.LogoxanhApp;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(2, 10);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(183, 93);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // CEO_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 596);
            this.Controls.Add(this.pnlChinh);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.Name = "CEO_Main";
            this.Text = "CEO";
            this.panelLogo.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlChinh;
        private Guna.UI2.WinForms.Guna2Button BtnQuanLyNhanVien;
        private Guna.UI2.WinForms.Guna2Button buttonThoat;
        private Guna.UI2.WinForms.Guna2Button BtnQuanLyTruyCap;
        private Guna.UI2.WinForms.Guna2Button BtnPhongBan;
        private Guna.UI2.WinForms.Guna2Button BtnDuAn;
        private Guna.UI2.WinForms.Guna2Button BtnThongBao;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttonTranslate;
        private Guna.UI2.WinForms.Guna2CircleButton BtnCaNhan;
        private System.Windows.Forms.Panel panelLogo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSidebar;
    }
}

