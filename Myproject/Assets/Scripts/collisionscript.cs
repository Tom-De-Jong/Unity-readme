using UnityEngine;

public class collisionscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // You can add update logic here if needed
    }

    void OnCollisionEnter(Collision collision)
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = new Color(0f, 204f / 255f, 102f / 255f);
        }
        else
        {
            Debug.LogWarning("This GameObject does not have a Renderer component.");
        }
    }
}