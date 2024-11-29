using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPingPong : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] bloques;
    public Vector3[] direcciones;

    public MeshRenderer [] mesRender;
    public Color[] colores;

    void Start()
    {
        direcciones = new Vector3[] { Vector3.right, Vector3.left, Vector3.right,
        Vector3.left };
        for (int i = 0; i < bloques.Length; i++)
        {
            mesRender[i].material.color = colores[i];
        }

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < bloques.Length; i++)
        {
            //bloques[i].position += Vector3.right * Time.deltaTime;
            bloques[i].position += (i + 1) * direcciones[i] * Time.deltaTime;
            if (bloques[i].position.x < -4)
            {
                direcciones[i] = Vector3.right;
            }
            else if (bloques[i].position.x > 4)
            {
                direcciones[i] = Vector3.left;

            }
        }
    }
}
