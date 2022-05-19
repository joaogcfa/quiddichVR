using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class Joint : MonoBehaviour
{
    public GameObject bola;
        public Rigidbody attachPoint;
        
        public SteamVR_Action_Boolean botao = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("InteractUI");

        // public SteamVR_Input batata = SteamVR_Input.Single;

        SteamVR_Behaviour_Pose trackedObj;
        FixedJoint joint = null;

        private void Awake()
        {
            trackedObj = GetComponent<SteamVR_Behaviour_Pose>();
        }

        private void FixedUpdate()
        {
            // print(botao.Single);
            //Criar e prende objeto na mão do usuário
            if (joint == null && botao.GetStateDown(trackedObj.inputSource))
            {
                // GameObject bola = GameObject.Instantiate(prefab);
                bola.transform.position = attachPoint.transform.position;

                joint = bola.AddComponent<FixedJoint>();
                joint.connectedBody = attachPoint;
            }
            // Lança o objeto
            else if (joint != null && botao.GetStateUp(trackedObj.inputSource))
            {
                GameObject bola = joint.gameObject;
                Rigidbody rigidbody = bola.GetComponent<Rigidbody>();
                Object.DestroyImmediate(joint);
                joint = null;
                //Object.Destroy(bola, 15.0f);
                Transform origin = trackedObj.origin ? trackedObj.origin : trackedObj.transform.parent;
                // if (origin != null)
                // {
                //     rigidbody.velocity = origin.TransformVector(trackedObj.GetVelocity());
                //     rigidbody.angularVelocity = origin.TransformVector(trackedObj.GetAngularVelocity());
                // }
                // else
                // {
                //     rigidbody.velocity = trackedObj.GetVelocity();
                //     rigidbody.angularVelocity = trackedObj.GetAngularVelocity();
                // }
                // rigidbody.maxAngularVelocity = rigidbody.angularVelocity.magnitude;
            }
        }

}

