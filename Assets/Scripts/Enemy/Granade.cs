using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granade : MonoBehaviour
{
    public float duration = 4f;
    private void Start()
    {
        Invoke("Explode", duration);
    }

    void Explode()
    {
        //Взырв
        Destroy(gameObject);
    }
}
