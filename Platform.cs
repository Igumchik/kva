using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public Vector3 direction = Vector3.up;
    public bool isActive;
    // Start is called before the first frame update
    void Update()
    {
          if (isActive)
           {
            transform.position += direction * speed * Time.deltaTime; 
           } 
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
     {
        if (other.tag == "PlatformStop")
        {
            direction = -direction;
        }
        if (other.tag == "Player") 
        {
            isActive = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") 
        {
            isActive = false;
        }
    }
}
