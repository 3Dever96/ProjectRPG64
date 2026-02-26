using UnityEngine;

namespace ProjectRPG64.Database
{
    [CreateAssetMenu(fileName = "ExpCurve", menuName = "Database/ExpCurve")]
    public class ExpCurve : ScriptableObject
    {
        [SerializeField] float baseValue;
        [SerializeField] float expo;

        public float GetExpAtLevel(int lvl)
        {
            return Mathf.FloorToInt(baseValue * Mathf.Pow(lvl - 1, expo));
        }
    }
}
