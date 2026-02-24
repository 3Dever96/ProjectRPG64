using System;
using UnityEngine;

namespace ProjectRPG64.PlayerMovement
{
    [Serializable]
    public class PlayerAirState : PlayerState
    {
        [SerializeField] float fallSpeed;

        Vector3 velocity;

        public override void StartState(PlayerController player)
        {
            velocity = player.Velocity;
        }

        public override void UpdateState(PlayerController player)
        {
            player.FaceDirection(player.Direction, player.TurnSpeed);

            if (!player.Input.Jump || Physics.CheckSphere(player.transform.position + Vector3.up * player.Controller.height, player.Controller.radius - 0.01f, LayerMask.GetMask("Solid")))
            {
                player.VerticalSpeed = Mathf.Min(0f, player.VerticalSpeed);
            }

            if (player.VerticalSpeed > fallSpeed)
            {
                player.VerticalSpeed += player.Gravity * Time.deltaTime;
            }

            velocity = player.Direction * player.CurrentSpeed;
            velocity.y = player.VerticalSpeed;

            player.Velocity = velocity;
        }

        public override void ChangeState(PlayerController player)
        {
            if (player.VerticalSpeed <= 0f && Physics.CheckSphere(player.transform.position, player.Controller.radius - 0.01f, LayerMask.GetMask("Solid")))
            {
                player.SetState(player.GroundState);
            }
        }

        public override void ExitState(PlayerController player)
        {
            
        }
    }
}
