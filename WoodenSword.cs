using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase derivada para espadas de madera
public class WoodenSword : Espadas
{
    public Sprite swordSprite1;
    void Awake()
    {
        Daño = 5;
        Durabilidad = 20;
        
    }

    public override void Ataque()
    {
        
        Debug.Log("Ataque de espada de madera");
    }

}
