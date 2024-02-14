using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jump_force;

    [SerializeField]
    private Rigidbody2D rgbd;

    private bool grounded = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rgbd.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, rgbd.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rgbd.velocity = new Vector2(rgbd.velocity.x, jump_force);
            grounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            grounded = true;
        }
    }
}