﻿using CryptoSbmScanner.Model;
using System.Text.Json.Serialization;

namespace CryptoSbmScanner.Settings;

[Serializable]
public class SettingsSignal
{
    /// Is het signal algoritme actief
    public bool SoundsActive { get; set; } = true;
    public bool SignalsActive { get; set; } = true;

    public int RemoveSignalAfterxCandles { get; set; } = 15;
    public bool HideTechnicalStuffSignals { get; set; } = false;

    public bool ShowInvalidSignals { get; set; } = false;

    public int SoundHeartBeatMinutes { get; set; } = 0;
    public string SoundHeartBeat { get; set; } = "sound-heart-beat.wav";

    // Minimale 1h barometer om de meldingen te tonen (van - 1.5 tot hoger of iets dergelijks, en te hoog (>5) is eigenlijk ook niet goed)
    public decimal Barometer1hMinimal { get; set; } = -99m;
    public bool LogBarometerToLow { get; set; } = false;

    // Aantal dagen dat de munt moet bestaan
    public decimal SymbolMustExistsDays { get; set; } = 15;
    public bool LogSymbolMustExistsDays { get; set; } = false;

    // Vermijden van "barcode" charts
    public decimal MinimumTickPercentage { get; set; } = 0.4m;
    public bool LogMinimumTickPercentage { get; set; } = false;

    // de 24 en 48 uur change moet binnen dit interval zitten
    public double AnalysisMinChangePercentage { get; set; } = -50;
    public double AnalysisMaxChangePercentage { get; set; } = 50;
    public bool LogAnalysisMinMaxChangePercentage { get; set; } = true;


    // STOBB signals
    // Het BB percentage kan via de user interface uit worden gezet (nomargin)
    public double StobbBBMinPercentage { get; set; } = 1.50;
    public double StobbBBMaxPercentage { get; set; } = 5.0;
    public bool StobbUseLowHigh { get; set; } = false;

    [JsonConverter(typeof(Intern.ColorConverter))]
    public Color ColorStobb { get; set; } = Color.White;
    public bool PlaySoundStobbSignal { get; set; } = false;
    public bool PlaySpeechStobbSignal { get; set; } = false;
    public bool AnalysisShowStobbOversold { get; set; } = true;
    public string SoundStobbOversold { get; set; } = "sound-stobb-oversold.wav";
    public bool AnalysisShowStobbOverbought { get; set; } = false;
    public string SoundStobbOverbought { get; set; } = "sound-stobb-overbought.wav";
    public bool StobIncludeRsi { get; set; } = false;
    public bool StobIncludeSoftSbm { get; set; } = false;

    // SBM1 signals
    // Het BB percentage kan via de user interface uit worden gezet (nomargin)
    public double SbmBBMinPercentage { get; set; } = 1.50;
    public double SbmBBMaxPercentage { get; set; } = 100.0;
    public bool SbmUseLowHigh { get; set; } = false;

    [JsonConverter(typeof(Intern.ColorConverter))]
    public Color ColorSbm { get; set; } = Color.White;
    public bool PlaySoundSbmSignal { get; set; } = true;
    public bool PlaySpeechSbmSignal { get; set; } = true;
    public bool AnalysisShowSbmOversold { get; set; } = true;
    public string SoundSbmOversold { get; set; } = "sound-sbm-oversold.wav";
    public bool AnalysisShowSbmOverbought { get; set; } = false;
    public string SoundSbmOverbought { get; set; } = "sound-sbm-overbought.wav";
    public int Sbm1CandlesLookbackCount { get; set; } = 1;

    // SBM2 signals
    public bool AnalysisSbm2Oversold { get; set; } = false;
    public bool AnalysisSbm2Overbought { get; set; } = false;
    public int Sbm2CandlesLookbackCount { get; set; } = 2;
    public decimal Sbm2UpperPartOfBbPercentage { get; set; } = 00.50m;
    public decimal Sbm2LowerPartOfBbPercentage { get; set; } = 99.50m;

