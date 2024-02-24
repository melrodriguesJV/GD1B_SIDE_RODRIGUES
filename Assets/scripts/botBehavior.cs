using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botBehavior : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private float range;
    [SerializeField] private int damage;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private LayerMask characterLayer;
    private float cooldownTimer = Mathf.Infinity;


    private void Update()
    {
        cooldownTimer += Time.deltaTime;


        if (PlayerInSight())
        {
            if (cooldownTimer >= attackCooldown)
            {

            }

        }
    }
    private bool PlayerInSight()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounds.center + transform.right *range *transform.localScale.x,
            new Vector3 (boxCollider.bounds.size.x *range, boxCollider.bounds.size.y , boxCollider.bounds.size.z)
            , 0,Vector2.left,0,characterLayer);
        return hit.collider != null;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(boxCollider.bounds.center + transform.right * range * transform.localScale.x,
            new Vector3(boxCollider.bounds.size.x * range, boxCollider.bounds.size.y, boxCollider.bounds.size.z));
    }
}
