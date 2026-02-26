using System.Collections.Generic;
using UnityEngine;

namespace ProjectRPG64.Database
{
    [CreateAssetMenu(fileName = "Database", menuName = "Database/Database")]
    public class Database : ScriptableObject
    {
        [Header("Class Data")]
        public List<CharacterClass> classes;

        [Header("Exp Curve")]
        public ExpCurve expCurve;

        [Header("Stats")]
        public StatData hp;
        public StatData mp;
        public StatData sp;
        public StatData atk;
        public StatData def;
        public StatData mAtk;
        public StatData mDef;
        public StatData agi;
        public StatData crit;
        public StatData wis;
        public StatData cha;
        public StatData kno;
    }
}
