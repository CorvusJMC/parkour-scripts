using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTimerScript : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name == "startRace")
        {
            setTimer(1);
        }

        if (hit.gameObject.name == "finishRace")
        {
            setTimer(0);
        }
    }

    void setTimer (int t)
    {
        timer playerTimer = this.GetComponent<timer>();
        playerTimer.startTimer = t;
    }
}
