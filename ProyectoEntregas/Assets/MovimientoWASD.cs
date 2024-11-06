using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoWASD : MonoBehaviour
{

    public float rotationSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Obtener la entrada del teclado
        float rotacionHorizontal = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float rotacionVertical = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;



        // Aplicar el movimiento al cubo
        transform.Rotate(rotacionVertical, rotacionHorizontal, 0);
    }
}
