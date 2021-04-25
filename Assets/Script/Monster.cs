using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    List<MonsterInfo> monsters = new List<MonsterInfo>();
    int index = 0;
    SpriteRenderer spriteRenderer;

    public Text Artista;
    public Text Alien;
    public Text Artista_sombra;
    public Text Alien_sombra;
    public Animator animator;
    public ScrollViewContent scrollView;

    // Start is called before the first frame update
    void Start()
    {
        fillList();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        redrawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void fillList()
    {
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
        monsters.Add(new MonsterInfo("Rath", Resources.Load<Sprite>("monstros/Rath_@saruzilla"), "@saruzilla"));
        monsters.Add(new MonsterInfo("Rook Blonko", Resources.Load<Sprite>("monstros/Rook Blonko @fubukiiast"), "@fubukiiast"));
        monsters.Add(new MonsterInfo("Ultimos", Resources.Load<Sprite>("monstros/ultimos_@cabeloneto1"), "@cabeloneto1"));
        monsters.Add(new MonsterInfo("Eco Eco Supremo", Resources.Load<Sprite>("monstros/frame1"), "@joaoguiss05", true, "ecoeco"));
        monsters.Add(new MonsterInfo("Alien X", Resources.Load<Sprite>("monstros/Frame 1 (Alien X - @ncrwly)"), "@ncrwly", true, "alienx"));
        scrollView.fillContent(monsters.Select(a => a.name).ToList());
    }

    public void redrawn()
    {
        spriteRenderer.sprite = monsters[index].image;
        Artista.text = monsters[index].artist;
        Artista_sombra.text = monsters[index].artist;
        Alien.text = monsters[index].name;
        Alien_sombra.text = monsters[index].name;

        animator.enabled = monsters[index].enableAnimator;

        if (monsters[index].enableAnimator)
        {
            resetTriggers();
            animator.SetBool(monsters[index].animationTrigger, true);
            Debug.Log("Animation Trigger "+ monsters[index].animationTrigger);
        }
    }

    void resetTriggers()
    {
        animator.SetBool("ecoeco", false);
        animator.SetBool("alienx", false);
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
        public bool enableAnimator;
        public string animationTrigger;

       public MonsterInfo(string _name, Sprite _image, string _artist)
        {
            name = _name;
            image = _image;
            artist = _artist;
            enableAnimator = false;
        }

        public MonsterInfo(string _name, Sprite _image, string _artist, bool _enableAnimator, string _animationTrigger)
        {
            name = _name;
            image = _image;
            artist = _artist;
            enableAnimator = _enableAnimator;
            animationTrigger = _animationTrigger;
        }
    }
}
