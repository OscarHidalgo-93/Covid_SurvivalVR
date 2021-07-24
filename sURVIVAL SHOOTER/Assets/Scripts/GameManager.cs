using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;


public class GameManager : MonoBehaviour
{
    private Timer timer;
    public GameObject gameOver;
    public AudioSource ambiente;
    public GameObject youWin;
    public GameObject gvrReticlePointer;
    public AudioSource youDiedClip;
    public AudioSource victoryClip;
    public GameObject mascarillaCovid;
    public GameObject virusCovid;
    public GameObject pistola;
    public AudioSource sonidoTos;
    public float contadorVacuna = 0;

    public GameObject[] enemigos;

    public bool mascarillaOn;
    public AudioSource sonidoEquipar;

    public bool win = false;
    public GameObject objetoTos;
    public GameObject obejtoGameOver;



    
    void Start()
    {
        contadorVacuna = 0;

        timer = gameObject.GetComponent<Timer>();
        StartGame();
    }

    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            PararVirus();
        }
        if (win == true)
        {
            youWin.SetActive(true);
            gameOver.SetActive(false);
        }
       
    }
    public void StartGame()
    {
        gvrReticlePointer.SetActive(true);
        timer.startTimer();
        contadorVacuna = 0;

    }
    public void EndGame()
    {
        PararVirus();
        print("los virus se paran");
        objetoTos.SetActive(false);
        timer.stopTimer();
        ambiente.Pause();
        youDiedClip.Play();
        gvrReticlePointer.SetActive(false);
        pistola.SetActive(false);
        Invoke("ToMainMenu", 6f);
        objetoTos.SetActive(false);
        gameOver.SetActive(true);
        //Time.timeScale = 0;
        //reiniciar escena
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //volver al menu principal a los 3segundos de parar el juego 


    }
    public void YouWin()
    {
        PararVirus();
        objetoTos.SetActive(false);
        obejtoGameOver.SetActive(false);
        win = true;
        //encender un canvas que nos diga que hemos ganado
        youWin.SetActive(true);
        // parar audio y timer
        timer.stopTimer();
        ambiente.Pause();
        victoryClip.Play();
        gvrReticlePointer.SetActive(false);
        pistola.SetActive(false);
        // llamar al metodo main menu.
        Invoke("ToMainMenu", 6f);
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void FrenoMascarilla()
    {
        mascarillaCovid.SetActive(false);
        sonidoEquipar.Play();
        mascarillaOn = true;
       
        enemigos = GameObject.FindGameObjectsWithTag("Virus");
        foreach (var item in enemigos)
        {
          item.GetComponent<NavMeshAgent>().speed = 3f;
        }
        print(" El virus ha sido realentizado gracias a la mascarilla!!");

        
    }
    public void Infeccion()
    {
        sonidoTos.Play();

    }
    public void FrenoMascarillaAux()
    {
        enemigos = GameObject.FindGameObjectsWithTag("Virus");
        foreach (var item in enemigos)
        {
            item.GetComponent<NavMeshAgent>().speed = 3f;
        }
    }
    public void PararVirus()
    {
        enemigos = GameObject.FindGameObjectsWithTag("Virus");
        foreach (var item in enemigos)
        {
            item.GetComponent<NavMeshAgent>().speed = 0;
        }
    }
}
