using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float second;
    public int minute;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       second -= Time.deltaTime; 
       if (second <= 0)
       {
            if(minute != 0)
            {
                print("Осталось: "+ minute + " мин");
                second += 59;
                minute -= 1;
            }
            else
            {
             int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
            }
       }
       timerText.text = string.Format("{0:D2}:{1:D2}", minute, Mathf.FloorToInt(second));
    }
}
