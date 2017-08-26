using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

    public float speed;
    public GameObject ball;
    private Camera camera;
   

	// Use this for initialization
	void Start () {
        camera = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject instance = Instantiate(ball);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = camera.transform.rotation * Vector3.forward * speed;
        }
    }
}
