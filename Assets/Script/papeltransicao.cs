using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papeltransicao : MonoBehaviour
{
    public GameObject prefab;
    Animator animator;
    
    

    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetTrigger("transicao");
            
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("transicao");
            
        }
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
}
