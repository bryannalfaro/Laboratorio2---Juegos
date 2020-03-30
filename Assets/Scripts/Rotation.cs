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
        transform.Rotate(new Vector3(anguloRotacion, 0, 0) * Time.deltaTime);
    }
}
