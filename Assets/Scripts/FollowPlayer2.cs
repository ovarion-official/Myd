using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{

    public GameObject Capsule;
    private float x = 2.81F;
    private float y = 9.22F;
    private float z = -9.9F;
    private Vector3 offset = new Vector3(x, y, z);

    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.position = Capsule.transform.position + offset;
    }
}
