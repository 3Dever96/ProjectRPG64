using UnityEngine;

namespace ProjectRPG64.Database
{
    [CreateAssetMenu(fileName = "StatData", menuName = "Database/StatData")]
    public class StatData : ScriptableObject
    {
        [SerializeField] string statName;
        [SerializeField] float baseValue;
        [SerializeField] float modValue;
        [SerializeField] float power;
        [SerializeField, Range(0, 11)] int ringPosition; 
        
        public float GetStatValue(CharacterClass myClass, int level)
        {
            int diff = GetRingDifference(myClass.ringPosition, ringPosition);

            float t = (level - 1) / 99f;

            float curvedT = Mathf.Pow(t, power);

            float min = baseValue - (diff * modValue);

            return Mathf.FloorToInt(Mathf.Lerp(min, 100f, curvedT));
        }

        int GetRingDifference(int posA, int posB)
        {
            int diff = Mathf.Abs(posA - posB);
            return Mathf.Min(diff, 12 - diff);
        }
    }
}
