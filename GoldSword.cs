using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSword : Espadas
{
    public Sprite swordSprite4;
    void Awake()
    {
        Daño = 16;
        Durabilidad = 40;

    }

    public override void Ataque()
    {

        Debug.Log("Ataque de espada de oro");
    }
}
