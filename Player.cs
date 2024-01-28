using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float shootInterval;
    public float shootTimer;
    public int points;

    void Update()
    {
        Move();
        shootTimer -= Time.deltaTime;
        Shoot();
    }

    public Projectile projectilePrefab;
    public Transform shootPoint;

    void Shoot()
    {
        if(shootTimer <= 0)
        {
            Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            shootTimer = shootInterval;
        }
        
    }

    void Move()
    {
        if(Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
    }
}
