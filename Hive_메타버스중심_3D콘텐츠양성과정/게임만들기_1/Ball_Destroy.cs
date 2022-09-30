using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "¹Ù´Ú")
        {
            Destroy(this.gameObject);
        }
        
    }
    void Update()
    {
        if (transform.position.y < -5.0f)
        {
            Destroy(this.gameObject);
        }
    }

}
