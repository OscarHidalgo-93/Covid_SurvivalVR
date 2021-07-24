using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shoot : MonoBehaviour
{
   
    
    


    public void Start()
    {
       
    }
    //En este Script parece que el contador si se suma, prueba a poner la parte de la edicion de texto en este metodo.
    //Introducir el Sonido de eliminar el virus o un disparo o algo parecido
    public void Matar()
    {
        FindObjectOfType<GameManager>().GetComponent<AudioSource>().Play();
        print(" Sonido Pium pium");
        FindObjectOfType<Contador>().count();
        print("contador +1");
        Destroy(this.gameObject);
        print("virus eliminado");
        
       
    }

}
