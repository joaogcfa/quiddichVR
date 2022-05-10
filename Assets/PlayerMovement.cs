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

    private void Start()

        {

            trackedObj = LeftHand.GetComponent<SteamVR_Behaviour_Pose>();

        }

    // Update is called once per frame
    void Update()
    {

        if (botao.GetState(trackedObj.inputSource))
            {
                print("Cliquei");
                transform.position += LeftHand.transform.forward;
                
            }

        // transform.rotation(rotation_hand);
        // print("Rotation: " + LeftHand.transform.rotation);
    }
}
