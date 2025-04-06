using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    public Transform teleportTo;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportTo.transform.position;
    }
}
