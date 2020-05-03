using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    private float Speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log(Time.deltaTime);
			this.velocity = transform.TransformDirection(Vector3.forward * Speed * Time.deltaTime);

            this.transform.TransformDirection(Vector3.forward * Speed * Time.deltaTime);
        }
    }
}
