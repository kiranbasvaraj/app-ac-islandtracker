﻿using System;
using System.Linq;
using MvvmHelpers;
using Newtonsoft.Json;

namespace TurnipTracker.Model
{
    public class Day : ObservableObject
    {
        [JsonIgnore]
        public Action SaveCurrentWeekAction { get; set; }

        public string DayLong { get; set; }

        [JsonIgnore]
        public string DayShort => DayLong.FirstOrDefault().ToString();

        bool firstPurchase;
        public bool FirstPurchase
        {
            get => firstPurchase;
            set => SetProperty(ref firstPurchase, value, onChanged: SaveCurrentWeekAction);
        }

        int lastWeekPattern = (int)PredictionPattern.IDontKnow;
        public int LastWeekPattern
        {
            get => lastWeekPattern;
            set => SetProperty(ref lastWeekPattern, value, onChanged: SaveCurrentWeekAction);
        }

        int? buyPrice;

        public int? BuyPrice
        {
            get => buyPrice;
            set => SetProperty(ref buyPrice, value, onChanged: SaveCurrentWeekAction);
        }

        int? priceAM;

        public int? PriceAM
        {
            get => priceAM;
            set => SetProperty(ref priceAM, value, onChanged: SaveCurrentWeekAction);
        }

        int? pricePM;
        public int? PricePM
        {
            get => pricePM;
            set => SetProperty(ref pricePM, value, onChanged: SaveCurrentWeekAction);
        }

        string predictionAM = string.Empty;
        public string PredictionAM
        {
            get => predictionAM;
            set => SetProperty(ref predictionAM, value);
        }

        string predictionPM = string.Empty;
        public string PredictionPM
        {
            get => predictionPM;
            set => SetProperty(ref predictionPM, value);
        }

        bool isSelectedDay;
        [JsonIgnore]
        public bool IsSelectedDay
        {
            get => isSelectedDay;
            set => SetProperty(ref isSelectedDay, value);
        }

        public bool IsSunday { get; set; }

        [JsonIgnore]
        public bool IsNotSunday => !IsSunday;
    }
}