    // SBM3 signals
    public bool AnalysisSbm3Oversold { get; set; } = false;
    public bool AnalysisSbm3Overbought { get; set; } = false;
    public int Sbm3CandlesLookbackCount { get; set; } = 8;
    public decimal Sbm3CandlesBbRecoveryPercentage { get; set; } = 225m;

    // SBM4 signals
    //public bool AnalysisSbm4Oversold { get; set; } = false;
    //public bool AnalysisSbm4Overbought { get; set; } = false;
    //public decimal Sbm4BbPercent { get; set; } = 1.5m;
    //public decimal Sbm4Percentage { get; set; } = 0.80m;
    //public int Sbm4CandlesLookback { get; set; } = 2;

    // SBM5 signals
    //public bool AnalysisSbm5Oversold { get; set; } = false;

    // SBM algemene instellingen recovery, percentages, crossing && lookback
    public int SbmCandlesForMacdRecovery { get; set; } = 2;

    public decimal SbmMa200AndMa50Percentage { get; set; } = 0.3m;
    public decimal SbmMa50AndMa20Percentage { get; set; } = 0.3m;
    public decimal SbmMa200AndMa20Percentage { get; set; } = 0.7m;

    public bool SbmMa200AndMa50Crossing { get; set; } = true;
    public int SbmMa200AndMa50Lookback { get; set; } = 20;
    public bool SbmMa50AndMa20Crossing { get; set; } = true;
    public int SbmMa50AndMa20Lookback { get; set; } = 10;
    public bool SbmMa200AndMa20Crossing { get; set; } = true;
    public int SbmMa200AndMa20Lookback { get; set; } = 20;


    // JUMP
    [JsonConverter(typeof(Intern.ColorConverter))]
    public Color ColorJump { get; set; } = Color.White;
    public bool PlaySoundCandleJumpSignal { get; set; } = false;
    public bool PlaySpeechCandleJumpSignal { get; set; } = false;
    public bool AnalysisShowCandleJumpDown { get; set; } = false;
    public bool JumpUseLowHighCalculation { get; set; } = false;
    public int JumpCandlesLookbackCount { get; set; } = 1;
    public string SoundCandleJumpDown { get; set; } = "sound-jump-down.wav";
    public bool AnalysisShowCandleJumpUp { get; set; } = false;
    public string SoundCandleJumpUp { get; set; } = "sound-jump-up.wav";
    public decimal AnalysisCandleJumpPercentage { get; set; } = 2.5m;


    // Logging
    public bool LogMinimalVolume { get; set; } = false;
    public bool LogMinimalPrice { get; set; } = false;
    public bool LogNotEnoughCandles { get; set; }

    // Fine tuning (later)
    public int AboveBollingerBandsSma { get; set; } = 0;
    public bool LogAboveBollingerBandsSma { get; set; } = false;

    // Fine tuning (later)
    public int AboveBollingerBandsUpper { get; set; } = 0;
    public bool LogAboveBollingerBandsUpper { get; set; } = false;

    // Fine tuning (later)
    // Candles zonder volume
    public int CandlesWithZeroVolume { get; set; } = 0;
    public bool LogCandlesWithZeroVolume { get; set; } = false;

    // Fine tuning (later)
    // De zogenaamde platte candles
    public int CandlesWithFlatPrice { get; set; } = 0;
    public bool LogCandlesWithFlatPrice { get; set; } = false;


    // Welke intervallen willen we analyseren?
    public bool[] AnalyseInterval { get; set; } = new bool[Enum.GetNames(typeof(CryptoIntervalPeriod)).Length];
    // Welke strategieën willen we analyseren?
    public bool[] AnalyseStrategy { get; set; } = new bool[Enum.GetNames(typeof(SignalStrategy)).Length];

    // For me..
    public bool AltradyWebhookActive { get; set; } = false;



    public SettingsSignal()
    {
        AnalyseInterval[(int)CryptoIntervalPeriod.interval1m] = true;
        AnalyseInterval[(int)CryptoIntervalPeriod.interval2m] = true;
        AnalyseInterval[(int)CryptoIntervalPeriod.interval3m] = true;
    }
}