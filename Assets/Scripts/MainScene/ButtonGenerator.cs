using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGenerator : MonoBehaviour
{
    public GameObject canvas,buttonPrefab,buttonInsekiPrefab;
    public float span = 0.5f,spanInseki = 5.0f;
    float delta,deltaInseki = 0f;

    void FixedUpdate()
    {
        this.delta += Time.deltaTime;
        //this.deltaInseki += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(buttonPrefab);
            int px = Random.Range(-100, 200);
            go.transform.position = new Vector3(px, 170, 0);

            canvas = GameObject.Find("Canvas");
            go.transform.SetParent(canvas.transform, false);
        }
        //if (this.deltaInseki > this.spanInseki)
        {
            //this.deltaInseki = 0;
            //GameObject goInseki = Instantiate(buttonInsekiPrefab);
            //int pxInseki = Random.Range(-100, 200);
            //goInseki.transform.position = new Vector3(pxInseki, 170, 0);

            //canvas = GameObject.Find("Canvas");
            //goInseki.transform.SetParent(canvas.transform, false);
        }
    }
}
