using Unity.Netcode;
using UnityEngine;
using ProjectRPG64.System;

namespace ProjectRPG64.PlayerMovement
{
    [RequireComponent(typeof(NetworkObject)), RequireComponent(typeof(InputManager)), RequireComponent(typeof(CharacterController))]
    public class PlayerController : NetworkBehaviour
    {
        // References
        public CharacterController Controller {  get; private set; }
        public InputManager Input {  get; private set; }

        // Movement Variables
        public float CurrentSpeed { get; set; }
        public float VerticalSpeed {  get; set; }
        public Vector3 Direction { get; set;}
        public Vector3 Velocity {  get; set; }

        public float StickForce { get { return stickForce; } }
        public float Gravity { get { return gravity; } }
        public float JumpSpeed { get { return jumpSpeed; } }
        public float TurnSpeed { get { return turnSpeed; } }

        // State Machine
        public PlayerState CurrentState { get; private set; }
        public PlayerGroundState GroundState { get { return groundState; } }
        public PlayerAirState AirState { get { return airState; } }

        [Header("Univeral Variables")]
        [SerializeField] float stickForce;
        [SerializeField] float gravity;
        [SerializeField] float jumpSpeed;
        [SerializeField] float turnSpeed;

        // States
        [SerializeField] PlayerGroundState groundState = new PlayerGroundState();
        [SerializeField] PlayerAirState airState = new PlayerAirState();

        void Start()
        {
            // Assign References
            Controller = GetComponent<CharacterController>();
            Input = GetComponent<InputManager>();

            // Set Default Direction
            Direction = transform.forward;

            // Set Camera Target
            if (IsOwner)
            {
                FindFirstObjectByType<CameraTarget>().SetTarget(transform);
            }

            // Initialize State Machine
            SetState(groundState);
        }

        void FixedUpdate()
        {
            if (IsOwner)
            {
                if (CurrentState != null)
                {
                    CurrentState.UpdateState(this);
                    CurrentState.ChangeState(this);
                }

                Controller.Move(Velocity * Time.deltaTime);
            }
        }

        public void SetState(PlayerState newState)
        {
            if (CurrentState != null)
            {
                CurrentState.ExitState(this);
            }

            CurrentState = newState;

            if (CurrentState != null)
            {
                CurrentState.StartState(this);
            }
        }

        public void FaceDirection(Vector3 direction, float speed)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction), speed * Time.deltaTime);
        }
    }
}
