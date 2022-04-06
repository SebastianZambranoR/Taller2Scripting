using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss
{
    internal class SupportSkill : Card
    {
        public enum Effect_Type {ReduceAP, ReduceRP, ReduceAll, DestroyEquip, RestoreRP}
        private Effect_Type effect_Type;

        private int EffectPoints = 0;

        public SupportSkill(int costPoints, string name, Card_Rarity rarity, Effect_Type effect_Type, int effectPoints) : base(costPoints, name, rarity)
        {
            this.effect_Type = effect_Type;
            EffectPoints = effectPoints;
            if(effect_Type == Effect_Type.DestroyEquip)
                EffectPoints = 0;
        }


    }
}
