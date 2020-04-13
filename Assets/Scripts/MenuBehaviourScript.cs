using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Bryann Alfaro
 * Clase para manejar el boton del menu principal
 */
public class MenuBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame() {

        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    
    }
}
