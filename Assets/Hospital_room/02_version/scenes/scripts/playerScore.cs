using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerScore : MonoBehaviour
{
    public Text scoreText;
    public int score=0;
    // Start is called before the first frame update
    public void AddScore() {
        score++;
        scoreText.text = "Score:"+score.ToString()+" / 14";
    
    }
}
