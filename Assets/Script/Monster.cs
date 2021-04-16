using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    List<MonsterInfo> monsters = new List<MonsterInfo>();
    int index = 0;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        fillList();
        spriteRenderer = GetComponent<SpriteRenderer>();
        redrawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void fillList()
    {
        monsters.Add(new MonsterInfo("AlienX", Resources.Load<Sprite>("monstros/AlienX_@ncrwly"), "@ncrwly"));
        monsters.Add(new MonsterInfo("Ameaça Aquatica", Resources.Load<Sprite>("monstros/Ameaça aquatica_@desenhai"), "@desenhai"));
        monsters.Add(new MonsterInfo("Aquatico", Resources.Load<Sprite>("monstros/Aquático_@abyssbreno"), "@abyssbreno"));
        monsters.Add(new MonsterInfo("Arraia a Jato", Resources.Load<Sprite>("monstros/Arraia a jato_@tavisko"), "@tavisko"));
        monsters.Add(new MonsterInfo("Artrópode", Resources.Load<Sprite>("monstros/artrópode_@pombodioclin"), "@pombodioclin"));
        monsters.Add(new MonsterInfo("Bala de canhão Supremo", Resources.Load<Sprite>("monstros/Bala de canhão supremo_ @joshdesenha"), "@joshdesenha"));
        monsters.Add(new MonsterInfo("Besta", Resources.Load<Sprite>("monstros/Besta_@raphael_cafes") , "@raphael_cafes"));
        monsters.Add(new MonsterInfo("Besta Suprema", Resources.Load<Sprite>("monstros/Besta_Suprema_@drawingfroes"), "@raphael_cafes"));
        monsters.Add(new MonsterInfo("Chamalien", Resources.Load<Sprite>("monstros/Chamalien_@pumpiking"), "@pumpiking"));
        monsters.Add(new MonsterInfo("Doutor animal", Resources.Load<Sprite>("monstros/Doutor animal. @dudesken"), "@dudesken"));
        monsters.Add(new MonsterInfo("Gigante", Resources.Load<Sprite>("monstros/Gigante_@jardellucas_art"), "@jardellucas_art"));
        monsters.Add(new MonsterInfo("Glutao", Resources.Load<Sprite>("monstros/glutao_@thunlob"), "@thunlob"));
        monsters.Add(new MonsterInfo("Gwen Massa Cizenta", Resources.Load<Sprite>("monstros/gwen massa cinzenta_@d_evotchka"), "@d_evotchka"));
        monsters.Add(new MonsterInfo("Quatro Braços", Resources.Load<Sprite>("monstros/Quatro Braços_@elruditos"), "@elruditos"));
        monsters.Add(new MonsterInfo("ReinrassicIII_", Resources.Load<Sprite>("monstros/ReinrassicIII_@gabijacques.art"), "@gabijacques.art"));
        monsters.Add(new MonsterInfo("Zombozo", Resources.Load<Sprite>("monstros/zombozo_@henrikscarts"), "@henrikscarts"));
    }

    public void redrawn()
    {
        spriteRenderer.sprite = monsters[index].image;
    }

    public void next()
    {
        index++;
        if (index > monsters.Count - 1) index = 0;
        redrawn();
    }

    public void previous()
    {
        index--;
        if (index < 0) index = monsters.Count - 1;
        redrawn();
    }

    public class MonsterInfo
    {
        public string name;
        public Sprite image;
        public string artist;

       public MonsterInfo(string _name, Sprite _image, string _artist)
        {
            name = _name;
            image = _image;
            artist = _artist;
        }
    }
}
