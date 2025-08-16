using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    TextMeshProUGUI timerText;
    public float time = 2.0f;
    public float cleartime = 30.0f;
    private int count = 0;
    public bool hutuClick = false;

    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        Debug.Log(timerText);
        timerText.text = time.ToString();
    }

    void Update()
    {
        time -= Time.deltaTime;

        if (hutuClick)
        {
            time += 2;
            hutuClick = false;
        }
        timerText.text = time.ToString("F0") + "•b";
        if (time < 0.0f)
        {
            SceneManager.LoadScene("GameOverScene");
        }
        if (time > cleartime)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
