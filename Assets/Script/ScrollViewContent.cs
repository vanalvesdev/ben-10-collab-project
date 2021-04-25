using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Button;

public class ScrollViewContent : MonoBehaviour
{
    public GameObject buttonPrefab;
    public List<string> listaMonsterName;
    public List<GameObject> contents;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fillContent(List<string> lista)
    {
        listaMonsterName = lista;
        for (int i = 0; i < listaMonsterName.Count; i++)
        {
            GameObject button = Instantiate(buttonPrefab, this.transform);
            contents.Add(button);
            button.GetComponentInChildren<Text>().text = listaMonsterName[i];
            button.GetComponent<Button>().onClick.AddListener(delegate { ButtonClicked(contents.IndexOf(button)); });
        }
    }

    void ButtonClicked(int index)
    {
        Debug.Log("Button "+index+" was clicked");
    }
}
