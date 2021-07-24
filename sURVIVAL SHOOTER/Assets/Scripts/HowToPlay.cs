using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject panelMenu;
    public GameObject panelAcercaDe;
    public GameObject panelComoJugar;

    public void HowTo()
    {
        panelComoJugar.SetActive(true);
        panelMenu.SetActive(false);
        panelAcercaDe.SetActive(false);
    }
}
