using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arms1fbx : MonoBehaviour
{

    public Animation throwBall;
    public arms1fbx ball;
    // Start is called before the first frame update
    void Start()
    {
        throwBall = GetComponent<Animation>();
        ball = GetComponent<arms1fbx>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void releaseBall(){
        // if(!throwBall.isPlaying("arms1fbx")){
        //     //make ball kinematic
        // }
    }

}
