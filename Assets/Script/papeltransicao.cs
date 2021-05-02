using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papeltransicao : MonoBehaviour
{
    public GameObject prefab;
    Animator animator;
    public GameObject alien;
    public GameObject artist;
    

    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            transicao();
            GetComponentInChildren<Character>().previous();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            transicao();
            GetComponentInChildren<Character>().next();
        }
    }

    public void transicao()
    {
        animator.SetTrigger("transicao");
    }

    public void duplicate()
    {
        Debug.Log("duplicate");
        Instantiate(prefab);
    }

    public void destroy()
    {
        Debug.Log("Destroy");
        Destroy(gameObject);
    }

    public void hideText()
    {
        alien.SetActive(false);
        artist.SetActive(false);
    }

    public void showText()
    {
        alien.SetActive(true);
        artist.SetActive(true);
    }
}
