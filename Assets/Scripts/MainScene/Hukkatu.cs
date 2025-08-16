using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hukkatu : MonoBehaviour
{
    public void HukkatuClick()
    {
        Debug.Log("Hukkatu");
        SceneManager.LoadScene("SampleScene");
    }
}
