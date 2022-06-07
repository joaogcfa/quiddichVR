using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject ball;
    public GameObject player;
    public float goalkeeperz;

    public float velocidade = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ThrowableBall");
        player = GameObject.Find("Player");
        goalkeeperz = gameObject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {


        // if(gameObject.transform.position.x > ball.transform.position.x){
        //     gameObject.transform.position = new Vector3(-Time.deltaTime * 10 ,ball.transform.position.y,gameObject.transform.position.z);
        // }
        // if(gameObject.transform.position.x < ball.transform.position.x){
        //     gameObject.transform.position = new Vector3(Time.deltaTime * 10 ,ball.transform.position.y,gameObject.transform.position.z);
        // }
        // if(gameObject.transform.position.y > ball.transform.position.y){
        //     gameObject.transform.position = new Vector3(ball.transform.position.x ,-Time.deltaTime * 10,gameObject.transform.position.z);
        // }
        // if(gameObject.transform.position.y < ball.transform.position.y){
        //     gameObject.transform.position = new Vector3(ball.transform.position.x ,Time.deltaTime * 10,gameObject.transform.position.z);
        // }

        if(ball.transform.position.x > -25  && ball.transform.position.x < 30 && ball.transform.position.y > 55 && ball.transform.position.y < 85){

            float px = gameObject.transform.position.x;
            float py = gameObject.transform.position.y;
            float pz = gameObject.transform.position.z;
            float vx = ball.transform.position.x;
            float vy = ball.transform.position.y-2f;
            float vz = ball.transform.position.z +2;

            if (vx > px) px += velocidade; else px -= velocidade;
            if (vy > py) py += velocidade; else py -= velocidade;
            if (vz > pz) pz += velocidade; else pz -= velocidade;

               px += (vx - px) * velocidade;

            if(player.transform.position.z > 170 && gameObject.transform.position.z <= goalkeeperz){
                gameObject.transform.position = new Vector3(px, py, pz);
            }
            else{
                gameObject.transform.position = new Vector3(px, py, goalkeeperz);
            }

        }
        
        if (ball.transform.position.x < -25){
            if (ball.transform.position.y < 55){
                gameObject.transform.position = new Vector3(-25, 55f, gameObject.transform.position.z) ;
            }
            else if(ball.transform.position.y > 85)
            {
                gameObject.transform.position = new Vector3(-25, 85f, gameObject.transform.position.z);
            }
            else{
                print("oi");
                gameObject.transform.position = new Vector3(-25f, ball.transform.position.y, gameObject.transform.position.z) ;
            }
        }
        if(ball.transform.position.x > 30)
        {
            if (ball.transform.position.y < 55){
                gameObject.transform.position = new Vector3(30, 55f, gameObject.transform.position.z) ;
            }
            else if(ball.transform.position.y > 85)
            {
                gameObject.transform.position = new Vector3(30, 85f, gameObject.transform.position.z);
            }
            else{
                gameObject.transform.position = new Vector3(30f, ball.transform.position.y, gameObject.transform.position.z);
            }
        }
        // if (ball.transform.position.y < 55){
        //     gameObject.transform.position = new Vector3(ball.transform.position.x, 55f, gameObject.transform.position.z) ;
        // }
        // else if(ball.transform.position.y > 85)
        // {
        //     gameObject.transform.position = new Vector3(ball.transform.position.x, 85f, gameObject.transform.position.z);
        // }
        // else{
        //     if (ball.transform.position.x < -25){
        //         print("oi");
        //         gameObject.transform.position = new Vector3(-25f, ball.transform.position.y, gameObject.transform.position.z) ;
        //     }
        //     else if(ball.transform.position.x > 30)
        //     {
        //         print("oi");
        //         gameObject.transform.position = new Vector3(30f, ball.transform.position.y, gameObject.transform.position.z);
        //     }
        //     // if(gameObject.transform.position.x > ball.transform)
        //     else{
        //        gameObject.transform.position = new Vector3(ball.transform.position.x,ball.transform.position.y,gameObject.transform.position.z);
        //     }
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
