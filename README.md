# Disparos - Desafío 5 unity

Se solicita realizar la creación de múltiples cámaras que sigan a un gameobject controlado por inputs o que tengan
una vista fija (deben ser al menos 2)

## Información adicional

Se creo un entorno y se utilizaron assets de unity store para el cañon, el fondo, el mar. Se agregó también un prefab de
barco pirata (considerando el cañon y las balas, ya son 3 assets importados).

En cuanto a las texturas, ya se contaban con diversas texturas previamente, tanto para el cielo como para el terreno, pero se añadió
además una textura de agua donde fue posicionado el barco pirata para coherencia del plano

Se añadieron, a cada una de las cámaras, un audio source para que se reproduzcan los sonidos importados, al activar una cámara X

## Con respecto a la entrega anterior, los cambios principales son: 

Se añadieron 3 cámaras para diferentes vistas de la escena:
```c
Main camera = Cinemachine con una perspectiva de 3ra persona y seguimiento del cañon
Topdowncamera = camara mirando el plano enfocando el cañon, el mar y el barco pirata
Thirdcamera = camara mirando al cañon de frente, volteando la vista
```

Se creo un script para el control de cámaras utilizando un arreglo, actualmente
solo se usan 3:

```c
     // activar o desactivar camaras
        if (Input.GetKey(KeyCode.F1))
        {
            if (!thirdpersonenabled)
            {
                cameras[0].SetActive(true);
                cameras[1].SetActive(false);
                cameras[2].SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            if (!topdownenabled)
            {
                cameras[0].SetActive(false);
                cameras[1].SetActive(true);
                cameras[2].SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            if (!topdownenabled)
            {
                cameras[0].SetActive(false);
                cameras[1].SetActive(false);
                cameras[2].SetActive(true);
            }
        }

```


## Authors
Josue Cea - Samuel Cea
