using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float moveLimit = 4.5f;

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        Vector2 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x + moveInput * moveSpeed * Time.deltaTime, -moveLimit, moveLimit);
        transform.position = playerPos;

    }
}
