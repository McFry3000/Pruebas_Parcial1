using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondSword : Espadas
{
    public Sprite swordSprite5;
    void Awake()
    {
        Daño = 40;
        Durabilidad = 250;

    }

    public override void Ataque()
    {

        Debug.Log("Ataque de espada de diamante");
    }
}
