using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LevelManager : MonoBehaviour
{
    private bool[,] generators = new bool[3,3];

    private bool[,] genMatchA = { {true, true, false }, { true, true, false }, { true, true, true } };

    [SerializeField]
    private Generator[] gens;

    [SerializeField]
    private Light2D[] alertLights;

    [SerializeField]
    private GameObject levelEnder;

    [SerializeField]
    private string dialogName;
    [SerializeField]
    private Dialogue dialog;

    private bool isComplete = false;

    [SerializeField]
    private new Light2D light;

    public void UpdateGenStatus(int x, int y)
    {

        int temp = x;
        x = y;
        y = temp;

        generators[x, y] = !generators[x, y];
        if(x > 0)
            generators[x - 1, y] = !generators[x - 1, y];
        if (x < 2)
            generators[x + 1, y] = !generators[x + 1, y];
        if (y > 0)
            generators[x, y - 1] = !generators[x, y - 1];
        if (y < 2)
            generators[x, y + 1] = !generators[x, y + 1];

        UpdateGen();
    }

    private void UpdateGen()
    {
        int count = 0;
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                gens[count++].Toggle(generators[i, j]);
            }
        }

        if (checkCorrect())
        {
            isComplete = true;
            levelEnder.SetActive(true);
            dialog.gameObject.SetActive(true);
            dialog.StartDialogueOnInteraction(dialogName);
            foreach (Light2D l in alertLights)
            {
                l.GetComponent<BlinkingLights>().enabled = false;
                l.enabled = false;
            }
        }

    }

    private void Update()
    {
        if (isComplete)
        {
            light.intensity = Mathf.Lerp(light.intensity, 0.8f, 5 * Time.deltaTime);
           
        }
    }

    public bool checkCorrect()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (generators[i, j] != genMatchA[i, j])
                    return false;
            }
        }

        return true;
    }
}
