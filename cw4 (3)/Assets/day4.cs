using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class day4 : MonoBehaviour
{
    public int score = 0;
    public Text scoretext;
    public int inc = 1;
    public Text inctext;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
     public void scoreUp()
    {
        score += inc;
        scoretext.text = score.ToString();

    }

    public void store()
    {
        if (score >= 2) 
        {
            score -= 2;
            inc += 1;
            scoretext.text = score.ToString();

        }
    }
    
}
      