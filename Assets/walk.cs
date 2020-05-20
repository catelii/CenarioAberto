using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour {

    public float Vertical;
    public float Horizontal;

	void Start () {
      
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //float translate = (Input.GetAxis ("Vertical") * _velocidade) * Time.deltaTime;
        //transform.Translate (0, 0, translate);
        print("Vertical" + Input.GetAxis("Vertical"));
        print("Horizontal" + Input.GetAxis("Horizontal"));

        float translate = (Input.GetAxis("Vertical") * Vertical)* Time.deltaTime;
        float rotation = (Input.GetAxis("Horizontal") * Horizontal) * Time.deltaTime;
        transform.Translate(rotation, 0, translate);
    }
}
