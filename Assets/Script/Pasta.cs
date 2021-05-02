using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasta : MonoBehaviour
{
    public List<CharactersInfo> characters = new List<CharactersInfo>();
    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void fillList()
    {
        characters.Add(new CharactersInfo("Reinrassic III", Resources.Load<Sprite>("monstros/ReinrassicIII_@gabijacques.art"), "@gabijacques.art"));
        characters.Add(new CharactersInfo("Zombozo", Resources.Load<Sprite>("monstros/zombozo_@henrikscarts"), "@henrikscarts"));
        characters.Add(new CharactersInfo("Rook Blonko", Resources.Load<Sprite>("monstros/Rook Blonko @fubukiiast"), "@fubukiiast"));
        characters.Add(new CharactersInfo("Ultimos", Resources.Load<Sprite>("monstros/ultimos_@cabeloneto1"), "@cabeloneto1"));
        characters.Add(new CharactersInfo("Albedo", Resources.Load<Sprite>("monstros/@mordidoart"), "@mordidoart"));
        characters.Add(new CharactersInfo("Ben Tennyson", Resources.Load<Sprite>("monstros/Ben10_@yaypumpkin"), "@yaypumpkin"));
        characters.Add(new CharactersInfo("Ben 10.000", Resources.Load<Sprite>("monstros/Ben10k @Makice_Hit"), "@Makice_Hit"));
        characters.Add(new CharactersInfo("Gwen Tennyson", Resources.Load<Sprite>("monstros/gwen_@vinicas"), "@vinicas"));
        characters.Add(new CharactersInfo("Gwen 10.000", Resources.Load<Sprite>("monstros/gwen10000_@jefferson83r"), "@jefferson83r"));
        characters.Add(new CharactersInfo("Kevin Levin", Resources.Load<Sprite>("monstros/kevin@_yurics"), "@_yurics"));
        characters.Add(new CharactersInfo("Kevin Supremo", Resources.Load<Sprite>("monstros/kevinsupremo_@jvictorbp"), "@jvictorbp"));
        characters.Add(new CharactersInfo("Enoch", Resources.Load<Sprite>("monstros/enoch@julhoo"), "@julhoo"));
        characters.Add(new CharactersInfo("Lata Velha", Resources.Load<Sprite>("monstros/LataVelha_@urzodesenhero"), "@urzodesenhero"));
        characters.Add(new CharactersInfo("Max Tennyson", Resources.Load<Sprite>("monstros/Max Tennyson_@rogemartines"), "@rogemartines"));
        characters.Add(new CharactersInfo("Professor Paradoxo", Resources.Load<Sprite>("monstros/ProfessorParadoxo_@visturine"), "@visturine"));
        characters.Add(new CharactersInfo("Seis-seis", Resources.Load<Sprite>("monstros/seis-seis_@zacarovs"), "@zacarovs"));
        characters.Add(new CharactersInfo("Tini", Resources.Load<Sprite>("monstros/Tini_@vandersarts04"), "@vandersarts04"));
        characters.Add(new CharactersInfo("Verdona", Resources.Load<Sprite>("monstros/verdona_@rafadreu"), "@rafadreu"));
        characters.Add(new CharactersInfo("Azmuth", Resources.Load<Sprite>("monstros/Azmuth_@lkv_7f"), "@lkv_7f"));
        characters.Add(new CharactersInfo("Ishyiama", Resources.Load<Sprite>("monstros/ishyiama@nathsenaart"), "@nathsenaart"));
        characters.Add(new CharactersInfo("Vilgax", Resources.Load<Sprite>("monstros/vilgax_@fpjuni"), "@fpjuni"));
        characters.Add(new CharactersInfo("Raff", Resources.Load<Sprite>("monstros/Raff_@auntkey.art"), "@auntkey.art"));
        characters.Add(new CharactersInfo("Skurd", Resources.Load<Sprite>("monstros/Skurd@rafaccaldas"), "@rafaccaldas"));
        characters.Add(new CharactersInfo("Zs'Skayr", Resources.Load<Sprite>("monstros/Zs_Skayr @rosa_lucasrosa"), "@rosa_lucasrosa"));
    }

    void Awake()
    {
        fillList();
    }

    public void next()
    {
        index++;
        if (index > characters.Count - 1) index = 0;
    }

    public void previous()
    {
        index--;
        if (index < 0) index = characters.Count - 1;
    }

    public void jumpTo(int _index)
    {
        index = _index;
    }

    public CharactersInfo getcurrentcharacter()
    {
        return characters[index];
    }

    public class CharactersInfo
    {
        public string name;
        public Sprite image;
        public string artist;
        public bool enableAnimator;
        public string animationTrigger;

        public CharactersInfo(string _name, Sprite _image, string _artist)
        {
            name = _name;
            image = _image;
            artist = _artist;
            enableAnimator = false;
        }

        public CharactersInfo(string _name, Sprite _image, string _artist, bool _enableAnimator, string _animationTrigger)
        {
            name = _name;
            image = _image;
            artist = _artist;
            enableAnimator = _enableAnimator;
            animationTrigger = _animationTrigger;
        }
    }
}
