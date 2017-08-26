using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

    Text text;
    LevelManager levelManager;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        text = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {
        text.text = ("Time remaining " + levelManager.timeTillNextLevel);
    }
}
