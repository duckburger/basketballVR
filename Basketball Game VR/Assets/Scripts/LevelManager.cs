using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    private int currentSceneIndex;

    public float timeTillNextLevel;



    // Use this for initialization
    void Start()
    {
        // Load scene
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Load current index + 1


    }



    public void LoadNextLevel()
    {

        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadPreviousLevel()
    {
        SceneManager.LoadScene(currentSceneIndex - 1);
    }

    // Update is called once per frame
    void Update()
    {

        
        // print("Time till next level " + timeTillNextLevel);
        if (timeTillNextLevel > 0)
        {
            timeTillNextLevel -= Time.deltaTime;
            if (timeTillNextLevel < 0)
            {
                LoadNextLevel();
            }
            return;
        }
    }
}
