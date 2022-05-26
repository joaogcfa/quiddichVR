using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    public AudioSource soundGoal;
    public bool goalP1;
    private bool hasCollide = false;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){
        if (col.tag == "Ball"){

            if (hasCollide == false)
            {
                if(goalP1){
                    score = int.Parse(GameObject.Find("PlacarP1").GetComponent<Text>().text)+1;
                    GameObject.Find("PlacarP1").GetComponent<Text>().text = score.ToString();
                    print("GOAL");
                    soundGoal.Play();
                }
                else{
                    score = int.Parse(GameObject.Find("PlacarP2").GetComponent<Text>().text)+1;
                    GameObject.Find("PlacarP2").GetComponent<Text>().text = score.ToString();
                    print("GOAL");
                    soundGoal.Play();
                }
                hasCollide = true;
                StartCoroutine(CoolDown());
            }
        }
    }

    IEnumerator CoolDown()
    {

        yield return new WaitForSeconds(1);
        hasCollide = false;

    }
}
