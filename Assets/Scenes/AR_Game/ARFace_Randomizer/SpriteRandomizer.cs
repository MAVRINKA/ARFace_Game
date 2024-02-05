using UnityEngine;
using System;
using System.Collections.Generic;

public class SpriteRandomizer : MonoBehaviour
{
    public List<string> objectsList = new List<string>();
    private int totalCount = 30;
    private int perListCount;

    private Dictionary<int, List<string>> themedLists = new Dictionary<int, List<string>>();
    List<string> names = new List<string> { "Гриффиндор", "Слизерин", "Пуффендуй", "Когтевран" };

    void Start()
    {
        perListCount = totalCount / 4;
        for (int i = 0; i < totalCount; i++)
        {
            objectsList.Add("Object " + (i + 1));
        }

        for (int i = 1; i <= 4; i++)
        {
            List<string> newList = new List<string>();
            for (int j = 0; j < perListCount; j++)
            {
                newList.Add(objectsList[(i - 1) * perListCount + j]);
            }
            themedLists.Add(i, newList);
        }

    }

    public void Randomize()
    {

        if (totalCount > 0)
        {
            //int indx = UnityEngine.Random.Range(0, names.Count);
            //string name = names[indx];

            int randomTheme = UnityEngine.Random.Range(1, 5);
            if (themedLists[randomTheme].Count > 0)
            {
                int index = UnityEngine.Random.Range(0, themedLists[randomTheme].Count);
                string selectedObject = themedLists[randomTheme][index];
                Debug.Log("Theme " + randomTheme + " - " + selectedObject);
                themedLists[randomTheme].RemoveAt(index);
                totalCount--;
            }
            else
            {
                Debug.Log("Theme " + randomTheme + " is empty");
            }
        }
        else
        {
            Debug.Log("All objects have been selected");
        }
    }
}
