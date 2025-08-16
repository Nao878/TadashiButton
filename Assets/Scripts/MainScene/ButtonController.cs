using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public float buttonSpeed = 1.3f;

    private void FixedUpdate()
    {
        transform.Translate(0, -buttonSpeed, 0);

        if (transform.position.y < -100.0f)
        {
            Destroy(gameObject);
        }
    }

    public void HutuClick()
    {
        CountDown countDown;
        GameObject obj = GameObject.Find("Text (TMP)");
        countDown = obj.GetComponent<CountDown>();
        countDown.hutuClick = true;
    }
}
