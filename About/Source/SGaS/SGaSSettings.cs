using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace SGaS
{
    internal class SGaSSettings : ModSettings
    {
        
        public float BodySizeMin = 0.50f;//minimum body isze to be consudered a "big" corpse
        
        public override void ExposeData()
        {            
            Scribe_Values.Look(ref BodySizeMin, "BodySizeMin", 0.50f);
            base.ExposeData();
        }

        public void ResetSettings()
        {
            BodySizeMin = 0.50f;
        }
    }
}
