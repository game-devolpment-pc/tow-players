using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover1 : MonoBehaviour
{
    float stepsize = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.UpArrow)){
            transform.position+= new Vector3(0,stepsize * Time.deltaTime,0);
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            transform.position+= new Vector3(0,-stepsize * Time.deltaTime,0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position+= new Vector3(-stepsize * Time.deltaTime,0,0);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            transform.position+= new Vector3(stepsize * Time.deltaTime,0,0);
        } 
    }
}
