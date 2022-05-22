using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerLabel;
    public float startTimer = 0;

    public float time;

    // Update is called once per frame
    void Update()
    {
        if (startTimer > 0)
        {
            time += Time.deltaTime;

            var minutes = time / 60;
            var seconds = time % 60;
            var fraction = (time * 100) % 100;

            timerLabel.text = string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction);
        }

        else
        {

        }

    }
}
