using System;
using UnityEngine;

namespace ProjectRPG64.PlayerMovement
{
    [Serializable]
    public class PlayerGroundState : PlayerState
    {
        [SerializeField] float maxSpeed;
        [SerializeField] float accel;
        [SerializeField] float decel;
        [SerializeField] float fric;
        [SerializeField] float maxTurnAngle;

        float moveSpeed;

        public override void StartState(PlayerController player)
        {
            player.VerticalSpeed = player.StickForce;
        }

        public override void UpdateState(PlayerController player)
        {
            Vector3 direction = Camera.main.transform.right * player.Input.Move.x + Camera.main.transform.forward * player.Input.Move.y;
            direction.y = 0f;
            direction = direction.normalized;

            if (player.Input.Move != Vector2.zero)
            {
                if (Vector3.Angle(direction, player.Direction) > maxTurnAngle)
                {
                    player.CurrentSpeed -= decel * Time.deltaTime;

                    if (player.CurrentSpeed <= 0f)
                    {
                        player.CurrentSpeed = 0f;
                        player.Direction = direction;
                    }
                }
                else
                {
                    if (player.CurrentSpeed < moveSpeed)
                    {
                        player.CurrentSpeed += accel * Time.deltaTime;
                    }
                    else
                    {
                        player.CurrentSpeed = moveSpeed;
                    }

                    player.Direction = direction;
                }
            }
            else
            {
                player.CurrentSpeed -= MathF.Min(player.CurrentSpeed, fric * Time.deltaTime);
            }

            moveSpeed = maxSpeed * player.Input.Move.magnitude;

            player.FaceDirection(player.Direction, player.TurnSpeed);

            Vector3 velocity = player.Direction * player.CurrentSpeed;

            player.Velocity = velocity;
        }

        public override void ChangeState(PlayerController player)
        {
            
        }

        public override void ExitState(PlayerController player)
        {
            
        }
    }
}
