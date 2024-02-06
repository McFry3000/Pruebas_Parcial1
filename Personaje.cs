using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    public bool Isdead;
    protected float health;
}

public class Heroe : Personaje
{
  
    private int nivel;
    private float experiencia;
    private int HeroeAgil;
    private int HeroeFuerte;
    private float tipoArma;
}

public class Enemigo1 : Personaje
{

    protected float arquero;
    protected float caballero;
    protected float hechizero;
    protected float explorador;
    protected string tipoArmaEnemigo;
   
}

public class OtraClase
{
    void AccederAObjetos()
    {
        // Acceder a objetos de las clases Heroe y Enemigo
        Heroe miHeroe = new Heroe();
        bool estaMuertoHeroe = miHeroe.Isdead;

        /*Enemigo miEnemigo1 = new Enemigo();
        int puntosAtaqueEnemigo = miEnemigo1.PuntosAtaque;
        string tipoArmaEnemigo = miEnemigo1.tipoArma;*/
    }
}


