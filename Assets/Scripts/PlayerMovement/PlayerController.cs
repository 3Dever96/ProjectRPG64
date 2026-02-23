using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;
using ProjectRPG64.System;

namespace ProjectRPG64.PlayerMovement
{
    [RequireComponent(typeof(NetworkObject)), RequireComponent(typeof(PlayerInput)), RequireComponent(typeof(CharacterController))]
    public class PlayerController : NetworkBehaviour
    {

    }
}
