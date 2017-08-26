using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Parent transform");
        print(transform);
        print("Camera transform");
        
	}
	
	// Update is called once per frame
	void Update () {
        float rotationSpeed = 5f;
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        Camera camera = GetComponentInChildren<Camera>();
        camera.transform.localRotation = camera.transform.localRotation * Quaternion.Euler(-mouseY, 0, 0);
        transform.localRotation = transform.localRotation * Quaternion.Euler(0, mouseX, 0);
    }
}
