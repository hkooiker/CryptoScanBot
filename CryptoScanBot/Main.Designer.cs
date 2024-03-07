﻿namespace CryptoScanBot
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panelLeft = new Panel();
            tabControlSymbols = new TabControl();
            tabPageSymbols = new TabPage();
            dataGridViewSymbols = new DataGridView();
            panelLeftTop = new Panel();
            label1 = new Label();
            symbolFilter = new TextBox();
            panelClient = new Panel();
            tabControl = new TabControl();
            tabPageDashBoard = new TabPage();
            dashBoardControl1 = new DashBoardControl();
            tabPageSignals = new TabPage();
            dataGridViewSignals = new DataGridView();
            tabPageBrowser = new TabPage();
            webViewTradingView = new Microsoft.Web.WebView2.WinForms.WebView2();
            tabPagePositionsOpen = new TabPage();
            dataGridViewPositionOpen = new DataGridView();
            tabPagePositionsClosed = new TabPage();
            dataGridViewPositionClosed = new DataGridView();
            tabPageLog = new TabPage();
            TextBoxLog = new TextBox();
            tabPagewebViewDummy = new TabPage();
            webViewDummy = new Microsoft.Web.WebView2.WinForms.WebView2();
            panelClient1 = new Panel();
            dashBoardInformation1 = new TradingView.DashBoardInformation();
            MenuMain = new ToolStripMenuItem();
            ApplicationPlaySounds = new ToolStripMenuItem();
            ApplicationCreateSignals = new ToolStripMenuItem();
            ApplicationTradingBot = new ToolStripMenuItem();
            ToolStripMenuItemSettings = new ToolStripMenuItem();
            ToolStripMenuItemRefresh = new ToolStripMenuItem();
            clearMenusToolStripMenuItem = new ToolStripMenuItem();
            backtestToolStripMenuItem = new ToolStripMenuItem();
            positionInfoToolStripMenuItem = new ToolStripMenuItem();
            applicationMenuStrip = new MenuStrip();
            panelLeft.SuspendLayout();
            tabControlSymbols.SuspendLayout();
            tabPageSymbols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSymbols).BeginInit();
            panelLeftTop.SuspendLayout();
            panelClient.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageDashBoard.SuspendLayout();
            tabPageSignals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSignals).BeginInit();
            tabPageBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewTradingView).BeginInit();
            tabPagePositionsOpen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositionOpen).BeginInit();
            tabPagePositionsClosed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositionClosed).BeginInit();
            tabPageLog.SuspendLayout();
            tabPagewebViewDummy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewDummy).BeginInit();
            panelClient1.SuspendLayout();
            applicationMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(tabControlSymbols);
            panelLeft.Controls.Add(panelLeftTop);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 24);
            panelLeft.Margin = new Padding(2);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(236, 723);
            panelLeft.TabIndex = 12;
            // 
            // tabControlSymbols
            // 
            tabControlSymbols.Appearance = TabAppearance.FlatButtons;
            tabControlSymbols.Controls.Add(tabPageSymbols);
            tabControlSymbols.Dock = DockStyle.Fill;
            tabControlSymbols.Location = new Point(0, 103);
            tabControlSymbols.Name = "tabControlSymbols";
            tabControlSymbols.SelectedIndex = 0;
            tabControlSymbols.Size = new Size(236, 620);
            tabControlSymbols.TabIndex = 2;
            // 
            // tabPageSymbols
            // 
            tabPageSymbols.Controls.Add(dataGridViewSymbols);
            tabPageSymbols.Location = new Point(4, 27);
            tabPageSymbols.Name = "tabPageSymbols";
            tabPageSymbols.Size = new Size(228, 589);
            tabPageSymbols.TabIndex = 0;
            tabPageSymbols.Text = "Symbols";
            tabPageSymbols.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSymbols
            // 
            dataGridViewSymbols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSymbols.Dock = DockStyle.Fill;
            dataGridViewSymbols.Location = new Point(0, 0);
            dataGridViewSymbols.Name = "dataGridViewSymbols";
            dataGridViewSymbols.Size = new Size(228, 589);
            dataGridViewSymbols.TabIndex = 0;
            // 
            // panelLeftTop
            // 
            panelLeftTop.Controls.Add(label1);
            panelLeftTop.Controls.Add(symbolFilter);
            panelLeftTop.Dock = DockStyle.Top;
            panelLeftTop.Location = new Point(0, 0);
            panelLeftTop.Margin = new Padding(2);
            panelLeftTop.Name = "panelLeftTop";
            panelLeftTop.Size = new Size(236, 103);
            panelLeftTop.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 71;
            label1.Text = "Filter:";
            // 
            // symbolFilter
            // 
            symbolFilter.Location = new Point(10, 75);
            symbolFilter.Margin = new Padding(2);
            symbolFilter.Name = "symbolFilter";
            symbolFilter.Size = new Size(164, 23);
            symbolFilter.TabIndex = 0;
            symbolFilter.KeyDown += SymbolFilter_KeyDown;
            // 
            // panelClient
            // 
            panelClient.Controls.Add(tabControl);
            panelClient.Dock = DockStyle.Fill;
            panelClient.Location = new Point(0, 103);
            panelClient.Margin = new Padding(2);
            panelClient.Name = "panelClient";
            panelClient.Size = new Size(1164, 620);
            panelClient.TabIndex = 13;
            // 
            // tabControl
            // 
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.Controls.Add(tabPageDashBoard);
            tabControl.Controls.Add(tabPageSignals);
            tabControl.Controls.Add(tabPageBrowser);
            tabControl.Controls.Add(tabPagePositionsOpen);
            tabControl.Controls.Add(tabPagePositionsClosed);
            tabControl.Controls.Add(tabPageLog);
            tabControl.Controls.Add(tabPagewebViewDummy);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1164, 620);
            tabControl.TabIndex = 12;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            tabControl.TabIndexChanged += TimerClearMemo_Tick;
            // 
            // tabPageDashBoard
            // 
            tabPageDashBoard.Controls.Add(dashBoardControl1);
            tabPageDashBoard.Font = new Font("Segoe UI", 9F);
            tabPageDashBoard.Location = new Point(4, 27);
            tabPageDashBoard.Name = "tabPageDashBoard";
            tabPageDashBoard.Padding = new Padding(3);
            tabPageDashBoard.Size = new Size(1156, 589);
            tabPageDashBoard.TabIndex = 9;
            tabPageDashBoard.Text = "Dashboard";
            tabPageDashBoard.UseVisualStyleBackColor = true;
            // 
            // dashBoardControl1
            // 
            dashBoardControl1.Dock = DockStyle.Fill;
            dashBoardControl1.Location = new Point(3, 3);
            dashBoardControl1.Name = "dashBoardControl1";
            dashBoardControl1.Size = new Size(1150, 583);
            dashBoardControl1.TabIndex = 0;
            // 
            // tabPageSignals
            // 
            tabPageSignals.Controls.Add(dataGridViewSignals);
            tabPageSignals.Location = new Point(4, 27);
            tabPageSignals.Margin = new Padding(4, 3, 4, 3);
            tabPageSignals.Name = "tabPageSignals";
            tabPageSignals.Padding = new Padding(4, 3, 4, 3);
            tabPageSignals.Size = new Size(1170, 589);
            tabPageSignals.TabIndex = 4;
            tabPageSignals.Text = "Signals";
            tabPageSignals.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSignals
            // 
            dataGridViewSignals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSignals.Dock = DockStyle.Fill;
            dataGridViewSignals.Location = new Point(4, 3);
            dataGridViewSignals.Name = "dataGridViewSignals";
            dataGridViewSignals.Size = new Size(1162, 583);
            dataGridViewSignals.TabIndex = 1;
            // 
            // tabPageBrowser
            // 
            tabPageBrowser.Controls.Add(webViewTradingView);
            tabPageBrowser.Location = new Point(4, 27);
            tabPageBrowser.Margin = new Padding(4, 3, 4, 3);
            tabPageBrowser.Name = "tabPageBrowser";
            tabPageBrowser.Padding = new Padding(4, 3, 4, 3);
            tabPageBrowser.Size = new Size(1170, 589);
            tabPageBrowser.TabIndex = 5;
            tabPageBrowser.Text = "Tradingview";
            tabPageBrowser.UseVisualStyleBackColor = true;
            // 
            // webViewTradingView
            // 
            webViewTradingView.AllowExternalDrop = true;
            webViewTradingView.CreationProperties = null;
            webViewTradingView.DefaultBackgroundColor = Color.White;
            webViewTradingView.Dock = DockStyle.Fill;
            webViewTradingView.Location = new Point(4, 3);
            webViewTradingView.Margin = new Padding(4, 3, 4, 3);
            webViewTradingView.Name = "webViewTradingView";
            webViewTradingView.Size = new Size(1162, 583);
            webViewTradingView.TabIndex = 0;
            webViewTradingView.ZoomFactor = 1D;
            // 
            // tabPagePositionsOpen
            // 
            tabPagePositionsOpen.Controls.Add(dataGridViewPositionOpen);
            tabPagePositionsOpen.Location = new Point(4, 27);
            tabPagePositionsOpen.Name = "tabPagePositionsOpen";
            tabPagePositionsOpen.Padding = new Padding(3);
            tabPagePositionsOpen.Size = new Size(1170, 589);
            tabPagePositionsOpen.TabIndex = 7;
            tabPagePositionsOpen.Text = "Open positions";
            tabPagePositionsOpen.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPositionOpen
            // 
            dataGridViewPositionOpen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPositionOpen.Dock = DockStyle.Fill;
            dataGridViewPositionOpen.Location = new Point(3, 3);
            dataGridViewPositionOpen.Name = "dataGridViewPositionOpen";
            dataGridViewPositionOpen.Size = new Size(1164, 583);
            dataGridViewPositionOpen.TabIndex = 1;
            // 
            // tabPagePositionsClosed
            // 
            tabPagePositionsClosed.Controls.Add(dataGridViewPositionClosed);
            tabPagePositionsClosed.Location = new Point(4, 27);
            tabPagePositionsClosed.Name = "tabPagePositionsClosed";
            tabPagePositionsClosed.Padding = new Padding(3);
            tabPagePositionsClosed.Size = new Size(1170, 589);
            tabPagePositionsClosed.TabIndex = 8;
            tabPagePositionsClosed.Text = "Closed positions";
            tabPagePositionsClosed.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPositionClosed
            // 
            dataGridViewPositionClosed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPositionClosed.Dock = DockStyle.Fill;
            dataGridViewPositionClosed.Location = new Point(3, 3);
            dataGridViewPositionClosed.Name = "dataGridViewPositionClosed";
            dataGridViewPositionClosed.Size = new Size(1164, 583);
            dataGridViewPositionClosed.TabIndex = 1;
            // 
            // tabPageLog
            // 
            tabPageLog.Controls.Add(TextBoxLog);
            tabPageLog.Location = new Point(4, 27);
            tabPageLog.Margin = new Padding(2);
            tabPageLog.Name = "tabPageLog";
            tabPageLog.Padding = new Padding(2);
            tabPageLog.Size = new Size(1170, 589);
            tabPageLog.TabIndex = 1;
            tabPageLog.Text = "Log";
            tabPageLog.UseVisualStyleBackColor = true;
            // 
            // TextBoxLog
            // 
            TextBoxLog.BorderStyle = BorderStyle.None;
            TextBoxLog.Dock = DockStyle.Fill;
            TextBoxLog.Location = new Point(2, 2);
            TextBoxLog.Margin = new Padding(2);
            TextBoxLog.Multiline = true;
            TextBoxLog.Name = "TextBoxLog";
            TextBoxLog.ScrollBars = ScrollBars.Both;
            TextBoxLog.Size = new Size(1166, 585);
            TextBoxLog.TabIndex = 1;
            // 
            // tabPagewebViewDummy
            // 
            tabPagewebViewDummy.Controls.Add(webViewDummy);
            tabPagewebViewDummy.Location = new Point(4, 27);
            tabPagewebViewDummy.Margin = new Padding(4, 3, 4, 3);
            tabPagewebViewDummy.Name = "tabPagewebViewDummy";
            tabPagewebViewDummy.Padding = new Padding(4, 3, 4, 3);
            tabPagewebViewDummy.Size = new Size(1170, 589);
            tabPagewebViewDummy.TabIndex = 6;
            tabPagewebViewDummy.Text = "WebView (dummy)";
            tabPagewebViewDummy.UseVisualStyleBackColor = true;
            // 
            // webViewDummy
            // 
            webViewDummy.AllowExternalDrop = true;
            webViewDummy.CreationProperties = null;
            webViewDummy.DefaultBackgroundColor = Color.White;
            webViewDummy.Dock = DockStyle.Fill;
            webViewDummy.Location = new Point(4, 3);
            webViewDummy.Margin = new Padding(4, 3, 4, 3);
            webViewDummy.Name = "webViewDummy";
            webViewDummy.Size = new Size(1162, 583);
            webViewDummy.TabIndex = 1;
            webViewDummy.ZoomFactor = 1D;
            // 
            // panelClient1
            // 
            panelClient1.Controls.Add(panelClient);
            panelClient1.Controls.Add(dashBoardInformation1);
            panelClient1.Dock = DockStyle.Fill;
            panelClient1.Location = new Point(236, 24);
            panelClient1.Margin = new Padding(2);
            panelClient1.Name = "panelClient1";
            panelClient1.Size = new Size(1164, 723);
            panelClient1.TabIndex = 12;
            // 
            // dashBoardInformation1
            // 
            dashBoardInformation1.Dock = DockStyle.Top;
            dashBoardInformation1.Location = new Point(0, 0);
            dashBoardInformation1.Name = "dashBoardInformation1";
            dashBoardInformation1.Size = new Size(1164, 103);
            dashBoardInformation1.TabIndex = 15;
            // 
            // MenuMain
            // 
            MenuMain.DropDownItems.AddRange(new ToolStripItem[] { ApplicationPlaySounds, ApplicationCreateSignals, ApplicationTradingBot, ToolStripMenuItemSettings, ToolStripMenuItemRefresh, clearMenusToolStripMenuItem, backtestToolStripMenuItem, positionInfoToolStripMenuItem });
            MenuMain.Name = "MenuMain";
            MenuMain.Size = new Size(50, 20);
            MenuMain.Text = "Menu";
            // 
            // ApplicationPlaySounds
            // 
            ApplicationPlaySounds.Checked = true;
            ApplicationPlaySounds.CheckState = CheckState.Checked;
            ApplicationPlaySounds.Name = "ApplicationPlaySounds";
            ApplicationPlaySounds.Size = new Size(168, 22);
            ApplicationPlaySounds.Text = "Geluiden afspelen";
            ApplicationPlaySounds.Click += ApplicationPlaySounds_Click;
            // 
            // ApplicationCreateSignals
            // 
            ApplicationCreateSignals.Checked = true;
            ApplicationCreateSignals.CheckState = CheckState.Checked;
            ApplicationCreateSignals.Name = "ApplicationCreateSignals";
            ApplicationCreateSignals.Size = new Size(168, 22);
            ApplicationCreateSignals.Text = "Signalen maken";
            ApplicationCreateSignals.Click += ApplicationCreateSignals_Click;
            // 
            // ApplicationTradingBot
            // 
            ApplicationTradingBot.Name = "ApplicationTradingBot";
            ApplicationTradingBot.Size = new Size(168, 22);
            ApplicationTradingBot.Text = "Trading bot actief";
            ApplicationTradingBot.Click += ApplicationTradingBot_Click;
            // 
            // ToolStripMenuItemSettings
            // 
            ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            ToolStripMenuItemSettings.Size = new Size(168, 22);
            ToolStripMenuItemSettings.Text = "Instellingen";
            ToolStripMenuItemSettings.Click += ToolStripMenuItemSettings_Click;
            // 
            // ToolStripMenuItemRefresh
            // 
            ToolStripMenuItemRefresh.Name = "ToolStripMenuItemRefresh";
            ToolStripMenuItemRefresh.Size = new Size(168, 22);
            ToolStripMenuItemRefresh.Text = "Verversen";
            ToolStripMenuItemRefresh.Click += ToolStripMenuItemRefresh_Click_1;
            // 
            // clearMenusToolStripMenuItem
            // 
            clearMenusToolStripMenuItem.Name = "clearMenusToolStripMenuItem";
            clearMenusToolStripMenuItem.Size = new Size(168, 22);
            clearMenusToolStripMenuItem.Text = "Clear";
            clearMenusToolStripMenuItem.Click += MainMenuClearAll_Click;
            // 
            // backtestToolStripMenuItem
            // 
            backtestToolStripMenuItem.Name = "backtestToolStripMenuItem";
            backtestToolStripMenuItem.Size = new Size(168, 22);
            backtestToolStripMenuItem.Text = "Backtest";
            // 
            // positionInfoToolStripMenuItem
            // 
            positionInfoToolStripMenuItem.Name = "positionInfoToolStripMenuItem";
            positionInfoToolStripMenuItem.Size = new Size(168, 22);
            positionInfoToolStripMenuItem.Text = "PositionInfo";
            positionInfoToolStripMenuItem.Click += PositionInfoToolStripMenuItem_Click;
            // 
            // applicationMenuStrip
            // 
            applicationMenuStrip.ImageScalingSize = new Size(20, 20);
            applicationMenuStrip.Items.AddRange(new ToolStripItem[] { MenuMain });
            applicationMenuStrip.Location = new Point(0, 0);
            applicationMenuStrip.Name = "applicationMenuStrip";
            applicationMenuStrip.Padding = new Padding(5, 2, 0, 2);
            applicationMenuStrip.RenderMode = ToolStripRenderMode.Professional;
            applicationMenuStrip.Size = new Size(1400, 24);
            applicationMenuStrip.TabIndex = 16;
            applicationMenuStrip.Text = "menuStrip1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 747);
            Controls.Add(panelClient1);
            Controls.Add(panelLeft);
            Controls.Add(applicationMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FrmMain";
            FormClosing += FrmMain_FormClosing;
            panelLeft.ResumeLayout(false);
            tabControlSymbols.ResumeLayout(false);
            tabPageSymbols.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSymbols).EndInit();
            panelLeftTop.ResumeLayout(false);
            panelLeftTop.PerformLayout();
            panelClient.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPageDashBoard.ResumeLayout(false);
            tabPageSignals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSignals).EndInit();
            tabPageBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webViewTradingView).EndInit();
            tabPagePositionsOpen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositionOpen).EndInit();
            tabPagePositionsClosed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositionClosed).EndInit();
            tabPageLog.ResumeLayout(false);
            tabPageLog.PerformLayout();
            tabPagewebViewDummy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webViewDummy).EndInit();
            panelClient1.ResumeLayout(false);
            applicationMenuStrip.ResumeLayout(false);
            applicationMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelLeft;
        private Panel panelClient;
        private Panel panelLeftTop;
        private Panel panelClient1;
        private TextBox symbolFilter;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabPageSignals;
        private TabPage tabPageBrowser;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewTradingView;
        private TabPage tabPageLog;
        private TextBox TextBoxLog;
        private TabPage tabPagewebViewDummy;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDummy;
        private TabPage tabPagePositionsOpen;
        private TabPage tabPagePositionsClosed;
        private TabPage tabPageDashBoard;
        private DashBoardControl dashBoardControl1;
        private TradingView.DashBoardInformation dashBoardInformation1;
        private TabControl tabControlSymbols;
        private TabPage tabPageSymbols;
        private ToolStripMenuItem MenuMain;
        private ToolStripMenuItem ApplicationPlaySounds;
        private ToolStripMenuItem ApplicationCreateSignals;
        private ToolStripMenuItem ApplicationTradingBot;
        private ToolStripMenuItem ToolStripMenuItemSettings;
        private ToolStripMenuItem ToolStripMenuItemRefresh;
        private ToolStripMenuItem clearMenusToolStripMenuItem;
        private ToolStripMenuItem backtestToolStripMenuItem;
        private ToolStripMenuItem positionInfoToolStripMenuItem;
        private MenuStrip applicationMenuStrip;
        private DataGridView dataGridViewSymbols;
        private DataGridView dataGridViewSignals;
        private DataGridView dataGridViewPositionOpen;
        private DataGridView dataGridViewPositionClosed;
    }
}
