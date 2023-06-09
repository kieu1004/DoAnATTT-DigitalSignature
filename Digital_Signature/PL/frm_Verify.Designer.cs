﻿namespace Digital_Signature
{
    partial class frm_Verify
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Verify));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.titlePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMinus = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnVerify = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.dgvStuList = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // titlePanel
            // 
            this.titlePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titlePanel.BackgroundImage")));
            this.titlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titlePanel.Controls.Add(this.btnMinus);
            this.titlePanel.Controls.Add(this.btnClose);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.titlePanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.titlePanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.titlePanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Quality = 10;
            this.titlePanel.Size = new System.Drawing.Size(1300, 38);
            this.titlePanel.TabIndex = 6;
            // 
            // btnMinus
            // 
            this.btnMinus.ActiveImage = null;
            this.btnMinus.AllowAnimations = true;
            this.btnMinus.AllowBuffering = false;
            this.btnMinus.AllowToggling = false;
            this.btnMinus.AllowZooming = true;
            this.btnMinus.AllowZoomingOnFocus = false;
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.btnMinus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinus.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMinus.ErrorImage")));
            this.btnMinus.FadeWhenInactive = false;
            this.btnMinus.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMinus.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinus.Image = global::Digital_Signature.Properties.Resources.minus;
            this.btnMinus.ImageActive = null;
            this.btnMinus.ImageLocation = null;
            this.btnMinus.ImageMargin = 5;
            this.btnMinus.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMinus.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnMinus.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMinus.InitialImage")));
            this.btnMinus.Location = new System.Drawing.Point(1231, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Rotation = 0;
            this.btnMinus.ShowActiveImage = true;
            this.btnMinus.ShowCursorChanges = true;
            this.btnMinus.ShowImageBorders = true;
            this.btnMinus.ShowSizeMarkers = false;
            this.btnMinus.Size = new System.Drawing.Size(30, 30);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.ToolTipText = "";
            this.btnMinus.WaitOnLoad = true;
            this.btnMinus.Zoom = 5;
            this.btnMinus.ZoomSpeed = 10;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::Digital_Signature.Properties.Resources.crossed;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 5;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(1267, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = true;
            this.btnClose.Zoom = 5;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.ActiveBorderThickness = 1;
            this.btnVerify.ActiveCornerRadius = 20;
            this.btnVerify.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(129)))));
            this.btnVerify.ActiveForecolor = System.Drawing.Color.White;
            this.btnVerify.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(117)))), ((int)(((byte)(129)))));
            this.btnVerify.BackColor = System.Drawing.Color.White;
            this.btnVerify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerify.BackgroundImage")));
            this.btnVerify.ButtonText = "Xác thực";
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.Font = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.IdleBorderThickness = 1;
            this.btnVerify.IdleCornerRadius = 20;
            this.btnVerify.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnVerify.IdleForecolor = System.Drawing.Color.White;
            this.btnVerify.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnVerify.Location = new System.Drawing.Point(1002, 582);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(165, 55);
            this.btnVerify.TabIndex = 37;
            this.btnVerify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // dgvStuList
            // 
            this.dgvStuList.AllowCustomTheming = false;
            this.dgvStuList.AllowUserToAddRows = false;
            this.dgvStuList.AllowUserToDeleteRows = false;
            this.dgvStuList.AllowUserToResizeColumns = false;
            this.dgvStuList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvStuList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStuList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStuList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStuList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStuList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStuList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStuList.ColumnHeadersHeight = 40;
            this.dgvStuList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvStuList.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvStuList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStuList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvStuList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStuList.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvStuList.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvStuList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvStuList.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvStuList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStuList.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvStuList.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStuList.CurrentTheme.Name = null;
            this.dgvStuList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStuList.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvStuList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStuList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvStuList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStuList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStuList.EnableHeadersVisualStyles = false;
            this.dgvStuList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvStuList.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvStuList.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvStuList.HeaderForeColor = System.Drawing.Color.White;
            this.dgvStuList.Location = new System.Drawing.Point(70, 120);
            this.dgvStuList.MultiSelect = false;
            this.dgvStuList.Name = "dgvStuList";
            this.dgvStuList.ReadOnly = true;
            this.dgvStuList.RowHeadersVisible = false;
            this.dgvStuList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStuList.RowTemplate.Height = 40;
            this.dgvStuList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStuList.Size = new System.Drawing.Size(1152, 452);
            this.dgvStuList.TabIndex = 38;
            this.dgvStuList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel1.Location = new System.Drawing.Point(487, 44);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(332, 30);
            this.bunifuLabel1.TabIndex = 39;
            this.bunifuLabel1.Text = "Danh sách thông tin sinh viên đã ký";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frm_Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.dgvStuList);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Verify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Verify";
            this.Load += new System.EventHandler(this.frm_Verify_Load);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel titlePanel;
        private Bunifu.UI.WinForms.BunifuImageButton btnMinus;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnVerify;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvStuList;
    }
}