using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{


    Vector3 oldpos;
    Vector3 newpos;
    public Vector3 velocity;

    void Start(){
     
        oldpos = transform.position;
     }
     
    void Update(){
         newpos = transform.position;
         Vector3 media =  (newpos - oldpos);
         velocity = media / Time.deltaTime;
         oldpos = newpos;
         newpos = transform.position;

     }

}


