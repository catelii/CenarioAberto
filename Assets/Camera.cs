using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public bool Mouse = true;
    public float Sensibilidade = 2.0f;

    private float mouseX = 0.0f, mouseY = 0.0f;


    void Start () {

        if (!Mouse)
        {
            return;
        }

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
	
	// Update is called once per frame
	void Update () {

        mouseX += Input.GetAxis("Mouse X") * Sensibilidade;
        mouseY -= Input.GetAxis("Mouse Y") * Sensibilidade;

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}
