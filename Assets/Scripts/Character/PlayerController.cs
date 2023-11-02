using UnityEngine;
using UnityEngine.InputSystem;

namespace SOS.AndrewsAdventure.Character
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float sprintMultiplier = 2f;
        [SerializeField] float walkSpeed = 5f;
        [SerializeField] float jumpSpeed = 3f;

        public bool CanMove { get; set; }

        CharacterController controller;

        private const float gravityValue = -9.8f;
        private float speedMultiplier = 1f;
        private Vector3 movementComposite = Vector3.zero;

        void Start()
        {
            CanMove = true;
            controller = GetComponent<CharacterController>();
        }

        void Update()
        {
            if (CanMove)
            {
                controller.Move(movementComposite * walkSpeed * speedMultiplier * Time.deltaTime);
                movementComposite.y += gravityValue * Time.deltaTime;
            }
        }

        public void OnMovement(InputAction.CallbackContext value)
        {
            Vector3 movement = value.ReadValue<Vector3>();
            movementComposite = new Vector3(movement.x, movementComposite.y, movement.z);
        }

        public void OnJump(InputAction.CallbackContext value)
        {
            if (controller.isGrounded)
            {
                movementComposite.y = jumpSpeed; ;
            }
        }

        public void OnSprint(InputAction.CallbackContext value)
        {
            if (value.started) speedMultiplier = sprintMultiplier;
            else if(value.canceled) speedMultiplier = 1f;
        }
    }
}
