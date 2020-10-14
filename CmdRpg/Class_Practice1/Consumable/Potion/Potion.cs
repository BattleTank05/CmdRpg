using The_Dragon_Lair_SoloRPG.Equipment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace The_Dragon_Lair_SoloRPG.Consumable.Potion
{
    public class Potion : Consumables
    {
        public int damage;
        public int maxFireApplication;
        public int potionLevel;
        public int potionNumber;
        public Potion(string itemName, int number) : base(itemName)
        {
            potionNumber = number;
        }
        public void PotionEffect(string effectType, Entity target, int change) 
        {
            switch (effectType) 
            {
                case "healing":
                    target.Health = EffectHealing(target, change);
                    break;
                case "fire":
                    EffectDamage("fire", target, change);
                    break;
            }
        }
        public int EffectHealing(Entity target, int change) 
        {
            return target.EntityStatClamp(target, "Health", change);
        }
        public int EffectDamage(string damageType, Entity target, int change) 
        {
            switch (damageType) 
            {
                case "fire":
                    target.entityOnFire += GetRandom(-1, maxFireApplication);
                    return target.EntityStatClamp(target, "Health", change);
            }
            return target.Health;
        }
        static int GetRandom(int min, int max) 
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
