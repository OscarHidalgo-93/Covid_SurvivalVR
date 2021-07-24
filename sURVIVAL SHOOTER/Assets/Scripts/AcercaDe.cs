using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcercaDe : MonoBehaviour
{
    public GameObject PanelMenu;
    public GameObject PanelAcercaDe;
    public GameObject PanelComoJugar;

    public void MostrarInfo()
    {
        PanelAcercaDe.SetActive(true);
        PanelMenu.SetActive(false);
        PanelComoJugar.SetActive(false);
        
    }
}
