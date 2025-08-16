using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleBackSc : MonoBehaviour
{
    public GameObject titleBack;
    public float time = 5.0f;

    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0.0f)
        {
            titleBack.SetActive(true);
        }
    }

    public void Finish()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
