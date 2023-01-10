using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;
    int lives = 10;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score: " + score + "\n" + "Lives: " + lives);
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int value)
    {
        lives += value;
        if(lives < 1)
        {
            Debug.Log("Out of Lives");
            lives = 0;
        }
        Debug.Log("Lives: " + lives);
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }
}
