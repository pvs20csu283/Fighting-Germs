using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
  public TextMesh scoreText;
   private float score;


    // Update is called once per frame
    void Update()
    {
        score += 1 * Time.deltaTime;
        scoreText.text = ((int)score).ToString();
    }
}
