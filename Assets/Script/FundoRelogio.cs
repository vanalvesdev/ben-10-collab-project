using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FundoRelogio : MonoBehaviour
{
    public GameObject texto_relogio;
    public GameObject monstro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ActiveMonster()
    {
        texto_relogio.SetActive(true);
        monstro.SetActive(true);
    }
}
