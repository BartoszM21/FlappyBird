using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesController : MonoBehaviour
{

    public float Speed;
    public float DespawnPoint;
    public float SpawmPoint;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);    
        
        if(transform.position.x < DespawnPoint.position.x)
        {

        }
        }
    }
}
