﻿
using System;
using System.Threading;

namespace MajoraAutoItemTracker.UI.MainUI
{
    partial class MainUIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUIForm));
            this.tboxDebug = new System.Windows.Forms.TextBox();
            this.pictureBoxOOTItemList = new System.Windows.Forms.PictureBox();
            this.lbCheckListOOT = new System.Windows.Forms.ListBox();
            this.tabGameMenu = new System.Windows.Forms.TabControl();
            this.tabOcarinaOfTime = new System.Windows.Forms.TabPage();
            this.splitContainerOotSideContent = new System.Windows.Forms.SplitContainer();
            this.splitContainerOotCheckListCheckItemSeparator = new System.Windows.Forms.SplitContainer();
            this.gbCheckListOOT = new System.Windows.Forms.GroupBox();
            this.imageBoxMapOOT = new Cyotek.Windows.Forms.ImageBox();
            this.tabMajoraMask = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxMMItemList = new System.Windows.Forms.PictureBox();
            this.gbCheckListMM = new System.Windows.Forms.GroupBox();
            this.lbCheckListMM = new System.Windows.Forms.ListBox();
            this.imageBoxMapMM = new Cyotek.Windows.Forms.ImageBox();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCheckClaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkLogicEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logicTesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocarinaOfTimeLogicCreatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocarinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxEmulatorList = new System.Windows.Forms.ToolStripComboBox();
            this.romToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxRomTypeList = new System.Windows.Forms.ToolStripComboBox();
            this.stratStopToolStripMenuItemStartStopEmulator = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCheckList = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOOTItemList)).BeginInit();
            this.tabGameMenu.SuspendLayout();
            this.tabOcarinaOfTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOotSideContent)).BeginInit();
            this.splitContainerOotSideContent.Panel1.SuspendLayout();
            this.splitContainerOotSideContent.Panel2.SuspendLayout();
            this.splitContainerOotSideContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOotCheckListCheckItemSeparator)).BeginInit();
            this.splitContainerOotCheckListCheckItemSeparator.Panel1.SuspendLayout();
            this.splitContainerOotCheckListCheckItemSeparator.Panel2.SuspendLayout();
            this.splitContainerOotCheckListCheckItemSeparator.SuspendLayout();
            this.gbCheckListOOT.SuspendLayout();
            this.tabMajoraMask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMMItemList)).BeginInit();
            this.gbCheckListMM.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxDebug
            // 
            this.tboxDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxDebug.Location = new System.Drawing.Point(4, 4);
            this.tboxDebug.Margin = new System.Windows.Forms.Padding(4);
            this.tboxDebug.Multiline = true;
            this.tboxDebug.Name = "tboxDebug";
            this.tboxDebug.Size = new System.Drawing.Size(440, 615);
            this.tboxDebug.TabIndex = 3;
            // 
            // pictureBoxOOTItemList
            // 
            this.pictureBoxOOTItemList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOOTItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOOTItemList.InitialImage = null;
            this.pictureBoxOOTItemList.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxOOTItemList.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxOOTItemList.Name = "pictureBoxOOTItemList";
            this.pictureBoxOOTItemList.Size = new System.Drawing.Size(300, 400);
            this.pictureBoxOOTItemList.TabIndex = 4;
            this.pictureBoxOOTItemList.TabStop = false;
            // 
            // lbCheckListOOT
            // 
            this.lbCheckListOOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCheckListOOT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCheckListOOT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbCheckListOOT.FormattingEnabled = true;
            this.lbCheckListOOT.ItemHeight = 17;
            this.lbCheckListOOT.Location = new System.Drawing.Point(3, 19);
            this.lbCheckListOOT.Margin = new System.Windows.Forms.Padding(0);
            this.lbCheckListOOT.Name = "lbCheckListOOT";
            this.lbCheckListOOT.Size = new System.Drawing.Size(294, 199);
            this.lbCheckListOOT.TabIndex = 67;
            // 
            // tabGameMenu
            // 
            this.tabGameMenu.Controls.Add(this.tabOcarinaOfTime);
            this.tabGameMenu.Controls.Add(this.tabMajoraMask);
            this.tabGameMenu.Controls.Add(this.tabPageLog);
            this.tabGameMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGameMenu.Location = new System.Drawing.Point(0, 27);
            this.tabGameMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabGameMenu.Name = "tabGameMenu";
            this.tabGameMenu.SelectedIndex = 0;
            this.tabGameMenu.Size = new System.Drawing.Size(1264, 654);
            this.tabGameMenu.TabIndex = 70;
            // 
            // tabOcarinaOfTime
            // 
            this.tabOcarinaOfTime.Controls.Add(this.splitContainerOotSideContent);
            this.tabOcarinaOfTime.Location = new System.Drawing.Point(4, 25);
            this.tabOcarinaOfTime.Margin = new System.Windows.Forms.Padding(0);
            this.tabOcarinaOfTime.Name = "tabOcarinaOfTime";
            this.tabOcarinaOfTime.Size = new System.Drawing.Size(1256, 625);
            this.tabOcarinaOfTime.TabIndex = 0;
            this.tabOcarinaOfTime.Text = "Ocarina of time";
            this.tabOcarinaOfTime.UseVisualStyleBackColor = true;
            // 
            // splitContainerOotSideContent
            // 
            this.splitContainerOotSideContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOotSideContent.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerOotSideContent.Location = new System.Drawing.Point(0, 0);
            this.splitContainerOotSideContent.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerOotSideContent.Name = "splitContainerOotSideContent";
            // 
            // splitContainerOotSideContent.Panel1
            // 
            this.splitContainerOotSideContent.Panel1.Controls.Add(this.splitContainerOotCheckListCheckItemSeparator);
            // 
            // splitContainerOotSideContent.Panel2
            // 
            this.splitContainerOotSideContent.Panel2.Controls.Add(this.imageBoxMapOOT);
            this.splitContainerOotSideContent.Size = new System.Drawing.Size(1256, 625);
            this.splitContainerOotSideContent.SplitterDistance = 300;
            this.splitContainerOotSideContent.SplitterWidth = 5;
            this.splitContainerOotSideContent.TabIndex = 71;
            // 
            // splitContainerOotCheckListCheckItemSeparator
            // 
            this.splitContainerOotCheckListCheckItemSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOotCheckListCheckItemSeparator.Location = new System.Drawing.Point(0, 0);
            this.splitContainerOotCheckListCheckItemSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerOotCheckListCheckItemSeparator.Name = "splitContainerOotCheckListCheckItemSeparator";
            this.splitContainerOotCheckListCheckItemSeparator.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerOotCheckListCheckItemSeparator.Panel1
            // 
            this.splitContainerOotCheckListCheckItemSeparator.Panel1.Controls.Add(this.pictureBoxOOTItemList);
            // 
            // splitContainerOotCheckListCheckItemSeparator.Panel2
            // 
            this.splitContainerOotCheckListCheckItemSeparator.Panel2.Controls.Add(this.gbCheckListOOT);
            this.splitContainerOotCheckListCheckItemSeparator.Size = new System.Drawing.Size(300, 625);
            this.splitContainerOotCheckListCheckItemSeparator.SplitterDistance = 400;
            this.splitContainerOotCheckListCheckItemSeparator.TabIndex = 0;
            // 
            // gbCheckListOOT
            // 
            this.gbCheckListOOT.Controls.Add(this.lbCheckListOOT);
            this.gbCheckListOOT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCheckListOOT.Location = new System.Drawing.Point(0, 0);
            this.gbCheckListOOT.Name = "gbCheckListOOT";
            this.gbCheckListOOT.Size = new System.Drawing.Size(300, 221);
            this.gbCheckListOOT.TabIndex = 68;
            this.gbCheckListOOT.TabStop = false;
            this.gbCheckListOOT.Text = "Zone";
            // 
            // imageBoxMapOOT
            // 
            this.imageBoxMapOOT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxMapOOT.Location = new System.Drawing.Point(0, 0);
            this.imageBoxMapOOT.Margin = new System.Windows.Forms.Padding(0);
            this.imageBoxMapOOT.Name = "imageBoxMapOOT";
            this.imageBoxMapOOT.Size = new System.Drawing.Size(951, 625);
            this.imageBoxMapOOT.TabIndex = 0;
            // 
            // tabMajoraMask
            // 
            this.tabMajoraMask.Controls.Add(this.splitContainer1);
            this.tabMajoraMask.Location = new System.Drawing.Point(4, 25);
            this.tabMajoraMask.Margin = new System.Windows.Forms.Padding(0);
            this.tabMajoraMask.Name = "tabMajoraMask";
            this.tabMajoraMask.Size = new System.Drawing.Size(1256, 625);
            this.tabMajoraMask.TabIndex = 1;
            this.tabMajoraMask.Text = "Majora mask";
            this.tabMajoraMask.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imageBoxMapMM);
            this.splitContainer1.Size = new System.Drawing.Size(1256, 625);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 70;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pictureBoxMMItemList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbCheckListMM);
            this.splitContainer2.Size = new System.Drawing.Size(300, 625);
            this.splitContainer2.SplitterDistance = 400;
            this.splitContainer2.TabIndex = 0;
            // 
            // pictureBoxMMItemList
            // 
            this.pictureBoxMMItemList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMMItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMMItemList.InitialImage = null;
            this.pictureBoxMMItemList.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMMItemList.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxMMItemList.Name = "pictureBoxMMItemList";
            this.pictureBoxMMItemList.Size = new System.Drawing.Size(300, 400);
            this.pictureBoxMMItemList.TabIndex = 5;
            this.pictureBoxMMItemList.TabStop = false;
            // 
            // gbCheckListMM
            // 
            this.gbCheckListMM.Controls.Add(this.lbCheckListMM);
            this.gbCheckListMM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCheckListMM.Location = new System.Drawing.Point(0, 0);
            this.gbCheckListMM.Name = "gbCheckListMM";
            this.gbCheckListMM.Size = new System.Drawing.Size(300, 221);
            this.gbCheckListMM.TabIndex = 69;
            this.gbCheckListMM.TabStop = false;
            this.gbCheckListMM.Text = "Zone";
            // 
            // lbCheckListMM
            // 
            this.lbCheckListMM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCheckListMM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCheckListMM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbCheckListMM.FormattingEnabled = true;
            this.lbCheckListMM.ItemHeight = 17;
            this.lbCheckListMM.Location = new System.Drawing.Point(3, 19);
            this.lbCheckListMM.Margin = new System.Windows.Forms.Padding(0);
            this.lbCheckListMM.Name = "lbCheckListMM";
            this.lbCheckListMM.Size = new System.Drawing.Size(294, 199);
            this.lbCheckListMM.TabIndex = 68;
            // 
            // imageBoxMapMM
            // 
            this.imageBoxMapMM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxMapMM.Location = new System.Drawing.Point(0, 0);
            this.imageBoxMapMM.Name = "imageBoxMapMM";
            this.imageBoxMapMM.Size = new System.Drawing.Size(951, 625);
            this.imageBoxMapMM.TabIndex = 0;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.tboxDebug);
            this.tabPageLog.Location = new System.Drawing.Point(4, 25);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Size = new System.Drawing.Size(1256, 625);
            this.tabPageLog.TabIndex = 2;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.emulatorToolStripMenuItem,
            this.toolStripComboBoxEmulatorList,
            this.romToolStripMenuItem,
            this.toolStripComboBoxRomTypeList,
            this.stratStopToolStripMenuItemStartStopEmulator,
            this.refreshListToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1264, 27);
            this.menuStripMain.TabIndex = 79;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSaveToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearCheckClaimToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // loadSaveToolStripMenuItem
            // 
            this.loadSaveToolStripMenuItem.Name = "loadSaveToolStripMenuItem";
            this.loadSaveToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loadSaveToolStripMenuItem.Text = "Load check claim";
            this.loadSaveToolStripMenuItem.Click += new System.EventHandler(this.OnManualLoadCheckClaim);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveToolStripMenuItem.Text = "Save check claim";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnManualSaveCheckClaim);
            // 
            // clearCheckClaimToolStripMenuItem
            // 
            this.clearCheckClaimToolStripMenuItem.Name = "clearCheckClaimToolStripMenuItem";
            this.clearCheckClaimToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clearCheckClaimToolStripMenuItem.Text = "Reset check claim";
            this.clearCheckClaimToolStripMenuItem.Click += new System.EventHandler(this.OnResetCheckClaimClick);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkLogicEditorToolStripMenuItem,
            this.logicTesterToolStripMenuItem,
            this.ocarinaOfTimeLogicCreatorToolStripMenuItem,
            this.ocarinaToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // checkLogicEditorToolStripMenuItem
            // 
            this.checkLogicEditorToolStripMenuItem.Name = "checkLogicEditorToolStripMenuItem";
            this.checkLogicEditorToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.checkLogicEditorToolStripMenuItem.Text = "Check logic editor";
            this.checkLogicEditorToolStripMenuItem.Click += new System.EventHandler(this.OnCheckLogicEditorClick);
            // 
            // logicTesterToolStripMenuItem
            // 
            this.logicTesterToolStripMenuItem.Name = "logicTesterToolStripMenuItem";
            this.logicTesterToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.logicTesterToolStripMenuItem.Text = "Logic tester";
            this.logicTesterToolStripMenuItem.Click += new System.EventHandler(this.OnLogicTesterClick);
            // 
            // ocarinaOfTimeLogicCreatorToolStripMenuItem
            // 
            this.ocarinaOfTimeLogicCreatorToolStripMenuItem.Name = "ocarinaOfTimeLogicCreatorToolStripMenuItem";
            this.ocarinaOfTimeLogicCreatorToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.ocarinaOfTimeLogicCreatorToolStripMenuItem.Text = "Ocarina of time Logic creator";
            this.ocarinaOfTimeLogicCreatorToolStripMenuItem.Click += new System.EventHandler(this.OnOotLogicCreatorClick);
            // 
            // ocarinaToolStripMenuItem
            // 
            this.ocarinaToolStripMenuItem.Name = "ocarinaToolStripMenuItem";
            this.ocarinaToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.ocarinaToolStripMenuItem.Text = "Majora mask Logic creator";
            this.ocarinaToolStripMenuItem.Click += new System.EventHandler(this.OnMmLogicCreatorClick);
            // 
            // emulatorToolStripMenuItem
            // 
            this.emulatorToolStripMenuItem.Enabled = false;
            this.emulatorToolStripMenuItem.Name = "emulatorToolStripMenuItem";
            this.emulatorToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.emulatorToolStripMenuItem.Text = "Emulator";
            // 
            // toolStripComboBoxEmulatorList
            // 
            this.toolStripComboBoxEmulatorList.Name = "toolStripComboBoxEmulatorList";
            this.toolStripComboBoxEmulatorList.Size = new System.Drawing.Size(150, 23);
            // 
            // romToolStripMenuItem
            // 
            this.romToolStripMenuItem.Enabled = false;
            this.romToolStripMenuItem.Name = "romToolStripMenuItem";
            this.romToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.romToolStripMenuItem.Text = "Rom";
            // 
            // toolStripComboBoxRomTypeList
            // 
            this.toolStripComboBoxRomTypeList.Name = "toolStripComboBoxRomTypeList";
            this.toolStripComboBoxRomTypeList.Size = new System.Drawing.Size(150, 23);
            // 
            // stratStopToolStripMenuItemStartStopEmulator
            // 
            this.stratStopToolStripMenuItemStartStopEmulator.Name = "stratStopToolStripMenuItemStartStopEmulator";
            this.stratStopToolStripMenuItemStartStopEmulator.Size = new System.Drawing.Size(72, 23);
            this.stratStopToolStripMenuItemStartStopEmulator.Text = "Strat/Stop";
            this.stratStopToolStripMenuItemStartStopEmulator.Click += new System.EventHandler(this.OnStartStopEmulatorClick);
            // 
            // refreshListToolStripMenuItem
            // 
            this.refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            this.refreshListToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.refreshListToolStripMenuItem.Text = "Refresh List";
            this.refreshListToolStripMenuItem.Click += new System.EventHandler(this.OnRefreshEmulatorListClick);
            // 
            // cmsCheckList
            // 
            this.cmsCheckList.Name = "cmsCheckMenu";
            this.cmsCheckList.Size = new System.Drawing.Size(181, 26);
            // 
            // MainUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabGameMenu);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainUIForm";
            this.Text = "Ocarin Of Time And Majora Mask Auto Tracker By Rukko";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnMainUiFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOOTItemList)).EndInit();
            this.tabGameMenu.ResumeLayout(false);
            this.tabOcarinaOfTime.ResumeLayout(false);
            this.splitContainerOotSideContent.Panel1.ResumeLayout(false);
            this.splitContainerOotSideContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOotSideContent)).EndInit();
            this.splitContainerOotSideContent.ResumeLayout(false);
            this.splitContainerOotCheckListCheckItemSeparator.Panel1.ResumeLayout(false);
            this.splitContainerOotCheckListCheckItemSeparator.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOotCheckListCheckItemSeparator)).EndInit();
            this.splitContainerOotCheckListCheckItemSeparator.ResumeLayout(false);
            this.gbCheckListOOT.ResumeLayout(false);
            this.tabMajoraMask.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMMItemList)).EndInit();
            this.gbCheckListMM.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tboxDebug;
        private System.Windows.Forms.PictureBox pictureBoxOOTItemList;
        private System.Windows.Forms.ListBox lbCheckListOOT;
        private System.Windows.Forms.TabControl tabGameMenu;
        private System.Windows.Forms.TabPage tabOcarinaOfTime;
        private System.Windows.Forms.TabPage tabMajoraMask;
        private System.Windows.Forms.ListBox lbCheckListMM;
        private System.Windows.Forms.PictureBox pictureBoxMMItemList;
        private System.Windows.Forms.SplitContainer splitContainerOotSideContent;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkLogicEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logicTesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocarinaOfTimeLogicCreatorToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxEmulatorList;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxRomTypeList;
        private System.Windows.Forms.ToolStripMenuItem emulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stratStopToolStripMenuItemStartStopEmulator;
        private System.Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerOotCheckListCheckItemSeparator;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem loadSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCheckClaimToolStripMenuItem;
        private Cyotek.Windows.Forms.ImageBox imageBoxMapOOT;
        private Cyotek.Windows.Forms.ImageBox imageBoxMapMM;
        private System.Windows.Forms.GroupBox gbCheckListOOT;
        private System.Windows.Forms.GroupBox gbCheckListMM;
        private System.Windows.Forms.ToolStripMenuItem ocarinaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsCheckList;
    }
}

