using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class Joint : MonoBehaviour
{
    public GameObject bola;
        public float desiredDuration = 1.0f;
        private float elapsedTime;
        public Rigidbody attachPoint;
        public float distance;
        
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
            if (botao.GetState(trackedObj.inputSource))
            {
                print("estou aqui");
                // GameObject bola = GameObject.Instantiate(prefab);
                elapsedTime += Time.deltaTime;
                float percentageComplete = elapsedTime / desiredDuration;

                bola.transform.position = Vector3.Lerp(bola.transform.position, attachPoint.transform.position, 0.5f);

                if (joint == null && Vector3.Distance(bola.transform.position, attachPoint.transform.position) < distance)
                {
                    joint = bola.AddComponent<FixedJoint>();
                    joint.connectedBody = attachPoint;
                }
                
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

        IEnumerator WaitAndMove(float delayTime){
            yield return new WaitForSeconds(delayTime); // start at time X
            float startTime=Time.time; // Time.time contains current frame time, so remember starting point
            while(Time.time-startTime<=1){ // until one second passed
                bola.transform.position = Vector3.Lerp(bola.transform.position,attachPoint.transform.position,Time.time-startTime); // lerp from A to B in one second
                yield return 1; // wait for next frame
            }
            
        }

}

