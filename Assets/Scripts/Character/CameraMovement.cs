using UnityEngine;
using UnityEngine.InputSystem;

namespace SOS.AndrewsAdventure.Character
{
    public class CameraMovement : MonoBehaviour
    {
        [SerializeField] float cameraRotateSpeed;
        [SerializeField] float xBuffer = 100;

        private float rotation = 0;
        private bool canRotate = true;

        public void HorizontalMovement(InputAction.CallbackContext value)
        {
            float x = value.ReadValue<Vector2>().x - Screen.width / 2;
            rotation = Mathf.Abs(x) > xBuffer ? cameraRotateSpeed * x : 0;
        }

        private void Update()
        {
            if (canRotate)
            {
                transform.Rotate(Vector3.up, rotation / 360);
            }
        }

        public void StopCameraMovement()
        {
            canRotate = false;
        }
    }
}
