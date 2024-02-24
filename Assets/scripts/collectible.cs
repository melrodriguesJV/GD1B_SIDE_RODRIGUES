using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
    public BoxCollider2D bc2d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.IsTouchingLayers(3))
        {
            Destroy(bc2d.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
