using UnityEngine;
using Unity.Netcode;

namespace ProjectRPG64.System
{
    public class GameManager : NetworkBehaviour
    {
        public static GameManager instance;

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

            if (Application.isEditor)
            {
                if (Application.dataPath.Contains("Clone"))
                {
                    NetworkManager.Singleton.StartClient();
                }
                else
                {
                    NetworkManager.Singleton.StartHost();
                }
            }
            else
            {
                NetworkManager.Singleton.StartHost();
            }
        }
    }
}
