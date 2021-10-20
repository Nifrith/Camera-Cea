using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 position; // Vector para el direccionamiento del personaje
    public float speed = 10; // velocidad de movimiento del personaje
    public int life = 50; // vida del personaje
    public int maxLife = 100; // vida máxima del personaje
    public string direction = ""; // dirección hacia la cual se mueve el personaje

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Heal(10);
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            TakeDamage(5);
        }

    }

    void Movement()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {

            position = transform.localPosition;
            // valor que aumenta el movimiento en eje Z
            float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            position.x += x;
            transform.localPosition = position;
            // llamar al método de dirección
            SetDirection(x, true);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            position = transform.localPosition;
            // valor que aumenta el movimiento en eje Z
            float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
            position.z += z;
            transform.localPosition = position;
            SetDirection(z, false);
        }
    }


    // Lógica para establecer dirección del objeto
    void SetDirection(float dirValue, bool isX)
    {
        if (isX)
        {
            if (dirValue > 0)
            {
                direction = "Derecha";
            }
            else
            {
                direction = "Izquierda";
            }
        }
        else
        {
            if (dirValue > 0)
            {
                direction = "Arriba";
            }
            else
            {
                direction = "Abajo";
            }
        }

        Debug.Log(direction);

    }

    // Lógica para curación
    void Heal(int healing)
    {
        if ((healing + life) > maxLife)
        {
            life = maxLife;
            Debug.Log("Max Healed");
        }
        else
        {
            life += healing;
        }

        Debug.Log("healed, life now is: " + life);
    }

    // Lógica para recibir daño
    void TakeDamage(int damage)
    {
        if (damage > life)
        {
            life = 0;
            Debug.Log("Already Dead");
        }
        else
        {
            life -= damage;
        }

        Debug.Log("Damage taken, life now is: " + life);

    }
}
