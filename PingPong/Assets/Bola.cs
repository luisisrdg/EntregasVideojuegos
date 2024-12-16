using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    [SerializeField] private float velocidadInicial = 4f;
    private Rigidbody2D rb;
    [SerializeField] private float MultiplicadorVelocidad = 1.1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InicarMovimiento();
    }
    void InicarMovimiento()
    {
        float VelocidadX = Random.Range(0, 2) == 0 ? 1 : -1;
        float VelocidadY = Random.Range(0, 2) == 0 ? 1 : -1;
        rb.velocity = new Vector2(VelocidadX, VelocidadY) * velocidadInicial;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Players"))
        {
            rb.velocity *= MultiplicadorVelocidad;
        }
    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("gol1"))
        {
            Marcador.Instance.PuntuacionPlayer2();
            Marcador.Instance.Restart();
        }
        else
        {
            Marcador.Instance.PuntuacionPlayer1();
            Marcador.Instance.Restart();
        }
        this.InicarMovimiento();
    }


    // Update is called once per frame
    void Update()
    {

    }
}
