using UnityEngine;
using System.Collections;



public class DetectScoring : MonoBehaviour {


    public int scoreIncrement;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter (Collision collision)
    {
        ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
        scoreKeeper.IncrementScore(scoreIncrement);

    }
}
