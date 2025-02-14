using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowPlayer : MonoBehaviour
{
    public GameObject cube;


    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = cube.transform.position + new Vector3(0, 6, -10);
    }
}
