using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objPrefab;
    // Start is called before the first frame update
    void Start()
    {
        void SpawnWhatiNeed(GameObject objPrefab)
        {
             Instantiate(objPrefab);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
