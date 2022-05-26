using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ThrowableBall");
    }

    // Update is called once per frame
    void Update()
    {


        if(gameObject.transform.position.x > ball.transform.position.x){
            gameObject.transform.position = new Vector3(-Time.deltaTime * 10 ,ball.transform.position.y,gameObject.transform.position.z);
        }
        if(gameObject.transform.position.x < ball.transform.position.x){
            gameObject.transform.position = new Vector3(Time.deltaTime * 10 ,ball.transform.position.y,gameObject.transform.position.z);
        }
        if(gameObject.transform.position.y > ball.transform.position.y){
            gameObject.transform.position = new Vector3(ball.transform.position.x ,-Time.deltaTime * 10,gameObject.transform.position.z);
        }
        if(gameObject.transform.position.y < ball.transform.position.y){
            gameObject.transform.position = new Vector3(ball.transform.position.x ,Time.deltaTime * 10,gameObject.transform.position.z);
        }
        // if (ball.transform.position.x < -25){
        //     print("oi");
        //     gameObject.transform.position = new Vector3(-25f, ball.transform.position.y, gameObject.transform.position.z) ;
        // }
        // else if(ball.transform.position.x > 30)
        // {
        //     print("oi");
        //     gameObject.transform.position = new Vector3(30f, ball.transform.position.y, gameObject.transform.position.z);
        // }

        // if (ball.transform.position.y < 55){
        //     gameObject.transform.position = new Vector3(ball.transform.position.x, 55f, gameObject.transform.position.z) ;
        // }
        // else if(ball.transform.position.y > 85)
        // {
        //     gameObject.transform.position = new Vector3(ball.transform.position.x, 85f, gameObject.transform.position.z);
        // }
        // else{
        //     // if(gameObject.transform.position.x > ball.transform)
        //     gameObject.transform.position = new Vector3(ball.transform.position.x,ball.transform.position.y,gameObject.transform.position.z);
        // }
        // if (gameObject.transform.position.y > 55 && gameObject.transform.position.y < 85 ){//&& gameObject.transform.position.x > -20 && gameObject.transform.position.x > 25){
        //     gameObject.transform.position = new Vector3(ball.transform.position.x,ball.transform.position.y,gameObject.transform.position.z);
        // }
        // else if(ball.transform.position.y < 55) {
        //     gameObject.transform.position = new Vector3(gameObject.transform.position.x, 55.5f, gameObject.transform.position.z) ;
        // } else if (ball.transform.position.y > 85){
        //     gameObject.transform.position = new Vector3(gameObject.transform.position.x, 84.5f, gameObject.transform.position.z);
        // }
         
        
    }
}
