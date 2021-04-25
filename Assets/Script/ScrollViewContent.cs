﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Button;

public class ScrollViewContent : MonoBehaviour
{
    public GameObject buttonPrefab;
    public List<GameObject> contents;
    public Monster monsterScript;

    // Start is called before the first frame update
    void Start()
    {
        monsterScript = FindObjectOfType<Monster>();
        fillContent(monsterScript.monsters.Select(a => a.name).ToList());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fillContent(List<string> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            GameObject button = Instantiate(buttonPrefab, this.transform);
            contents.Add(button);
            button.GetComponentInChildren<Text>().text = lista[i];
            button.GetComponent<Button>().onClick.AddListener(delegate { ButtonClicked(contents.IndexOf(button)); });
        }
    }

    void ButtonClicked(int index)
    {
        Debug.Log("Button "+index+" was clicked");
        monsterScript.jumpTo(index);
    }
}
