using UnityEngine;
//the script is attached to the Main Camera
//The purpose of the script:Controls the behavior of the Main Camera
//Your name:Leo Jiang
//Date written:September 25, 2026
//Version 1

using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;

    void LateUpdate()
    {
        transform.position = playerTransform.position + offset;
    }
}