using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefab_Ball : MonoBehaviour
{
    public GameObject 복제공;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject item = Instantiate(복제공) ;
            float x = Random.Range (-3,3);
            item.transform.position = new Vector3(x, 10, 0);


        }
    }
}
