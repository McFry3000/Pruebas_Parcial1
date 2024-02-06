using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [Header("CLASE BASE")]
    public string Name = "Animal";
    public float speed = 5f;
    public Vector3 posicionMouse;
    public virtual void Move()

    {
        if (Input.GetMouseButtonDown(0))
        {

            posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 direccion = (posicionMouse - transform.position).normalized;

            transform.Translate(direccion * speed * Time.deltaTime);

        }
        
    }
    public virtual void Display()
    {
        Debug.Log("El nombre del animal es: " + Name);

    }
}
