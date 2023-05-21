using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed)*Time.deltaTime; // time.deltaTime -> will keep the mmultiplication same no matter the numbers of time frames

        if(transform.position.x<deadZone)
        {
            Destroy(gameObject);
        }

    }
}
