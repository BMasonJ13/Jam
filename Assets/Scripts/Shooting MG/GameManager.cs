using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    [Header("Minigame Settings")]
    [SerializeField]
    private float trialDuration;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private int reloadIndex;

    [Header("GUI")]
    [SerializeField]
    private TextMeshProUGUI timer;
    [SerializeField]
    private Image panel;

    [Header("Completion Game Objects")]
    [SerializeField]
    private new Light2D light;
    [SerializeField]
    private GameObject[] spawners;
    [SerializeField]
    private GameObject levelLoader;



    private bool isComplete;

    void Update()
    {
      
        HandleTimer();
        CheckPlayerStatus();

        if (isComplete)
        {
            light.intensity = Mathf.Lerp(light.intensity, 1.0f, 5 * Time.deltaTime);

        }

    }

    private void CheckPlayerStatus()
    {
        if (!player.activeInHierarchy)
        {
            panel.gameObject.SetActive(true);
            timer.gameObject.SetActive(false);
        }
    }

    private void HandleTimer()
    {
        trialDuration -= Time.deltaTime;

        if(trialDuration <= 0)
        {
            isComplete = true;

            levelLoader.SetActive(true);
            timer.gameObject.SetActive(false);

            foreach(GameObject g in spawners)
            {
                Destroy(g);
            }

        }

        timer.text = "Time left: " + trialDuration.ToString("#.##");
    }

    public void ReloadLevel()
    {
        SceneManager.LoadSceneAsync(reloadIndex);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
