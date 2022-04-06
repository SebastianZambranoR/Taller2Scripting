using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss
{
    class Character: Card, IEffect, IEquip
    {
        private int attackPoints;
        private int resistPoints;
        public enum C_Affinity { Knight, Mage, Undead };
        private C_Affinity affinity;
        public List<Equip> characterEquip = new List<Equip>();
        public Character(int costPoints, string name, Card_Rarity rarity, int attackPoints, int resistPoints) : base(costPoints, name, rarity)
        {
            this.attackPoints = attackPoints;
            this.resistPoints = resistPoints;
        }

        public int AttackPoints { get => attackPoints + getEquipAttackPoints(); }
        public int ResistPoints { get => resistPoints + getEquipResistPoints(); }
        public C_Affinity Affinity { get => affinity; set => affinity = value; }

        public void ApplyEffect(SupportSkill card)
        {
            switch (card.EffectType)
            {
                case SupportSkill.Effect_Type.ReduceAP:
                    attackPoints -= card.EffectPoints;
                    break;
                case SupportSkill.Effect_Type.ReduceRP:
                    resistPoints -= card.EffectPoints;
                    break;
                case SupportSkill.Effect_Type.ReduceAll:
                    attackPoints -= card.EffectPoints;
                    resistPoints -= card.EffectPoints;
                    break;
                case SupportSkill.Effect_Type.RestoreRP:
                    resistPoints += card.EffectPoints;
                    break;
                case SupportSkill.Effect_Type.DestroyEquip:
                    break;

            }
        }

        public void AddEquip(Equip equip)
        {
            if(characterEquip.Count < 3)
            {
                if(equip.Affinity.ToString() == affinity.ToString() || equip.Affinity.ToString() == "All")
                    characterEquip.Add(equip);
            }
        }

        public void DestroyEquip(Equip equip)
        {
            if (characterEquip.Contains(equip))
            {
                characterEquip.Remove(equip);
            }
        }

        int getEquipAttackPoints()
        {
            int amount = 0;
            for (int i = 0; i < characterEquip.Count; i++)
            {
                if (characterEquip[i].Target_Attribute1.ToString() == "AP" || characterEquip[i].Target_Attribute1.ToString() == "ALL")
                    amount++;
            }

            return amount;
        }

        int getEquipResistPoints()
        {
            int amount = 0;
            for (int i = 0; i < characterEquip.Count; i++)
            {
                if (characterEquip[i].Target_Attribute1.ToString() == "RP" || characterEquip[i].Target_Attribute1.ToString() == "ALL")
                    amount++;
            }

            return amount;
        }
    }
}
