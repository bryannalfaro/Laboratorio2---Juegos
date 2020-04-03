using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float anguloRotacion = 45;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, anguloRotacion) * Time.deltaTime);
    }
}
