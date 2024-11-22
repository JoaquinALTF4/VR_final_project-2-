using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    public float rotateSpeed = 10f; // Adjust the rotation speed

    void Update()
    {
        // Rotate the skybox
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
    }
}
