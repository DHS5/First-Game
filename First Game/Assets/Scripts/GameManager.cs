using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject dogPrefab;
    public GameObject foxPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        GenerateAnimal();
    }

    private void GenerateAnimal()
    {
        if (MainManager.Instance.animal == "Dog")
        {
            Instantiate(dogPrefab, dogPrefab.transform.position, dogPrefab.transform.rotation);
        }
        else if(MainManager.Instance.animal == "Fox")
        {
            Instantiate(foxPrefab, foxPrefab.transform.position, foxPrefab.transform.rotation);
        }
    }
}
