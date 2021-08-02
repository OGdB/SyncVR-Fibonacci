using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    private void FixedUpdate()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * speed);
    }
}
