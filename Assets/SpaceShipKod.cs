using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipKod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Rigidbody2D>().velocity = Vector3.left * 10.0f;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
