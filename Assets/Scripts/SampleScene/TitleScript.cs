using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{
    public GameObject image, image2,text1,text2;
    public int i = 0;

    public void TestClick()
    {
        Debug.Log("a");
        ++i;
    }

    public void Update()
    {
        if (i == 1)
        {
            image.SetActive(false);
            image2.SetActive(true);
        }
        if (i == 2)
        {
            text1.SetActive(true);
        }
        if (i == 3)
        {
            text2.SetActive(true);
        }
        if (i == 4)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
