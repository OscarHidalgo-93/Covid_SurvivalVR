using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
   
    [SerializeField]
    private GameObject vacuna1;
    [SerializeField]
    private GameObject vacuna2;
    [SerializeField]
    private GameObject vacuna3;

   public GameManager gm;
    

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        vacuna1 = GameObject.Find("Vida1");
        vacuna2 = GameObject.Find("Vida2");
        vacuna3 = GameObject.Find("Vida3");
        print(gm.contadorVacuna);
    }

    // Update is called once per frame
    void Update()
    {

        

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            print("contacto");
            quitarVidas();
            gm.Infeccion();
            Destroy(this.gameObject);



        }
              
    }
    public void quitarVidas()
    {
        gm.contadorVacuna = gm.contadorVacuna+1;
        if (gm.contadorVacuna >= 3)//Oojo
        {
            print("Perdiste");

            vacuna3.SetActive(false);
            gm.EndGame();
       
        }
        else if (gm.contadorVacuna == 2)
        {
            print("quitar una vacuna");
           
            vacuna2.SetActive(false);
        }
        else if(gm.contadorVacuna == 1)
        {
            print("quitar otra vacuna");
           
            vacuna1.SetActive(false);
        }
        print("Vacunas usadas: " + gm.contadorVacuna);
        
    }

    }
