using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    public GameObject other;
    public GameObject primary;
    private Text score;
    public float limit = 30.0f;
    private float distance = 0.0f;

    void Start()
    {
        score = GetComponent<Text>();
        score.text = "Distance: " + (int)distance + "/" + (int)limit;
    }
    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(primary.transform.position, other.transform.position);
        if (distance < limit)
        {
            score.text = "Distance: " + (int)distance + "/" + (int)limit;

        }
        else
        {
            score.text = "YOU LOST";
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(sceneName: "Start");
            // End here 
        }
    }
}
