 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espadas : MonoBehaviour
{
    public int Daño;
    public int Durabilidad;
    public Sprite swordSprite;
   

    void Start()
    {
   
    }

    public virtual void Ataque()
    {
        // Lógica de ataque base
        Debug.Log("Realizando ataque normal.");
    }
}


