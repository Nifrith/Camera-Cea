using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{

    // Public variables from here
    [SerializeField] float damage;
    [SerializeField] float bulletSpeed;
    [SerializeField] float impulse;

    // Direction should be: right, left, up , down , forward, back
    [SerializeField] Direction direction;
    

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        switch (direction)
        {
            case Direction.right:
                MoveBullet(Vector3.right);
                break;
            case Direction.left:
                MoveBullet(Vector3.left);
                break;
            case Direction.up:
                MoveBullet(Vector3.up);
                break;
            case Direction.down:
                MoveBullet(Vector3.down);
                break;
            case Direction.forward:
                MoveBullet(Vector3.forward);
                break;
            case Direction.back:
                MoveBullet(Vector3.back);
                break;
        }

        if (impulse > 0f)
        {
           impulse -= Time.deltaTime;
           Debug.Log(impulse);
        } else
        {
            DestroyBullet();
        }

        // destruir el proyectil si el impulso de la bala es 0

        BulletGrow();

    }

    // Método para mover la bala
    private void MoveBullet(Vector3 vector3)
    {
       transform.Translate(bulletSpeed * Time.deltaTime * vector3);

    }

    // Método para destruir la bala en caso de que el impulso llegue a 0
    private void DestroyBullet()
    {
            Destroy(gameObject);
           
    }

    public enum Direction
    {
        up,
        down,
        left,
        right,
        forward,
        back
    }

    // método para destruir la bala al llegar a determinado punto
    void BulletGrow()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float scaleX = transform.localScale.x * 2;
            float scaleY = transform.localScale.y * 2;
            float scaleZ = transform.localScale.z * 2;

            transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
            Debug.Log(transform.localScale);


        }
    }    

}
