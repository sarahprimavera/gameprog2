using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endOfClub : MonoBehaviour
{
    private GameObject sphere;
    private float force = 0.0f;
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip hitBallClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Sphere")
        {
            audioSource.PlayOneShot(hitBallClip);
        }
    }
}
