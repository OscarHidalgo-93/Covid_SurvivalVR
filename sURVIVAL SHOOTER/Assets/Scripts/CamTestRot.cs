using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTestRot : MonoBehaviour
{
    public Camera mainCam;
    //private float camRotX;
    //private float camRotY;

    //public float maxLimit = 90f;
    //public float minLimit = 60f;

    public float limit = 0.5f;
    private Quaternion camRot;

    // Start is called before the first frame update
    void Start()
    {
        // camRotX = mainCam.transform.rotation.x;
        //camRotY = mainCam.transform.rotation.y;
        camRot = mainCam.transform.localRotation;
        

    }

    // Update is called once per frame
    void Update()
    {
        //camRotX = Mathf.Clamp(camRotX, maxLimit, minLimit);
        //camRotY = Mathf.Clamp(camRotY, maxLimit, minLimit);
        mainCam.transform.localRotation = Quaternion.Slerp(camRot, Quaternion.Euler(Vector3.left), limit);
    }
}
