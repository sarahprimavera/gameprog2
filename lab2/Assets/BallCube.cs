using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCube : MonoBehaviour
{
    Vector3 ogPosition;

    // Start is called before the first frame update
    void Start()
    {
        ogPosition = new Vector3(gameObject.transform.position.x, 
                                gameObject.transform.position.y, 
                                gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hole")
        {
            gameObject.transform.position = ogPosition;
        }

    }
}
