using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Clase que funciona como el Manager para crear esfera al eliminarse de la escena
 */
public class NewSphere : MonoBehaviour
{
    public GameObject prefab;
    GameObject actualJugador;
    public GameObject referenciaSpawn;

    // Start is called before the first frame update
    void Start()
    {
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
    }
}
