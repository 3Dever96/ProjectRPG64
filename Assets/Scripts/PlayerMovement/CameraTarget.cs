using UnityEngine;

namespace ProjectRPG64.PlayerMovement
{
    public class CameraTarget : MonoBehaviour
    {
        Transform target;

        void Update()
        {
            if (target != null)
            {
                transform.position = target.position;
            }
        }

        public void SetTarget(Transform newTarget)
        {
            target = newTarget;
        }
    }
}
