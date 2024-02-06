using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{

    [Header("Clase Derivada")]
    public string Raza;

    void Start()
    {
        Display();
    }

    public override void Move()
    {
        posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionMouse.z = 0f;
        Vector3 direccion = (posicionMouse - transform.position).normalized;

        transform.Translate(direccion * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
