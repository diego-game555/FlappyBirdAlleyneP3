using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePool : MonoBehaviour
{
    private GameObject[] columns;
    public int columnPoolSize = 5;
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
