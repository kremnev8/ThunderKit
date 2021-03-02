﻿using ThunderKit.Core.Manifests;
using UnityEngine;

namespace ThunderKit.Integrations.Thunderstore
{
    public class ThunderstoreData : ManifestDatum
    {
        public string url;
        public TextAsset readme;
        public Texture2D icon;
    }
}