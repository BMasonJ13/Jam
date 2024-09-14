using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Light2D))]
public class BlinkingLights : MonoBehaviour
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

    private new Light2D light;

    private void Start()
    {
        light = GetComponent<Light2D>();
        timer = timeBetweenFade;
        currentTarget = maxFalloff;
    }

    private void Update()
    {

        if (isBlinking)
        {
            timer -= Time.deltaTime;

            if(timer <= 0)
            {
                light.falloffIntensity = Mathf.Lerp(light.falloffIntensity, currentTarget, Time.deltaTime * fadeSpeed);

                if(Mathf.Abs(light.falloffIntensity - currentTarget) <= 0.01f)
                {
                    goingUp = !goingUp;
                    currentTarget = goingUp ? maxFalloff : minFalloff;
                    timer = timeBetweenFade;
                }
            }
        }
    }

}
