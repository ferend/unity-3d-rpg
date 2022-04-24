using UnityEngine;

namespace Components
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform cameraTarget;

        private void Update()
        {
            transform.position = cameraTarget.position;
        }
    }
}
