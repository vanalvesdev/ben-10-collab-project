using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treco2 : MonoBehaviour
{
    public GameObject treco2;
    public GameObject fundo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ActiveTreco2()
    {
        treco2.SetActive(true);
        fundo.SetActive(true);
    }
}
