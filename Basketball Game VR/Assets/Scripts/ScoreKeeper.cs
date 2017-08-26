using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    public int score = 0;

    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void IncrementScore(int increment)
    {
        score += increment;
        print("Your score is " + score);
        audioSource.Play();
    }
}
