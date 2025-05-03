using UnityEngine;

public class Region : MonoBehaviour
{
    public string regionName;
    public int population;
    public int armySize;

    private void OnMouseDown()
    {
        Debug.Log($"Clicked Region: {regionName} | Population: {population} | Army: {armySize}");
    }
}
