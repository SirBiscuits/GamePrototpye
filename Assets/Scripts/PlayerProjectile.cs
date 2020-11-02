using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public float speed;

    public Transform enemy;
    private Vector2 target;

    public int damage = 5;

    private Enemy health;
    private void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;

        target = new Vector2(enemy.position.x, enemy.position.y);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {   //If projectiles hit an enemy or wall they disappear
        if (other.CompareTag("Enemy")|| other.CompareTag("Walls"))
        {
            DestroyProjectile();
            other.gameObject.GetComponent<Enemy>().TakeDamage(damage);
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
