using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace SGaS
{
    internal class SGaSMod : Mod
    {
        public static SGaSMod instance;

        private SGaSSettings settings;

        internal SGaSSettings Settings
        {
            get
            {
                if (settings == null)
                {
                    settings = GetSettings<SGaSSettings>();
                }
                return settings;
            }
            set
            {
                settings = value;
            }
        }

        public SGaSMod(ModContentPack content) : base(content)
        {
            instance = this;
            this.settings = GetSettings<SGaSSettings>();
        }

        public override string SettingsCategory()
        {
            return "Small Graves And Sarcophaguses";
        }

        public override void DoSettingsWindowContents(Rect rect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.Begin(rect);
            listing_Standard.Gap();
            listing_Standard.Label("Wanzi_BodySize_Small".Translate(Math.Truncate(100 * settings.BodySizeMin) / 100).ToString(), -1f, "Wanzi_BodySize_Tooltip_Small".Translate());
            settings.BodySizeMin = listing_Standard.Slider(settings.BodySizeMin, 0f, 2f);
            listing_Standard.Gap();
            if (listing_Standard.ButtonText("Wanzi_Reset_Small".Translate()))
            {
                settings.ResetSettings();
            }
            listing_Standard.End();
        }

        
    }
}
