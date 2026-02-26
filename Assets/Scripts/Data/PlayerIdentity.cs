using UnityEngine;
using ProjectRPG64.Database;

namespace ProjectRPG64.Data
{
    public class PlayerIdentity : MonoBehaviour
    {
        [SerializeField, Range(1, 100)] int currentLevel;

        [SerializeField, Range(0, 11)] int classIndex;
        [SerializeField] float nextExp;

        [SerializeField] float maxHp;
        [SerializeField] float maxMp;
        [SerializeField] float maxSp;
        [SerializeField] float atk;
        [SerializeField] float def;
        [SerializeField] float mAtk;
        [SerializeField] float mDef;
        [SerializeField] float agi;
        [SerializeField] float crit;
        [SerializeField] float wis;
        [SerializeField] float cha;
        [SerializeField] float kno;

        int lasLevel;
        int lastClass;

        void Start()
        {
            SetData();
        }

        private void Update()
        {
            if (lasLevel != currentLevel || lastClass != classIndex)
            {
                SetData();
                lasLevel = currentLevel;
                lastClass = classIndex;
            }
        }

        void SetData()
        {
            Database.Database database = DatabaseManager.instance.database;

            nextExp = database.expCurve.GetExpAtLevel(currentLevel + 1);

            maxHp = database.hp.GetStatValue(database.classes[classIndex], currentLevel);
            maxMp = database.mp.GetStatValue(database.classes[classIndex], currentLevel);
            maxSp = database.sp.GetStatValue(database.classes[classIndex], currentLevel);
            atk = database.atk.GetStatValue(database.classes[classIndex], currentLevel);
            def = database.def.GetStatValue(database.classes[classIndex], currentLevel);
            mAtk = database.mAtk.GetStatValue(database.classes[classIndex], currentLevel);
            mDef = database.mDef.GetStatValue(database.classes[classIndex], currentLevel);
            agi = database.agi.GetStatValue(database.classes[classIndex], currentLevel);
            crit = database.crit.GetStatValue(database.classes[classIndex], currentLevel);
            wis = database.wis.GetStatValue(database.classes[classIndex], currentLevel);
            cha = database.cha.GetStatValue(database.classes[classIndex], currentLevel);
            kno = database.kno.GetStatValue(database.classes[classIndex], currentLevel);
        }
    }
}
