using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countdownTimer : MonoBehaviour
{
    private TMPro.TextMeshProUGUI Timer;
    public int timeRemaining = 10;
    public float delay = 60f;

    void Start()
    {
        Timer = GetComponent<TMPro.TextMeshProUGUI>();
        Timer.text = timeRemaining.ToString();
        StartCoroutine(StartCountdown());
    }

    // Update is called once per frame
    IEnumerator StartCountdown()
    {
        while (timeRemaining > 0)
        {
            Timer.text = timeRemaining.ToString();
            timeRemaining -= 1;
            yield return new WaitForSeconds(delay);
        }
    }
}
