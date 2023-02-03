using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCas : MonoBehaviour
{
    float MaxDistance = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray();
    }
    void Ray()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, MaxDistance);
        if (hit.collider == null) return;
        hit.transform.GetComponent<SpriteRenderer>().color = Color.red;
    }
}
