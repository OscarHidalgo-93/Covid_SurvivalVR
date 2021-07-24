using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBack : MonoBehaviour
{
    public GameObject panelMenu;
    public GameObject panelInstrucciones;
    public GameObject panelAcercaDe;
    public GameObject botonComenzarJuego;

  
    public void GoToMenu()
       
    {
        panelMenu.SetActive(true);
        botonComenzarJuego.SetActive(true);
        panelAcercaDe.SetActive(false);
        panelInstrucciones.SetActive(false);
        
    }
}
