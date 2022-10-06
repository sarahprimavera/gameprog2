using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private Rigidbody sphereRigidbody;
    private float force;
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip rollClip;
    // Start is called before the first frame update
    void Start()
    {
        sphereRigidbody = GetComponent<Rigidbody>();
        force = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "endOfClub")
        {
            sphereRigidbody.AddForce(new Vector3(-1f, 2f, 2f) * force, ForceMode.Impulse);
            audioSource.PlayOneShot(rollClip);
        }
    }
}
