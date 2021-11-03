using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounder1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-5f,5f),
                Mathf.Clamp(transform.position.y,-5f,5f) , transform.position.z);
    }
}
