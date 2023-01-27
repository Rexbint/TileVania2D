using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D enemyRigidbody;
    BoxCollider2D flipCollider;
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
        flipCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        enemyRigidbody.velocity = new Vector2(moveSpeed, enemyRigidbody.velocity.y);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        moveSpeed = -moveSpeed;
        FlipEnemyFacing();
    }

    void FlipEnemyFacing()
    {
        transform.localScale = new Vector2(-(Mathf.Sign(enemyRigidbody.velocity.x)),1f);
    }
}
