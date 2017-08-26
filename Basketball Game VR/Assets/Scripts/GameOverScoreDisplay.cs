using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {

    Text text;
    AbsorbScorekeeper absorbScoreKeeper;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        absorbScoreKeeper = FindObjectOfType<AbsorbScorekeeper>();
	
	}
	
	// Update is called once per frame
	void Update () {
        text.text = ("You earned " + absorbScoreKeeper.score + " points");

	
	}
}
