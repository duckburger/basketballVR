using UnityEngine;
using System.Collections;

public class AbsorbScorekeeper: MonoBehaviour {

    public int score;

	// Use this for initialization
	void Start () {

        ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper>();
        score = oldKeeper.score;
        Destroy(oldKeeper.gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
