using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSword : Espadas
{
    public Sprite swordSprite2;
    void Awake()
    {
        Daño = 8;
        Durabilidad = 40;
        
    }

    public override void Ataque()
    {
        
        Debug.Log("Ataque de espada de piedra");
    }

}
