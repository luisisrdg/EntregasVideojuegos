using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labola : MonoBehaviour
{
    [SerializeField] private Vector2 inicialVelocity;
    [SerializeField] private float velocityMultiplayer;
    private Rigidbody2D rb;
    private bool isbolling = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        launch();
    }

    private void launch()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isbolling)
        {
            transform.SetParent(null);
            rb.velocity = inicialVelocity;
            isbolling = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bloque"))
        {
            Destroy(collision.gameObject);
            rb.velocity *= velocityMultiplayer;
            ManagerArka.Instance.BlockDestroyed();
        }
        VelocityFix();
    }

    private void VelocityFix()
    {
        float velocityDe1ta = 0.5f;
        float minVelocity = 0.2f;

        if (Mathf.Abs(rb.velocity.x) < minVelocity)
        {
            velocityDe1ta *= Random.value < 0.5f ? velocityDe1ta : -velocityDe1ta;
            rb.velocity *= new Vector2(velocityDe1ta, 0f);
        }
        if (Mathf.Abs(rb.velocity.y) < minVelocity)
        {
            velocityDe1ta *= Random.value < 0.5f ? velocityDe1ta : -velocityDe1ta;
            rb.velocity *= new Vector2(0f, velocityDe1ta);
        }
    }
    }
