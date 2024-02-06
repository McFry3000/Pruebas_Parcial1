using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalSword : Espadas
{
    public Sprite swordSprite3;
    void Awake()
    {
        Daño = 20;
        Durabilidad = 50;

    }

    public override void Ataque()
    {

        Debug.Log("Ataque de espada de metal");
    }
}
