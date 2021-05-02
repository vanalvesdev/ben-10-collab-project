using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    
    SpriteRenderer spriteRenderer;
    Pasta pasta;
    public Text Artista;
    public Text Alien;

    

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        pasta = GameObject.FindObjectOfType<Pasta>();
        redrawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    

    public void redrawn()
    {
        Pasta.CharactersInfo charac = pasta.getcurrentcharacter();
        spriteRenderer.sprite = charac.image;
        Artista.text = charac.artist;
        Alien.text = charac.name;

    }

    public void next()
    {
        pasta.next();
    }

    public void previous()
    {
        pasta.previous();
    }
}