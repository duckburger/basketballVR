using UnityEngine;
using System.Collections;

public class PrimaryTrigger : MonoBehaviour {

    SecondaryTrigger secondaryTrigger;

	void OnTriggerEnter (Collider collider)
    {
        
        SecondaryTrigger secondaryTrigger = GetComponentInChildren<SecondaryTrigger>();
        secondaryTrigger.ExpectCollider(collider);
        
    }
	
	
}
