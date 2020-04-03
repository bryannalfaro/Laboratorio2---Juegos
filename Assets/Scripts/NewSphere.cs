using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSphere : MonoBehaviour
{
    public GameObject prefab;
    GameObject currentPlayer;
    public GameObject spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        if(prefab){
            currentPlayer = Instantiate(prefab, spawnpoint.transform.position, Quaternion.identity);
}
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            if (prefab && !currentPlayer)
                currentPlayer = Instantiate(prefab, spawnpoint.transform.position, Quaternion.identity);
    }
}
