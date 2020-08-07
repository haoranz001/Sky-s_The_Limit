using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeping : MonoBehaviour
{
    private Text score;
    public GameObject capsule;
    static public int ScoreHighest = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        score.text = "Score: " + ScoreHighest;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if((int)capsule.transform.position.y > ScoreHighest)
        {
            ScoreHighest = (int)capsule.transform.position.y;
        }
        
        score.text = "Score: " + ScoreHighest;
    }

    //void OnDisable()
    //{
    //    PlayerPrefs.SetInt("score", ScoreHighest);
    //}
    //void OnEnable()
    //{
    //    ScoreHighest = PlayerPrefs.GetInt("score");
    //}
}
