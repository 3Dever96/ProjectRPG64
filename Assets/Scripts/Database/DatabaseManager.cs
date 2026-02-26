using UnityEngine;

namespace ProjectRPG64.Database
{
    public class DatabaseManager : MonoBehaviour
    {
        public static DatabaseManager instance;
        public Database database;

        void Start()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                if (instance != this)
                {
                    Destroy(gameObject);
                }
            }

            DontDestroyOnLoad(gameObject);
        }
    }
}
