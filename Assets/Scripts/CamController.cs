using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField] GameObject[] cameras;
    private bool thirdpersonenabled = false;
    private bool topdownenabled = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
