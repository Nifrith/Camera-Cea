using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{

    // Public variables from here
    public float damage;
    public float bulletSpeed;

    // Direction should be: right, left, up , down , forward, back
    public string direction;
    


    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.localPosition.x <= 4f || gameObject.transform.localPosition.y <= 4f || gameObject.transform.localPosition.z <= 4f)
        {
            if (direction.Equals("right"))
            {
                MoveBullet(Vector3.right);
            }
            if (direction.Equals("left"))
            {
                MoveBullet(Vector3.left);
            }
            if (direction.Equals("up"))
            {
                MoveBullet(Vector3.up);
            }
            if (direction.Equals("down"))
            {
                MoveBullet(Vector3.down);
            }
            if (direction.Equals("forward"))
            {
                MoveBullet(Vector3.forward);
            }
            if (direction.Equals("back"))
            {
                MoveBullet(Vector3.back);
            }
        } else
        {
            DestroyBullet();
        }
        
    }

    private void MoveBullet(Vector3 vector3)
    {
       transform.Translate(bulletSpeed * Time.deltaTime * vector3);
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }

    // método para destruir la bala al llegar a determinado punto
    

}
