using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Clase que funciona como el Manager para crear esfera al eliminarse de la escena
 * Referencia: Clase impartida
 * Bryann Alfaro
 */
public class NewSphere : MonoBehaviour
{
    public GameObject prefab;
    GameObject actualJugador;
    public GameObject pauseMenu;
    private bool isPaused = false;
    public GameObject referenciaSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        //Al inicio instanciar un prefab
        
        if(prefab){
            actualJugador = Instantiate(prefab, referenciaSpawn.transform.position, Quaternion.identity);
}
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            if (prefab && !actualJugador)
                actualJugador = Instantiate(prefab, referenciaSpawn.transform.position, Quaternion.identity);

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            TogglePause();
        }


    }


    public void TogglePause()
    {

        if (pauseMenu)
        {
            pauseMenu.SetActive(!pauseMenu.activeSelf);
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0f : 1f;
        }

    }

    public void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ResetGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }
}
