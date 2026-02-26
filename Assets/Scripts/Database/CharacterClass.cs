using System.Collections.Generic;
using UnityEngine;

namespace ProjectRPG64.Database
{
    [CreateAssetMenu(fileName = "CharacterClass", menuName = "Database/CharacterClass")]
    public class CharacterClass : ScriptableObject
    {
        [Header("General Information")]
        public string className;
        public Sprite classIcon;
        [Range(0, 11)] public int ringPosition;

        [Header("Equipment")]
        public List<ArmorType> armorTypes;
        public List<WeaponType> weaponTypes;
    }
}
