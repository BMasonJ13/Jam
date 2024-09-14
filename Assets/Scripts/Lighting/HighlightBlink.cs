using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class HighlightBlink : MonoBehaviour
{

    [SerializeField]
    private float timeBetweenFade = 3f;
    [SerializeField]
    private float fadeSpeed = 4f;
    [SerializeField]
    private float minFalloff = 0.3f;
    [SerializeField]
    private float maxFalloff = 0.8f;
    [SerializeField]
    private bool isBlinking = true;

    private float currentTarget;
    private float timer;
    private bool goingUp = true;

    private float delay;

    private new Light2D light;

    private void Start()
    {
        light = GetComponent<Light2D>();
        timer = timeBetweenFade;
        currentTarget = maxFalloff;

        delay = Random.Range(0.1f, .3f);
        timer += delay;
    }

    private void Update()
    {

        if (isBlinking)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                light.intensity = Mathf.Lerp(light.intensity, currentTarget, Time.deltaTime * fadeSpeed);

                if (Mathf.Abs(light.intensity - currentTarget) <= 0.01f)
                {
                    goingUp = !goingUp;
                    currentTarget = goingUp ? maxFalloff : minFalloff;
                    timer = timeBetweenFade + delay;
                }
            }
        }
    }

}
