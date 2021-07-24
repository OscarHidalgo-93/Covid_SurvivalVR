using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    private GameManager gm;
    public Text txtContador;
    private string texto;
    private float contadorVirus = 0f;


    // Start is called before the first frame update
    void Start()
    {
        gm = gameObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void count()
    {
        contadorVirus++;
        txtContador.text = contadorVirus + "/6";
        if (contadorVirus >=6)
        {
            gm.YouWin();
            print("HAS GANADO!");
        }
    }
}
