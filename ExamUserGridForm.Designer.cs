﻿namespace ExamProj
{
    partial class ExamUserGridForm
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
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamUserGridForm));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsTeacher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teacherCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barManager = new DevExpress.XtraBars.BarManager(components);
            this.bar = new DevExpress.XtraBars.Bar();
            this.newBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)this.gridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.teacherCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.barManager).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl.Location = new System.Drawing.Point(0, 24);
            this.gridControl.MainView = gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { teacherCheck });
            this.gridControl.Size = new System.Drawing.Size(1278, 664);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            this.gridControl.DoubleClick += new System.EventHandler(this.gridControl_DoubleClick);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colUsername, colPassword, colIsTeacher });
            this.gridView.DetailHeight = 239;
            this.gridView.GridControl = gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowColumnResizing = false;
            this.gridView.OptionsDetail.EnableMasterViewMode = false;
            this.gridView.OptionsMenu.EnableColumnMenu = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colUsername
            // 
            this.colUsername.FieldName = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 1;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 2;
            // 
            // colIsTeacher
            // 
            this.colIsTeacher.ColumnEdit = teacherCheck;
            this.colIsTeacher.FieldName = "IsTeacher";
            this.colIsTeacher.Name = "colIsTeacher";
            this.colIsTeacher.Visible = true;
            this.colIsTeacher.VisibleIndex = 3;
            // 
            // teacherCheck
            // 
            this.teacherCheck.AutoHeight = false;
            this.teacherCheck.Name = "teacherCheck";
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowMoveBarOnToolbar = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar });
            this.barManager.DockControls.Add(barDockControlTop);
            this.barManager.DockControls.Add(barDockControlBottom);
            this.barManager.DockControls.Add(barDockControlLeft);
            this.barManager.DockControls.Add(barDockControlRight);
            this.barManager.DockWindowTabFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { newBtn, deleteBtn });
            this.barManager.MainMenu = bar;
            this.barManager.MaxItemId = 4;
            // 
            // bar
            // 
            this.bar.BarName = "Main Menu";
            this.bar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar.DockCol = 0;
            this.bar.DockRow = 0;
            this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, newBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, deleteBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
            this.bar.OptionsBar.AllowQuickCustomization = false;
            this.bar.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.bar.OptionsBar.DisableCustomization = true;
            this.bar.OptionsBar.DrawBorder = false;
            this.bar.OptionsBar.DrawDragBorder = false;
            this.bar.OptionsBar.MultiLine = true;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.Text = "Main Menu";
            // 
            // newBtn
            // 
            this.newBtn.Caption = "New";
            this.newBtn.Id = 0;
            this.newBtn.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("newBtn.ImageOptions.Image");
            this.newBtn.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("newBtn.ImageOptions.LargeImage");
            this.newBtn.Name = "newBtn";
            this.newBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Delete";
            this.deleteBtn.Id = 1;
            this.deleteBtn.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("deleteBtn.ImageOptions.Image");
            this.deleteBtn.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("deleteBtn.ImageOptions.LargeImage");
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1278, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 688);
            this.barDockControlBottom.Manager = barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1278, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 664);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1278, 24);
            this.barDockControlRight.Manager = barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 664);
            // 
            // ExamUserGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 688);
            this.Controls.Add(gridControl);
            this.Controls.Add(barDockControlLeft);
            this.Controls.Add(barDockControlRight);
            this.Controls.Add(barDockControlBottom);
            this.Controls.Add(barDockControlTop);
            this.Name = "ExamUserGridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Grid";
            ((System.ComponentModel.ISupportInitialize)this.gridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.teacherCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.barManager).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem newBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTeacher;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit teacherCheck;
    }
}