using UnityEngine;
using System.Collections;

public class BallBounceSound : MonoBehaviour {

    


    

    void OnCollisionEnter (Collision collision)
    {


        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
}
