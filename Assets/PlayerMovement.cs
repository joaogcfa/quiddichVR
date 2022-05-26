using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;
using Valve.VR;

public class PlayerMovement : MonoBehaviour
{

    public GameObject LeftHand;

    public SteamVR_Action_Boolean botao = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("InteractUI");

    public SteamVR_Behaviour_Pose trackedObj;

    public Quaternion rotation_hand;
    
    public AudioSource audioSource; 
    public AudioClip woosh; 
    public AudioClip wind; 
    public AudioClip inverted; 

    public bool boleana;

    private void Start()

        {
            boleana = true;
            trackedObj = LeftHand.GetComponent<SteamVR_Behaviour_Pose>();

        }

    // Update is called once per frame
    void Update()
    {

        if (botao.GetState(trackedObj.inputSource))
            {
                if(boleana){
                    audioSource.PlayOneShot(woosh, 0.7f);


                //     if()
                //     audioSource.clip = wind;
                //     audioSource.Play();
                }
                if(!audioSource.isPlaying)
                    audioSource.PlayOneShot(wind, 0.7f);
                    
                transform.position += LeftHand.transform.forward;
                boleana = false;
            }

        if (botao.GetStateUp(trackedObj.inputSource)){
            audioSource.Pause();
            
            // wind.Pause();
            // inverted.Play();
            boleana = true;
        }
        // if(boleana){

        // }
        // boleana = true;

        // transform.rotation(rotation_hand);
        // print("Rotation: " + LeftHand.transform.rotation);
    }
}
