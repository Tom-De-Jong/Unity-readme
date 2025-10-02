using UnityEngine;

public class Inputtest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {



    Vector3 newPosition = transform.position;
        float moveSpeed = 5f;

        if (Input.GetKey(KeyCode.A))
        {
            newPosition.x -= moveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }

        if (Input.GetKey(KeyCode.D))
        {
            newPosition.x += moveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }

        if (Input.GetKey(KeyCode.W))
        {
            newPosition.z += moveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPosition.z -= moveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }



    }
}
