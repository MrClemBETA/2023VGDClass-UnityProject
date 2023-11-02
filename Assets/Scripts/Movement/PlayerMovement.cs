using UnityEngine;

namespace SOS.AndrewsAdventure.Character
{
    public class PlayerMovement : MonoBehaviour
    {
        private CharacterController controller;
        private Vector3 playerVelocity;
        private bool groundedPlayer;
        [SerializeField] float playerSpeed = 5.0f;
        [SerializeField] float sprintMultiplier = 3.0f;
        [SerializeField] float jumpForce = 3.0f;
        [SerializeField] KeyCode sprintKeyCode = KeyCode.LeftShift;
        // private float gravityValue = -50f;

        private void Start()
        {
            controller = gameObject.AddComponent<CharacterController>();
        }

        void Update()
        {
            // Ensure player has 0 y velocity if grounded
            if (controller.isGrounded && playerVelocity.y < 0)
                playerVelocity.y = 0f;

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            // Check if the shift key is held down for sprinting
            move *= playerSpeed * (Input.GetKeyDown(sprintKeyCode) ? sprintMultiplier : 1);

            controller.Move(move * Time.deltaTime);

            // Determine if a jump occured
            if(Input.GetButtonDown("Jump"))
                controller.attachedRigidbody.AddForce(Vector3.up * jumpForce);

        }

    }
}
