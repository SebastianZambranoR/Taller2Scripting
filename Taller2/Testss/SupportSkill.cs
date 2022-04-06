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

        private int effectPoints = 0;

        internal Effect_Type EffectType{ get => effect_Type; set => effect_Type = value; }
        public int EffectPoints { get => effectPoints; set => effectPoints = value; }

        public SupportSkill(int costPoints, string name, Card_Rarity rarity, Effect_Type effect_Type, int effectPoints) : base(costPoints, name, rarity)
        {
            this.effect_Type = effect_Type;
            this.effectPoints = effectPoints;
            if(effect_Type == Effect_Type.DestroyEquip)
                this.effectPoints = 0;
        }


    }
}
