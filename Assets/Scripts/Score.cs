using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public int currentScore = 0;

    private void Start() 
    {
        score = 0;    
    }

    private void Update() 
    {
        currentScore = score;
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
