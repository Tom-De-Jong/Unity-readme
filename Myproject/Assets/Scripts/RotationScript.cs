using UnityEngine;

public class RotationScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // rotation
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, 60.0f * Time.deltaTime);
        Debug.Log("Rotating");
    }
}
