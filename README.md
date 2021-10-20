# Disparos - Desafío 3 unity

Se solicita realizar la instancia de prefabs que representen balas mediante un generador, simulando un cañon

## Información adicional

Se creo un entorno y se utilizaron assets de unity store para el cañon, el fondo y el color de las balas :D

Las balas exponen 3 variables: 
```cs
// Public variables from here
    public float damage;
    public float bulletSpeed;

// Direction should be: right, left, up , down , forward, back
    public string direction;

```

Se utiliza el metodo InvokeRepeating: 
```cs
 // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Cannon", 2f, 1.5f);
    }

```
Y un método para hacer la llamada a el o los prefabs: 
```cs
 void Cannon()
    {
        int bulletInstance = Random.Range(0, bulletPrefab.Length);
        Instantiate(bulletPrefab[bulletInstance], transform.position, bulletPrefab[bulletInstance].transform.rotation);
    }

```
## Authors
Josue Cea - Samuel Cea
