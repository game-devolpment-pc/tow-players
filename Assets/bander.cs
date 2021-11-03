using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bander : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-21f,21f),
                Mathf.Clamp(transform.position.y,-6f,6f) , transform.position.z);
    }
}
