using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfClub : MonoBehaviour
{
    private Animator animator;
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip swingClip;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // if space bar is down play pull back
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.enabled = true;
            animator.Play("pull_back");
            audioSource.PlayOneShot(swingClip);
        }
        //if spcae bar is up play push?
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.enabled = true;
            animator.Play("push");
        }
    }
}
