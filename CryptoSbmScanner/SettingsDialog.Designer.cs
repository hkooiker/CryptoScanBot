﻿namespace CryptoSbmScanner;

partial class FrmSettings
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
        panel2 = new Panel();
        buttonReset = new Button();
        buttonTestSpeech = new Button();
        buttonCancel = new Button();
        buttonOk = new Button();
        panel1 = new Panel();
        tabControl = new TabControl();
        tabAlgemeen = new TabPage();
        EditSendSignalsToTelegram = new CheckBox();
        ButtonTestTelegram = new Button();
        label24 = new Label();
        EditTelegramChatId = new TextBox();
        label15 = new Label();
        EditTelegramToken = new TextBox();
        EditShowFluxIndicator5m = new CheckBox();
        label16 = new Label();
        EditGetCandleInterval = new NumericUpDown();
        label40 = new Label();
        EditTrendCalculationMethod = new ComboBox();
        EditHideTechnicalStuffSignals = new CheckBox();
        label6 = new Label();
        EditGlobalDataRemoveSignalAfterxCandles = new NumericUpDown();
        EditBlackTheming = new CheckBox();
        buttonFontDialog = new Button();
        label18 = new Label();
        EditSoundHeartBeatMinutes = new NumericUpDown();
        label23 = new Label();
        EditDoubleClickAction = new ComboBox();
        label2 = new Label();
        EditTradingApp = new ComboBox();
        tabBasismunten = new TabPage();
        label19 = new Label();
        tabPageSignals = new TabPage();
        label64 = new Label();
        EditAnalysisMinEffectivePercentage = new NumericUpDown();
        EditAnalysisMaxEffectivePercentage = new NumericUpDown();
        EditLogAnalysisMinMaxEffectivePercentage = new CheckBox();
        label79 = new Label();
        label48 = new Label();
        label38 = new Label();
        label37 = new Label();
        label10 = new Label();
        EditCandlesWithFlatPriceCheck = new CheckBox();
        EditCandlesWithZeroVolumeCheck = new CheckBox();
        EditMinimumAboveBollingerBandsSmaCheck = new CheckBox();
        EditMinimumAboveBollingerBandsUpperCheck = new CheckBox();
        EditCandlesWithZeroVolume = new NumericUpDown();
        EditCandlesWithFlatPrice = new NumericUpDown();
        EditMinimumAboveBollingerBandsUpper = new NumericUpDown();
        EditMinimumAboveBollingerBandsSma = new NumericUpDown();
        EditShowInvalidSignals = new CheckBox();
        label26 = new Label();
        EditLogMinimumTickPercentage = new CheckBox();
        EditMinimumTickPercentage = new NumericUpDown();
        label61 = new Label();
        label53 = new Label();
        EditAnalysisMinChangePercentage = new NumericUpDown();
        EditAnalysisMaxChangePercentage = new NumericUpDown();
        EditLogBarometerToLow = new CheckBox();
        EditLogSymbolMustExistsDays = new CheckBox();
        EditSymbolMustExistsDays = new NumericUpDown();
        label25 = new Label();
        label35 = new Label();
        EditBarometer1hMinimal = new NumericUpDown();
        EditLogAnalysisMinMaxChangePercentage = new CheckBox();
        groupBoxInterval = new GroupBox();
        EditAnalyzeInterval6h = new CheckBox();
        EditAnalyzeInterval8h = new CheckBox();
        EditAnalyzeInterval12h = new CheckBox();
        EditAnalyzeInterval1d = new CheckBox();
        EditAnalyzeInterval5m = new CheckBox();
        EditAnalyzeInterval1m = new CheckBox();
        EditAnalyzeInterval2m = new CheckBox();
        EditAnalyzeInterval3m = new CheckBox();
        EditAnalyzeInterval10m = new CheckBox();
        EditAnalyzeInterval15m = new CheckBox();
        EditAnalyzeInterval30m = new CheckBox();
        EditAnalyzeInterval1h = new CheckBox();
        EditAnalyzeInterval2h = new CheckBox();
        EditAnalyzeInterval4h = new CheckBox();
        tabSignalStobb = new TabPage();
        label77 = new Label();
        label75 = new Label();
        EditStobIncludeSbmPercAndCrossing = new CheckBox();
        label30 = new Label();
        label28 = new Label();
        buttonColorStobb = new Button();
        EditStobIncludeSbmMaLines = new CheckBox();
        EditStobIncludeRsi = new CheckBox();
        buttonPlaySoundStobbOversold = new Button();
        buttonPlaySoundStobbOverbought = new Button();
        buttonSelectSoundStobbOversold = new Button();
        panelColorStobb = new Panel();
        EditSoundStobbOversold = new TextBox();
        EditSoundStobbOverbought = new TextBox();
        buttonSelectSoundStobbOverbought = new Button();
        EditPlaySpeechStobbSignal = new CheckBox();
        EditPlaySoundStobbSignal = new CheckBox();
        EditAnalyzeStobbOversold = new CheckBox();
        EditAnalyzeStobbOverbought = new CheckBox();
        EditStobbUseLowHigh = new CheckBox();
        label1 = new Label();
        EditStobbBBMinPercentage = new NumericUpDown();
        EditStobbBBMaxPercentage = new NumericUpDown();
        tabSignalSbm = new TabPage();
        EditSbm2UseLowHigh = new CheckBox();
        label21 = new Label();
        label20 = new Label();
        label9 = new Label();
        label41 = new Label();
        EditSbm1CandlesLookbackCount = new NumericUpDown();
        label39 = new Label();
        EditSbmCandlesForMacdRecovery = new NumericUpDown();
        label31 = new Label();
        label32 = new Label();
        buttonPlaySoundSbmOversold = new Button();
        buttonPlaySoundSbmOverbought = new Button();
        buttonSelectSoundSbmOversold = new Button();
        EditSoundFileSbmOversold = new TextBox();
        buttonSelectSoundSbmOverbought = new Button();
        EditSoundFileSbmOverbought = new TextBox();
        EditPlaySpeechSbmSignal = new CheckBox();
        EditAnalyzeSbmOversold = new CheckBox();
        EditAnalyzeSbmOverbought = new CheckBox();
        EditPlaySoundSbmSignal = new CheckBox();
        buttonColorSbm = new Button();
        EditSbmUseLowHigh = new CheckBox();
        label17 = new Label();
        EditSbmBBMinPercentage = new NumericUpDown();
        EditSbmBBMaxPercentage = new NumericUpDown();
        label22 = new Label();
        label4 = new Label();
        EditSbmMa200AndMa20Percentage = new NumericUpDown();
        label8 = new Label();
        EditSbmMa50AndMa20Percentage = new NumericUpDown();
        label7 = new Label();
        EditSbmMa200AndMa50Percentage = new NumericUpDown();
        EditSbmMa50AndMa20Lookback = new NumericUpDown();
        EditSbmMa50AndMa20Crossing = new CheckBox();
        EditSbmMa200AndMa50Lookback = new NumericUpDown();
        EditSbmMa200AndMa50Crossing = new CheckBox();
        EditSbmMa200AndMa20Lookback = new NumericUpDown();
        EditSbmMa200AndMa20Crossing = new CheckBox();
        EditAnalyzeSbm3Overbought = new CheckBox();
        EditAnalyzeSbm2Overbought = new CheckBox();
        label12 = new Label();
        EditSbm2BbPercentage = new NumericUpDown();
        panelColorSbm = new Panel();
        label13 = new Label();
        EditSbm3CandlesForBBRecovery = new NumericUpDown();
        label14 = new Label();
        EditSbm3CandlesForBBRecoveryPercentage = new NumericUpDown();
        label11 = new Label();
        EditSbm2CandlesLookbackCount = new NumericUpDown();
        EditAnalyzeSbm3Oversold = new CheckBox();
        EditAnalyzeSbm2Oversold = new CheckBox();
        tabSignalJump = new TabPage();
        label78 = new Label();
        label76 = new Label();
        label33 = new Label();
        label34 = new Label();
        label5 = new Label();
        EditJumpCandlesLookbackCount = new NumericUpDown();
        EditJumpUseLowHighCalculation = new CheckBox();
        buttonColorJump = new Button();
        buttonPlaySoundCandleJumpDown = new Button();
        buttonPlaySoundCandleJumpUp = new Button();
        buttonSelectSoundCandleJumpDown = new Button();
        panelColorJump = new Panel();
        EditSoundFileCandleJumpDown = new TextBox();
        EditSoundFileCandleJumpUp = new TextBox();
        buttonSelectSoundCandleJumpUp = new Button();
        EditPlaySpeechCandleJumpSignal = new CheckBox();
        label3 = new Label();
        EditPlaySoundCandleJumpSignal = new CheckBox();
        EditAnalyzeCandleJumpUp = new CheckBox();
        EditAnalyzeCandleJumpDown = new CheckBox();
        EditAnalysisCandleJumpPercentage = new NumericUpDown();
        tabWhiteListOversold = new TabPage();
        textBoxWhiteListOversold = new TextBox();
        panel3 = new Panel();
        label55 = new Label();
        tabBlackListOversold = new TabPage();
        textBoxBlackListOversold = new TextBox();
        panel4 = new Panel();
        label51 = new Label();
        tabWhiteListOverbought = new TabPage();
        textBoxWhiteListOverbought = new TextBox();
        panel5 = new Panel();
        label29 = new Label();
        tabBlacklistOverbought = new TabPage();
        textBoxBlackListOverbought = new TextBox();
        panel6 = new Panel();
        label49 = new Label();
        tabExtra = new TabPage();
        EditLockProfits = new CheckBox();
        EditTradeViaBinance = new CheckBox();
        label63 = new Label();
        EditSellMethod = new ComboBox();
        EditDoNotEnterTrade = new CheckBox();
        EditTradeViaPaperTrading = new CheckBox();
        label60 = new Label();
        EditDcaMethod = new ComboBox();
        label36 = new Label();
        label81 = new Label();
        label57 = new Label();
        label54 = new Label();
        label80 = new Label();
        groupBoxSlots = new GroupBox();
        label50 = new Label();
        EditSlotsMaximalExchange = new NumericUpDown();
        label52 = new Label();
        EditSlotsMaximalSymbol = new NumericUpDown();
        label56 = new Label();
        EditSlotsMaximalBase = new NumericUpDown();
        label58 = new Label();
        label59 = new Label();
        groupBox2 = new GroupBox();
        EditBarometer15mBotMinimal = new NumericUpDown();
        label27 = new Label();
        EditBarometer24hBotMinimal = new NumericUpDown();
        label42 = new Label();
        EditBarometer04hBotMinimal = new NumericUpDown();
        label43 = new Label();
        EditBarometer01hBotMinimal = new NumericUpDown();
        label44 = new Label();
        label45 = new Label();
        EditBarometer30mBotMinimal = new NumericUpDown();
        groupBox1 = new GroupBox();
        EditMonitorInterval1h = new CheckBox();
        EditMonitorInterval2h = new CheckBox();
        EditMonitorInterval4h = new CheckBox();
        EditMonitorInterval1m = new CheckBox();
        EditMonitorInterval2m = new CheckBox();
        EditMonitorInterval3m = new CheckBox();
        EditMonitorInterval5m = new CheckBox();
        EditMonitorInterval10m = new CheckBox();
        EditMonitorInterval15m = new CheckBox();
        EditMonitorInterval30m = new CheckBox();
        EditMonitorJump = new CheckBox();
        EditMonitorBullishEngulfing = new CheckBox();
        EditAnalyzeBullishEngulfing = new CheckBox();
        EditAnalyzeFluxOversold = new CheckBox();
        EditMonitorFluxOversold = new CheckBox();
        EditAnalyzeSbm4Oversold = new CheckBox();
        EditMonitorSbm4 = new CheckBox();
        EditBotSlopeEma20TurningPositive = new CheckBox();
        EditBotSlopeSma20TurningPositive = new CheckBox();
        EditAnalyzeSlopeEma20TurningPositive = new CheckBox();
        EditAnalyzeSlopeSma20TurningPositive = new CheckBox();
        EditBotSlopeEma50TurningPositive = new CheckBox();
        EditBotSlopeSma50TurningPositive = new CheckBox();
        EditBotPriceCrossingEma50 = new CheckBox();
        EditBotPriceCrossingSma50 = new CheckBox();
        EditBotPriceCrossingEma20 = new CheckBox();
        EditBotPriceCrossingSma20 = new CheckBox();
        label74 = new Label();
        label62 = new Label();
        EditBuyMethod = new ComboBox();
        EditDcaCount = new NumericUpDown();
        label67 = new Label();
        label68 = new Label();
        EditDcaFactor = new NumericUpDown();
        label69 = new Label();
        EditDcaPercentage = new NumericUpDown();
        EditGlobalStopLimitPercentage = new NumericUpDown();
        label70 = new Label();
        EditGlobalStopPercentage = new NumericUpDown();
        label71 = new Label();
        label72 = new Label();
        EditProfitPercentage = new NumericUpDown();
        label73 = new Label();
        EditGlobalBuyCooldownTime = new NumericUpDown();
        EditGlobalBuyVarying = new NumericUpDown();
        label47 = new Label();
        label46 = new Label();
        EditGlobalBuyRemoveTime = new NumericUpDown();
        EditAnalyzeSlopeEma50TurningPositive = new CheckBox();
        EditMonitorStobb = new CheckBox();
        EditMonitorSbm1 = new CheckBox();
        EditMonitorSbm2 = new CheckBox();
        EditMonitorSbm3 = new CheckBox();
        EditAnalyzeSlopeSma50TurningPositive = new CheckBox();
        EditTradeViaAltradyWebhook = new CheckBox();
        EditAnalyzePriceCrossedEma50 = new CheckBox();
        EditAnalyzePriceCrossedSma50 = new CheckBox();
        EditAnalyzePriceCrossedEma20 = new CheckBox();
        EditAnalyzePriceCrossedSma20 = new CheckBox();
        tabExtra2 = new TabPage();
        textBox1 = new TextBox();
        toolTip1 = new ToolTip(components);
        imageList1 = new ImageList(components);
        colorDialog1 = new ColorDialog();
        EditDynamicTp = new CheckBox();
        label65 = new Label();
        EditDynamicTpPercentage = new NumericUpDown();
        panel2.SuspendLayout();
        panel1.SuspendLayout();
        tabControl.SuspendLayout();
        tabAlgemeen.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EditGetCandleInterval).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditGlobalDataRemoveSignalAfterxCandles).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSoundHeartBeatMinutes).BeginInit();
        tabBasismunten.SuspendLayout();
        tabPageSignals.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EditAnalysisMinEffectivePercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditAnalysisMaxEffectivePercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditCandlesWithZeroVolume).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditCandlesWithFlatPrice).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditMinimumAboveBollingerBandsUpper).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditMinimumAboveBollingerBandsSma).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditMinimumTickPercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditAnalysisMinChangePercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditAnalysisMaxChangePercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSymbolMustExistsDays).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditBarometer1hMinimal).BeginInit();
        groupBoxInterval.SuspendLayout();
        tabSignalStobb.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EditStobbBBMinPercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditStobbBBMaxPercentage).BeginInit();
        tabSignalSbm.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EditSbm1CandlesLookbackCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmCandlesForMacdRecovery).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmBBMinPercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmBBMaxPercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmMa200AndMa20Percentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmMa50AndMa20Percentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmMa200AndMa50Percentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmMa50AndMa20Lookback).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmMa200AndMa50Lookback).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmMa200AndMa20Lookback).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbm2BbPercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbm3CandlesForBBRecovery).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbm3CandlesForBBRecoveryPercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSbm2CandlesLookbackCount).BeginInit();
        tabSignalJump.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EditJumpCandlesLookbackCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditAnalysisCandleJumpPercentage).BeginInit();
        tabWhiteListOversold.SuspendLayout();
        panel3.SuspendLayout();
        tabBlackListOversold.SuspendLayout();
        panel4.SuspendLayout();
        tabWhiteListOverbought.SuspendLayout();
        panel5.SuspendLayout();
        tabBlacklistOverbought.SuspendLayout();
        panel6.SuspendLayout();
        tabExtra.SuspendLayout();
        groupBoxSlots.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EditSlotsMaximalExchange).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSlotsMaximalSymbol).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditSlotsMaximalBase).BeginInit();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EditBarometer15mBotMinimal).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditBarometer24hBotMinimal).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditBarometer04hBotMinimal).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditBarometer01hBotMinimal).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditBarometer30mBotMinimal).BeginInit();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EditDcaCount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditDcaFactor).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditDcaPercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditGlobalStopLimitPercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditGlobalStopPercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditProfitPercentage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditGlobalBuyCooldownTime).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditGlobalBuyVarying).BeginInit();
        ((System.ComponentModel.ISupportInitialize)EditGlobalBuyRemoveTime).BeginInit();
        tabExtra2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)EditDynamicTpPercentage).BeginInit();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.Controls.Add(buttonReset);
        panel2.Controls.Add(buttonTestSpeech);
        panel2.Controls.Add(buttonCancel);
        panel2.Controls.Add(buttonOk);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0, 762);
        panel2.Margin = new Padding(4, 3, 4, 3);
        panel2.Name = "panel2";
        panel2.Size = new Size(1240, 46);
        panel2.TabIndex = 1;
        // 
        // buttonReset
        // 
        buttonReset.Location = new Point(27, 10);
        buttonReset.Margin = new Padding(4, 3, 4, 3);
        buttonReset.Name = "buttonReset";
        buttonReset.Size = new Size(88, 27);
        buttonReset.TabIndex = 11;
        buttonReset.Text = "Reset";
        buttonReset.UseVisualStyleBackColor = true;
        // 
        // buttonTestSpeech
        // 
        buttonTestSpeech.Location = new Point(132, 10);
        buttonTestSpeech.Margin = new Padding(4, 3, 4, 3);
        buttonTestSpeech.Name = "buttonTestSpeech";
        buttonTestSpeech.Size = new Size(88, 27);
        buttonTestSpeech.TabIndex = 10;
        buttonTestSpeech.Text = "Test speech";
        buttonTestSpeech.UseVisualStyleBackColor = true;
        // 
        // buttonCancel
        // 
        buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonCancel.Location = new Point(1140, 10);
        buttonCancel.Margin = new Padding(4, 3, 4, 3);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(88, 27);
        buttonCancel.TabIndex = 1;
        buttonCancel.Text = "&Cancel";
        buttonCancel.UseVisualStyleBackColor = true;
        buttonCancel.Click += ButtonCancel_Click;
        // 
        // buttonOk
        // 
        buttonOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        buttonOk.Location = new Point(1045, 10);
        buttonOk.Margin = new Padding(4, 3, 4, 3);
        buttonOk.Name = "buttonOk";
        buttonOk.Size = new Size(88, 27);
        buttonOk.TabIndex = 0;
        buttonOk.Text = "&Ok";
        buttonOk.UseVisualStyleBackColor = true;
        buttonOk.Click += ButtonOk_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(tabControl);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Margin = new Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(1240, 808);
        panel1.TabIndex = 0;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabAlgemeen);
        tabControl.Controls.Add(tabBasismunten);
        tabControl.Controls.Add(tabPageSignals);
        tabControl.Controls.Add(tabSignalStobb);
        tabControl.Controls.Add(tabSignalSbm);
        tabControl.Controls.Add(tabSignalJump);
        tabControl.Controls.Add(tabWhiteListOversold);
        tabControl.Controls.Add(tabBlackListOversold);
        tabControl.Controls.Add(tabWhiteListOverbought);
        tabControl.Controls.Add(tabBlacklistOverbought);
        tabControl.Controls.Add(tabExtra);
        tabControl.Controls.Add(tabExtra2);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Location = new Point(0, 0);
        tabControl.Margin = new Padding(4, 3, 4, 3);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(1240, 808);
        tabControl.TabIndex = 100;
        // 
        // tabAlgemeen
        // 
        tabAlgemeen.Controls.Add(EditSendSignalsToTelegram);
        tabAlgemeen.Controls.Add(ButtonTestTelegram);
        tabAlgemeen.Controls.Add(label24);
        tabAlgemeen.Controls.Add(EditTelegramChatId);
        tabAlgemeen.Controls.Add(label15);
        tabAlgemeen.Controls.Add(EditTelegramToken);
        tabAlgemeen.Controls.Add(EditShowFluxIndicator5m);
        tabAlgemeen.Controls.Add(label16);
        tabAlgemeen.Controls.Add(EditGetCandleInterval);
        tabAlgemeen.Controls.Add(label40);
        tabAlgemeen.Controls.Add(EditTrendCalculationMethod);
        tabAlgemeen.Controls.Add(EditHideTechnicalStuffSignals);
        tabAlgemeen.Controls.Add(label6);
        tabAlgemeen.Controls.Add(EditGlobalDataRemoveSignalAfterxCandles);
        tabAlgemeen.Controls.Add(EditBlackTheming);
        tabAlgemeen.Controls.Add(buttonFontDialog);
        tabAlgemeen.Controls.Add(label18);
        tabAlgemeen.Controls.Add(EditSoundHeartBeatMinutes);
        tabAlgemeen.Controls.Add(label23);
        tabAlgemeen.Controls.Add(EditDoubleClickAction);
        tabAlgemeen.Controls.Add(label2);
        tabAlgemeen.Controls.Add(EditTradingApp);
        tabAlgemeen.Location = new Point(4, 24);
        tabAlgemeen.Margin = new Padding(4, 3, 4, 3);
        tabAlgemeen.Name = "tabAlgemeen";
        tabAlgemeen.Padding = new Padding(4, 3, 4, 3);
        tabAlgemeen.Size = new Size(1232, 780);
        tabAlgemeen.TabIndex = 6;
        tabAlgemeen.Text = "Algemeen";
        tabAlgemeen.UseVisualStyleBackColor = true;
        // 
        // EditSendSignalsToTelegram
        // 
        EditSendSignalsToTelegram.AutoSize = true;
        EditSendSignalsToTelegram.Location = new Point(56, 463);
        EditSendSignalsToTelegram.Margin = new Padding(4, 3, 4, 3);
        EditSendSignalsToTelegram.Name = "EditSendSignalsToTelegram";
        EditSendSignalsToTelegram.Size = new Size(190, 19);
        EditSendSignalsToTelegram.TabIndex = 169;
        EditSendSignalsToTelegram.Text = "Stuur meldingen naar telegram";
        EditSendSignalsToTelegram.UseVisualStyleBackColor = true;
        // 
        // ButtonTestTelegram
        // 
        ButtonTestTelegram.Location = new Point(432, 407);
        ButtonTestTelegram.Name = "ButtonTestTelegram";
        ButtonTestTelegram.Size = new Size(75, 23);
        ButtonTestTelegram.TabIndex = 168;
        ButtonTestTelegram.Text = "Test";
        ButtonTestTelegram.UseVisualStyleBackColor = true;
        ButtonTestTelegram.Click += ButtonTestTelegram_Click;
        // 
        // label24
        // 
        label24.AutoSize = true;
        label24.Location = new Point(51, 436);
        label24.Margin = new Padding(4, 0, 4, 0);
        label24.Name = "label24";
        label24.Size = new Size(93, 15);
        label24.TabIndex = 167;
        label24.Text = "Telegram ChatId";
        // 
        // EditTelegramChatId
        // 
        EditTelegramChatId.Location = new Point(188, 433);
        EditTelegramChatId.Margin = new Padding(4, 3, 4, 3);
        EditTelegramChatId.Name = "EditTelegramChatId";
        EditTelegramChatId.Size = new Size(227, 23);
        EditTelegramChatId.TabIndex = 166;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(51, 407);
        label15.Margin = new Padding(4, 0, 4, 0);
        label15.Name = "label15";
        label15.Size = new Size(89, 15);
        label15.TabIndex = 165;
        label15.Text = "Telegram Token";
        // 
        // EditTelegramToken
        // 
        EditTelegramToken.Location = new Point(188, 404);
        EditTelegramToken.Margin = new Padding(4, 3, 4, 3);
        EditTelegramToken.Name = "EditTelegramToken";
        EditTelegramToken.Size = new Size(227, 23);
        EditTelegramToken.TabIndex = 164;
        // 
        // EditShowFluxIndicator5m
        // 
        EditShowFluxIndicator5m.AutoSize = true;
        EditShowFluxIndicator5m.Location = new Point(26, 241);
        EditShowFluxIndicator5m.Margin = new Padding(4, 3, 4, 3);
        EditShowFluxIndicator5m.Name = "EditShowFluxIndicator5m";
        EditShowFluxIndicator5m.Size = new Size(159, 19);
        EditShowFluxIndicator5m.TabIndex = 163;
        EditShowFluxIndicator5m.Text = "Toon de FLUX 5m waarde";
        EditShowFluxIndicator5m.UseVisualStyleBackColor = true;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(26, 189);
        label16.Margin = new Padding(4, 0, 4, 0);
        label16.Name = "label16";
        label16.Size = new Size(263, 15);
        label16.TabIndex = 161;
        label16.Text = "Iedere x minuten controleren op nieuwe munten";
        // 
        // EditGetCandleInterval
        // 
        EditGetCandleInterval.Location = new Point(323, 187);
        EditGetCandleInterval.Margin = new Padding(4, 3, 4, 3);
        EditGetCandleInterval.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
        EditGetCandleInterval.Name = "EditGetCandleInterval";
        EditGetCandleInterval.Size = new Size(57, 23);
        EditGetCandleInterval.TabIndex = 162;
        EditGetCandleInterval.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // label40
        // 
        label40.AutoSize = true;
        label40.Location = new Point(22, 105);
        label40.Margin = new Padding(4, 0, 4, 0);
        label40.Name = "label40";
        label40.Size = new Size(97, 15);
        label40.TabIndex = 160;
        label40.Text = "Trend calculation";
        // 
        // EditTrendCalculationMethod
        // 
        EditTrendCalculationMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        EditTrendCalculationMethod.FormattingEnabled = true;
        EditTrendCalculationMethod.Items.AddRange(new object[] { "cAlgo#1 zigzag + interpretatie", "cAlgo#2 zigzag + interpretatie", "EMA 8 > EMA 20 " });
        EditTrendCalculationMethod.Location = new Point(188, 102);
        EditTrendCalculationMethod.Margin = new Padding(4, 3, 4, 3);
        EditTrendCalculationMethod.Name = "EditTrendCalculationMethod";
        EditTrendCalculationMethod.Size = new Size(190, 23);
        EditTrendCalculationMethod.TabIndex = 159;
        // 
        // EditHideTechnicalStuffSignals
        // 
        EditHideTechnicalStuffSignals.AutoSize = true;
        EditHideTechnicalStuffSignals.Location = new Point(29, 216);
        EditHideTechnicalStuffSignals.Margin = new Padding(4, 3, 4, 3);
        EditHideTechnicalStuffSignals.Name = "EditHideTechnicalStuffSignals";
        EditHideTechnicalStuffSignals.Size = new Size(386, 19);
        EditHideTechnicalStuffSignals.TabIndex = 158;
        EditHideTechnicalStuffSignals.Text = "Verberg de technische informatie in het overzicht (de RSI, ma's, psar)";
        EditHideTechnicalStuffSignals.UseVisualStyleBackColor = true;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(26, 164);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(243, 15);
        label6.TabIndex = 156;
        label6.Text = "Verwijder signalen uit de display na x candles";
        // 
        // EditGlobalDataRemoveSignalAfterxCandles
        // 
        EditGlobalDataRemoveSignalAfterxCandles.Location = new Point(323, 161);
        EditGlobalDataRemoveSignalAfterxCandles.Margin = new Padding(4, 3, 4, 3);
        EditGlobalDataRemoveSignalAfterxCandles.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        EditGlobalDataRemoveSignalAfterxCandles.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
        EditGlobalDataRemoveSignalAfterxCandles.Name = "EditGlobalDataRemoveSignalAfterxCandles";
        EditGlobalDataRemoveSignalAfterxCandles.Size = new Size(57, 23);
        EditGlobalDataRemoveSignalAfterxCandles.TabIndex = 157;
        toolTip1.SetToolTip(EditGlobalDataRemoveSignalAfterxCandles, "Kunnen filteren op de 24 uur volume percentage.");
        EditGlobalDataRemoveSignalAfterxCandles.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // EditBlackTheming
        // 
        EditBlackTheming.AutoSize = true;
        EditBlackTheming.Location = new Point(31, 301);
        EditBlackTheming.Margin = new Padding(4, 3, 4, 3);
        EditBlackTheming.Name = "EditBlackTheming";
        EditBlackTheming.Size = new Size(84, 19);
        EditBlackTheming.TabIndex = 155;
        EditBlackTheming.Text = "Gray mode";
        EditBlackTheming.UseVisualStyleBackColor = true;
        // 
        // buttonFontDialog
        // 
        buttonFontDialog.Location = new Point(29, 268);
        buttonFontDialog.Margin = new Padding(4, 3, 4, 3);
        buttonFontDialog.Name = "buttonFontDialog";
        buttonFontDialog.Size = new Size(139, 27);
        buttonFontDialog.TabIndex = 154;
        buttonFontDialog.Text = "Lettertype";
        buttonFontDialog.UseVisualStyleBackColor = true;
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Location = new Point(26, 137);
        label18.Margin = new Padding(4, 0, 4, 0);
        label18.Name = "label18";
        label18.Size = new Size(257, 15);
        label18.TabIndex = 152;
        label18.Text = "Iedere x minuten een heart beat geluid afspelen";
        // 
        // EditSoundHeartBeatMinutes
        // 
        EditSoundHeartBeatMinutes.Location = new Point(323, 135);
        EditSoundHeartBeatMinutes.Margin = new Padding(4, 3, 4, 3);
        EditSoundHeartBeatMinutes.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        EditSoundHeartBeatMinutes.Name = "EditSoundHeartBeatMinutes";
        EditSoundHeartBeatMinutes.Size = new Size(57, 23);
        EditSoundHeartBeatMinutes.TabIndex = 153;
        EditSoundHeartBeatMinutes.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // label23
        // 
        label23.AutoSize = true;
        label23.Location = new Point(22, 74);
        label23.Margin = new Padding(4, 0, 4, 0);
        label23.Name = "label23";
        label23.Size = new Size(91, 15);
        label23.TabIndex = 151;
        label23.Text = "Dubbelklik actie";
        // 
        // EditDoubleClickAction
        // 
        EditDoubleClickAction.DropDownStyle = ComboBoxStyle.DropDownList;
        EditDoubleClickAction.FormattingEnabled = true;
        EditDoubleClickAction.Items.AddRange(new object[] { "Tradingapp", "Tradingapp + Tradingview intern", "Tradingview intern", "Tradingview extern" });
        EditDoubleClickAction.Location = new Point(188, 70);
        EditDoubleClickAction.Margin = new Padding(4, 3, 4, 3);
        EditDoubleClickAction.Name = "EditDoubleClickAction";
        EditDoubleClickAction.Size = new Size(190, 23);
        EditDoubleClickAction.TabIndex = 150;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(22, 43);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(69, 15);
        label2.TabIndex = 149;
        label2.Text = "Trading app";
        // 
        // EditTradingApp
        // 
        EditTradingApp.DropDownStyle = ComboBoxStyle.DropDownList;
        EditTradingApp.FormattingEnabled = true;
        EditTradingApp.Items.AddRange(new object[] { "Altrady", "Altrady web", "Hypertrader" });
        EditTradingApp.Location = new Point(188, 39);
        EditTradingApp.Margin = new Padding(4, 3, 4, 3);
        EditTradingApp.Name = "EditTradingApp";
        EditTradingApp.Size = new Size(190, 23);
        EditTradingApp.TabIndex = 148;
        // 
        // tabBasismunten
        // 
        tabBasismunten.Controls.Add(label19);
        tabBasismunten.Location = new Point(4, 24);
        tabBasismunten.Margin = new Padding(4, 3, 4, 3);
        tabBasismunten.Name = "tabBasismunten";
        tabBasismunten.Padding = new Padding(4, 3, 4, 3);
        tabBasismunten.Size = new Size(1232, 780);
        tabBasismunten.TabIndex = 0;
        tabBasismunten.Text = "Basismunten";
        tabBasismunten.UseVisualStyleBackColor = true;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Location = new Point(16, 12);
        label19.Margin = new Padding(4, 0, 4, 0);
        label19.Name = "label19";
        label19.Size = new Size(473, 15);
        label19.TabIndex = 146;
        label19.Text = "Attentie: Wijzigingen in de kolom \"Candles halen\"vereisen een herstart van de applicatie!";
        // 
        // tabPageSignals
        // 
        tabPageSignals.Controls.Add(label64);
        tabPageSignals.Controls.Add(EditAnalysisMinEffectivePercentage);
        tabPageSignals.Controls.Add(EditAnalysisMaxEffectivePercentage);
        tabPageSignals.Controls.Add(EditLogAnalysisMinMaxEffectivePercentage);
        tabPageSignals.Controls.Add(label79);
        tabPageSignals.Controls.Add(label48);
        tabPageSignals.Controls.Add(label38);
        tabPageSignals.Controls.Add(label37);
        tabPageSignals.Controls.Add(label10);
        tabPageSignals.Controls.Add(EditCandlesWithFlatPriceCheck);
        tabPageSignals.Controls.Add(EditCandlesWithZeroVolumeCheck);
        tabPageSignals.Controls.Add(EditMinimumAboveBollingerBandsSmaCheck);
        tabPageSignals.Controls.Add(EditMinimumAboveBollingerBandsUpperCheck);
        tabPageSignals.Controls.Add(EditCandlesWithZeroVolume);
        tabPageSignals.Controls.Add(EditCandlesWithFlatPrice);
        tabPageSignals.Controls.Add(EditMinimumAboveBollingerBandsUpper);
        tabPageSignals.Controls.Add(EditMinimumAboveBollingerBandsSma);
        tabPageSignals.Controls.Add(EditShowInvalidSignals);
        tabPageSignals.Controls.Add(label26);
        tabPageSignals.Controls.Add(EditLogMinimumTickPercentage);
        tabPageSignals.Controls.Add(EditMinimumTickPercentage);
        tabPageSignals.Controls.Add(label61);
        tabPageSignals.Controls.Add(label53);
        tabPageSignals.Controls.Add(EditAnalysisMinChangePercentage);
        tabPageSignals.Controls.Add(EditAnalysisMaxChangePercentage);
        tabPageSignals.Controls.Add(EditLogBarometerToLow);
        tabPageSignals.Controls.Add(EditLogSymbolMustExistsDays);
        tabPageSignals.Controls.Add(EditSymbolMustExistsDays);
        tabPageSignals.Controls.Add(label25);
        tabPageSignals.Controls.Add(label35);
        tabPageSignals.Controls.Add(EditBarometer1hMinimal);
        tabPageSignals.Controls.Add(EditLogAnalysisMinMaxChangePercentage);
        tabPageSignals.Controls.Add(groupBoxInterval);
        tabPageSignals.Location = new Point(4, 24);
        tabPageSignals.Margin = new Padding(4, 3, 4, 3);
        tabPageSignals.Name = "tabPageSignals";
        tabPageSignals.Padding = new Padding(4, 3, 4, 3);
        tabPageSignals.Size = new Size(1232, 780);
        tabPageSignals.TabIndex = 10;
        tabPageSignals.Text = "Signals";
        tabPageSignals.UseVisualStyleBackColor = true;
        // 
        // label64
        // 
        label64.AutoSize = true;
        label64.Location = new Point(287, 86);
        label64.Margin = new Padding(4, 0, 4, 0);
        label64.Name = "label64";
        label64.Size = new Size(86, 15);
        label64.TabIndex = 208;
        label64.Text = "24 uur effectief";
        // 
        // EditAnalysisMinEffectivePercentage
        // 
        EditAnalysisMinEffectivePercentage.Location = new Point(419, 84);
        EditAnalysisMinEffectivePercentage.Margin = new Padding(4, 3, 4, 3);
        EditAnalysisMinEffectivePercentage.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        EditAnalysisMinEffectivePercentage.Name = "EditAnalysisMinEffectivePercentage";
        EditAnalysisMinEffectivePercentage.Size = new Size(57, 23);
        EditAnalysisMinEffectivePercentage.TabIndex = 209;
        toolTip1.SetToolTip(EditAnalysisMinEffectivePercentage, "Kunnen filteren op de 24 uur volume percentage.");
        // 
        // EditAnalysisMaxEffectivePercentage
        // 
        EditAnalysisMaxEffectivePercentage.Location = new Point(483, 84);
        EditAnalysisMaxEffectivePercentage.Margin = new Padding(4, 3, 4, 3);
        EditAnalysisMaxEffectivePercentage.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        EditAnalysisMaxEffectivePercentage.Name = "EditAnalysisMaxEffectivePercentage";
        EditAnalysisMaxEffectivePercentage.Size = new Size(57, 23);
        EditAnalysisMaxEffectivePercentage.TabIndex = 210;
        toolTip1.SetToolTip(EditAnalysisMaxEffectivePercentage, "Kunnen filteren op de 24 uur volume percentage.");
        EditAnalysisMaxEffectivePercentage.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // EditLogAnalysisMinMaxEffectivePercentage
        // 
        EditLogAnalysisMinMaxEffectivePercentage.AutoSize = true;
        EditLogAnalysisMinMaxEffectivePercentage.Location = new Point(568, 85);
        EditLogAnalysisMinMaxEffectivePercentage.Margin = new Padding(4, 3, 4, 3);
        EditLogAnalysisMinMaxEffectivePercentage.Name = "EditLogAnalysisMinMaxEffectivePercentage";
        EditLogAnalysisMinMaxEffectivePercentage.Size = new Size(203, 19);
        EditLogAnalysisMinMaxEffectivePercentage.TabIndex = 211;
        EditLogAnalysisMinMaxEffectivePercentage.Text = "Log waarden buiten deze grenzen";
        EditLogAnalysisMinMaxEffectivePercentage.UseVisualStyleBackColor = true;
        // 
        // label79
        // 
        label79.AutoSize = true;
        label79.Location = new Point(723, 344);
        label79.Margin = new Padding(4, 0, 4, 0);
        label79.Name = "label79";
        label79.Size = new Size(176, 15);
        label79.TabIndex = 207;
        label79.Text = "Kleiner dan dit getal is een nogo";
        // 
        // label48
        // 
        label48.AutoSize = true;
        label48.Location = new Point(723, 312);
        label48.Margin = new Padding(4, 0, 4, 0);
        label48.Name = "label48";
        label48.Size = new Size(176, 15);
        label48.TabIndex = 206;
        label48.Text = "Kleiner dan dit getal is een nogo";
        // 
        // label38
        // 
        label38.AutoSize = true;
        label38.Location = new Point(723, 282);
        label38.Margin = new Padding(4, 0, 4, 0);
        label38.Name = "label38";
        label38.Size = new Size(173, 15);
        label38.TabIndex = 205;
        label38.Text = "Groter dan dit getal is een nogo";
        // 
        // label37
        // 
        label37.AutoSize = true;
        label37.Location = new Point(723, 255);
        label37.Margin = new Padding(4, 0, 4, 0);
        label37.Name = "label37";
        label37.Size = new Size(173, 15);
        label37.TabIndex = 204;
        label37.Text = "Groter dan dit getal is een nogo";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(283, 227);
        label10.Margin = new Padding(4, 0, 4, 0);
        label10.Name = "label10";
        label10.Size = new Size(186, 15);
        label10.TabIndex = 203;
        label10.Text = "Controles op de laatste 60 candles";
        // 
        // EditCandlesWithFlatPriceCheck
        // 
        EditCandlesWithFlatPriceCheck.AutoSize = true;
        EditCandlesWithFlatPriceCheck.Location = new Point(283, 257);
        EditCandlesWithFlatPriceCheck.Margin = new Padding(4, 3, 4, 3);
        EditCandlesWithFlatPriceCheck.Name = "EditCandlesWithFlatPriceCheck";
        EditCandlesWithFlatPriceCheck.Size = new Size(213, 19);
        EditCandlesWithFlatPriceCheck.TabIndex = 202;
        EditCandlesWithFlatPriceCheck.Text = "Controleer het aantal platte candles";
        EditCandlesWithFlatPriceCheck.UseVisualStyleBackColor = true;
        // 
        // EditCandlesWithZeroVolumeCheck
        // 
        EditCandlesWithZeroVolumeCheck.AutoSize = true;
        EditCandlesWithZeroVolumeCheck.Location = new Point(284, 286);
        EditCandlesWithZeroVolumeCheck.Margin = new Padding(4, 3, 4, 3);
        EditCandlesWithZeroVolumeCheck.Name = "EditCandlesWithZeroVolumeCheck";
        EditCandlesWithZeroVolumeCheck.Size = new Size(262, 19);
        EditCandlesWithZeroVolumeCheck.TabIndex = 201;
        EditCandlesWithZeroVolumeCheck.Text = "Controleer het aantal candles zonder volume";
        EditCandlesWithZeroVolumeCheck.UseVisualStyleBackColor = true;
        // 
        // EditMinimumAboveBollingerBandsSmaCheck
        // 
        EditMinimumAboveBollingerBandsSmaCheck.AutoSize = true;
        EditMinimumAboveBollingerBandsSmaCheck.Location = new Point(284, 316);
        EditMinimumAboveBollingerBandsSmaCheck.Margin = new Padding(4, 3, 4, 3);
        EditMinimumAboveBollingerBandsSmaCheck.Name = "EditMinimumAboveBollingerBandsSmaCheck";
        EditMinimumAboveBollingerBandsSmaCheck.Size = new Size(211, 19);
        EditMinimumAboveBollingerBandsSmaCheck.TabIndex = 200;
        EditMinimumAboveBollingerBandsSmaCheck.Text = "Controleer aantal boven de bb.sma";
        EditMinimumAboveBollingerBandsSmaCheck.UseVisualStyleBackColor = true;
        // 
        // EditMinimumAboveBollingerBandsUpperCheck
        // 
        EditMinimumAboveBollingerBandsUpperCheck.AutoSize = true;
        EditMinimumAboveBollingerBandsUpperCheck.Location = new Point(284, 346);
        EditMinimumAboveBollingerBandsUpperCheck.Margin = new Padding(4, 3, 4, 3);
        EditMinimumAboveBollingerBandsUpperCheck.Name = "EditMinimumAboveBollingerBandsUpperCheck";
        EditMinimumAboveBollingerBandsUpperCheck.Size = new Size(220, 19);
        EditMinimumAboveBollingerBandsUpperCheck.TabIndex = 199;
        EditMinimumAboveBollingerBandsUpperCheck.Text = "Controleer aantal boven de bb.upper";
        EditMinimumAboveBollingerBandsUpperCheck.UseVisualStyleBackColor = true;
        // 
        // EditCandlesWithZeroVolume
        // 
        EditCandlesWithZeroVolume.Location = new Point(614, 282);
        EditCandlesWithZeroVolume.Margin = new Padding(4, 3, 4, 3);
        EditCandlesWithZeroVolume.Name = "EditCandlesWithZeroVolume";
        EditCandlesWithZeroVolume.Size = new Size(88, 23);
        EditCandlesWithZeroVolume.TabIndex = 197;
        EditCandlesWithZeroVolume.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // EditCandlesWithFlatPrice
        // 
        EditCandlesWithFlatPrice.Location = new Point(614, 253);
        EditCandlesWithFlatPrice.Margin = new Padding(4, 3, 4, 3);
        EditCandlesWithFlatPrice.Name = "EditCandlesWithFlatPrice";
        EditCandlesWithFlatPrice.Size = new Size(88, 23);
        EditCandlesWithFlatPrice.TabIndex = 195;
        EditCandlesWithFlatPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // EditMinimumAboveBollingerBandsUpper
        // 
        EditMinimumAboveBollingerBandsUpper.Location = new Point(613, 342);
        EditMinimumAboveBollingerBandsUpper.Margin = new Padding(4, 3, 4, 3);
        EditMinimumAboveBollingerBandsUpper.Name = "EditMinimumAboveBollingerBandsUpper";
        EditMinimumAboveBollingerBandsUpper.Size = new Size(88, 23);
        EditMinimumAboveBollingerBandsUpper.TabIndex = 192;
        EditMinimumAboveBollingerBandsUpper.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // EditMinimumAboveBollingerBandsSma
        // 
        EditMinimumAboveBollingerBandsSma.Location = new Point(614, 312);
        EditMinimumAboveBollingerBandsSma.Margin = new Padding(4, 3, 4, 3);
        EditMinimumAboveBollingerBandsSma.Name = "EditMinimumAboveBollingerBandsSma";
        EditMinimumAboveBollingerBandsSma.Size = new Size(88, 23);
        EditMinimumAboveBollingerBandsSma.TabIndex = 189;
        EditMinimumAboveBollingerBandsSma.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // EditShowInvalidSignals
        // 
        EditShowInvalidSignals.AutoSize = true;
        EditShowInvalidSignals.Location = new Point(22, 346);
        EditShowInvalidSignals.Margin = new Padding(4, 3, 4, 3);
        EditShowInvalidSignals.Name = "EditShowInvalidSignals";
        EditShowInvalidSignals.Size = new Size(175, 19);
        EditShowInvalidSignals.TabIndex = 186;
        EditShowInvalidSignals.Text = "Laat ongeldige signalen zien";
        EditShowInvalidSignals.UseVisualStyleBackColor = true;
        // 
        // label26
        // 
        label26.AutoSize = true;
        label26.Location = new Point(19, 25);
        label26.Margin = new Padding(4, 0, 4, 0);
        label26.Name = "label26";
        label26.Size = new Size(206, 15);
        label26.TabIndex = 185;
        label26.Text = "Create signals for the intervals and .....";
        // 
        // EditLogMinimumTickPercentage
        // 
        EditLogMinimumTickPercentage.AutoSize = true;
        EditLogMinimumTickPercentage.Location = new Point(568, 173);
        EditLogMinimumTickPercentage.Margin = new Padding(4, 3, 4, 3);
        EditLogMinimumTickPercentage.Name = "EditLogMinimumTickPercentage";
        EditLogMinimumTickPercentage.Size = new Size(165, 19);
        EditLogMinimumTickPercentage.TabIndex = 180;
        EditLogMinimumTickPercentage.Text = "Log als dit niet het geval is";
        EditLogMinimumTickPercentage.UseVisualStyleBackColor = true;
        // 
        // EditMinimumTickPercentage
        // 
        EditMinimumTickPercentage.DecimalPlaces = 2;
        EditMinimumTickPercentage.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        EditMinimumTickPercentage.Location = new Point(455, 172);
        EditMinimumTickPercentage.Margin = new Padding(4, 3, 4, 3);
        EditMinimumTickPercentage.Name = "EditMinimumTickPercentage";
        EditMinimumTickPercentage.Size = new Size(75, 23);
        EditMinimumTickPercentage.TabIndex = 179;
        toolTip1.SetToolTip(EditMinimumTickPercentage, "Soms heb je van die munten die of een barcode streepjes patroon hebben of die per tick een enorme afstand overbruggen. Via deze instelling kun je die markeren in het overzicht");
        EditMinimumTickPercentage.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label61
        // 
        label61.AutoSize = true;
        label61.Location = new Point(284, 175);
        label61.Margin = new Padding(4, 0, 4, 0);
        label61.Name = "label61";
        label61.Size = new Size(90, 15);
        label61.TabIndex = 178;
        label61.Text = "Tick percentage";
        // 
        // label53
        // 
        label53.AutoSize = true;
        label53.Location = new Point(287, 61);
        label53.Margin = new Padding(4, 0, 4, 0);
        label53.Name = "label53";
        label53.Size = new Size(82, 15);
        label53.TabIndex = 181;
        label53.Text = "24 uur change";
        // 
        // EditAnalysisMinChangePercentage
        // 
        EditAnalysisMinChangePercentage.Location = new Point(419, 59);
        EditAnalysisMinChangePercentage.Margin = new Padding(4, 3, 4, 3);
        EditAnalysisMinChangePercentage.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        EditAnalysisMinChangePercentage.Name = "EditAnalysisMinChangePercentage";
        EditAnalysisMinChangePercentage.Size = new Size(57, 23);
        EditAnalysisMinChangePercentage.TabIndex = 182;
        toolTip1.SetToolTip(EditAnalysisMinChangePercentage, "Kunnen filteren op de 24 uur volume percentage.");
        // 
        // EditAnalysisMaxChangePercentage
        // 
        EditAnalysisMaxChangePercentage.Location = new Point(483, 59);
        EditAnalysisMaxChangePercentage.Margin = new Padding(4, 3, 4, 3);
        EditAnalysisMaxChangePercentage.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        EditAnalysisMaxChangePercentage.Name = "EditAnalysisMaxChangePercentage";
        EditAnalysisMaxChangePercentage.Size = new Size(57, 23);
        EditAnalysisMaxChangePercentage.TabIndex = 183;
        toolTip1.SetToolTip(EditAnalysisMaxChangePercentage, "Kunnen filteren op de 24 uur volume percentage.");
        EditAnalysisMaxChangePercentage.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // EditLogBarometerToLow
        // 
        EditLogBarometerToLow.AutoSize = true;
        EditLogBarometerToLow.Location = new Point(568, 118);
        EditLogBarometerToLow.Margin = new Padding(4, 3, 4, 3);
        EditLogBarometerToLow.Name = "EditLogBarometerToLow";
        EditLogBarometerToLow.Size = new Size(142, 19);
        EditLogBarometerToLow.TabIndex = 174;
        EditLogBarometerToLow.Text = "Log te lage barometer";
        EditLogBarometerToLow.UseVisualStyleBackColor = true;
        // 
        // EditLogSymbolMustExistsDays
        // 
        EditLogSymbolMustExistsDays.AutoSize = true;
        EditLogSymbolMustExistsDays.Location = new Point(568, 144);
        EditLogSymbolMustExistsDays.Margin = new Padding(4, 3, 4, 3);
        EditLogSymbolMustExistsDays.Name = "EditLogSymbolMustExistsDays";
        EditLogSymbolMustExistsDays.Size = new Size(208, 19);
        EditLogSymbolMustExistsDays.TabIndex = 177;
        EditLogSymbolMustExistsDays.Text = "Log minimale dagen nieuwe munt";
        EditLogSymbolMustExistsDays.UseVisualStyleBackColor = true;
        // 
        // EditSymbolMustExistsDays
        // 
        EditSymbolMustExistsDays.Location = new Point(454, 144);
        EditSymbolMustExistsDays.Margin = new Padding(4, 3, 4, 3);
        EditSymbolMustExistsDays.Name = "EditSymbolMustExistsDays";
        EditSymbolMustExistsDays.Size = new Size(75, 23);
        EditSymbolMustExistsDays.TabIndex = 176;
        toolTip1.SetToolTip(EditSymbolMustExistsDays, "Negeer munten die korten dan x dagen bestaan");
        EditSymbolMustExistsDays.Value = new decimal(new int[] { 15, 0, 0, 0 });
        // 
        // label25
        // 
        label25.AutoSize = true;
        label25.Location = new Point(284, 148);
        label25.Margin = new Padding(4, 0, 4, 0);
        label25.Name = "label25";
        label25.Size = new Size(115, 15);
        label25.TabIndex = 175;
        label25.Text = "Nieuwe munt dagen";
        // 
        // label35
        // 
        label35.AutoSize = true;
        label35.Location = new Point(284, 120);
        label35.Margin = new Padding(4, 0, 4, 0);
        label35.Name = "label35";
        label35.Size = new Size(115, 15);
        label35.TabIndex = 172;
        label35.Text = "Minimale barometer";
        // 
        // EditBarometer1hMinimal
        // 
        EditBarometer1hMinimal.DecimalPlaces = 2;
        EditBarometer1hMinimal.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
        EditBarometer1hMinimal.Location = new Point(455, 118);
        EditBarometer1hMinimal.Margin = new Padding(4, 3, 4, 3);
        EditBarometer1hMinimal.Name = "EditBarometer1hMinimal";
        EditBarometer1hMinimal.Size = new Size(74, 23);
        EditBarometer1hMinimal.TabIndex = 173;
        toolTip1.SetToolTip(EditBarometer1hMinimal, "Als de barometer laag staat krijg je enorm veel medlingen, negeer meldingen als de barometer onder dit getal staat");
        EditBarometer1hMinimal.Value = new decimal(new int[] { 25, 0, 0, 65536 });
        // 
        // EditLogAnalysisMinMaxChangePercentage
        // 
        EditLogAnalysisMinMaxChangePercentage.AutoSize = true;
        EditLogAnalysisMinMaxChangePercentage.Location = new Point(568, 60);
        EditLogAnalysisMinMaxChangePercentage.Margin = new Padding(4, 3, 4, 3);
        EditLogAnalysisMinMaxChangePercentage.Name = "EditLogAnalysisMinMaxChangePercentage";
        EditLogAnalysisMinMaxChangePercentage.Size = new Size(203, 19);
        EditLogAnalysisMinMaxChangePercentage.TabIndex = 184;
        EditLogAnalysisMinMaxChangePercentage.Text = "Log waarden buiten deze grenzen";
        EditLogAnalysisMinMaxChangePercentage.UseVisualStyleBackColor = true;
        // 
        // groupBoxInterval
        // 
        groupBoxInterval.Controls.Add(EditAnalyzeInterval6h);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval8h);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval12h);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval1d);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval5m);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval1m);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval2m);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval3m);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval10m);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval15m);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval30m);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval1h);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval2h);
        groupBoxInterval.Controls.Add(EditAnalyzeInterval4h);
        groupBoxInterval.Location = new Point(22, 60);
        groupBoxInterval.Margin = new Padding(4, 3, 4, 3);
        groupBoxInterval.Name = "groupBoxInterval";
        groupBoxInterval.Padding = new Padding(4, 3, 4, 3);
        groupBoxInterval.Size = new Size(224, 240);
        groupBoxInterval.TabIndex = 149;
        groupBoxInterval.TabStop = false;
        groupBoxInterval.Text = "Interval";
        // 
        // EditAnalyzeInterval6h
        // 
        EditAnalyzeInterval6h.AutoSize = true;
        EditAnalyzeInterval6h.Location = new Point(134, 112);
        EditAnalyzeInterval6h.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval6h.Name = "EditAnalyzeInterval6h";
        EditAnalyzeInterval6h.Size = new Size(53, 19);
        EditAnalyzeInterval6h.TabIndex = 115;
        EditAnalyzeInterval6h.Text = "6 uur";
        EditAnalyzeInterval6h.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval8h
        // 
        EditAnalyzeInterval8h.AutoSize = true;
        EditAnalyzeInterval8h.Location = new Point(134, 141);
        EditAnalyzeInterval8h.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval8h.Name = "EditAnalyzeInterval8h";
        EditAnalyzeInterval8h.Size = new Size(53, 19);
        EditAnalyzeInterval8h.TabIndex = 116;
        EditAnalyzeInterval8h.Text = "8 uur";
        EditAnalyzeInterval8h.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval12h
        // 
        EditAnalyzeInterval12h.AutoSize = true;
        EditAnalyzeInterval12h.Location = new Point(134, 168);
        EditAnalyzeInterval12h.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval12h.Name = "EditAnalyzeInterval12h";
        EditAnalyzeInterval12h.Size = new Size(59, 19);
        EditAnalyzeInterval12h.TabIndex = 117;
        EditAnalyzeInterval12h.Text = "12 uur";
        EditAnalyzeInterval12h.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval1d
        // 
        EditAnalyzeInterval1d.AutoSize = true;
        EditAnalyzeInterval1d.Location = new Point(134, 195);
        EditAnalyzeInterval1d.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval1d.Name = "EditAnalyzeInterval1d";
        EditAnalyzeInterval1d.Size = new Size(55, 19);
        EditAnalyzeInterval1d.TabIndex = 118;
        EditAnalyzeInterval1d.Text = "1 dag";
        EditAnalyzeInterval1d.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval5m
        // 
        EditAnalyzeInterval5m.AutoSize = true;
        EditAnalyzeInterval5m.Location = new Point(20, 114);
        EditAnalyzeInterval5m.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval5m.Name = "EditAnalyzeInterval5m";
        EditAnalyzeInterval5m.Size = new Size(56, 19);
        EditAnalyzeInterval5m.TabIndex = 108;
        EditAnalyzeInterval5m.Text = "5 min";
        EditAnalyzeInterval5m.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval1m
        // 
        EditAnalyzeInterval1m.AutoSize = true;
        EditAnalyzeInterval1m.Location = new Point(20, 31);
        EditAnalyzeInterval1m.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval1m.Name = "EditAnalyzeInterval1m";
        EditAnalyzeInterval1m.Size = new Size(56, 19);
        EditAnalyzeInterval1m.TabIndex = 105;
        EditAnalyzeInterval1m.Text = "1 min";
        EditAnalyzeInterval1m.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval2m
        // 
        EditAnalyzeInterval2m.AutoSize = true;
        EditAnalyzeInterval2m.Location = new Point(20, 61);
        EditAnalyzeInterval2m.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval2m.Name = "EditAnalyzeInterval2m";
        EditAnalyzeInterval2m.Size = new Size(56, 19);
        EditAnalyzeInterval2m.TabIndex = 106;
        EditAnalyzeInterval2m.Text = "2 min";
        EditAnalyzeInterval2m.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval3m
        // 
        EditAnalyzeInterval3m.AutoSize = true;
        EditAnalyzeInterval3m.Location = new Point(20, 88);
        EditAnalyzeInterval3m.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval3m.Name = "EditAnalyzeInterval3m";
        EditAnalyzeInterval3m.Size = new Size(56, 19);
        EditAnalyzeInterval3m.TabIndex = 107;
        EditAnalyzeInterval3m.Text = "3 min";
        EditAnalyzeInterval3m.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval10m
        // 
        EditAnalyzeInterval10m.AutoSize = true;
        EditAnalyzeInterval10m.Location = new Point(20, 141);
        EditAnalyzeInterval10m.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval10m.Name = "EditAnalyzeInterval10m";
        EditAnalyzeInterval10m.Size = new Size(62, 19);
        EditAnalyzeInterval10m.TabIndex = 109;
        EditAnalyzeInterval10m.Text = "10 min";
        EditAnalyzeInterval10m.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval15m
        // 
        EditAnalyzeInterval15m.AutoSize = true;
        EditAnalyzeInterval15m.Location = new Point(20, 167);
        EditAnalyzeInterval15m.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval15m.Name = "EditAnalyzeInterval15m";
        EditAnalyzeInterval15m.Size = new Size(62, 19);
        EditAnalyzeInterval15m.TabIndex = 110;
        EditAnalyzeInterval15m.Text = "15 min";
        EditAnalyzeInterval15m.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval30m
        // 
        EditAnalyzeInterval30m.AutoSize = true;
        EditAnalyzeInterval30m.Location = new Point(20, 194);
        EditAnalyzeInterval30m.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval30m.Name = "EditAnalyzeInterval30m";
        EditAnalyzeInterval30m.Size = new Size(62, 19);
        EditAnalyzeInterval30m.TabIndex = 111;
        EditAnalyzeInterval30m.Text = "30 min";
        EditAnalyzeInterval30m.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval1h
        // 
        EditAnalyzeInterval1h.AutoSize = true;
        EditAnalyzeInterval1h.Location = new Point(134, 31);
        EditAnalyzeInterval1h.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval1h.Name = "EditAnalyzeInterval1h";
        EditAnalyzeInterval1h.Size = new Size(53, 19);
        EditAnalyzeInterval1h.TabIndex = 112;
        EditAnalyzeInterval1h.Text = "1 uur";
        EditAnalyzeInterval1h.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval2h
        // 
        EditAnalyzeInterval2h.AutoSize = true;
        EditAnalyzeInterval2h.Location = new Point(134, 59);
        EditAnalyzeInterval2h.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval2h.Name = "EditAnalyzeInterval2h";
        EditAnalyzeInterval2h.Size = new Size(53, 19);
        EditAnalyzeInterval2h.TabIndex = 113;
        EditAnalyzeInterval2h.Text = "2 uur";
        EditAnalyzeInterval2h.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeInterval4h
        // 
        EditAnalyzeInterval4h.AutoSize = true;
        EditAnalyzeInterval4h.Location = new Point(134, 85);
        EditAnalyzeInterval4h.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeInterval4h.Name = "EditAnalyzeInterval4h";
        EditAnalyzeInterval4h.Size = new Size(53, 19);
        EditAnalyzeInterval4h.TabIndex = 114;
        EditAnalyzeInterval4h.Text = "4 uur";
        EditAnalyzeInterval4h.UseVisualStyleBackColor = true;
        // 
        // tabSignalStobb
        // 
        tabSignalStobb.Controls.Add(label77);
        tabSignalStobb.Controls.Add(label75);
        tabSignalStobb.Controls.Add(EditStobIncludeSbmPercAndCrossing);
        tabSignalStobb.Controls.Add(label30);
        tabSignalStobb.Controls.Add(label28);
        tabSignalStobb.Controls.Add(buttonColorStobb);
        tabSignalStobb.Controls.Add(EditStobIncludeSbmMaLines);
        tabSignalStobb.Controls.Add(EditStobIncludeRsi);
        tabSignalStobb.Controls.Add(buttonPlaySoundStobbOversold);
        tabSignalStobb.Controls.Add(buttonPlaySoundStobbOverbought);
        tabSignalStobb.Controls.Add(buttonSelectSoundStobbOversold);
        tabSignalStobb.Controls.Add(panelColorStobb);
        tabSignalStobb.Controls.Add(EditSoundStobbOversold);
        tabSignalStobb.Controls.Add(EditSoundStobbOverbought);
        tabSignalStobb.Controls.Add(buttonSelectSoundStobbOverbought);
        tabSignalStobb.Controls.Add(EditPlaySpeechStobbSignal);
        tabSignalStobb.Controls.Add(EditPlaySoundStobbSignal);
        tabSignalStobb.Controls.Add(EditAnalyzeStobbOversold);
        tabSignalStobb.Controls.Add(EditAnalyzeStobbOverbought);
        tabSignalStobb.Controls.Add(EditStobbUseLowHigh);
        tabSignalStobb.Controls.Add(label1);
        tabSignalStobb.Controls.Add(EditStobbBBMinPercentage);
        tabSignalStobb.Controls.Add(EditStobbBBMaxPercentage);
        tabSignalStobb.Location = new Point(4, 24);
        tabSignalStobb.Margin = new Padding(4, 3, 4, 3);
        tabSignalStobb.Name = "tabSignalStobb";
        tabSignalStobb.Padding = new Padding(4, 3, 4, 3);
        tabSignalStobb.Size = new Size(1232, 780);
        tabSignalStobb.TabIndex = 1;
        tabSignalStobb.Text = "STOBB";
        tabSignalStobb.UseVisualStyleBackColor = true;
        // 
        // label77
        // 
        label77.AutoSize = true;
        label77.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        label77.Location = new Point(19, 221);
        label77.Margin = new Padding(4, 0, 4, 0);
        label77.Name = "label77";
        label77.Size = new Size(48, 13);
        label77.TabIndex = 151;
        label77.Text = "STOBB";
        // 
        // label75
        // 
        label75.AutoSize = true;
        label75.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        label75.Location = new Point(19, 316);
        label75.Margin = new Padding(4, 0, 4, 0);
        label75.Name = "label75";
        label75.Size = new Size(72, 13);
        label75.TabIndex = 121;
        label75.Text = "Instellingen";
        // 
        // EditStobIncludeSbmPercAndCrossing
        // 
        EditStobIncludeSbmPercAndCrossing.AutoSize = true;
        EditStobIncludeSbmPercAndCrossing.Location = new Point(19, 443);
        EditStobIncludeSbmPercAndCrossing.Margin = new Padding(4, 3, 4, 3);
        EditStobIncludeSbmPercAndCrossing.Name = "EditStobIncludeSbmPercAndCrossing";
        EditStobIncludeSbmPercAndCrossing.Size = new Size(252, 19);
        EditStobIncludeSbmPercAndCrossing.TabIndex = 120;
        EditStobIncludeSbmPercAndCrossing.Text = "Met SBM condities percentages/kruisingen";
        EditStobIncludeSbmPercAndCrossing.UseVisualStyleBackColor = true;
        // 
        // label30
        // 
        label30.AutoSize = true;
        label30.Location = new Point(19, 170);
        label30.Margin = new Padding(4, 0, 4, 0);
        label30.Name = "label30";
        label30.Size = new Size(86, 15);
        label30.TabIndex = 119;
        label30.Text = "Long soundfile";
        // 
        // label28
        // 
        label28.AutoSize = true;
        label28.Location = new Point(19, 144);
        label28.Margin = new Padding(4, 0, 4, 0);
        label28.Name = "label28";
        label28.Size = new Size(87, 15);
        label28.TabIndex = 118;
        label28.Text = "Short soundfile";
        // 
        // buttonColorStobb
        // 
        buttonColorStobb.Location = new Point(127, 47);
        buttonColorStobb.Margin = new Padding(4, 3, 4, 3);
        buttonColorStobb.Name = "buttonColorStobb";
        buttonColorStobb.Size = new Size(88, 27);
        buttonColorStobb.TabIndex = 115;
        buttonColorStobb.Text = "Achtergrond";
        buttonColorStobb.UseVisualStyleBackColor = true;
        // 
        // EditStobIncludeSbmMaLines
        // 
        EditStobIncludeSbmMaLines.AutoSize = true;
        EditStobIncludeSbmMaLines.Location = new Point(19, 418);
        EditStobIncludeSbmMaLines.Margin = new Padding(4, 3, 4, 3);
        EditStobIncludeSbmMaLines.Name = "EditStobIncludeSbmMaLines";
        EditStobIncludeSbmMaLines.Size = new Size(181, 19);
        EditStobIncludeSbmMaLines.TabIndex = 114;
        EditStobIncludeSbmMaLines.Text = "Met SBM condities MA-lijnen";
        EditStobIncludeSbmMaLines.UseVisualStyleBackColor = true;
        // 
        // EditStobIncludeRsi
        // 
        EditStobIncludeRsi.AutoSize = true;
        EditStobIncludeRsi.Location = new Point(19, 393);
        EditStobIncludeRsi.Margin = new Padding(4, 3, 4, 3);
        EditStobIncludeRsi.Name = "EditStobIncludeRsi";
        EditStobIncludeRsi.Size = new Size(232, 19);
        EditStobIncludeRsi.TabIndex = 113;
        EditStobIncludeRsi.Text = "Met RSI oversold/overbought condities";
        EditStobIncludeRsi.UseVisualStyleBackColor = true;
        // 
        // buttonPlaySoundStobbOversold
        // 
        buttonPlaySoundStobbOversold.Image = Properties.Resources.volume;
        buttonPlaySoundStobbOversold.Location = new Point(421, 170);
        buttonPlaySoundStobbOversold.Margin = new Padding(4, 3, 4, 3);
        buttonPlaySoundStobbOversold.Name = "buttonPlaySoundStobbOversold";
        buttonPlaySoundStobbOversold.Size = new Size(23, 23);
        buttonPlaySoundStobbOversold.TabIndex = 112;
        buttonPlaySoundStobbOversold.UseVisualStyleBackColor = true;
        // 
        // buttonPlaySoundStobbOverbought
        // 
        buttonPlaySoundStobbOverbought.Image = Properties.Resources.volume;
        buttonPlaySoundStobbOverbought.Location = new Point(421, 142);
        buttonPlaySoundStobbOverbought.Margin = new Padding(4, 3, 4, 3);
        buttonPlaySoundStobbOverbought.Name = "buttonPlaySoundStobbOverbought";
        buttonPlaySoundStobbOverbought.Size = new Size(23, 23);
        buttonPlaySoundStobbOverbought.TabIndex = 111;
        buttonPlaySoundStobbOverbought.UseVisualStyleBackColor = true;
        // 
        // buttonSelectSoundStobbOversold
        // 
        buttonSelectSoundStobbOversold.Location = new Point(391, 170);
        buttonSelectSoundStobbOversold.Margin = new Padding(4, 3, 4, 3);
        buttonSelectSoundStobbOversold.Name = "buttonSelectSoundStobbOversold";
        buttonSelectSoundStobbOversold.Size = new Size(23, 23);
        buttonSelectSoundStobbOversold.TabIndex = 110;
        buttonSelectSoundStobbOversold.UseVisualStyleBackColor = true;
        // 
        // panelColorStobb
        // 
        panelColorStobb.BackColor = Color.Transparent;
        panelColorStobb.BorderStyle = BorderStyle.FixedSingle;
        panelColorStobb.Location = new Point(19, 50);
        panelColorStobb.Margin = new Padding(4, 3, 4, 3);
        panelColorStobb.Name = "panelColorStobb";
        panelColorStobb.Size = new Size(70, 22);
        panelColorStobb.TabIndex = 116;
        // 
        // EditSoundStobbOversold
        // 
        EditSoundStobbOversold.Location = new Point(156, 170);
        EditSoundStobbOversold.Margin = new Padding(4, 3, 4, 3);
        EditSoundStobbOversold.Name = "EditSoundStobbOversold";
        EditSoundStobbOversold.Size = new Size(227, 23);
        EditSoundStobbOversold.TabIndex = 109;
        // 
        // EditSoundStobbOverbought
        // 
        EditSoundStobbOverbought.Location = new Point(156, 141);
        EditSoundStobbOverbought.Margin = new Padding(4, 3, 4, 3);
        EditSoundStobbOverbought.Name = "EditSoundStobbOverbought";
        EditSoundStobbOverbought.Size = new Size(227, 23);
        EditSoundStobbOverbought.TabIndex = 106;
        // 
        // buttonSelectSoundStobbOverbought
        // 
        buttonSelectSoundStobbOverbought.Location = new Point(391, 142);
        buttonSelectSoundStobbOverbought.Margin = new Padding(4, 3, 4, 3);
        buttonSelectSoundStobbOverbought.Name = "buttonSelectSoundStobbOverbought";
        buttonSelectSoundStobbOverbought.Size = new Size(23, 23);
        buttonSelectSoundStobbOverbought.TabIndex = 107;
        buttonSelectSoundStobbOverbought.Text = "...";
        buttonSelectSoundStobbOverbought.UseVisualStyleBackColor = true;
        // 
        // EditPlaySpeechStobbSignal
        // 
        EditPlaySpeechStobbSignal.AutoSize = true;
        EditPlaySpeechStobbSignal.Location = new Point(19, 110);
        EditPlaySpeechStobbSignal.Margin = new Padding(4, 3, 4, 3);
        EditPlaySpeechStobbSignal.Name = "EditPlaySpeechStobbSignal";
        EditPlaySpeechStobbSignal.Size = new Size(88, 19);
        EditPlaySpeechStobbSignal.TabIndex = 104;
        EditPlaySpeechStobbSignal.Text = "Play speech";
        EditPlaySpeechStobbSignal.UseVisualStyleBackColor = true;
        // 
        // EditPlaySoundStobbSignal
        // 
        EditPlaySoundStobbSignal.AutoSize = true;
        EditPlaySoundStobbSignal.Location = new Point(19, 83);
        EditPlaySoundStobbSignal.Margin = new Padding(4, 3, 4, 3);
        EditPlaySoundStobbSignal.Name = "EditPlaySoundStobbSignal";
        EditPlaySoundStobbSignal.Size = new Size(84, 19);
        EditPlaySoundStobbSignal.TabIndex = 103;
        EditPlaySoundStobbSignal.Text = "Play sound";
        EditPlaySoundStobbSignal.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeStobbOversold
        // 
        EditAnalyzeStobbOversold.AutoSize = true;
        EditAnalyzeStobbOversold.Location = new Point(19, 272);
        EditAnalyzeStobbOversold.Margin = new Padding(2);
        EditAnalyzeStobbOversold.Name = "EditAnalyzeStobbOversold";
        EditAnalyzeStobbOversold.Size = new Size(151, 19);
        EditAnalyzeStobbOversold.TabIndex = 108;
        EditAnalyzeStobbOversold.Text = "Maak aankoop signalen";
        EditAnalyzeStobbOversold.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeStobbOverbought
        // 
        EditAnalyzeStobbOverbought.AutoSize = true;
        EditAnalyzeStobbOverbought.Location = new Point(19, 243);
        EditAnalyzeStobbOverbought.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeStobbOverbought.Name = "EditAnalyzeStobbOverbought";
        EditAnalyzeStobbOverbought.Size = new Size(148, 19);
        EditAnalyzeStobbOverbought.TabIndex = 105;
        EditAnalyzeStobbOverbought.Text = "Maak verkoop signalen";
        EditAnalyzeStobbOverbought.UseVisualStyleBackColor = true;
        // 
        // EditStobbUseLowHigh
        // 
        EditStobbUseLowHigh.AutoSize = true;
        EditStobbUseLowHigh.Location = new Point(19, 368);
        EditStobbUseLowHigh.Margin = new Padding(4, 3, 4, 3);
        EditStobbUseLowHigh.Name = "EditStobbUseLowHigh";
        EditStobbUseLowHigh.Size = new Size(398, 19);
        EditStobbUseLowHigh.TabIndex = 98;
        EditStobbUseLowHigh.Text = "Bereken de BB oversold/overbought via de low/high ipv de open/close";
        EditStobbUseLowHigh.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(19, 340);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(77, 15);
        label1.TabIndex = 42;
        label1.Text = "Filter on BB%";
        // 
        // EditStobbBBMinPercentage
        // 
        EditStobbBBMinPercentage.DecimalPlaces = 2;
        EditStobbBBMinPercentage.Location = new Point(140, 338);
        EditStobbBBMinPercentage.Margin = new Padding(4, 3, 4, 3);
        EditStobbBBMinPercentage.Name = "EditStobbBBMinPercentage";
        EditStobbBBMinPercentage.Size = new Size(65, 23);
        EditStobbBBMinPercentage.TabIndex = 43;
        toolTip1.SetToolTip(EditStobbBBMinPercentage, "Een BB heeft een bepaalde breedte, je kunt hier filteren waardoor op de minimale en maximale breedte kan worden gefilterd.");
        EditStobbBBMinPercentage.Value = new decimal(new int[] { 150, 0, 0, 131072 });
        // 
        // EditStobbBBMaxPercentage
        // 
        EditStobbBBMaxPercentage.DecimalPlaces = 2;
        EditStobbBBMaxPercentage.Location = new Point(225, 338);
        EditStobbBBMaxPercentage.Margin = new Padding(4, 3, 4, 3);
        EditStobbBBMaxPercentage.Name = "EditStobbBBMaxPercentage";
        EditStobbBBMaxPercentage.Size = new Size(65, 23);
        EditStobbBBMaxPercentage.TabIndex = 44;
        toolTip1.SetToolTip(EditStobbBBMaxPercentage, "Een BB heeft een bepaalde breedte, je kunt hier filteren waardoor op de minimale en maximale breedte kan worden gefilterd.");
        EditStobbBBMaxPercentage.Value = new decimal(new int[] { 6, 0, 0, 0 });
        // 
        // tabSignalSbm
        // 
        tabSignalSbm.Controls.Add(EditSbm2UseLowHigh);
        tabSignalSbm.Controls.Add(label21);
        tabSignalSbm.Controls.Add(label20);
        tabSignalSbm.Controls.Add(label9);
        tabSignalSbm.Controls.Add(label41);
        tabSignalSbm.Controls.Add(EditSbm1CandlesLookbackCount);
        tabSignalSbm.Controls.Add(label39);
        tabSignalSbm.Controls.Add(EditSbmCandlesForMacdRecovery);
        tabSignalSbm.Controls.Add(label31);
        tabSignalSbm.Controls.Add(label32);
        tabSignalSbm.Controls.Add(buttonPlaySoundSbmOversold);
        tabSignalSbm.Controls.Add(buttonPlaySoundSbmOverbought);
        tabSignalSbm.Controls.Add(buttonSelectSoundSbmOversold);
        tabSignalSbm.Controls.Add(EditSoundFileSbmOversold);
        tabSignalSbm.Controls.Add(buttonSelectSoundSbmOverbought);
        tabSignalSbm.Controls.Add(EditSoundFileSbmOverbought);
        tabSignalSbm.Controls.Add(EditPlaySpeechSbmSignal);
        tabSignalSbm.Controls.Add(EditAnalyzeSbmOversold);
        tabSignalSbm.Controls.Add(EditAnalyzeSbmOverbought);
        tabSignalSbm.Controls.Add(EditPlaySoundSbmSignal);
        tabSignalSbm.Controls.Add(buttonColorSbm);
        tabSignalSbm.Controls.Add(EditSbmUseLowHigh);
        tabSignalSbm.Controls.Add(label17);
        tabSignalSbm.Controls.Add(EditSbmBBMinPercentage);
        tabSignalSbm.Controls.Add(EditSbmBBMaxPercentage);
        tabSignalSbm.Controls.Add(label22);
        tabSignalSbm.Controls.Add(label4);
        tabSignalSbm.Controls.Add(EditSbmMa200AndMa20Percentage);
        tabSignalSbm.Controls.Add(label8);
        tabSignalSbm.Controls.Add(EditSbmMa50AndMa20Percentage);
        tabSignalSbm.Controls.Add(label7);
        tabSignalSbm.Controls.Add(EditSbmMa200AndMa50Percentage);
        tabSignalSbm.Controls.Add(EditSbmMa50AndMa20Lookback);
        tabSignalSbm.Controls.Add(EditSbmMa50AndMa20Crossing);
        tabSignalSbm.Controls.Add(EditSbmMa200AndMa50Lookback);
        tabSignalSbm.Controls.Add(EditSbmMa200AndMa50Crossing);
        tabSignalSbm.Controls.Add(EditSbmMa200AndMa20Lookback);
        tabSignalSbm.Controls.Add(EditSbmMa200AndMa20Crossing);
        tabSignalSbm.Controls.Add(EditAnalyzeSbm3Overbought);
        tabSignalSbm.Controls.Add(EditAnalyzeSbm2Overbought);
        tabSignalSbm.Controls.Add(label12);
        tabSignalSbm.Controls.Add(EditSbm2BbPercentage);
        tabSignalSbm.Controls.Add(panelColorSbm);
        tabSignalSbm.Controls.Add(label13);
        tabSignalSbm.Controls.Add(EditSbm3CandlesForBBRecovery);
        tabSignalSbm.Controls.Add(label14);
        tabSignalSbm.Controls.Add(EditSbm3CandlesForBBRecoveryPercentage);
        tabSignalSbm.Controls.Add(label11);
        tabSignalSbm.Controls.Add(EditSbm2CandlesLookbackCount);
        tabSignalSbm.Controls.Add(EditAnalyzeSbm3Oversold);
        tabSignalSbm.Controls.Add(EditAnalyzeSbm2Oversold);
        tabSignalSbm.Location = new Point(4, 24);
        tabSignalSbm.Margin = new Padding(4, 3, 4, 3);
        tabSignalSbm.Name = "tabSignalSbm";
        tabSignalSbm.Padding = new Padding(4, 3, 4, 3);
        tabSignalSbm.Size = new Size(1232, 780);
        tabSignalSbm.TabIndex = 5;
        tabSignalSbm.Text = "SBM";
        tabSignalSbm.UseVisualStyleBackColor = true;
        // 
        // EditSbm2UseLowHigh
        // 
        EditSbm2UseLowHigh.AutoSize = true;
        EditSbm2UseLowHigh.Location = new Point(23, 415);
        EditSbm2UseLowHigh.Margin = new Padding(4, 3, 4, 3);
        EditSbm2UseLowHigh.Name = "EditSbm2UseLowHigh";
        EditSbm2UseLowHigh.Size = new Size(281, 19);
        EditSbm2UseLowHigh.TabIndex = 152;
        EditSbm2UseLowHigh.Text = "Gebruik daarvoor de high/low ipv de open/close";
        EditSbm2UseLowHigh.UseVisualStyleBackColor = true;
        // 
        // label21
        // 
        label21.AutoSize = true;
        label21.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        label21.Location = new Point(19, 487);
        label21.Margin = new Padding(4, 0, 4, 0);
        label21.Name = "label21";
        label21.Size = new Size(40, 13);
        label21.TabIndex = 151;
        label21.Text = "SBM3";
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        label20.Location = new Point(19, 316);
        label20.Margin = new Padding(4, 0, 4, 0);
        label20.Name = "label20";
        label20.Size = new Size(40, 13);
        label20.TabIndex = 150;
        label20.Text = "SBM2";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        label9.Location = new Point(19, 178);
        label9.Margin = new Padding(4, 0, 4, 0);
        label9.Name = "label9";
        label9.Size = new Size(40, 13);
        label9.TabIndex = 149;
        label9.Text = "SBM1";
        // 
        // label41
        // 
        label41.AutoSize = true;
        label41.Location = new Point(19, 251);
        label41.Margin = new Padding(4, 0, 4, 0);
        label41.Name = "label41";
        label41.Size = new Size(95, 15);
        label41.TabIndex = 146;
        label41.Text = "Candle lookback";
        // 
        // EditSbm1CandlesLookbackCount
        // 
        EditSbm1CandlesLookbackCount.Location = new Point(274, 248);
        EditSbm1CandlesLookbackCount.Margin = new Padding(4, 3, 4, 3);
        EditSbm1CandlesLookbackCount.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        EditSbm1CandlesLookbackCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        EditSbm1CandlesLookbackCount.Name = "EditSbm1CandlesLookbackCount";
        EditSbm1CandlesLookbackCount.Size = new Size(57, 23);
        EditSbm1CandlesLookbackCount.TabIndex = 147;
        EditSbm1CandlesLookbackCount.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // label39
        // 
        label39.AutoSize = true;
        label39.Location = new Point(612, 244);
        label39.Margin = new Padding(4, 0, 4, 0);
        label39.Name = "label39";
        label39.Size = new Size(180, 15);
        label39.TabIndex = 141;
        label39.Text = "Het aantal MACD herstel candles";
        // 
        // EditSbmCandlesForMacdRecovery
        // 
        EditSbmCandlesForMacdRecovery.Location = new Point(1052, 238);
        EditSbmCandlesForMacdRecovery.Margin = new Padding(4, 3, 4, 3);
        EditSbmCandlesForMacdRecovery.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        EditSbmCandlesForMacdRecovery.Name = "EditSbmCandlesForMacdRecovery";
        EditSbmCandlesForMacdRecovery.Size = new Size(57, 23);
        EditSbmCandlesForMacdRecovery.TabIndex = 142;
        EditSbmCandlesForMacdRecovery.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // label31
        // 
        label31.AutoSize = true;
        label31.Location = new Point(19, 134);
        label31.Margin = new Padding(4, 0, 4, 0);
        label31.Name = "label31";
        label31.Size = new Size(106, 15);
        label31.TabIndex = 135;
        label31.Text = "Oversold soundfile";
        // 
        // label32
        // 
        label32.AutoSize = true;
        label32.Location = new Point(19, 109);
        label32.Margin = new Padding(4, 0, 4, 0);
        label32.Name = "label32";
        label32.Size = new Size(123, 15);
        label32.TabIndex = 134;
        label32.Text = "Overbought soundfile";
        // 
        // buttonPlaySoundSbmOversold
        // 
        buttonPlaySoundSbmOversold.Image = Properties.Resources.volume;
        buttonPlaySoundSbmOversold.Location = new Point(474, 129);
        buttonPlaySoundSbmOversold.Margin = new Padding(4, 3, 4, 3);
        buttonPlaySoundSbmOversold.Name = "buttonPlaySoundSbmOversold";
        buttonPlaySoundSbmOversold.Size = new Size(23, 23);
        buttonPlaySoundSbmOversold.TabIndex = 132;
        buttonPlaySoundSbmOversold.UseVisualStyleBackColor = true;
        // 
        // buttonPlaySoundSbmOverbought
        // 
        buttonPlaySoundSbmOverbought.Image = Properties.Resources.volume;
        buttonPlaySoundSbmOverbought.Location = new Point(474, 106);
        buttonPlaySoundSbmOverbought.Margin = new Padding(4, 3, 4, 3);
        buttonPlaySoundSbmOverbought.Name = "buttonPlaySoundSbmOverbought";
        buttonPlaySoundSbmOverbought.Size = new Size(23, 23);
        buttonPlaySoundSbmOverbought.TabIndex = 133;
        buttonPlaySoundSbmOverbought.UseVisualStyleBackColor = true;
        // 
        // buttonSelectSoundSbmOversold
        // 
        buttonSelectSoundSbmOversold.Location = new Point(443, 129);
        buttonSelectSoundSbmOversold.Margin = new Padding(4, 3, 4, 3);
        buttonSelectSoundSbmOversold.Name = "buttonSelectSoundSbmOversold";
        buttonSelectSoundSbmOversold.Size = new Size(23, 23);
        buttonSelectSoundSbmOversold.TabIndex = 124;
        buttonSelectSoundSbmOversold.UseVisualStyleBackColor = true;
        // 
        // EditSoundFileSbmOversold
        // 
        EditSoundFileSbmOversold.Location = new Point(209, 129);
        EditSoundFileSbmOversold.Margin = new Padding(4, 3, 4, 3);
        EditSoundFileSbmOversold.Name = "EditSoundFileSbmOversold";
        EditSoundFileSbmOversold.Size = new Size(227, 23);
        EditSoundFileSbmOversold.TabIndex = 131;
        // 
        // buttonSelectSoundSbmOverbought
        // 
        buttonSelectSoundSbmOverbought.Location = new Point(443, 104);
        buttonSelectSoundSbmOverbought.Margin = new Padding(4, 3, 4, 3);
        buttonSelectSoundSbmOverbought.Name = "buttonSelectSoundSbmOverbought";
        buttonSelectSoundSbmOverbought.Size = new Size(23, 23);
        buttonSelectSoundSbmOverbought.TabIndex = 129;
        buttonSelectSoundSbmOverbought.UseVisualStyleBackColor = true;
        // 
        // EditSoundFileSbmOverbought
        // 
        EditSoundFileSbmOverbought.Location = new Point(209, 103);
        EditSoundFileSbmOverbought.Margin = new Padding(4, 3, 4, 3);
        EditSoundFileSbmOverbought.Name = "EditSoundFileSbmOverbought";
        EditSoundFileSbmOverbought.Size = new Size(227, 23);
        EditSoundFileSbmOverbought.TabIndex = 128;
        // 
        // EditPlaySpeechSbmSignal
        // 
        EditPlaySpeechSbmSignal.AutoSize = true;
        EditPlaySpeechSbmSignal.Location = new Point(19, 78);
        EditPlaySpeechSbmSignal.Margin = new Padding(4, 3, 4, 3);
        EditPlaySpeechSbmSignal.Name = "EditPlaySpeechSbmSignal";
        EditPlaySpeechSbmSignal.Size = new Size(88, 19);
        EditPlaySpeechSbmSignal.TabIndex = 126;
        EditPlaySpeechSbmSignal.Text = "Play speech";
        EditPlaySpeechSbmSignal.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeSbmOversold
        // 
        EditAnalyzeSbmOversold.AutoSize = true;
        EditAnalyzeSbmOversold.Location = new Point(19, 225);
        EditAnalyzeSbmOversold.Margin = new Padding(2);
        EditAnalyzeSbmOversold.Name = "EditAnalyzeSbmOversold";
        EditAnalyzeSbmOversold.Size = new Size(151, 19);
        EditAnalyzeSbmOversold.TabIndex = 130;
        EditAnalyzeSbmOversold.Text = "Maak aankoop signalen";
        EditAnalyzeSbmOversold.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeSbmOverbought
        // 
        EditAnalyzeSbmOverbought.AutoSize = true;
        EditAnalyzeSbmOverbought.Location = new Point(19, 200);
        EditAnalyzeSbmOverbought.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeSbmOverbought.Name = "EditAnalyzeSbmOverbought";
        EditAnalyzeSbmOverbought.Size = new Size(148, 19);
        EditAnalyzeSbmOverbought.TabIndex = 127;
        EditAnalyzeSbmOverbought.Text = "Maak verkoop signalen";
        EditAnalyzeSbmOverbought.UseVisualStyleBackColor = true;
        // 
        // EditPlaySoundSbmSignal
        // 
        EditPlaySoundSbmSignal.AutoSize = true;
        EditPlaySoundSbmSignal.Location = new Point(19, 51);
        EditPlaySoundSbmSignal.Margin = new Padding(4, 3, 4, 3);
        EditPlaySoundSbmSignal.Name = "EditPlaySoundSbmSignal";
        EditPlaySoundSbmSignal.Size = new Size(84, 19);
        EditPlaySoundSbmSignal.TabIndex = 125;
        EditPlaySoundSbmSignal.Text = "Play sound";
        EditPlaySoundSbmSignal.UseVisualStyleBackColor = true;
        // 
        // buttonColorSbm
        // 
        buttonColorSbm.Location = new Point(127, 13);
        buttonColorSbm.Margin = new Padding(4, 3, 4, 3);
        buttonColorSbm.Name = "buttonColorSbm";
        buttonColorSbm.Size = new Size(88, 27);
        buttonColorSbm.TabIndex = 121;
        buttonColorSbm.Text = "Achtergrond";
        buttonColorSbm.UseVisualStyleBackColor = true;
        // 
        // EditSbmUseLowHigh
        // 
        EditSbmUseLowHigh.AutoSize = true;
        EditSbmUseLowHigh.Location = new Point(19, 274);
        EditSbmUseLowHigh.Margin = new Padding(4, 3, 4, 3);
        EditSbmUseLowHigh.Name = "EditSbmUseLowHigh";
        EditSbmUseLowHigh.Size = new Size(265, 19);
        EditSbmUseLowHigh.TabIndex = 117;
        EditSbmUseLowHigh.Text = "Gebruik daarvoor de low/high ipv open/close";
        EditSbmUseLowHigh.UseVisualStyleBackColor = true;
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(611, 208);
        label17.Margin = new Padding(4, 0, 4, 0);
        label17.Name = "label17";
        label17.Size = new Size(77, 15);
        label17.TabIndex = 113;
        label17.Text = "Filter on BB%";
        // 
        // EditSbmBBMinPercentage
        // 
        EditSbmBBMinPercentage.DecimalPlaces = 2;
        EditSbmBBMinPercentage.Location = new Point(725, 205);
        EditSbmBBMinPercentage.Margin = new Padding(4, 3, 4, 3);
        EditSbmBBMinPercentage.Name = "EditSbmBBMinPercentage";
        EditSbmBBMinPercentage.Size = new Size(65, 23);
        EditSbmBBMinPercentage.TabIndex = 114;
        toolTip1.SetToolTip(EditSbmBBMinPercentage, "Een BB heeft een bepaalde breedte, je kunt hier filteren waardoor op de minimale en maximale breedte kan worden gefilterd.");
        EditSbmBBMinPercentage.Value = new decimal(new int[] { 150, 0, 0, 131072 });
        // 
        // EditSbmBBMaxPercentage
        // 
        EditSbmBBMaxPercentage.DecimalPlaces = 2;
        EditSbmBBMaxPercentage.Location = new Point(810, 205);
        EditSbmBBMaxPercentage.Margin = new Padding(4, 3, 4, 3);
        EditSbmBBMaxPercentage.Name = "EditSbmBBMaxPercentage";
        EditSbmBBMaxPercentage.Size = new Size(65, 23);
        EditSbmBBMaxPercentage.TabIndex = 115;
        toolTip1.SetToolTip(EditSbmBBMaxPercentage, "Een BB heeft een bepaalde breedte, je kunt hier filteren waardoor op de minimale en maximale breedte kan worden gefilterd.");
        EditSbmBBMaxPercentage.Value = new decimal(new int[] { 6, 0, 0, 0 });
        // 
        // label22
        // 
        label22.AutoSize = true;
        label22.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        label22.Location = new Point(612, 178);
        label22.Margin = new Padding(4, 0, 4, 0);
        label22.Name = "label22";
        label22.Size = new Size(193, 13);
        label22.TabIndex = 112;
        label22.Text = "Extra instellingen voor alle SBMx";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(612, 400);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(372, 15);
        label4.TabIndex = 110;
        label4.Text = "Het minimaal percentage wat tussen de ma200 en ma20  moet liggen";
        // 
        // EditSbmMa200AndMa20Percentage
        // 
        EditSbmMa200AndMa20Percentage.DecimalPlaces = 2;
        EditSbmMa200AndMa20Percentage.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        EditSbmMa200AndMa20Percentage.Location = new Point(1052, 397);
        EditSbmMa200AndMa20Percentage.Margin = new Padding(4, 3, 4, 3);
        EditSbmMa200AndMa20Percentage.Name = "EditSbmMa200AndMa20Percentage";
        EditSbmMa200AndMa20Percentage.Size = new Size(57, 23);
        EditSbmMa200AndMa20Percentage.TabIndex = 111;
        EditSbmMa200AndMa20Percentage.Value = new decimal(new int[] { 3, 0, 0, 65536 });
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(612, 425);
        label8.Margin = new Padding(4, 0, 4, 0);
        label8.Name = "label8";
        label8.Size = new Size(363, 15);
        label8.TabIndex = 108;
        label8.Text = "Het minimaal percentage wat tussen de ma50 en ma20 moet liggen";
        // 
        // EditSbmMa50AndMa20Percentage
        // 
        EditSbmMa50AndMa20Percentage.DecimalPlaces = 2;
        EditSbmMa50AndMa20Percentage.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        EditSbmMa50AndMa20Percentage.Location = new Point(1052, 424);
        EditSbmMa50AndMa20Percentage.Margin = new Padding(4, 3, 4, 3);
        EditSbmMa50AndMa20Percentage.Name = "EditSbmMa50AndMa20Percentage";
        EditSbmMa50AndMa20Percentage.Size = new Size(57, 23);
        EditSbmMa50AndMa20Percentage.TabIndex = 109;
        EditSbmMa50AndMa20Percentage.Value = new decimal(new int[] { 3, 0, 0, 65536 });
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(612, 371);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(369, 15);
        label7.TabIndex = 106;
        label7.Text = "Het minimaal percentage wat tussen de ma200 en ma50 moet liggen";
        // 
        // EditSbmMa200AndMa50Percentage
        // 
        EditSbmMa200AndMa50Percentage.DecimalPlaces = 2;
        EditSbmMa200AndMa50Percentage.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        EditSbmMa200AndMa50Percentage.Location = new Point(1052, 371);
        EditSbmMa200AndMa50Percentage.Margin = new Padding(4, 3, 4, 3);
        EditSbmMa200AndMa50Percentage.Name = "EditSbmMa200AndMa50Percentage";
        EditSbmMa200AndMa50Percentage.Size = new Size(57, 23);
        EditSbmMa200AndMa50Percentage.TabIndex = 107;
        toolTip1.SetToolTip(EditSbmMa200AndMa50Percentage, "Percentage tussen de ma200 en ma50");
        EditSbmMa200AndMa50Percentage.Value = new decimal(new int[] { 3, 0, 0, 65536 });
        // 
        // EditSbmMa50AndMa20Lookback
        // 
        EditSbmMa50AndMa20Lookback.Location = new Point(1052, 335);
        EditSbmMa50AndMa20Lookback.Margin = new Padding(4, 3, 4, 3);
        EditSbmMa50AndMa20Lookback.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        EditSbmMa50AndMa20Lookback.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        EditSbmMa50AndMa20Lookback.Name = "EditSbmMa50AndMa20Lookback";
        EditSbmMa50AndMa20Lookback.Size = new Size(57, 23);
        EditSbmMa50AndMa20Lookback.TabIndex = 105;
        EditSbmMa50AndMa20Lookback.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // EditSbmMa50AndMa20Crossing
        // 
        EditSbmMa50AndMa20Crossing.AutoSize = true;
        EditSbmMa50AndMa20Crossing.Location = new Point(614, 334);
        EditSbmMa50AndMa20Crossing.Margin = new Padding(4, 3, 4, 3);
        EditSbmMa50AndMa20Crossing.Name = "EditSbmMa50AndMa20Crossing";
        EditSbmMa50AndMa20Crossing.Size = new Size(402, 19);
        EditSbmMa50AndMa20Crossing.TabIndex = 104;
        EditSbmMa50AndMa20Crossing.Text = "Controleer op een kruising van de ma50 en ma20 in de laatste x candles";
        EditSbmMa50AndMa20Crossing.UseVisualStyleBackColor = true;
        // 
        // EditSbmMa200AndMa50Lookback
        // 
        EditSbmMa200AndMa50Lookback.Location = new Point(1052, 283);
        EditSbmMa200AndMa50Lookback.Margin = new Padding(4, 3, 4, 3);
        EditSbmMa200AndMa50Lookback.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        EditSbmMa200AndMa50Lookback.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        EditSbmMa200AndMa50Lookback.Name = "EditSbmMa200AndMa50Lookback";
        EditSbmMa200AndMa50Lookback.Size = new Size(57, 23);
        EditSbmMa200AndMa50Lookback.TabIndex = 103;
        EditSbmMa200AndMa50Lookback.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // EditSbmMa200AndMa50Crossing
        // 
        EditSbmMa200AndMa50Crossing.AutoSize = true;
        EditSbmMa200AndMa50Crossing.Location = new Point(614, 283);
        EditSbmMa200AndMa50Crossing.Margin = new Padding(4, 3, 4, 3);
        EditSbmMa200AndMa50Crossing.Name = "EditSbmMa200AndMa50Crossing";
        EditSbmMa200AndMa50Crossing.Size = new Size(408, 19);
        EditSbmMa200AndMa50Crossing.TabIndex = 102;
        EditSbmMa200AndMa50Crossing.Text = "Controleer op een kruising van de ma200 en ma50 in de laatste x candles";
        EditSbmMa200AndMa50Crossing.UseVisualStyleBackColor = true;
        // 
        // EditSbmMa200AndMa20Lookback
        // 
        EditSbmMa200AndMa20Lookback.Location = new Point(1052, 309);
        EditSbmMa200AndMa20Lookback.Margin = new Padding(4, 3, 4, 3);
        EditSbmMa200AndMa20Lookback.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        EditSbmMa200AndMa20Lookback.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        EditSbmMa200AndMa20Lookback.Name = "EditSbmMa200AndMa20Lookback";
        EditSbmMa200AndMa20Lookback.Size = new Size(57, 23);
        EditSbmMa200AndMa20Lookback.TabIndex = 101;
        EditSbmMa200AndMa20Lookback.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // EditSbmMa200AndMa20Crossing
        // 
        EditSbmMa200AndMa20Crossing.AutoSize = true;
        EditSbmMa200AndMa20Crossing.Location = new Point(614, 309);
        EditSbmMa200AndMa20Crossing.Margin = new Padding(4, 3, 4, 3);
        EditSbmMa200AndMa20Crossing.Name = "EditSbmMa200AndMa20Crossing";
        EditSbmMa200AndMa20Crossing.Size = new Size(408, 19);
        EditSbmMa200AndMa20Crossing.TabIndex = 100;
        EditSbmMa200AndMa20Crossing.Text = "Controleer op een kruising van de ma200 en ma20 in de laatste x candles";
        EditSbmMa200AndMa20Crossing.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeSbm3Overbought
        // 
        EditAnalyzeSbm3Overbought.AutoSize = true;
        EditAnalyzeSbm3Overbought.Location = new Point(19, 514);
        EditAnalyzeSbm3Overbought.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeSbm3Overbought.Name = "EditAnalyzeSbm3Overbought";
        EditAnalyzeSbm3Overbought.Size = new Size(148, 19);
        EditAnalyzeSbm3Overbought.TabIndex = 97;
        EditAnalyzeSbm3Overbought.Text = "Maak verkoop signalen";
        EditAnalyzeSbm3Overbought.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeSbm2Overbought
        // 
        EditAnalyzeSbm2Overbought.AutoSize = true;
        EditAnalyzeSbm2Overbought.Location = new Point(19, 341);
        EditAnalyzeSbm2Overbought.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeSbm2Overbought.Name = "EditAnalyzeSbm2Overbought";
        EditAnalyzeSbm2Overbought.Size = new Size(148, 19);
        EditAnalyzeSbm2Overbought.TabIndex = 96;
        EditAnalyzeSbm2Overbought.Text = "Maak verkoop signalen";
        EditAnalyzeSbm2Overbought.UseVisualStyleBackColor = true;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(19, 392);
        label12.Margin = new Padding(4, 0, 4, 0);
        label12.Name = "label12";
        label12.Size = new Size(224, 15);
        label12.TabIndex = 94;
        label12.Text = "Percentage ten opzichte van de BB bands";
        // 
        // EditSbm2BbPercentage
        // 
        EditSbm2BbPercentage.DecimalPlaces = 2;
        EditSbm2BbPercentage.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
        EditSbm2BbPercentage.Location = new Point(274, 390);
        EditSbm2BbPercentage.Margin = new Padding(4, 3, 4, 3);
        EditSbm2BbPercentage.Name = "EditSbm2BbPercentage";
        EditSbm2BbPercentage.Size = new Size(57, 23);
        EditSbm2BbPercentage.TabIndex = 95;
        EditSbm2BbPercentage.Value = new decimal(new int[] { 50, 0, 0, 131072 });
        // 
        // panelColorSbm
        // 
        panelColorSbm.BorderStyle = BorderStyle.FixedSingle;
        panelColorSbm.Location = new Point(19, 16);
        panelColorSbm.Margin = new Padding(4, 3, 4, 3);
        panelColorSbm.Name = "panelColorSbm";
        panelColorSbm.Size = new Size(70, 22);
        panelColorSbm.TabIndex = 122;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(19, 591);
        label13.Margin = new Padding(4, 0, 4, 0);
        label13.Name = "label13";
        label13.Size = new Size(95, 15);
        label13.TabIndex = 85;
        label13.Text = "Candle lookback";
        // 
        // EditSbm3CandlesForBBRecovery
        // 
        EditSbm3CandlesForBBRecovery.Location = new Point(274, 589);
        EditSbm3CandlesForBBRecovery.Margin = new Padding(4, 3, 4, 3);
        EditSbm3CandlesForBBRecovery.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        EditSbm3CandlesForBBRecovery.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        EditSbm3CandlesForBBRecovery.Name = "EditSbm3CandlesForBBRecovery";
        EditSbm3CandlesForBBRecovery.Size = new Size(57, 23);
        EditSbm3CandlesForBBRecovery.TabIndex = 86;
        EditSbm3CandlesForBBRecovery.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(19, 567);
        label14.Margin = new Padding(4, 0, 4, 0);
        label14.Name = "label14";
        label14.Size = new Size(139, 15);
        label14.TabIndex = 83;
        label14.Text = "Percentage oprekking BB";
        // 
        // EditSbm3CandlesForBBRecoveryPercentage
        // 
        EditSbm3CandlesForBBRecoveryPercentage.Location = new Point(274, 565);
        EditSbm3CandlesForBBRecoveryPercentage.Margin = new Padding(4, 3, 4, 3);
        EditSbm3CandlesForBBRecoveryPercentage.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
        EditSbm3CandlesForBBRecoveryPercentage.Name = "EditSbm3CandlesForBBRecoveryPercentage";
        EditSbm3CandlesForBBRecoveryPercentage.Size = new Size(57, 23);
        EditSbm3CandlesForBBRecoveryPercentage.TabIndex = 84;
        EditSbm3CandlesForBBRecoveryPercentage.Value = new decimal(new int[] { 225, 0, 0, 0 });
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(19, 439);
        label11.Margin = new Padding(4, 0, 4, 0);
        label11.Name = "label11";
        label11.Size = new Size(95, 15);
        label11.TabIndex = 79;
        label11.Text = "Candle lookback";
        // 
        // EditSbm2CandlesLookbackCount
        // 
        EditSbm2CandlesLookbackCount.Location = new Point(274, 437);
        EditSbm2CandlesLookbackCount.Margin = new Padding(4, 3, 4, 3);
        EditSbm2CandlesLookbackCount.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        EditSbm2CandlesLookbackCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        EditSbm2CandlesLookbackCount.Name = "EditSbm2CandlesLookbackCount";
        EditSbm2CandlesLookbackCount.Size = new Size(57, 23);
        EditSbm2CandlesLookbackCount.TabIndex = 80;
        EditSbm2CandlesLookbackCount.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // EditAnalyzeSbm3Oversold
        // 
        EditAnalyzeSbm3Oversold.AutoSize = true;
        EditAnalyzeSbm3Oversold.Location = new Point(19, 540);
        EditAnalyzeSbm3Oversold.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeSbm3Oversold.Name = "EditAnalyzeSbm3Oversold";
        EditAnalyzeSbm3Oversold.Size = new Size(151, 19);
        EditAnalyzeSbm3Oversold.TabIndex = 69;
        EditAnalyzeSbm3Oversold.Text = "Maak aankoop signalen";
        EditAnalyzeSbm3Oversold.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeSbm2Oversold
        // 
        EditAnalyzeSbm2Oversold.AutoSize = true;
        EditAnalyzeSbm2Oversold.Location = new Point(19, 367);
        EditAnalyzeSbm2Oversold.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeSbm2Oversold.Name = "EditAnalyzeSbm2Oversold";
        EditAnalyzeSbm2Oversold.Size = new Size(151, 19);
        EditAnalyzeSbm2Oversold.TabIndex = 68;
        EditAnalyzeSbm2Oversold.Text = "Maak aankoop signalen";
        EditAnalyzeSbm2Oversold.UseVisualStyleBackColor = true;
        // 
        // tabSignalJump
        // 
        tabSignalJump.Controls.Add(label78);
        tabSignalJump.Controls.Add(label76);
        tabSignalJump.Controls.Add(label33);
        tabSignalJump.Controls.Add(label34);
        tabSignalJump.Controls.Add(label5);
        tabSignalJump.Controls.Add(EditJumpCandlesLookbackCount);
        tabSignalJump.Controls.Add(EditJumpUseLowHighCalculation);
        tabSignalJump.Controls.Add(buttonColorJump);
        tabSignalJump.Controls.Add(buttonPlaySoundCandleJumpDown);
        tabSignalJump.Controls.Add(buttonPlaySoundCandleJumpUp);
        tabSignalJump.Controls.Add(buttonSelectSoundCandleJumpDown);
        tabSignalJump.Controls.Add(panelColorJump);
        tabSignalJump.Controls.Add(EditSoundFileCandleJumpDown);
        tabSignalJump.Controls.Add(EditSoundFileCandleJumpUp);
        tabSignalJump.Controls.Add(buttonSelectSoundCandleJumpUp);
        tabSignalJump.Controls.Add(EditPlaySpeechCandleJumpSignal);
        tabSignalJump.Controls.Add(label3);
        tabSignalJump.Controls.Add(EditPlaySoundCandleJumpSignal);
        tabSignalJump.Controls.Add(EditAnalyzeCandleJumpUp);
        tabSignalJump.Controls.Add(EditAnalyzeCandleJumpDown);
        tabSignalJump.Controls.Add(EditAnalysisCandleJumpPercentage);
        tabSignalJump.Location = new Point(4, 24);
        tabSignalJump.Margin = new Padding(4, 3, 4, 3);
        tabSignalJump.Name = "tabSignalJump";
        tabSignalJump.Padding = new Padding(4, 3, 4, 3);
        tabSignalJump.Size = new Size(1232, 780);
        tabSignalJump.TabIndex = 9;
        tabSignalJump.Text = "JUMP";
        tabSignalJump.UseVisualStyleBackColor = true;
        // 
        // label78
        // 
        label78.AutoSize = true;
        label78.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        label78.Location = new Point(21, 246);
        label78.Margin = new Padding(4, 0, 4, 0);
        label78.Name = "label78";
        label78.Size = new Size(40, 13);
        label78.TabIndex = 151;
        label78.Text = "JUMP";
        // 
        // label76
        // 
        label76.AutoSize = true;
        label76.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
        label76.Location = new Point(23, 349);
        label76.Margin = new Padding(4, 0, 4, 0);
        label76.Name = "label76";
        label76.Size = new Size(72, 13);
        label76.TabIndex = 138;
        label76.Text = "Instellingen";
        // 
        // label33
        // 
        label33.AutoSize = true;
        label33.Location = new Point(20, 171);
        label33.Margin = new Padding(4, 0, 4, 0);
        label33.Name = "label33";
        label33.Size = new Size(121, 15);
        label33.TabIndex = 137;
        label33.Text = "Jump down soundfile";
        // 
        // label34
        // 
        label34.AutoSize = true;
        label34.Location = new Point(19, 145);
        label34.Margin = new Padding(4, 0, 4, 0);
        label34.Name = "label34";
        label34.Size = new Size(105, 15);
        label34.TabIndex = 136;
        label34.Text = "Jump up soundfile";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(23, 402);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(95, 15);
        label5.TabIndex = 123;
        label5.Text = "Candle lookback";
        // 
        // EditJumpCandlesLookbackCount
        // 
        EditJumpCandlesLookbackCount.Location = new Point(170, 401);
        EditJumpCandlesLookbackCount.Margin = new Padding(4, 3, 4, 3);
        EditJumpCandlesLookbackCount.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
        EditJumpCandlesLookbackCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        EditJumpCandlesLookbackCount.Name = "EditJumpCandlesLookbackCount";
        EditJumpCandlesLookbackCount.Size = new Size(57, 23);
        EditJumpCandlesLookbackCount.TabIndex = 124;
        EditJumpCandlesLookbackCount.Value = new decimal(new int[] { 8, 0, 0, 0 });
        // 
        // EditJumpUseLowHighCalculation
        // 
        EditJumpUseLowHighCalculation.AutoSize = true;
        EditJumpUseLowHighCalculation.Location = new Point(23, 430);
        EditJumpUseLowHighCalculation.Margin = new Padding(4, 3, 4, 3);
        EditJumpUseLowHighCalculation.Name = "EditJumpUseLowHighCalculation";
        EditJumpUseLowHighCalculation.Size = new Size(250, 19);
        EditJumpUseLowHighCalculation.TabIndex = 122;
        EditJumpUseLowHighCalculation.Text = "Bereken via de high/low ipv de open/close";
        EditJumpUseLowHighCalculation.UseVisualStyleBackColor = true;
        // 
        // buttonColorJump
        // 
        buttonColorJump.Location = new Point(127, 47);
        buttonColorJump.Margin = new Padding(4, 3, 4, 3);
        buttonColorJump.Name = "buttonColorJump";
        buttonColorJump.Size = new Size(88, 27);
        buttonColorJump.TabIndex = 120;
        buttonColorJump.Text = "Achtergrond";
        buttonColorJump.UseVisualStyleBackColor = true;
        // 
        // buttonPlaySoundCandleJumpDown
        // 
        buttonPlaySoundCandleJumpDown.Image = Properties.Resources.volume;
        buttonPlaySoundCandleJumpDown.Location = new Point(416, 167);
        buttonPlaySoundCandleJumpDown.Margin = new Padding(4, 3, 4, 3);
        buttonPlaySoundCandleJumpDown.Name = "buttonPlaySoundCandleJumpDown";
        buttonPlaySoundCandleJumpDown.Size = new Size(23, 23);
        buttonPlaySoundCandleJumpDown.TabIndex = 119;
        buttonPlaySoundCandleJumpDown.UseVisualStyleBackColor = true;
        // 
        // buttonPlaySoundCandleJumpUp
        // 
        buttonPlaySoundCandleJumpUp.Image = Properties.Resources.volume;
        buttonPlaySoundCandleJumpUp.Location = new Point(416, 142);
        buttonPlaySoundCandleJumpUp.Margin = new Padding(4, 3, 4, 3);
        buttonPlaySoundCandleJumpUp.Name = "buttonPlaySoundCandleJumpUp";
        buttonPlaySoundCandleJumpUp.Size = new Size(23, 23);
        buttonPlaySoundCandleJumpUp.TabIndex = 118;
        buttonPlaySoundCandleJumpUp.UseVisualStyleBackColor = true;
        // 
        // buttonSelectSoundCandleJumpDown
        // 
        buttonSelectSoundCandleJumpDown.Location = new Point(386, 167);
        buttonSelectSoundCandleJumpDown.Margin = new Padding(4, 3, 4, 3);
        buttonSelectSoundCandleJumpDown.Name = "buttonSelectSoundCandleJumpDown";
        buttonSelectSoundCandleJumpDown.Size = new Size(23, 23);
        buttonSelectSoundCandleJumpDown.TabIndex = 115;
        buttonSelectSoundCandleJumpDown.UseVisualStyleBackColor = true;
        // 
        // panelColorJump
        // 
        panelColorJump.BackColor = Color.Transparent;
        panelColorJump.BorderStyle = BorderStyle.FixedSingle;
        panelColorJump.Location = new Point(19, 50);
        panelColorJump.Margin = new Padding(4, 3, 4, 3);
        panelColorJump.Name = "panelColorJump";
        panelColorJump.Size = new Size(70, 22);
        panelColorJump.TabIndex = 121;
        // 
        // EditSoundFileCandleJumpDown
        // 
        EditSoundFileCandleJumpDown.Location = new Point(152, 167);
        EditSoundFileCandleJumpDown.Margin = new Padding(4, 3, 4, 3);
        EditSoundFileCandleJumpDown.Name = "EditSoundFileCandleJumpDown";
        EditSoundFileCandleJumpDown.Size = new Size(227, 23);
        EditSoundFileCandleJumpDown.TabIndex = 114;
        // 
        // EditSoundFileCandleJumpUp
        // 
        EditSoundFileCandleJumpUp.Location = new Point(152, 142);
        EditSoundFileCandleJumpUp.Margin = new Padding(4, 3, 4, 3);
        EditSoundFileCandleJumpUp.Name = "EditSoundFileCandleJumpUp";
        EditSoundFileCandleJumpUp.Size = new Size(227, 23);
        EditSoundFileCandleJumpUp.TabIndex = 112;
        // 
        // buttonSelectSoundCandleJumpUp
        // 
        buttonSelectSoundCandleJumpUp.Location = new Point(386, 142);
        buttonSelectSoundCandleJumpUp.Margin = new Padding(4, 3, 4, 3);
        buttonSelectSoundCandleJumpUp.Name = "buttonSelectSoundCandleJumpUp";
        buttonSelectSoundCandleJumpUp.Size = new Size(23, 23);
        buttonSelectSoundCandleJumpUp.TabIndex = 109;
        buttonSelectSoundCandleJumpUp.UseVisualStyleBackColor = true;
        // 
        // EditPlaySpeechCandleJumpSignal
        // 
        EditPlaySpeechCandleJumpSignal.AutoSize = true;
        EditPlaySpeechCandleJumpSignal.Location = new Point(19, 115);
        EditPlaySpeechCandleJumpSignal.Margin = new Padding(4, 3, 4, 3);
        EditPlaySpeechCandleJumpSignal.Name = "EditPlaySpeechCandleJumpSignal";
        EditPlaySpeechCandleJumpSignal.Size = new Size(88, 19);
        EditPlaySpeechCandleJumpSignal.TabIndex = 110;
        EditPlaySpeechCandleJumpSignal.Text = "Play speech";
        EditPlaySpeechCandleJumpSignal.UseVisualStyleBackColor = true;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(23, 371);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(98, 15);
        label3.TabIndex = 116;
        label3.Text = "Jump percentage";
        // 
        // EditPlaySoundCandleJumpSignal
        // 
        EditPlaySoundCandleJumpSignal.AutoSize = true;
        EditPlaySoundCandleJumpSignal.Location = new Point(19, 88);
        EditPlaySoundCandleJumpSignal.Margin = new Padding(4, 3, 4, 3);
        EditPlaySoundCandleJumpSignal.Name = "EditPlaySoundCandleJumpSignal";
        EditPlaySoundCandleJumpSignal.Size = new Size(84, 19);
        EditPlaySoundCandleJumpSignal.TabIndex = 108;
        EditPlaySoundCandleJumpSignal.Text = "Play sound";
        EditPlaySoundCandleJumpSignal.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeCandleJumpUp
        // 
        EditAnalyzeCandleJumpUp.AutoSize = true;
        EditAnalyzeCandleJumpUp.Location = new Point(21, 272);
        EditAnalyzeCandleJumpUp.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeCandleJumpUp.Name = "EditAnalyzeCandleJumpUp";
        EditAnalyzeCandleJumpUp.Size = new Size(160, 19);
        EditAnalyzeCandleJumpUp.TabIndex = 111;
        EditAnalyzeCandleJumpUp.Text = "Maak \"jump up\" signalen";
        EditAnalyzeCandleJumpUp.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeCandleJumpDown
        // 
        EditAnalyzeCandleJumpDown.AutoSize = true;
        EditAnalyzeCandleJumpDown.Location = new Point(21, 298);
        EditAnalyzeCandleJumpDown.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeCandleJumpDown.Name = "EditAnalyzeCandleJumpDown";
        EditAnalyzeCandleJumpDown.Size = new Size(176, 19);
        EditAnalyzeCandleJumpDown.TabIndex = 113;
        EditAnalyzeCandleJumpDown.Text = "Maak \"jump down\" signalen";
        EditAnalyzeCandleJumpDown.UseVisualStyleBackColor = true;
        // 
        // EditAnalysisCandleJumpPercentage
        // 
        EditAnalysisCandleJumpPercentage.DecimalPlaces = 2;
        EditAnalysisCandleJumpPercentage.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
        EditAnalysisCandleJumpPercentage.Location = new Point(170, 371);
        EditAnalysisCandleJumpPercentage.Margin = new Padding(4, 3, 4, 3);
        EditAnalysisCandleJumpPercentage.Name = "EditAnalysisCandleJumpPercentage";
        EditAnalysisCandleJumpPercentage.Size = new Size(56, 23);
        EditAnalysisCandleJumpPercentage.TabIndex = 117;
        // 
        // tabWhiteListOversold
        // 
        tabWhiteListOversold.Controls.Add(textBoxWhiteListOversold);
        tabWhiteListOversold.Controls.Add(panel3);
        tabWhiteListOversold.Location = new Point(4, 24);
        tabWhiteListOversold.Margin = new Padding(4, 3, 4, 3);
        tabWhiteListOversold.Name = "tabWhiteListOversold";
        tabWhiteListOversold.Padding = new Padding(4, 3, 4, 3);
        tabWhiteListOversold.Size = new Size(1232, 780);
        tabWhiteListOversold.TabIndex = 3;
        tabWhiteListOversold.Text = "WhiteList long";
        tabWhiteListOversold.UseVisualStyleBackColor = true;
        // 
        // textBoxWhiteListOversold
        // 
        textBoxWhiteListOversold.Dock = DockStyle.Fill;
        textBoxWhiteListOversold.Location = new Point(4, 60);
        textBoxWhiteListOversold.Margin = new Padding(4, 3, 4, 3);
        textBoxWhiteListOversold.Multiline = true;
        textBoxWhiteListOversold.Name = "textBoxWhiteListOversold";
        textBoxWhiteListOversold.Size = new Size(1224, 717);
        textBoxWhiteListOversold.TabIndex = 0;
        // 
        // panel3
        // 
        panel3.Controls.Add(label55);
        panel3.Dock = DockStyle.Top;
        panel3.Location = new Point(4, 3);
        panel3.Margin = new Padding(4, 3, 4, 3);
        panel3.Name = "panel3";
        panel3.Size = new Size(1224, 57);
        panel3.TabIndex = 1;
        // 
        // label55
        // 
        label55.AutoSize = true;
        label55.Location = new Point(20, 36);
        label55.Margin = new Padding(4, 0, 4, 0);
        label55.Name = "label55";
        label55.Size = new Size(308, 15);
        label55.TabIndex = 222;
        label55.Text = "(1 munt per regel met een optionele opmerking erachter)";
        // 
        // tabBlackListOversold
        // 
        tabBlackListOversold.Controls.Add(textBoxBlackListOversold);
        tabBlackListOversold.Controls.Add(panel4);
        tabBlackListOversold.Location = new Point(4, 24);
        tabBlackListOversold.Margin = new Padding(4, 3, 4, 3);
        tabBlackListOversold.Name = "tabBlackListOversold";
        tabBlackListOversold.Padding = new Padding(4, 3, 4, 3);
        tabBlackListOversold.Size = new Size(1232, 780);
        tabBlackListOversold.TabIndex = 4;
        tabBlackListOversold.Text = "Blacklist long";
        tabBlackListOversold.UseVisualStyleBackColor = true;
        // 
        // textBoxBlackListOversold
        // 
        textBoxBlackListOversold.Dock = DockStyle.Fill;
        textBoxBlackListOversold.Location = new Point(4, 60);
        textBoxBlackListOversold.Margin = new Padding(4, 3, 4, 3);
        textBoxBlackListOversold.Multiline = true;
        textBoxBlackListOversold.Name = "textBoxBlackListOversold";
        textBoxBlackListOversold.Size = new Size(1224, 717);
        textBoxBlackListOversold.TabIndex = 1;
        // 
        // panel4
        // 
        panel4.Controls.Add(label51);
        panel4.Dock = DockStyle.Top;
        panel4.Location = new Point(4, 3);
        panel4.Margin = new Padding(4, 3, 4, 3);
        panel4.Name = "panel4";
        panel4.Size = new Size(1224, 57);
        panel4.TabIndex = 2;
        // 
        // label51
        // 
        label51.AutoSize = true;
        label51.Location = new Point(20, 36);
        label51.Margin = new Padding(4, 0, 4, 0);
        label51.Name = "label51";
        label51.Size = new Size(308, 15);
        label51.TabIndex = 222;
        label51.Text = "(1 munt per regel met een optionele opmerking erachter)";
        // 
        // tabWhiteListOverbought
        // 
        tabWhiteListOverbought.Controls.Add(textBoxWhiteListOverbought);
        tabWhiteListOverbought.Controls.Add(panel5);
        tabWhiteListOverbought.Location = new Point(4, 24);
        tabWhiteListOverbought.Margin = new Padding(4, 3, 4, 3);
        tabWhiteListOverbought.Name = "tabWhiteListOverbought";
        tabWhiteListOverbought.Padding = new Padding(4, 3, 4, 3);
        tabWhiteListOverbought.Size = new Size(1232, 780);
        tabWhiteListOverbought.TabIndex = 7;
        tabWhiteListOverbought.Text = "Whitelist short";
        tabWhiteListOverbought.UseVisualStyleBackColor = true;
        // 
        // textBoxWhiteListOverbought
        // 
        textBoxWhiteListOverbought.Dock = DockStyle.Fill;
        textBoxWhiteListOverbought.Location = new Point(4, 60);
        textBoxWhiteListOverbought.Margin = new Padding(4, 3, 4, 3);
        textBoxWhiteListOverbought.Multiline = true;
        textBoxWhiteListOverbought.Name = "textBoxWhiteListOverbought";
        textBoxWhiteListOverbought.Size = new Size(1224, 717);
        textBoxWhiteListOverbought.TabIndex = 2;
        // 
        // panel5
        // 
        panel5.Controls.Add(label29);
        panel5.Dock = DockStyle.Top;
        panel5.Location = new Point(4, 3);
        panel5.Margin = new Padding(4, 3, 4, 3);
        panel5.Name = "panel5";
        panel5.Size = new Size(1224, 57);
        panel5.TabIndex = 3;
        // 
        // label29
        // 
        label29.AutoSize = true;
        label29.Location = new Point(20, 36);
        label29.Margin = new Padding(4, 0, 4, 0);
        label29.Name = "label29";
        label29.Size = new Size(308, 15);
        label29.TabIndex = 221;
        label29.Text = "(1 munt per regel met een optionele opmerking erachter)";
        // 
        // tabBlacklistOverbought
        // 
        tabBlacklistOverbought.Controls.Add(textBoxBlackListOverbought);
        tabBlacklistOverbought.Controls.Add(panel6);
        tabBlacklistOverbought.Location = new Point(4, 24);
        tabBlacklistOverbought.Margin = new Padding(4, 3, 4, 3);
        tabBlacklistOverbought.Name = "tabBlacklistOverbought";
        tabBlacklistOverbought.Padding = new Padding(4, 3, 4, 3);
        tabBlacklistOverbought.Size = new Size(1232, 780);
        tabBlacklistOverbought.TabIndex = 8;
        tabBlacklistOverbought.Text = "Blacklist short";
        tabBlacklistOverbought.UseVisualStyleBackColor = true;
        // 
        // textBoxBlackListOverbought
        // 
        textBoxBlackListOverbought.Dock = DockStyle.Fill;
        textBoxBlackListOverbought.Location = new Point(4, 60);
        textBoxBlackListOverbought.Margin = new Padding(4, 3, 4, 3);
        textBoxBlackListOverbought.Multiline = true;
        textBoxBlackListOverbought.Name = "textBoxBlackListOverbought";
        textBoxBlackListOverbought.Size = new Size(1224, 717);
        textBoxBlackListOverbought.TabIndex = 3;
        // 
        // panel6
        // 
        panel6.Controls.Add(label49);
        panel6.Dock = DockStyle.Top;
        panel6.Location = new Point(4, 3);
        panel6.Margin = new Padding(4, 3, 4, 3);
        panel6.Name = "panel6";
        panel6.Size = new Size(1224, 57);
        panel6.TabIndex = 4;
        // 
        // label49
        // 
        label49.AutoSize = true;
        label49.Location = new Point(20, 36);
        label49.Margin = new Padding(4, 0, 4, 0);
        label49.Name = "label49";
        label49.Size = new Size(308, 15);
        label49.TabIndex = 222;
        label49.Text = "(1 munt per regel met een optionele opmerking erachter)";
        // 
        // tabExtra
        // 
        tabExtra.Controls.Add(label65);
        tabExtra.Controls.Add(EditDynamicTpPercentage);
        tabExtra.Controls.Add(EditDynamicTp);
        tabExtra.Controls.Add(EditLockProfits);
        tabExtra.Controls.Add(EditTradeViaBinance);
        tabExtra.Controls.Add(label63);
        tabExtra.Controls.Add(EditSellMethod);
        tabExtra.Controls.Add(EditDoNotEnterTrade);
        tabExtra.Controls.Add(EditTradeViaPaperTrading);
        tabExtra.Controls.Add(label60);
        tabExtra.Controls.Add(EditDcaMethod);
        tabExtra.Controls.Add(label36);
        tabExtra.Controls.Add(label81);
        tabExtra.Controls.Add(label57);
        tabExtra.Controls.Add(label54);
        tabExtra.Controls.Add(label80);
        tabExtra.Controls.Add(groupBoxSlots);
        tabExtra.Controls.Add(groupBox2);
        tabExtra.Controls.Add(groupBox1);
        tabExtra.Controls.Add(EditMonitorJump);
        tabExtra.Controls.Add(EditMonitorBullishEngulfing);
        tabExtra.Controls.Add(EditAnalyzeBullishEngulfing);
        tabExtra.Controls.Add(EditAnalyzeFluxOversold);
        tabExtra.Controls.Add(EditMonitorFluxOversold);
        tabExtra.Controls.Add(EditAnalyzeSbm4Oversold);
        tabExtra.Controls.Add(EditMonitorSbm4);
        tabExtra.Controls.Add(EditBotSlopeEma20TurningPositive);
        tabExtra.Controls.Add(EditBotSlopeSma20TurningPositive);
        tabExtra.Controls.Add(EditAnalyzeSlopeEma20TurningPositive);
        tabExtra.Controls.Add(EditAnalyzeSlopeSma20TurningPositive);
        tabExtra.Controls.Add(EditBotSlopeEma50TurningPositive);
        tabExtra.Controls.Add(EditBotSlopeSma50TurningPositive);
        tabExtra.Controls.Add(EditBotPriceCrossingEma50);
        tabExtra.Controls.Add(EditBotPriceCrossingSma50);
        tabExtra.Controls.Add(EditBotPriceCrossingEma20);
        tabExtra.Controls.Add(EditBotPriceCrossingSma20);
        tabExtra.Controls.Add(label74);
        tabExtra.Controls.Add(label62);
        tabExtra.Controls.Add(EditBuyMethod);
        tabExtra.Controls.Add(EditDcaCount);
        tabExtra.Controls.Add(label67);
        tabExtra.Controls.Add(label68);
        tabExtra.Controls.Add(EditDcaFactor);
        tabExtra.Controls.Add(label69);
        tabExtra.Controls.Add(EditDcaPercentage);
        tabExtra.Controls.Add(EditGlobalStopLimitPercentage);
        tabExtra.Controls.Add(label70);
        tabExtra.Controls.Add(EditGlobalStopPercentage);
        tabExtra.Controls.Add(label71);
        tabExtra.Controls.Add(label72);
        tabExtra.Controls.Add(EditProfitPercentage);
        tabExtra.Controls.Add(label73);
        tabExtra.Controls.Add(EditGlobalBuyCooldownTime);
        tabExtra.Controls.Add(EditGlobalBuyVarying);
        tabExtra.Controls.Add(label47);
        tabExtra.Controls.Add(label46);
        tabExtra.Controls.Add(EditGlobalBuyRemoveTime);
        tabExtra.Controls.Add(EditAnalyzeSlopeEma50TurningPositive);
        tabExtra.Controls.Add(EditMonitorStobb);
        tabExtra.Controls.Add(EditMonitorSbm1);
        tabExtra.Controls.Add(EditMonitorSbm2);
        tabExtra.Controls.Add(EditMonitorSbm3);
        tabExtra.Controls.Add(EditAnalyzeSlopeSma50TurningPositive);
        tabExtra.Controls.Add(EditTradeViaAltradyWebhook);
        tabExtra.Controls.Add(EditAnalyzePriceCrossedEma50);
        tabExtra.Controls.Add(EditAnalyzePriceCrossedSma50);
        tabExtra.Controls.Add(EditAnalyzePriceCrossedEma20);
        tabExtra.Controls.Add(EditAnalyzePriceCrossedSma20);
        tabExtra.Location = new Point(4, 24);
        tabExtra.Margin = new Padding(4, 3, 4, 3);
        tabExtra.Name = "tabExtra";
        tabExtra.Padding = new Padding(4, 3, 4, 3);
        tabExtra.Size = new Size(1232, 780);
        tabExtra.TabIndex = 11;
        tabExtra.Text = "Extra";
        tabExtra.UseVisualStyleBackColor = true;
        // 
        // EditLockProfits
        // 
        EditLockProfits.AutoSize = true;
        EditLockProfits.Location = new Point(24, 513);
        EditLockProfits.Margin = new Padding(4, 3, 4, 3);
        EditLockProfits.Name = "EditLockProfits";
        EditLockProfits.Size = new Size(88, 19);
        EditLockProfits.TabIndex = 256;
        EditLockProfits.Text = "Lock profits";
        EditLockProfits.UseVisualStyleBackColor = true;
        // 
        // EditTradeViaBinance
        // 
        EditTradeViaBinance.AutoSize = true;
        EditTradeViaBinance.Location = new Point(912, 110);
        EditTradeViaBinance.Margin = new Padding(4, 3, 4, 3);
        EditTradeViaBinance.Name = "EditTradeViaBinance";
        EditTradeViaBinance.Size = new Size(109, 19);
        EditTradeViaBinance.TabIndex = 255;
        EditTradeViaBinance.Text = "Binance trading";
        EditTradeViaBinance.UseVisualStyleBackColor = true;
        // 
        // label63
        // 
        label63.AutoSize = true;
        label63.Location = new Point(24, 487);
        label63.Margin = new Padding(4, 0, 4, 0);
        label63.Name = "label63";
        label63.Size = new Size(55, 15);
        label63.TabIndex = 254;
        label63.Text = "Methode";
        // 
        // EditSellMethod
        // 
        EditSellMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        EditSellMethod.FormattingEnabled = true;
        EditSellMethod.Items.AddRange(new object[] { "Bied prijs", "Vraag prijs", "Het gemiddelde van de bied en vraag prijs", "Sma20", "Onderste Bollingerband", "Market order" });
        EditSellMethod.Location = new Point(145, 484);
        EditSellMethod.Margin = new Padding(4, 3, 4, 3);
        EditSellMethod.Name = "EditSellMethod";
        EditSellMethod.Size = new Size(140, 23);
        EditSellMethod.TabIndex = 253;
        // 
        // EditDoNotEnterTrade
        // 
        EditDoNotEnterTrade.AutoSize = true;
        EditDoNotEnterTrade.Location = new Point(912, 36);
        EditDoNotEnterTrade.Margin = new Padding(4, 3, 4, 3);
        EditDoNotEnterTrade.Name = "EditDoNotEnterTrade";
        EditDoNotEnterTrade.Size = new Size(153, 19);
        EditDoNotEnterTrade.TabIndex = 252;
        EditDoNotEnterTrade.Text = "Alleen de instap melden";
        EditDoNotEnterTrade.UseVisualStyleBackColor = true;
        // 
        // EditTradeViaPaperTrading
        // 
        EditTradeViaPaperTrading.AutoSize = true;
        EditTradeViaPaperTrading.Location = new Point(912, 85);
        EditTradeViaPaperTrading.Margin = new Padding(4, 3, 4, 3);
        EditTradeViaPaperTrading.Name = "EditTradeViaPaperTrading";
        EditTradeViaPaperTrading.Size = new Size(97, 19);
        EditTradeViaPaperTrading.TabIndex = 251;
        EditTradeViaPaperTrading.Text = "Paper trading";
        EditTradeViaPaperTrading.UseVisualStyleBackColor = true;
        // 
        // label60
        // 
        label60.AutoSize = true;
        label60.Location = new Point(17, 389);
        label60.Margin = new Padding(4, 0, 4, 0);
        label60.Name = "label60";
        label60.Size = new Size(55, 15);
        label60.TabIndex = 250;
        label60.Text = "Methode";
        // 
        // EditDcaMethod
        // 
        EditDcaMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        EditDcaMethod.FormattingEnabled = true;
        EditDcaMethod.Items.AddRange(new object[] { "Bied prijs", "Vraag prijs", "Het gemiddelde van de bied en vraag prijs", "Sma20", "Onderste Bollingerband", "Market order" });
        EditDcaMethod.Location = new Point(138, 386);
        EditDcaMethod.Margin = new Padding(4, 3, 4, 3);
        EditDcaMethod.Name = "EditDcaMethod";
        EditDcaMethod.Size = new Size(140, 23);
        EditDcaMethod.TabIndex = 249;
        // 
        // label36
        // 
        label36.AutoSize = true;
        label36.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label36.Location = new Point(18, 597);
        label36.Margin = new Padding(4, 0, 4, 0);
        label36.Name = "label36";
        label36.Size = new Size(63, 15);
        label36.TabIndex = 248;
        label36.Text = "Stopploss:";
        // 
        // label81
        // 
        label81.AutoSize = true;
        label81.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label81.Location = new Point(18, 435);
        label81.Margin = new Padding(4, 0, 4, 0);
        label81.Name = "label81";
        label81.Size = new Size(57, 15);
        label81.TabIndex = 247;
        label81.Text = "Verkoop:";
        // 
        // label57
        // 
        label57.AutoSize = true;
        label57.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label57.Location = new Point(16, 258);
        label57.Margin = new Padding(4, 0, 4, 0);
        label57.Name = "label57";
        label57.Size = new Size(52, 15);
        label57.TabIndex = 246;
        label57.Text = "Bijkoop:";
        // 
        // label54
        // 
        label54.AutoSize = true;
        label54.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label54.Location = new Point(16, 154);
        label54.Margin = new Padding(4, 0, 4, 0);
        label54.Name = "label54";
        label54.Size = new Size(59, 15);
        label54.TabIndex = 245;
        label54.Text = "Aankoop:";
        // 
        // label80
        // 
        label80.AutoSize = true;
        label80.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label80.Location = new Point(428, 392);
        label80.Margin = new Padding(4, 0, 4, 0);
        label80.Name = "label80";
        label80.Size = new Size(55, 15);
        label80.TabIndex = 240;
        label80.Text = "Monitor:";
        // 
        // groupBoxSlots
        // 
        groupBoxSlots.Controls.Add(label50);
        groupBoxSlots.Controls.Add(EditSlotsMaximalExchange);
        groupBoxSlots.Controls.Add(label52);
        groupBoxSlots.Controls.Add(EditSlotsMaximalSymbol);
        groupBoxSlots.Controls.Add(label56);
        groupBoxSlots.Controls.Add(EditSlotsMaximalBase);
        groupBoxSlots.Controls.Add(label58);
        groupBoxSlots.Controls.Add(label59);
        groupBoxSlots.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        groupBoxSlots.Location = new Point(16, 14);
        groupBoxSlots.Name = "groupBoxSlots";
        groupBoxSlots.Size = new Size(373, 116);
        groupBoxSlots.TabIndex = 244;
        groupBoxSlots.TabStop = false;
        groupBoxSlots.Text = "Slot limits";
        // 
        // label50
        // 
        label50.AutoSize = true;
        label50.Location = new Point(5, 26);
        label50.Margin = new Padding(4, 0, 4, 0);
        label50.Name = "label50";
        label50.Size = new Size(58, 15);
        label50.TabIndex = 194;
        label50.Text = "Exchange";
        // 
        // EditSlotsMaximalExchange
        // 
        EditSlotsMaximalExchange.Location = new Point(129, 24);
        EditSlotsMaximalExchange.Margin = new Padding(4, 3, 4, 3);
        EditSlotsMaximalExchange.Name = "EditSlotsMaximalExchange";
        EditSlotsMaximalExchange.Size = new Size(88, 23);
        EditSlotsMaximalExchange.TabIndex = 195;
        EditSlotsMaximalExchange.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // label52
        // 
        label52.AutoSize = true;
        label52.Location = new Point(5, 53);
        label52.Margin = new Padding(4, 0, 4, 0);
        label52.Name = "label52";
        label52.Size = new Size(47, 15);
        label52.TabIndex = 196;
        label52.Text = "Symbol";
        // 
        // EditSlotsMaximalSymbol
        // 
        EditSlotsMaximalSymbol.Location = new Point(129, 50);
        EditSlotsMaximalSymbol.Margin = new Padding(4, 3, 4, 3);
        EditSlotsMaximalSymbol.Name = "EditSlotsMaximalSymbol";
        EditSlotsMaximalSymbol.Size = new Size(88, 23);
        EditSlotsMaximalSymbol.TabIndex = 197;
        EditSlotsMaximalSymbol.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // label56
        // 
        label56.AutoSize = true;
        label56.Location = new Point(5, 80);
        label56.Margin = new Padding(4, 0, 4, 0);
        label56.Name = "label56";
        label56.Size = new Size(31, 15);
        label56.TabIndex = 198;
        label56.Text = "Base";
        // 
        // EditSlotsMaximalBase
        // 
        EditSlotsMaximalBase.Location = new Point(129, 78);
        EditSlotsMaximalBase.Margin = new Padding(4, 3, 4, 3);
        EditSlotsMaximalBase.Name = "EditSlotsMaximalBase";
        EditSlotsMaximalBase.Size = new Size(88, 23);
        EditSlotsMaximalBase.TabIndex = 199;
        EditSlotsMaximalBase.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // label58
        // 
        label58.AutoSize = true;
        label58.Location = new Point(237, 80);
        label58.Margin = new Padding(4, 0, 4, 0);
        label58.Name = "label58";
        label58.Size = new Size(109, 15);
        label58.TabIndex = 200;
        label58.Text = "ADA, AVA, XRP enz.";
        // 
        // label59
        // 
        label59.AutoSize = true;
        label59.Location = new Point(237, 50);
        label59.Margin = new Padding(4, 0, 4, 0);
        label59.Name = "label59";
        label59.Size = new Size(126, 15);
        label59.TabIndex = 201;
        label59.Text = "XRPBTC, ADAUSDT etc.";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(EditBarometer15mBotMinimal);
        groupBox2.Controls.Add(label27);
        groupBox2.Controls.Add(EditBarometer24hBotMinimal);
        groupBox2.Controls.Add(label42);
        groupBox2.Controls.Add(EditBarometer04hBotMinimal);
        groupBox2.Controls.Add(label43);
        groupBox2.Controls.Add(EditBarometer01hBotMinimal);
        groupBox2.Controls.Add(label44);
        groupBox2.Controls.Add(label45);
        groupBox2.Controls.Add(EditBarometer30mBotMinimal);
        groupBox2.Location = new Point(395, 14);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(234, 186);
        groupBox2.TabIndex = 243;
        groupBox2.TabStop = false;
        groupBox2.Text = "Barometer";
        // 
        // EditBarometer15mBotMinimal
        // 
        EditBarometer15mBotMinimal.DecimalPlaces = 2;
        EditBarometer15mBotMinimal.Location = new Point(130, 30);
        EditBarometer15mBotMinimal.Margin = new Padding(4, 3, 4, 3);
        EditBarometer15mBotMinimal.Name = "EditBarometer15mBotMinimal";
        EditBarometer15mBotMinimal.Size = new Size(88, 23);
        EditBarometer15mBotMinimal.TabIndex = 175;
        EditBarometer15mBotMinimal.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // label27
        // 
        label27.AutoSize = true;
        label27.Location = new Point(7, 33);
        label27.Margin = new Padding(4, 0, 4, 0);
        label27.Name = "label27";
        label27.Size = new Size(88, 15);
        label27.TabIndex = 173;
        label27.Text = "Barometer 15m";
        // 
        // EditBarometer24hBotMinimal
        // 
        EditBarometer24hBotMinimal.DecimalPlaces = 2;
        EditBarometer24hBotMinimal.Location = new Point(130, 138);
        EditBarometer24hBotMinimal.Margin = new Padding(4, 3, 4, 3);
        EditBarometer24hBotMinimal.Name = "EditBarometer24hBotMinimal";
        EditBarometer24hBotMinimal.Size = new Size(88, 23);
        EditBarometer24hBotMinimal.TabIndex = 179;
        EditBarometer24hBotMinimal.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // label42
        // 
        label42.AutoSize = true;
        label42.Location = new Point(9, 140);
        label42.Margin = new Padding(4, 0, 4, 0);
        label42.Name = "label42";
        label42.Size = new Size(84, 15);
        label42.TabIndex = 182;
        label42.Text = "Barometer 24h";
        // 
        // EditBarometer04hBotMinimal
        // 
        EditBarometer04hBotMinimal.DecimalPlaces = 2;
        EditBarometer04hBotMinimal.Location = new Point(130, 111);
        EditBarometer04hBotMinimal.Margin = new Padding(4, 3, 4, 3);
        EditBarometer04hBotMinimal.Name = "EditBarometer04hBotMinimal";
        EditBarometer04hBotMinimal.Size = new Size(88, 23);
        EditBarometer04hBotMinimal.TabIndex = 178;
        EditBarometer04hBotMinimal.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // label43
        // 
        label43.AutoSize = true;
        label43.Location = new Point(9, 112);
        label43.Margin = new Padding(4, 0, 4, 0);
        label43.Name = "label43";
        label43.Size = new Size(78, 15);
        label43.TabIndex = 181;
        label43.Text = "Barometer 4h";
        // 
        // EditBarometer01hBotMinimal
        // 
        EditBarometer01hBotMinimal.DecimalPlaces = 2;
        EditBarometer01hBotMinimal.Location = new Point(130, 83);
        EditBarometer01hBotMinimal.Margin = new Padding(4, 3, 4, 3);
        EditBarometer01hBotMinimal.Name = "EditBarometer01hBotMinimal";
        EditBarometer01hBotMinimal.Size = new Size(88, 23);
        EditBarometer01hBotMinimal.TabIndex = 177;
        EditBarometer01hBotMinimal.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // label44
        // 
        label44.AutoSize = true;
        label44.Location = new Point(9, 58);
        label44.Margin = new Padding(4, 0, 4, 0);
        label44.Name = "label44";
        label44.Size = new Size(88, 15);
        label44.TabIndex = 174;
        label44.Text = "Barometer 30m";
        // 
        // label45
        // 
        label45.AutoSize = true;
        label45.Location = new Point(9, 86);
        label45.Margin = new Padding(4, 0, 4, 0);
        label45.Name = "label45";
        label45.Size = new Size(78, 15);
        label45.TabIndex = 180;
        label45.Text = "Barometer 1h";
        // 
        // EditBarometer30mBotMinimal
        // 
        EditBarometer30mBotMinimal.DecimalPlaces = 2;
        EditBarometer30mBotMinimal.Location = new Point(130, 56);
        EditBarometer30mBotMinimal.Margin = new Padding(4, 3, 4, 3);
        EditBarometer30mBotMinimal.Name = "EditBarometer30mBotMinimal";
        EditBarometer30mBotMinimal.Size = new Size(88, 23);
        EditBarometer30mBotMinimal.TabIndex = 176;
        EditBarometer30mBotMinimal.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(EditMonitorInterval1h);
        groupBox1.Controls.Add(EditMonitorInterval2h);
        groupBox1.Controls.Add(EditMonitorInterval4h);
        groupBox1.Controls.Add(EditMonitorInterval1m);
        groupBox1.Controls.Add(EditMonitorInterval2m);
        groupBox1.Controls.Add(EditMonitorInterval3m);
        groupBox1.Controls.Add(EditMonitorInterval5m);
        groupBox1.Controls.Add(EditMonitorInterval10m);
        groupBox1.Controls.Add(EditMonitorInterval15m);
        groupBox1.Controls.Add(EditMonitorInterval30m);
        groupBox1.Location = new Point(636, 14);
        groupBox1.Margin = new Padding(4, 3, 4, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4, 3, 4, 3);
        groupBox1.Size = new Size(224, 218);
        groupBox1.TabIndex = 242;
        groupBox1.TabStop = false;
        groupBox1.Text = "Interval";
        // 
        // EditMonitorInterval1h
        // 
        EditMonitorInterval1h.AutoSize = true;
        EditMonitorInterval1h.Location = new Point(118, 27);
        EditMonitorInterval1h.Margin = new Padding(4, 3, 4, 3);
        EditMonitorInterval1h.Name = "EditMonitorInterval1h";
        EditMonitorInterval1h.Size = new Size(53, 19);
        EditMonitorInterval1h.TabIndex = 150;
        EditMonitorInterval1h.Text = "1 uur";
        EditMonitorInterval1h.UseVisualStyleBackColor = true;
        // 
        // EditMonitorInterval2h
        // 
        EditMonitorInterval2h.AutoSize = true;
        EditMonitorInterval2h.Location = new Point(118, 55);
        EditMonitorInterval2h.Margin = new Padding(4, 3, 4, 3);
        EditMonitorInterval2h.Name = "EditMonitorInterval2h";
        EditMonitorInterval2h.Size = new Size(53, 19);
        EditMonitorInterval2h.TabIndex = 151;
        EditMonitorInterval2h.Text = "2 uur";
        EditMonitorInterval2h.UseVisualStyleBackColor = true;
        // 
        // EditMonitorInterval4h
        // 
        EditMonitorInterval4h.AutoSize = true;
        EditMonitorInterval4h.Location = new Point(118, 82);
        EditMonitorInterval4h.Margin = new Padding(4, 3, 4, 3);
        EditMonitorInterval4h.Name = "EditMonitorInterval4h";
        EditMonitorInterval4h.Size = new Size(53, 19);
        EditMonitorInterval4h.TabIndex = 152;
        EditMonitorInterval4h.Text = "4 uur";
        EditMonitorInterval4h.UseVisualStyleBackColor = true;
        // 
        // EditMonitorInterval1m
        // 
        EditMonitorInterval1m.AutoSize = true;
        EditMonitorInterval1m.Location = new Point(14, 27);
        EditMonitorInterval1m.Margin = new Padding(4, 3, 4, 3);
        EditMonitorInterval1m.Name = "EditMonitorInterval1m";
        EditMonitorInterval1m.Size = new Size(56, 19);
        EditMonitorInterval1m.TabIndex = 143;
        EditMonitorInterval1m.Text = "1 min";
        EditMonitorInterval1m.UseVisualStyleBackColor = true;
        // 
        // EditMonitorInterval2m
        // 
        EditMonitorInterval2m.AutoSize = true;
        EditMonitorInterval2m.Location = new Point(14, 52);
        EditMonitorInterval2m.Margin = new Padding(4, 3, 4, 3);
        EditMonitorInterval2m.Name = "EditMonitorInterval2m";
        EditMonitorInterval2m.Size = new Size(56, 19);
        EditMonitorInterval2m.TabIndex = 144;
        EditMonitorInterval2m.Text = "2 min";
        EditMonitorInterval2m.UseVisualStyleBackColor = true;
        // 
        // EditMonitorInterval3m
        // 
        EditMonitorInterval3m.AutoSize = true;
        EditMonitorInterval3m.Location = new Point(14, 79);
        EditMonitorInterval3m.Margin = new Padding(4, 3, 4, 3);
        EditMonitorInterval3m.Name = "EditMonitorInterval3m";
        EditMonitorInterval3m.Size = new Size(56, 19);
        EditMonitorInterval3m.TabIndex = 145;
        EditMonitorInterval3m.Text = "3 min";
        EditMonitorInterval3m.UseVisualStyleBackColor = true;
        // 
        // EditMonitorInterval5m
        // 
        EditMonitorInterval5m.AutoSize = true;
        EditMonitorInterval5m.Location = new Point(14, 105);
        EditMonitorInterval5m.Margin = new Padding(4, 3, 4, 3);
        EditMonitorInterval5m.Name = "EditMonitorInterval5m";
        EditMonitorInterval5m.Size = new Size(56, 19);
        EditMonitorInterval5m.TabIndex = 146;
        EditMonitorInterval5m.Text = "5 min";
        EditMonitorInterval5m.UseVisualStyleBackColor = true;
        // 
        // EditMonitorInterval10m
        // 
        EditMonitorInterval10m.AutoSize = true;
        EditMonitorInterval10m.Location = new Point(14, 132);
        EditMonitorInterval10m.Margin = new Padding(4, 3, 4, 3);
        EditMonitorInterval10m.Name = "EditMonitorInterval10m";
        EditMonitorInterval10m.Size = new Size(62, 19);
        EditMonitorInterval10m.TabIndex = 147;
        EditMonitorInterval10m.Text = "10 min";
        EditMonitorInterval10m.UseVisualStyleBackColor = true;
        // 
        // EditMonitorInterval15m
        // 
        EditMonitorInterval15m.AutoSize = true;
        EditMonitorInterval15m.Location = new Point(14, 158);
        EditMonitorInterval15m.Margin = new Padding(4, 3, 4, 3);
        EditMonitorInterval15m.Name = "EditMonitorInterval15m";
        EditMonitorInterval15m.Size = new Size(62, 19);
        EditMonitorInterval15m.TabIndex = 148;
        EditMonitorInterval15m.Text = "15 min";
        EditMonitorInterval15m.UseVisualStyleBackColor = true;
        // 
        // EditMonitorInterval30m
        // 
        EditMonitorInterval30m.AutoSize = true;
        EditMonitorInterval30m.Location = new Point(14, 185);
        EditMonitorInterval30m.Margin = new Padding(4, 3, 4, 3);
        EditMonitorInterval30m.Name = "EditMonitorInterval30m";
        EditMonitorInterval30m.Size = new Size(62, 19);
        EditMonitorInterval30m.TabIndex = 149;
        EditMonitorInterval30m.Text = "30 min";
        EditMonitorInterval30m.UseVisualStyleBackColor = true;
        // 
        // EditMonitorJump
        // 
        EditMonitorJump.AutoSize = true;
        EditMonitorJump.Location = new Point(601, 578);
        EditMonitorJump.Margin = new Padding(4, 3, 4, 3);
        EditMonitorJump.Name = "EditMonitorJump";
        EditMonitorJump.Size = new Size(56, 19);
        EditMonitorJump.TabIndex = 241;
        EditMonitorJump.Text = "JUMP";
        EditMonitorJump.UseVisualStyleBackColor = true;
        // 
        // EditMonitorBullishEngulfing
        // 
        EditMonitorBullishEngulfing.AutoSize = true;
        EditMonitorBullishEngulfing.Location = new Point(431, 553);
        EditMonitorBullishEngulfing.Margin = new Padding(4, 3, 4, 3);
        EditMonitorBullishEngulfing.Name = "EditMonitorBullishEngulfing";
        EditMonitorBullishEngulfing.Size = new Size(154, 19);
        EditMonitorBullishEngulfing.TabIndex = 239;
        EditMonitorBullishEngulfing.Text = "De ema20 wordt positief";
        EditMonitorBullishEngulfing.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeBullishEngulfing
        // 
        EditAnalyzeBullishEngulfing.AutoSize = true;
        EditAnalyzeBullishEngulfing.Location = new Point(867, 547);
        EditAnalyzeBullishEngulfing.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeBullishEngulfing.Name = "EditAnalyzeBullishEngulfing";
        EditAnalyzeBullishEngulfing.Size = new Size(154, 19);
        EditAnalyzeBullishEngulfing.TabIndex = 238;
        EditAnalyzeBullishEngulfing.Text = "De ema20 wordt positief";
        EditAnalyzeBullishEngulfing.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeFluxOversold
        // 
        EditAnalyzeFluxOversold.AutoSize = true;
        EditAnalyzeFluxOversold.Location = new Point(599, 419);
        EditAnalyzeFluxOversold.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeFluxOversold.Name = "EditAnalyzeFluxOversold";
        EditAnalyzeFluxOversold.Size = new Size(142, 19);
        EditAnalyzeFluxOversold.TabIndex = 237;
        EditAnalyzeFluxOversold.Text = "Monitor flux Oversold";
        EditAnalyzeFluxOversold.UseVisualStyleBackColor = true;
        // 
        // EditMonitorFluxOversold
        // 
        EditMonitorFluxOversold.AutoSize = true;
        EditMonitorFluxOversold.Location = new Point(1054, 419);
        EditMonitorFluxOversold.Margin = new Padding(4, 3, 4, 3);
        EditMonitorFluxOversold.Name = "EditMonitorFluxOversold";
        EditMonitorFluxOversold.Size = new Size(138, 19);
        EditMonitorFluxOversold.TabIndex = 236;
        EditMonitorFluxOversold.Text = "Analyze flux oversold";
        EditMonitorFluxOversold.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeSbm4Oversold
        // 
        EditAnalyzeSbm4Oversold.AutoSize = true;
        EditAnalyzeSbm4Oversold.Location = new Point(867, 419);
        EditAnalyzeSbm4Oversold.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeSbm4Oversold.Name = "EditAnalyzeSbm4Oversold";
        EditAnalyzeSbm4Oversold.Size = new Size(148, 19);
        EditAnalyzeSbm4Oversold.TabIndex = 235;
        EditAnalyzeSbm4Oversold.Text = "Analyze SBM4 oversold";
        EditAnalyzeSbm4Oversold.UseVisualStyleBackColor = true;
        // 
        // EditMonitorSbm4
        // 
        EditMonitorSbm4.AutoSize = true;
        EditMonitorSbm4.Location = new Point(431, 419);
        EditMonitorSbm4.Margin = new Padding(4, 3, 4, 3);
        EditMonitorSbm4.Name = "EditMonitorSbm4";
        EditMonitorSbm4.Size = new Size(150, 19);
        EditMonitorSbm4.TabIndex = 234;
        EditMonitorSbm4.Text = "Monitor SBM4 oversold";
        EditMonitorSbm4.UseVisualStyleBackColor = true;
        // 
        // EditBotSlopeEma20TurningPositive
        // 
        EditBotSlopeEma20TurningPositive.AutoSize = true;
        EditBotSlopeEma20TurningPositive.Location = new Point(431, 528);
        EditBotSlopeEma20TurningPositive.Margin = new Padding(4, 3, 4, 3);
        EditBotSlopeEma20TurningPositive.Name = "EditBotSlopeEma20TurningPositive";
        EditBotSlopeEma20TurningPositive.Size = new Size(154, 19);
        EditBotSlopeEma20TurningPositive.TabIndex = 233;
        EditBotSlopeEma20TurningPositive.Text = "De ema20 wordt positief";
        EditBotSlopeEma20TurningPositive.UseVisualStyleBackColor = true;
        // 
        // EditBotSlopeSma20TurningPositive
        // 
        EditBotSlopeSma20TurningPositive.AutoSize = true;
        EditBotSlopeSma20TurningPositive.Location = new Point(601, 528);
        EditBotSlopeSma20TurningPositive.Margin = new Padding(4, 3, 4, 3);
        EditBotSlopeSma20TurningPositive.Name = "EditBotSlopeSma20TurningPositive";
        EditBotSlopeSma20TurningPositive.Size = new Size(153, 19);
        EditBotSlopeSma20TurningPositive.TabIndex = 232;
        EditBotSlopeSma20TurningPositive.Text = "De sma20 wordt positief";
        EditBotSlopeSma20TurningPositive.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeSlopeEma20TurningPositive
        // 
        EditAnalyzeSlopeEma20TurningPositive.AutoSize = true;
        EditAnalyzeSlopeEma20TurningPositive.Location = new Point(868, 522);
        EditAnalyzeSlopeEma20TurningPositive.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeSlopeEma20TurningPositive.Name = "EditAnalyzeSlopeEma20TurningPositive";
        EditAnalyzeSlopeEma20TurningPositive.Size = new Size(154, 19);
        EditAnalyzeSlopeEma20TurningPositive.TabIndex = 231;
        EditAnalyzeSlopeEma20TurningPositive.Text = "De ema20 wordt positief";
        EditAnalyzeSlopeEma20TurningPositive.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeSlopeSma20TurningPositive
        // 
        EditAnalyzeSlopeSma20TurningPositive.AutoSize = true;
        EditAnalyzeSlopeSma20TurningPositive.Location = new Point(1054, 522);
        EditAnalyzeSlopeSma20TurningPositive.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeSlopeSma20TurningPositive.Name = "EditAnalyzeSlopeSma20TurningPositive";
        EditAnalyzeSlopeSma20TurningPositive.Size = new Size(153, 19);
        EditAnalyzeSlopeSma20TurningPositive.TabIndex = 230;
        EditAnalyzeSlopeSma20TurningPositive.Text = "De sma20 wordt positief";
        EditAnalyzeSlopeSma20TurningPositive.UseVisualStyleBackColor = true;
        // 
        // EditBotSlopeEma50TurningPositive
        // 
        EditBotSlopeEma50TurningPositive.AutoSize = true;
        EditBotSlopeEma50TurningPositive.Location = new Point(431, 500);
        EditBotSlopeEma50TurningPositive.Margin = new Padding(4, 3, 4, 3);
        EditBotSlopeEma50TurningPositive.Name = "EditBotSlopeEma50TurningPositive";
        EditBotSlopeEma50TurningPositive.Size = new Size(154, 19);
        EditBotSlopeEma50TurningPositive.TabIndex = 228;
        EditBotSlopeEma50TurningPositive.Text = "De ema50 wordt positief";
        EditBotSlopeEma50TurningPositive.UseVisualStyleBackColor = true;
        // 
        // EditBotSlopeSma50TurningPositive
        // 
        EditBotSlopeSma50TurningPositive.AutoSize = true;
        EditBotSlopeSma50TurningPositive.Location = new Point(601, 503);
        EditBotSlopeSma50TurningPositive.Margin = new Padding(4, 3, 4, 3);
        EditBotSlopeSma50TurningPositive.Name = "EditBotSlopeSma50TurningPositive";
        EditBotSlopeSma50TurningPositive.Size = new Size(153, 19);
        EditBotSlopeSma50TurningPositive.TabIndex = 226;
        EditBotSlopeSma50TurningPositive.Text = "De sma50 wordt positief";
        EditBotSlopeSma50TurningPositive.UseVisualStyleBackColor = true;
        // 
        // EditBotPriceCrossingEma50
        // 
        EditBotPriceCrossingEma50.AutoSize = true;
        EditBotPriceCrossingEma50.Location = new Point(431, 474);
        EditBotPriceCrossingEma50.Margin = new Padding(4, 3, 4, 3);
        EditBotPriceCrossingEma50.Name = "EditBotPriceCrossingEma50";
        EditBotPriceCrossingEma50.Size = new Size(138, 19);
        EditBotPriceCrossingEma50.TabIndex = 225;
        EditBotPriceCrossingEma50.Text = "Price kruist de ema50";
        EditBotPriceCrossingEma50.UseVisualStyleBackColor = true;
        // 
        // EditBotPriceCrossingSma50
        // 
        EditBotPriceCrossingSma50.AutoSize = true;
        EditBotPriceCrossingSma50.Location = new Point(599, 474);
        EditBotPriceCrossingSma50.Margin = new Padding(4, 3, 4, 3);
        EditBotPriceCrossingSma50.Name = "EditBotPriceCrossingSma50";
        EditBotPriceCrossingSma50.Size = new Size(133, 19);
        EditBotPriceCrossingSma50.TabIndex = 224;
        EditBotPriceCrossingSma50.Text = "Prijs kruist de sma50";
        EditBotPriceCrossingSma50.UseVisualStyleBackColor = true;
        // 
        // EditBotPriceCrossingEma20
        // 
        EditBotPriceCrossingEma20.AutoSize = true;
        EditBotPriceCrossingEma20.Location = new Point(431, 449);
        EditBotPriceCrossingEma20.Margin = new Padding(4, 3, 4, 3);
        EditBotPriceCrossingEma20.Name = "EditBotPriceCrossingEma20";
        EditBotPriceCrossingEma20.Size = new Size(138, 19);
        EditBotPriceCrossingEma20.TabIndex = 223;
        EditBotPriceCrossingEma20.Text = "Price kruist de ema20";
        EditBotPriceCrossingEma20.UseVisualStyleBackColor = true;
        // 
        // EditBotPriceCrossingSma20
        // 
        EditBotPriceCrossingSma20.AutoSize = true;
        EditBotPriceCrossingSma20.Location = new Point(599, 449);
        EditBotPriceCrossingSma20.Margin = new Padding(4, 3, 4, 3);
        EditBotPriceCrossingSma20.Name = "EditBotPriceCrossingSma20";
        EditBotPriceCrossingSma20.Size = new Size(133, 19);
        EditBotPriceCrossingSma20.TabIndex = 221;
        EditBotPriceCrossingSma20.Text = "Prijs kruist de sma20";
        EditBotPriceCrossingSma20.UseVisualStyleBackColor = true;
        // 
        // label74
        // 
        label74.AutoSize = true;
        label74.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label74.Location = new Point(868, 386);
        label74.Margin = new Padding(4, 0, 4, 0);
        label74.Name = "label74";
        label74.Size = new Size(248, 15);
        label74.TabIndex = 220;
        label74.Text = "Analyze (aanvullend op de andere drie tabs)";
        // 
        // label62
        // 
        label62.AutoSize = true;
        label62.Location = new Point(17, 227);
        label62.Margin = new Padding(4, 0, 4, 0);
        label62.Name = "label62";
        label62.Size = new Size(55, 15);
        label62.TabIndex = 214;
        label62.Text = "Methode";
        // 
        // EditBuyMethod
        // 
        EditBuyMethod.DropDownStyle = ComboBoxStyle.DropDownList;
        EditBuyMethod.FormattingEnabled = true;
        EditBuyMethod.Items.AddRange(new object[] { "Bied prijs", "Vraag prijs", "Het gemiddelde van de bied en vraag prijs", "Sma20", "Onderste Bollingerband", "Market order" });
        EditBuyMethod.Location = new Point(138, 224);
        EditBuyMethod.Margin = new Padding(4, 3, 4, 3);
        EditBuyMethod.Name = "EditBuyMethod";
        EditBuyMethod.Size = new Size(140, 23);
        EditBuyMethod.TabIndex = 213;
        // 
        // EditDcaCount
        // 
        EditDcaCount.Location = new Point(140, 333);
        EditDcaCount.Margin = new Padding(4, 3, 4, 3);
        EditDcaCount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        EditDcaCount.Name = "EditDcaCount";
        EditDcaCount.Size = new Size(88, 23);
        EditDcaCount.TabIndex = 206;
        EditDcaCount.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // label67
        // 
        label67.AutoSize = true;
        label67.Location = new Point(18, 335);
        label67.Margin = new Padding(4, 0, 4, 0);
        label67.Name = "label67";
        label67.Size = new Size(90, 15);
        label67.TabIndex = 207;
        label67.Text = "Aantal bijkopen";
        // 
        // label68
        // 
        label68.AutoSize = true;
        label68.Location = new Point(16, 309);
        label68.Margin = new Padding(4, 0, 4, 0);
        label68.Name = "label68";
        label68.Size = new Size(81, 15);
        label68.TabIndex = 202;
        label68.Text = "Bijkoop factor";
        // 
        // EditDcaFactor
        // 
        EditDcaFactor.DecimalPlaces = 2;
        EditDcaFactor.Location = new Point(140, 307);
        EditDcaFactor.Margin = new Padding(4, 3, 4, 3);
        EditDcaFactor.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
        EditDcaFactor.Name = "EditDcaFactor";
        EditDcaFactor.Size = new Size(88, 23);
        EditDcaFactor.TabIndex = 203;
        EditDcaFactor.Value = new decimal(new int[] { 10, 0, 0, 0 });
        // 
        // label69
        // 
        label69.AutoSize = true;
        label69.Location = new Point(19, 282);
        label69.Margin = new Padding(4, 0, 4, 0);
        label69.Name = "label69";
        label69.Size = new Size(91, 15);
        label69.TabIndex = 205;
        label69.Text = "Bijkopen op (%)";
        // 
        // EditDcaPercentage
        // 
        EditDcaPercentage.DecimalPlaces = 2;
        EditDcaPercentage.Location = new Point(140, 279);
        EditDcaPercentage.Margin = new Padding(4, 3, 4, 3);
        EditDcaPercentage.Name = "EditDcaPercentage";
        EditDcaPercentage.Size = new Size(88, 23);
        EditDcaPercentage.TabIndex = 204;
        EditDcaPercentage.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // EditGlobalStopLimitPercentage
        // 
        EditGlobalStopLimitPercentage.DecimalPlaces = 2;
        EditGlobalStopLimitPercentage.Location = new Point(140, 652);
        EditGlobalStopLimitPercentage.Margin = new Padding(4, 3, 4, 3);
        EditGlobalStopLimitPercentage.Name = "EditGlobalStopLimitPercentage";
        EditGlobalStopLimitPercentage.Size = new Size(88, 23);
        EditGlobalStopLimitPercentage.TabIndex = 200;
        EditGlobalStopLimitPercentage.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // label70
        // 
        label70.AutoSize = true;
        label70.Location = new Point(19, 654);
        label70.Margin = new Padding(4, 0, 4, 0);
        label70.Name = "label70";
        label70.Size = new Size(107, 15);
        label70.TabIndex = 201;
        label70.Text = "OCO stop limit (%)";
        // 
        // EditGlobalStopPercentage
        // 
        EditGlobalStopPercentage.DecimalPlaces = 2;
        EditGlobalStopPercentage.Location = new Point(140, 623);
        EditGlobalStopPercentage.Margin = new Padding(4, 3, 4, 3);
        EditGlobalStopPercentage.Name = "EditGlobalStopPercentage";
        EditGlobalStopPercentage.Size = new Size(88, 23);
        EditGlobalStopPercentage.TabIndex = 198;
        EditGlobalStopPercentage.Value = new decimal(new int[] { 4, 0, 0, 0 });
        // 
        // label71
        // 
        label71.AutoSize = true;
        label71.Location = new Point(19, 625);
        label71.Margin = new Padding(4, 0, 4, 0);
        label71.Name = "label71";
        label71.Size = new Size(109, 15);
        label71.TabIndex = 199;
        label71.Text = "OCO stop price (%)";
        // 
        // label72
        // 
        label72.AutoSize = true;
        label72.Location = new Point(23, 459);
        label72.Margin = new Padding(4, 0, 4, 0);
        label72.Name = "label72";
        label72.Size = new Size(120, 15);
        label72.TabIndex = 194;
        label72.Text = "Winst percentage (%)";
        // 
        // EditProfitPercentage
        // 
        EditProfitPercentage.DecimalPlaces = 2;
        EditProfitPercentage.Location = new Point(147, 457);
        EditProfitPercentage.Margin = new Padding(4, 3, 4, 3);
        EditProfitPercentage.Name = "EditProfitPercentage";
        EditProfitPercentage.Size = new Size(88, 23);
        EditProfitPercentage.TabIndex = 195;
        EditProfitPercentage.Value = new decimal(new int[] { 75, 0, 0, 131072 });
        // 
        // label73
        // 
        label73.AutoSize = true;
        label73.Location = new Point(17, 362);
        label73.Margin = new Padding(4, 0, 4, 0);
        label73.Name = "label73";
        label73.Size = new Size(114, 15);
        label73.TabIndex = 197;
        label73.Text = "Cool down time (m)";
        // 
        // EditGlobalBuyCooldownTime
        // 
        EditGlobalBuyCooldownTime.Location = new Point(138, 360);
        EditGlobalBuyCooldownTime.Margin = new Padding(4, 3, 4, 3);
        EditGlobalBuyCooldownTime.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
        EditGlobalBuyCooldownTime.Name = "EditGlobalBuyCooldownTime";
        EditGlobalBuyCooldownTime.Size = new Size(88, 23);
        EditGlobalBuyCooldownTime.TabIndex = 196;
        // 
        // EditGlobalBuyVarying
        // 
        EditGlobalBuyVarying.DecimalPlaces = 2;
        EditGlobalBuyVarying.Location = new Point(139, 173);
        EditGlobalBuyVarying.Margin = new Padding(4, 3, 4, 3);
        EditGlobalBuyVarying.Maximum = new decimal(new int[] { 5, 0, 0, 65536 });
        EditGlobalBuyVarying.Minimum = new decimal(new int[] { 5, 0, 0, -2147418112 });
        EditGlobalBuyVarying.Name = "EditGlobalBuyVarying";
        EditGlobalBuyVarying.Size = new Size(88, 23);
        EditGlobalBuyVarying.TabIndex = 178;
        EditGlobalBuyVarying.Value = new decimal(new int[] { 1, 0, 0, -2147418112 });
        // 
        // label47
        // 
        label47.AutoSize = true;
        label47.Location = new Point(17, 175);
        label47.Margin = new Padding(4, 0, 4, 0);
        label47.Name = "label47";
        label47.Size = new Size(108, 15);
        label47.TabIndex = 177;
        label47.Text = "Instap verlagen (%)";
        // 
        // label46
        // 
        label46.AutoSize = true;
        label46.Location = new Point(17, 199);
        label46.Margin = new Padding(4, 0, 4, 0);
        label46.Name = "label46";
        label46.Size = new Size(77, 15);
        label46.TabIndex = 176;
        label46.Text = "Remove time";
        // 
        // EditGlobalBuyRemoveTime
        // 
        EditGlobalBuyRemoveTime.Location = new Point(138, 197);
        EditGlobalBuyRemoveTime.Margin = new Padding(4, 3, 4, 3);
        EditGlobalBuyRemoveTime.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
        EditGlobalBuyRemoveTime.Name = "EditGlobalBuyRemoveTime";
        EditGlobalBuyRemoveTime.Size = new Size(88, 23);
        EditGlobalBuyRemoveTime.TabIndex = 175;
        // 
        // EditAnalyzeSlopeEma50TurningPositive
        // 
        EditAnalyzeSlopeEma50TurningPositive.AutoSize = true;
        EditAnalyzeSlopeEma50TurningPositive.Location = new Point(868, 497);
        EditAnalyzeSlopeEma50TurningPositive.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeSlopeEma50TurningPositive.Name = "EditAnalyzeSlopeEma50TurningPositive";
        EditAnalyzeSlopeEma50TurningPositive.Size = new Size(154, 19);
        EditAnalyzeSlopeEma50TurningPositive.TabIndex = 161;
        EditAnalyzeSlopeEma50TurningPositive.Text = "De ema50 wordt positief";
        EditAnalyzeSlopeEma50TurningPositive.UseVisualStyleBackColor = true;
        // 
        // EditMonitorStobb
        // 
        EditMonitorStobb.AutoSize = true;
        EditMonitorStobb.Location = new Point(599, 603);
        EditMonitorStobb.Margin = new Padding(4, 3, 4, 3);
        EditMonitorStobb.Name = "EditMonitorStobb";
        EditMonitorStobb.Size = new Size(60, 19);
        EditMonitorStobb.TabIndex = 159;
        EditMonitorStobb.Text = "STOBB";
        EditMonitorStobb.UseVisualStyleBackColor = true;
        // 
        // EditMonitorSbm1
        // 
        EditMonitorSbm1.AutoSize = true;
        EditMonitorSbm1.Location = new Point(429, 578);
        EditMonitorSbm1.Margin = new Padding(4, 3, 4, 3);
        EditMonitorSbm1.Name = "EditMonitorSbm1";
        EditMonitorSbm1.Size = new Size(56, 19);
        EditMonitorSbm1.TabIndex = 156;
        EditMonitorSbm1.Text = "SBM1";
        EditMonitorSbm1.UseVisualStyleBackColor = true;
        // 
        // EditMonitorSbm2
        // 
        EditMonitorSbm2.AutoSize = true;
        EditMonitorSbm2.Location = new Point(428, 603);
        EditMonitorSbm2.Margin = new Padding(4, 3, 4, 3);
        EditMonitorSbm2.Name = "EditMonitorSbm2";
        EditMonitorSbm2.Size = new Size(56, 19);
        EditMonitorSbm2.TabIndex = 157;
        EditMonitorSbm2.Text = "SBM2";
        EditMonitorSbm2.UseVisualStyleBackColor = true;
        // 
        // EditMonitorSbm3
        // 
        EditMonitorSbm3.AutoSize = true;
        EditMonitorSbm3.Location = new Point(428, 628);
        EditMonitorSbm3.Margin = new Padding(4, 3, 4, 3);
        EditMonitorSbm3.Name = "EditMonitorSbm3";
        EditMonitorSbm3.Size = new Size(56, 19);
        EditMonitorSbm3.TabIndex = 158;
        EditMonitorSbm3.Text = "SBM3";
        EditMonitorSbm3.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzeSlopeSma50TurningPositive
        // 
        EditAnalyzeSlopeSma50TurningPositive.AutoSize = true;
        EditAnalyzeSlopeSma50TurningPositive.Location = new Point(1054, 497);
        EditAnalyzeSlopeSma50TurningPositive.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzeSlopeSma50TurningPositive.Name = "EditAnalyzeSlopeSma50TurningPositive";
        EditAnalyzeSlopeSma50TurningPositive.Size = new Size(153, 19);
        EditAnalyzeSlopeSma50TurningPositive.TabIndex = 125;
        EditAnalyzeSlopeSma50TurningPositive.Text = "De sma50 wordt positief";
        EditAnalyzeSlopeSma50TurningPositive.UseVisualStyleBackColor = true;
        // 
        // EditTradeViaAltradyWebhook
        // 
        EditTradeViaAltradyWebhook.AutoSize = true;
        EditTradeViaAltradyWebhook.Location = new Point(912, 60);
        EditTradeViaAltradyWebhook.Margin = new Padding(4, 3, 4, 3);
        EditTradeViaAltradyWebhook.Name = "EditTradeViaAltradyWebhook";
        EditTradeViaAltradyWebhook.Size = new Size(118, 19);
        EditTradeViaAltradyWebhook.TabIndex = 124;
        EditTradeViaAltradyWebhook.Text = "Altrady Webhook";
        EditTradeViaAltradyWebhook.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzePriceCrossedEma50
        // 
        EditAnalyzePriceCrossedEma50.AutoSize = true;
        EditAnalyzePriceCrossedEma50.Location = new Point(868, 471);
        EditAnalyzePriceCrossedEma50.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzePriceCrossedEma50.Name = "EditAnalyzePriceCrossedEma50";
        EditAnalyzePriceCrossedEma50.Size = new Size(138, 19);
        EditAnalyzePriceCrossedEma50.TabIndex = 123;
        EditAnalyzePriceCrossedEma50.Text = "Price kruist de ema50";
        EditAnalyzePriceCrossedEma50.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzePriceCrossedSma50
        // 
        EditAnalyzePriceCrossedSma50.AutoSize = true;
        EditAnalyzePriceCrossedSma50.Location = new Point(1054, 471);
        EditAnalyzePriceCrossedSma50.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzePriceCrossedSma50.Name = "EditAnalyzePriceCrossedSma50";
        EditAnalyzePriceCrossedSma50.Size = new Size(133, 19);
        EditAnalyzePriceCrossedSma50.TabIndex = 122;
        EditAnalyzePriceCrossedSma50.Text = "Prijs kruist de sma50";
        EditAnalyzePriceCrossedSma50.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzePriceCrossedEma20
        // 
        EditAnalyzePriceCrossedEma20.AutoSize = true;
        EditAnalyzePriceCrossedEma20.Location = new Point(867, 444);
        EditAnalyzePriceCrossedEma20.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzePriceCrossedEma20.Name = "EditAnalyzePriceCrossedEma20";
        EditAnalyzePriceCrossedEma20.Size = new Size(138, 19);
        EditAnalyzePriceCrossedEma20.TabIndex = 121;
        EditAnalyzePriceCrossedEma20.Text = "Price kruist de ema20";
        EditAnalyzePriceCrossedEma20.UseVisualStyleBackColor = true;
        // 
        // EditAnalyzePriceCrossedSma20
        // 
        EditAnalyzePriceCrossedSma20.AutoSize = true;
        EditAnalyzePriceCrossedSma20.Location = new Point(1054, 444);
        EditAnalyzePriceCrossedSma20.Margin = new Padding(4, 3, 4, 3);
        EditAnalyzePriceCrossedSma20.Name = "EditAnalyzePriceCrossedSma20";
        EditAnalyzePriceCrossedSma20.Size = new Size(133, 19);
        EditAnalyzePriceCrossedSma20.TabIndex = 94;
        EditAnalyzePriceCrossedSma20.Text = "Prijs kruist de sma20";
        EditAnalyzePriceCrossedSma20.UseVisualStyleBackColor = true;
        // 
        // tabExtra2
        // 
        tabExtra2.Controls.Add(textBox1);
        tabExtra2.Location = new Point(4, 24);
        tabExtra2.Name = "tabExtra2";
        tabExtra2.Padding = new Padding(3);
        tabExtra2.Size = new Size(1232, 780);
        tabExtra2.TabIndex = 12;
        tabExtra2.Text = "Extra2";
        tabExtra2.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(716, 128);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(508, 391);
        textBox1.TabIndex = 0;
        textBox1.Text = resources.GetString("textBox1.Text");
        // 
        // imageList1
        // 
        imageList1.ColorDepth = ColorDepth.Depth8Bit;
        imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
        imageList1.TransparentColor = Color.Transparent;
        imageList1.Images.SetKeyName(0, "volume.png");
        // 
        // EditDynamicTp
        // 
        EditDynamicTp.AutoSize = true;
        EditDynamicTp.Location = new Point(23, 538);
        EditDynamicTp.Margin = new Padding(4, 3, 4, 3);
        EditDynamicTp.Name = "EditDynamicTp";
        EditDynamicTp.Size = new Size(107, 19);
        EditDynamicTp.TabIndex = 257;
        EditDynamicTp.Text = "Dynamische TP";
        EditDynamicTp.UseVisualStyleBackColor = true;
        // 
        // label65
        // 
        label65.AutoSize = true;
        label65.Location = new Point(21, 566);
        label65.Margin = new Padding(4, 0, 4, 0);
        label65.Name = "label65";
        label65.Size = new Size(121, 15);
        label65.TabIndex = 258;
        label65.Text = "MA20 percentage (%)";
        // 
        // EditDynamicTpPercentage
        // 
        EditDynamicTpPercentage.DecimalPlaces = 2;
        EditDynamicTpPercentage.Location = new Point(145, 564);
        EditDynamicTpPercentage.Margin = new Padding(4, 3, 4, 3);
        EditDynamicTpPercentage.Name = "EditDynamicTpPercentage";
        EditDynamicTpPercentage.Size = new Size(88, 23);
        EditDynamicTpPercentage.TabIndex = 259;
        EditDynamicTpPercentage.Value = new decimal(new int[] { 75, 0, 0, 131072 });
        // 
        // FrmSettings
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1240, 808);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 3, 4, 3);
        Name = "FrmSettings";
        Text = "Instellingen";
        panel2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        tabControl.ResumeLayout(false);
        tabAlgemeen.ResumeLayout(false);
        tabAlgemeen.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)EditGetCandleInterval).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditGlobalDataRemoveSignalAfterxCandles).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSoundHeartBeatMinutes).EndInit();
        tabBasismunten.ResumeLayout(false);
        tabBasismunten.PerformLayout();
        tabPageSignals.ResumeLayout(false);
        tabPageSignals.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)EditAnalysisMinEffectivePercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditAnalysisMaxEffectivePercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditCandlesWithZeroVolume).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditCandlesWithFlatPrice).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditMinimumAboveBollingerBandsUpper).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditMinimumAboveBollingerBandsSma).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditMinimumTickPercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditAnalysisMinChangePercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditAnalysisMaxChangePercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSymbolMustExistsDays).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditBarometer1hMinimal).EndInit();
        groupBoxInterval.ResumeLayout(false);
        groupBoxInterval.PerformLayout();
        tabSignalStobb.ResumeLayout(false);
        tabSignalStobb.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)EditStobbBBMinPercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditStobbBBMaxPercentage).EndInit();
        tabSignalSbm.ResumeLayout(false);
        tabSignalSbm.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)EditSbm1CandlesLookbackCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmCandlesForMacdRecovery).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmBBMinPercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmBBMaxPercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmMa200AndMa20Percentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmMa50AndMa20Percentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmMa200AndMa50Percentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmMa50AndMa20Lookback).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmMa200AndMa50Lookback).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbmMa200AndMa20Lookback).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbm2BbPercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbm3CandlesForBBRecovery).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbm3CandlesForBBRecoveryPercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSbm2CandlesLookbackCount).EndInit();
        tabSignalJump.ResumeLayout(false);
        tabSignalJump.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)EditJumpCandlesLookbackCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditAnalysisCandleJumpPercentage).EndInit();
        tabWhiteListOversold.ResumeLayout(false);
        tabWhiteListOversold.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        tabBlackListOversold.ResumeLayout(false);
        tabBlackListOversold.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        tabWhiteListOverbought.ResumeLayout(false);
        tabWhiteListOverbought.PerformLayout();
        panel5.ResumeLayout(false);
        panel5.PerformLayout();
        tabBlacklistOverbought.ResumeLayout(false);
        tabBlacklistOverbought.PerformLayout();
        panel6.ResumeLayout(false);
        panel6.PerformLayout();
        tabExtra.ResumeLayout(false);
        tabExtra.PerformLayout();
        groupBoxSlots.ResumeLayout(false);
        groupBoxSlots.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)EditSlotsMaximalExchange).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSlotsMaximalSymbol).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditSlotsMaximalBase).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)EditBarometer15mBotMinimal).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditBarometer24hBotMinimal).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditBarometer04hBotMinimal).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditBarometer01hBotMinimal).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditBarometer30mBotMinimal).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)EditDcaCount).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditDcaFactor).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditDcaPercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditGlobalStopLimitPercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditGlobalStopPercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditProfitPercentage).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditGlobalBuyCooldownTime).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditGlobalBuyVarying).EndInit();
        ((System.ComponentModel.ISupportInitialize)EditGlobalBuyRemoveTime).EndInit();
        tabExtra2.ResumeLayout(false);
        tabExtra2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)EditDynamicTpPercentage).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Panel panel2;
    private Button buttonCancel;
    private Button buttonOk;
    private Panel panel1;
    private ToolTip toolTip1;
    private Button buttonTestSpeech;
    private Button buttonReset;
    private ImageList imageList1;
    private ColorDialog colorDialog1;
    private TabControl tabControl;
    private TabPage tabAlgemeen;
    private CheckBox EditHideTechnicalStuffSignals;
    private Label label6;
    private NumericUpDown EditGlobalDataRemoveSignalAfterxCandles;
    private CheckBox EditBlackTheming;
    private Button buttonFontDialog;
    private Label label18;
    private NumericUpDown EditSoundHeartBeatMinutes;
    private Label label23;
    private ComboBox EditDoubleClickAction;
    private Label label2;
    private ComboBox EditTradingApp;
    private TabPage tabBasismunten;
    private Label label19;
    private TabPage tabPageSignals;
    private Label label26;
    private CheckBox EditLogMinimumTickPercentage;
    private NumericUpDown EditMinimumTickPercentage;
    private Label label61;
    private Label label53;
    private NumericUpDown EditAnalysisMinChangePercentage;
    private NumericUpDown EditAnalysisMaxChangePercentage;
    private CheckBox EditLogBarometerToLow;
    private CheckBox EditLogSymbolMustExistsDays;
    private NumericUpDown EditSymbolMustExistsDays;
    private Label label25;
    private Label label35;
    private NumericUpDown EditBarometer1hMinimal;
    private CheckBox EditLogAnalysisMinMaxChangePercentage;
    private GroupBox groupBoxInterval;
    private CheckBox EditAnalyzeInterval6h;
    private CheckBox EditAnalyzeInterval8h;
    private CheckBox EditAnalyzeInterval12h;
    private CheckBox EditAnalyzeInterval1d;
    private CheckBox EditAnalyzeInterval5m;
    private CheckBox EditAnalyzeInterval1m;
    private CheckBox EditAnalyzeInterval2m;
    private CheckBox EditAnalyzeInterval3m;
    private CheckBox EditAnalyzeInterval10m;
    private CheckBox EditAnalyzeInterval15m;
    private CheckBox EditAnalyzeInterval30m;
    private CheckBox EditAnalyzeInterval1h;
    private CheckBox EditAnalyzeInterval2h;
    private CheckBox EditAnalyzeInterval4h;
    private TabPage tabSignalStobb;
    private Button buttonColorStobb;
    private CheckBox EditStobIncludeSbmMaLines;
    private CheckBox EditStobIncludeRsi;
    private Button buttonPlaySoundStobbOversold;
    private Button buttonPlaySoundStobbOverbought;
    private Button buttonSelectSoundStobbOversold;
    private Panel panelColorStobb;
    private TextBox EditSoundStobbOversold;
    private TextBox EditSoundStobbOverbought;
    private Button buttonSelectSoundStobbOverbought;
    private CheckBox EditPlaySpeechStobbSignal;
    private CheckBox EditPlaySoundStobbSignal;
    private CheckBox EditAnalyzeStobbOversold;
    private CheckBox EditAnalyzeStobbOverbought;
    private CheckBox EditStobbUseLowHigh;
    private Label label1;
    private NumericUpDown EditStobbBBMinPercentage;
    private NumericUpDown EditStobbBBMaxPercentage;
    private TabPage tabSignalSbm;
    private Button buttonPlaySoundSbmOversold;
    private Button buttonPlaySoundSbmOverbought;
    private Button buttonSelectSoundSbmOversold;
    private TextBox EditSoundFileSbmOversold;
    private Button buttonSelectSoundSbmOverbought;
    private TextBox EditSoundFileSbmOverbought;
    private CheckBox EditPlaySpeechSbmSignal;
    private CheckBox EditAnalyzeSbmOversold;
    private CheckBox EditAnalyzeSbmOverbought;
    private CheckBox EditPlaySoundSbmSignal;
    private Button buttonColorSbm;
    private CheckBox EditSbmUseLowHigh;
    private Label label17;
    private NumericUpDown EditSbmBBMinPercentage;
    private NumericUpDown EditSbmBBMaxPercentage;
    private Label label22;
    private Label label4;
    private NumericUpDown EditSbmMa200AndMa20Percentage;
    private Label label8;
    private NumericUpDown EditSbmMa50AndMa20Percentage;
    private Label label7;
    private NumericUpDown EditSbmMa200AndMa50Percentage;
    private NumericUpDown EditSbmMa50AndMa20Lookback;
    private CheckBox EditSbmMa50AndMa20Crossing;
    private NumericUpDown EditSbmMa200AndMa50Lookback;
    private CheckBox EditSbmMa200AndMa50Crossing;
    private NumericUpDown EditSbmMa200AndMa20Lookback;
    private CheckBox EditSbmMa200AndMa20Crossing;
    private CheckBox EditAnalyzeSbm3Overbought;
    private CheckBox EditAnalyzeSbm2Overbought;
    private Label label12;
    private NumericUpDown EditSbm2BbPercentage;
    private Panel panelColorSbm;
    private Label label13;
    private NumericUpDown EditSbm3CandlesForBBRecovery;
    private Label label14;
    private NumericUpDown EditSbm3CandlesForBBRecoveryPercentage;
    private Label label11;
    private NumericUpDown EditSbm2CandlesLookbackCount;
    private CheckBox EditAnalyzeSbm3Oversold;
    private CheckBox EditAnalyzeSbm2Oversold;
    private TabPage tabSignalJump;
    private Label label5;
    private NumericUpDown EditJumpCandlesLookbackCount;
    private CheckBox EditJumpUseLowHighCalculation;
    private Button buttonColorJump;
    private Button buttonPlaySoundCandleJumpDown;
    private Button buttonPlaySoundCandleJumpUp;
    private Button buttonSelectSoundCandleJumpDown;
    private Panel panelColorJump;
    private TextBox EditSoundFileCandleJumpDown;
    private TextBox EditSoundFileCandleJumpUp;
    private Button buttonSelectSoundCandleJumpUp;
    private CheckBox EditPlaySpeechCandleJumpSignal;
    private Label label3;
    private CheckBox EditPlaySoundCandleJumpSignal;
    private CheckBox EditAnalyzeCandleJumpUp;
    private CheckBox EditAnalyzeCandleJumpDown;
    private NumericUpDown EditAnalysisCandleJumpPercentage;
    private TabPage tabWhiteListOversold;
    private TextBox textBoxWhiteListOversold;
    private Panel panel3;
    private TabPage tabBlackListOversold;
    private TextBox textBoxBlackListOversold;
    private Panel panel4;
    private TabPage tabWhiteListOverbought;
    private TextBox textBoxWhiteListOverbought;
    private Panel panel5;
    private TabPage tabBlacklistOverbought;
    private TextBox textBoxBlackListOverbought;
    private Panel panel6;
    private Label label30;
    private Label label28;
    private Label label31;
    private Label label32;
    private Label label33;
    private Label label34;
    private Label label39;
    private NumericUpDown EditSbmCandlesForMacdRecovery;
    private Label label40;
    private ComboBox EditTrendCalculationMethod;
    private Label label41;
    private NumericUpDown EditSbm1CandlesLookbackCount;
    private Label label21;
    private Label label20;
    private Label label9;
    private CheckBox EditShowInvalidSignals;
    private TabPage tabExtra2;
    private TextBox textBox1;
    private Label label16;
    private NumericUpDown EditGetCandleInterval;
    private CheckBox EditStobIncludeSbmPercAndCrossing;
    private CheckBox EditShowFluxIndicator5m;
    private Label label29;
    private Label label55;
    private Label label51;
    private Label label49;
    private Label label24;
    private TextBox EditTelegramChatId;
    private Label label15;
    private TextBox EditTelegramToken;
    private Button ButtonTestTelegram;
    private CheckBox EditSbm2UseLowHigh;
    private NumericUpDown EditCandlesWithZeroVolume;
    private NumericUpDown EditCandlesWithFlatPrice;
    private NumericUpDown EditMinimumAboveBollingerBandsUpper;
    private NumericUpDown EditMinimumAboveBollingerBandsSma;
    private Label label77;
    private Label label75;
    private Label label78;
    private Label label76;
    private CheckBox EditCandlesWithFlatPriceCheck;
    private CheckBox EditCandlesWithZeroVolumeCheck;
    private CheckBox EditMinimumAboveBollingerBandsSmaCheck;
    private CheckBox EditMinimumAboveBollingerBandsUpperCheck;
    private Label label10;
    private Label label79;
    private Label label48;
    private Label label38;
    private Label label37;
    private TabPage tabExtra;
    private GroupBox groupBox2;
    private NumericUpDown EditBarometer15mBotMinimal;
    private Label label27;
    private NumericUpDown EditBarometer24hBotMinimal;
    private Label label42;
    private NumericUpDown EditBarometer04hBotMinimal;
    private Label label43;
    private NumericUpDown EditBarometer01hBotMinimal;
    private Label label44;
    private Label label45;
    private NumericUpDown EditBarometer30mBotMinimal;
    private GroupBox groupBox1;
    private CheckBox EditMonitorInterval1h;
    private CheckBox EditMonitorInterval2h;
    private CheckBox EditMonitorInterval4h;
    private CheckBox EditMonitorInterval1m;
    private CheckBox EditMonitorInterval2m;
    private CheckBox EditMonitorInterval3m;
    private CheckBox EditMonitorInterval5m;
    private CheckBox EditMonitorInterval10m;
    private CheckBox EditMonitorInterval15m;
    private CheckBox EditMonitorInterval30m;
    private CheckBox EditMonitorJump;
    private Label label80;
    private CheckBox EditMonitorBullishEngulfing;
    private CheckBox EditAnalyzeBullishEngulfing;
    private CheckBox EditAnalyzeFluxOversold;
    private CheckBox EditMonitorFluxOversold;
    private CheckBox EditAnalyzeSbm4Oversold;
    private CheckBox EditMonitorSbm4;
    private CheckBox EditBotSlopeEma20TurningPositive;
    private CheckBox EditBotSlopeSma20TurningPositive;
    private CheckBox EditAnalyzeSlopeEma20TurningPositive;
    private CheckBox EditAnalyzeSlopeSma20TurningPositive;
    private CheckBox EditBotSlopeEma50TurningPositive;
    private CheckBox EditBotSlopeSma50TurningPositive;
    private CheckBox EditBotPriceCrossingEma50;
    private CheckBox EditBotPriceCrossingSma50;
    private CheckBox EditBotPriceCrossingEma20;
    private CheckBox EditBotPriceCrossingSma20;
    private Label label74;
    private Label label62;
    private ComboBox EditBuyMethod;
    private NumericUpDown EditDcaCount;
    private Label label67;
    private Label label68;
    private NumericUpDown EditDcaFactor;
    private Label label69;
    private NumericUpDown EditDcaPercentage;
    private NumericUpDown EditGlobalStopLimitPercentage;
    private Label label70;
    private NumericUpDown EditGlobalStopPercentage;
    private Label label71;
    private Label label72;
    private NumericUpDown EditProfitPercentage;
    private Label label73;
    private NumericUpDown EditGlobalBuyCooldownTime;
    private NumericUpDown EditGlobalBuyVarying;
    private Label label47;
    private Label label46;
    private NumericUpDown EditGlobalBuyRemoveTime;
    private CheckBox EditAnalyzeSlopeEma50TurningPositive;
    private CheckBox EditMonitorStobb;
    private CheckBox EditMonitorSbm1;
    private CheckBox EditMonitorSbm2;
    private CheckBox EditMonitorSbm3;
    private CheckBox EditAnalyzeSlopeSma50TurningPositive;
    private CheckBox EditTradeViaAltradyWebhook;
    private CheckBox EditAnalyzePriceCrossedEma50;
    private CheckBox EditAnalyzePriceCrossedSma50;
    private CheckBox EditAnalyzePriceCrossedEma20;
    private CheckBox EditAnalyzePriceCrossedSma20;
    private Label label81;
    private Label label57;
    private Label label54;
    private GroupBox groupBoxSlots;
    private Label label50;
    private NumericUpDown EditSlotsMaximalExchange;
    private Label label52;
    private NumericUpDown EditSlotsMaximalSymbol;
    private Label label56;
    private NumericUpDown EditSlotsMaximalBase;
    private Label label58;
    private Label label59;
    private Label label36;
    private Label label60;
    private ComboBox EditDcaMethod;
    private CheckBox EditDoNotEnterTrade;
    private CheckBox EditTradeViaPaperTrading;
    private Label label63;
    private ComboBox EditSellMethod;
    private Label label64;
    private NumericUpDown EditAnalysisMinEffectivePercentage;
    private NumericUpDown EditAnalysisMaxEffectivePercentage;
    private CheckBox EditLogAnalysisMinMaxEffectivePercentage;
    private CheckBox EditTradeViaBinance;
    private CheckBox EditSendSignalsToTelegram;
    private CheckBox EditLockProfits;
    private CheckBox EditDynamicTp;
    private Label label65;
    private NumericUpDown EditDynamicTpPercentage;
}