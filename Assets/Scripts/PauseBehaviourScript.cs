﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Bryann Alfaro
 * Clase que controla el menu de pausa
 * Referencia: Clase impartida
 */
public class PauseBehaviourScript : MonoBehaviour

   
{
    public GameObject pauseMenu;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {

            TogglePause();
        }
    }

    public void TogglePause() {

        if (pauseMenu)
        {
            pauseMenu.SetActive(!pauseMenu.activeSelf);
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0.0f : 1.0f;
        }
    
    }


    /*
     * Funcion que retorna al menu principal
     */
    public void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    
}
