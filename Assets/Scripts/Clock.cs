using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public float timerValue = 0;
    public float timerMaxValue = 10;
    public Slider timerVisuals;
    public GameObject bird;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerVisuals.maxValue = timerMaxValue;
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += Time.deltaTime;

        if (timerValue > 2)
        {
            Debug.Log("2");
      bird.SetActive(false);
        }

    if (timerValue > 3)
            {
            Debug.Log("3");
            bird.SetActive(true);
        }

        if (timerValue > 5)
        {
            Debug.Log("5");
            bird.SetActive(false);
        }

        if (timerValue > 6)
        {
            Debug.Log("6");
            bird.SetActive(true);
        }

        if (timerValue > 8)
        {
            Debug.Log("8");
            bird.SetActive(false);
        }

        if (timerValue > 9)
        {
            Debug.Log("9");
            bird.SetActive(true);
        }


        timerVisuals.value = timerValue;
    }
}
