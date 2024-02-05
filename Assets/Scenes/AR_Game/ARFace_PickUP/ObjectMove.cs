using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{  


    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -0.3f, 0.3f), -0.30f, 1f);
        transform.rotation = Quaternion.identity;
    }
}
