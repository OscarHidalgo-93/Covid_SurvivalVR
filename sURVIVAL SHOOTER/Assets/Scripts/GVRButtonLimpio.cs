
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GVRButtonLimpio : MonoBehaviour
{
    [SerializeField]
    private Image imgReticula;
    public UnityEvent GVRClick;
    bool gvrStatus;
    public float gvrTimer;
    public float totalTime = 2;

    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgReticula.fillAmount = gvrTimer / totalTime;
        }
        if (gvrTimer > totalTime)
        {
            GVRClick.Invoke();
            GvrOff();
        }

    }
    public void GvrOn()
    {
        gvrStatus = true;

    }
    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgReticula.fillAmount = 0;
    }
}
