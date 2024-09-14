using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private bool[,] generators = new bool[3,3];

    [SerializeField]
    private Generator[] gens;

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
    }

}
