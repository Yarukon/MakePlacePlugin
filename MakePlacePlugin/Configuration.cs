﻿using System;
using System.Collections.Generic;
using Dalamud.Configuration;
using Dalamud.Plugin;
using MakePlacePlugin.Objects;

namespace MakePlacePlugin
{
    [Serializable]
    public class Configuration : IPluginConfiguration
    {
        public int Version { get; set; } = 0;

        public bool ShowTooltips = true;
        public bool DrawScreen = false;
        public float DrawDistance = 0;
        public List<int> HiddenScreenItemHistory = new List<int>();
        public List<int> GroupingList = new List<int>();
        public bool PlaceAnywhere = false;

        public bool Basement = true;
        public bool GroundFloor = true;
        public bool UpperFloor = true;


        public List<string> Tags = new List<string>();
        public List<bool> TagsSelectList = new List<bool>();
        public int LocationId = 0;
        public int LoadInterval = 400;

        public int LoadIntervalRndMin = 0;
        public int LoadIntervalRndMax = 500;

        public string SaveLocation = null;

        #region Init and Save

        [NonSerialized] private DalamudPluginInterface _pluginInterface;

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            _pluginInterface = pluginInterface;
        }

        public void Save()
        {
            _pluginInterface.SavePluginConfig(this);
        }

        public void ResetRecord()
        {
            HiddenScreenItemHistory.Clear();
            GroupingList.Clear();
            Save();
        }

        #endregion
    }
}
