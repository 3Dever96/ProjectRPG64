using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ProjectRPG64.System
{
    [RequireComponent (typeof (PlayerInput))]
    public class InputManager : NetworkBehaviour
    {
        public Vector2 Move { get { return move; } }

        PlayerInput input;

        [SerializeField] Vector2 move;

        public override void OnNetworkSpawn()
        {
            if (input == null)
            {
                input = GetComponent<PlayerInput>();
            }

            input.onActionTriggered += OnAction;
        }

        public override void OnNetworkDespawn()
        {
            input.onActionTriggered -= OnAction;
        }

        void OnAction(InputAction.CallbackContext context)
        {
            if (IsOwner)
            {
                switch (context.action.name)
                {
                    case "Move":
                        move = context.ReadValue<Vector2>();
                        break;
                }
            }
        }
    }
}
