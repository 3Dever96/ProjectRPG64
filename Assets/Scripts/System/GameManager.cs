using UnityEngine;
using Unity.Netcode;

namespace ProjectRPG64.System
{
    public class GameManager : NetworkBehaviour
    {
        public static GameManager instance;

        void Awake()
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

            NetworkManager.Singleton.StartHost();
        }
    }
}
