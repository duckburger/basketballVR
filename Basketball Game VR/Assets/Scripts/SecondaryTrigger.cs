using UnityEngine;
using System.Collections;

public class SecondaryTrigger : MonoBehaviour {


    ScoreKeeper scoreKeeper;
    Collider expectedCollider;


    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }


    public void ExpectCollider(Collider collider)
    {
        expectedCollider = collider;

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider == expectedCollider)
        {
            scoreKeeper.IncrementScore(1);
            
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
