# Disparos - Desafío 4 unity

Se solicita realizar la instancia de prefabs que representen balas mediante un generador, simulando un cañon, se deben destruir las balas bajo determinadas condiciones

## Información adicional

Se creo un entorno y se utilizaron assets de unity store para el cañon, el fondo y el color de las balas :D

Las balas exponen 3 variables y una estructura llamada direction, que hace una llamada a los Enum de dirección: 
```c
// Public variables from here
    [SerializeField] float damage;
    [SerializeField] float bulletSpeed;
    [SerializeField] float impulse;

// Direction should be: right, left, up , down , forward, back
    [SerializeField] Direction direction;

```

Se utiliza el metodo InvokeRepeating, se actualizó el código serializando todas las variables: 

```c
    [SerializeField] GameObject[] bulletPrefab;
    [SerializeField] float spawnDelay;
    [SerializeField] float spawnInterval;
    
// Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Cannon", spawnInterval, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
               
    }

    void Cannon()
    {
        int bulletInstance = Random.Range(0, bulletPrefab.Length);
        Instantiate(bulletPrefab[bulletInstance], transform.position, bulletPrefab[bulletInstance].transform.rotation);
    }

```

Se añadio la lógica de aumento de escala al presionar la tecla espacio:
```c
// método para destruir la bala al llegar a determinado punto
    void BulletGrow()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = transform.localScale * 2f;
            Debug.Log(transform.localScale);

        }
    }  

```
## Authors
Josue Cea - Samuel Cea
