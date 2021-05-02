using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    public List<MonsterInfo> monsters = new List<MonsterInfo>();
    int index = 0;
    SpriteRenderer spriteRenderer;

    public Text Artista;
    public Text Alien;
    public Animator animator;

    void Awake()
    {
        fillList();
    }

    // Start is called before the first frame update
    void Start()
    {
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
        monsters.Add(new MonsterInfo("Acelerado", Resources.Load<Sprite>("monstros/Acelerado@moglibaiano"), "@moglibaiano"));
        monsters.Add(new MonsterInfo("Ameaça Aquatica", Resources.Load<Sprite>("monstros/Ameaça aquatica_@desenhai"), "@desenhai"));
        monsters.Add(new MonsterInfo("Aquatico", Resources.Load<Sprite>("monstros/Aquático_@abyssbreno"), "@abyssbreno"));
        monsters.Add(new MonsterInfo("Aquachamas", Resources.Load<Sprite>("monstros/aqua-chamas_@rafareloh"), "@rafareloh"));
        monsters.Add(new MonsterInfo("Arraia a Jato", Resources.Load<Sprite>("monstros/Arraia a jato_@tavisko"), "@tavisko"));
        monsters.Add(new MonsterInfo("Artrópode", Resources.Load<Sprite>("monstros/artrópode_@pombodioclin"), "@pombodioclin"));
        monsters.Add(new MonsterInfo("Bala de canhão Supremo", Resources.Load<Sprite>("monstros/Bala de canhão supremo_ @joshdesenha"), "@joshdesenha"));
        monsters.Add(new MonsterInfo("Besta", Resources.Load<Sprite>("monstros/Besta_@raphael_cafes") , "@raphael_cafes"));
        monsters.Add(new MonsterInfo("Besta Suprema", Resources.Load<Sprite>("monstros/Besta_Suprema_@drawingfroes"), "@drawingfroes"));
        monsters.Add(new MonsterInfo("Chamalien", Resources.Load<Sprite>("monstros/Chamalien_@pumpiking"), "@pumpiking"));
        monsters.Add(new MonsterInfo("Doutor animal", Resources.Load<Sprite>("monstros/Doutor animal. @dudesken"), "@dudesken"));
        monsters.Add(new MonsterInfo("Gigante", Resources.Load<Sprite>("monstros/Gigante_@jardellucas_art"), "@jardellucas_art"));
        monsters.Add(new MonsterInfo("Glutao", Resources.Load<Sprite>("monstros/glutao_@thunlob"), "@thunlob"));
        monsters.Add(new MonsterInfo("Gwen Massa Cizenta", Resources.Load<Sprite>("monstros/gwen massa cinzenta_@d_evotchka"), "@d_evotchka"));
        monsters.Add(new MonsterInfo("Quatro Braços", Resources.Load<Sprite>("monstros/Quatro Braços_@elruditos"), "@elruditos"));
        monsters.Add(new MonsterInfo("Reinrassic III", Resources.Load<Sprite>("monstros/ReinrassicIII_@gabijacques.art"), "@gabijacques.art"));
        monsters.Add(new MonsterInfo("Zombozo", Resources.Load<Sprite>("monstros/zombozo_@henrikscarts"), "@henrikscarts"));
        monsters.Add(new MonsterInfo("Rath", Resources.Load<Sprite>("monstros/Rath_@saruzilla"), "@saruzilla"));
        monsters.Add(new MonsterInfo("Rook Blonko", Resources.Load<Sprite>("monstros/Rook Blonko @fubukiiast"), "@fubukiiast"));
        monsters.Add(new MonsterInfo("Ultimos", Resources.Load<Sprite>("monstros/ultimos_@cabeloneto1"), "@cabeloneto1"));
        monsters.Add(new MonsterInfo("Eco Eco Supremo", Resources.Load<Sprite>("monstros/frame1"), "@joaoguiss05", true, "ecoeco"));
        monsters.Add(new MonsterInfo("Alien X", Resources.Load<Sprite>("monstros/Frame 1 (Alien X - @ncrwly)"), "@ncrwly", true, "alienx"));
        monsters.Add(new MonsterInfo("Anfibio", Resources.Load<Sprite>("monstros/anfibio @g_melo"), "@g_melo"));
        monsters.Add(new MonsterInfo("Armatu", Resources.Load<Sprite>("monstros/Armatu_@Quickerstup"), "@Quickerstup"));
        monsters.Add(new MonsterInfo("Chama", Resources.Load<Sprite>("monstros/Chama_@cheetoshenrique"), "@cheetoshenrique"));
        monsters.Add(new MonsterInfo("Cipó Selvagem", Resources.Load<Sprite>("monstros/CipóSelvagem_@iambrenim"), "@iambrenim"));
        monsters.Add(new MonsterInfo("Contra-tempo", Resources.Load<Sprite>("monstros/contra-tempo @rodolfonerd20"), "@rodolfonerd20"));
        monsters.Add(new MonsterInfo("Cuspior", Resources.Load<Sprite>("monstros/Cuspidor @Faeru55"), "@Faeru55"));
        monsters.Add(new MonsterInfo("Enormossauro Supremo", Resources.Load<Sprite>("monstros/enormossauro-supremo_@leosrob"), "@leosrob"));
        monsters.Add(new MonsterInfo("Fantasmático", Resources.Load<Sprite>("monstros/Fantasmático_@bz_erra"), "@bz_erra"));
        monsters.Add(new MonsterInfo("Fogo Fátuo", Resources.Load<Sprite>("monstros/fogo fatuo @ILSDias"), "@ILSDias"));
        monsters.Add(new MonsterInfo("Fogo Fátuo Supremo", Resources.Load<Sprite>("monstros/fogo_Fatuo_supremo_@bysaulo"), "@bysaulo"));
        monsters.Add(new MonsterInfo("Friagem", Resources.Load<Sprite>("monstros/friagem_@nogwinn"), "@nogwinn"));
        monsters.Add(new MonsterInfo("Friagem Supremo", Resources.Load<Sprite>("monstros/friagem supremo_@novatoart_"), "@novatoart_"));
        monsters.Add(new MonsterInfo("Gigante Supremo", Resources.Load<Sprite>("monstros/GiganteSupremo_@mandiocaio"), "@mandiocaio"));
        monsters.Add(new MonsterInfo("Iguana Ártica", Resources.Load<Sprite>("monstros/iguanaartica_@brino_marino"), "@brino_marino"));
        monsters.Add(new MonsterInfo("Insectóide", Resources.Load<Sprite>("monstros/insectoide_@ze.sna"), "@ze.sna"));
        monsters.Add(new MonsterInfo("Macaco-Aranha", Resources.Load<Sprite>("monstros/Macaco_Aranha_@KaaueR"), "@KaaueR"));
        monsters.Add(new MonsterInfo("Macaco-Aranha Supremo", Resources.Load<Sprite>("monstros/macacoaranhasupremo_@dubaeletrohits"), "@dubaeletrohits"));
        monsters.Add(new MonsterInfo("Massa Cinzenta", Resources.Load<Sprite>("monstros/MASSACINZENTA_@lucasmpalma_art"), "@lucasmpalma_art"));
        monsters.Add(new MonsterInfo("Mega Olhos", Resources.Load<Sprite>("monstros/Mega Olhos - @vulgoterencio"), "@vinicas"));
        monsters.Add(new MonsterInfo("Snare-Oh", Resources.Load<Sprite>("monstros/Snareoh_@Focalada"), "@Focalada"));
        monsters.Add(new MonsterInfo("Ultra-T", Resources.Load<Sprite>("monstros/ultrat_@atmocubo"), "@atmocubo"));
        monsters.Add(new MonsterInfo("XLR8", Resources.Load<Sprite>("monstros/XLR8_@filipe.emerson"), "@filipe.emerson"));
        monsters.Add(new MonsterInfo("Diamante", Resources.Load<Sprite>("monstros/Ben 10 - Diamante1"), "@opacamilos", true, "diamante"));
        monsters.Add(new MonsterInfo("Bala de Canhão", Resources.Load<Sprite>("monstros/benio0001"), "@fhilipemarmori", true, "baladecanhao"));
        monsters.Add(new MonsterInfo("Cromático", Resources.Load<Sprite>("monstros/cromatico__aluzearte"), "@aluzearte"));
        monsters.Add(new MonsterInfo("Diabrete", Resources.Load<Sprite>("monstros/diabrete_@kaynamelloh"), "@kaynamelloh"));
        monsters.Add(new MonsterInfo("Diamante (Gwen)", Resources.Load<Sprite>("monstros/diamanta_@tssketch"), "@tssketch"));
        monsters.Add(new MonsterInfo("Eco Eco", Resources.Load<Sprite>("monstros/Eco Eco_@6ustavo6"), "@6ustavo6"));
        monsters.Add(new MonsterInfo("Enormossauro", Resources.Load<Sprite>("monstros/Enormossauro@Barros.Peter"), "@Barros.Peter"));
        monsters.Add(new MonsterInfo("Estrela Polar", Resources.Load<Sprite>("monstros/estrela_polar_@theborgez"), "@theborgez"));
        monsters.Add(new MonsterInfo("Idem", Resources.Load<Sprite>("monstros/idem_@henriquejambu"), "@henriquejambu"));
        monsters.Add(new MonsterInfo("Gosma", Resources.Load<Sprite>("monstros/kaididthis gosma"), "@kaididthis"));
        monsters.Add(new MonsterInfo("Tartagira", Resources.Load<Sprite>("monstros/Tartagira_@desenhistakim"), "@desenhistakim"));
        monsters.Add(new MonsterInfo("Yeti-elétrico", Resources.Load<Sprite>("monstros/Yeti_Eletrico_@sleepyfelipe"), "@sleepyfelipe"));
        monsters.Add(new MonsterInfo("Quatro Braços (Gwen)", Resources.Load<Sprite>("monstros/4 Arms Gwen_@jojo_lines"), "@jojo_lines"));
        monsters.Add(new MonsterInfo("Insectobraços", Resources.Load<Sprite>("monstros/insectobraços_@euso.uobe"), "@euso.uobe"));
        monsters.Add(new MonsterInfo("Nanomech", Resources.Load<Sprite>("monstros/Nanomech_@cpituba"), "@cpituba"));

        monsters.Add(new MonsterInfo("Albedo", Resources.Load<Sprite>("monstros/@mordidoart"), "@mordidoart"));
        monsters.Add(new MonsterInfo("Ben Tennyson", Resources.Load<Sprite>("monstros/Ben10_@yaypumpkin"), "@yaypumpkin"));
        monsters.Add(new MonsterInfo("Ben 10.000", Resources.Load<Sprite>("monstros/Ben10k @Makice_Hit"), "@Makice_Hit"));
        monsters.Add(new MonsterInfo("Gwen Tennyson", Resources.Load<Sprite>("monstros/gwen_@vinicas"), "@vinicas"));
        monsters.Add(new MonsterInfo("Gwen 10.000", Resources.Load<Sprite>("monstros/gwen10000_@jefferson83r"), "@jefferson83r"));
        monsters.Add(new MonsterInfo("Kevin Levin", Resources.Load<Sprite>("monstros/kevin@_yurics"), "@_yurics"));
        monsters.Add(new MonsterInfo("Kevin Supremo", Resources.Load<Sprite>("monstros/kevinsupremo_@jvictorbp"), "@jvictorbp"));
        monsters.Add(new MonsterInfo("Enoch", Resources.Load<Sprite>("monstros/enoch@julhoo"), "@julhoo"));
        monsters.Add(new MonsterInfo("Lata Velha", Resources.Load<Sprite>("monstros/LataVelha_@urzodesenhero"), "@urzodesenhero"));
        monsters.Add(new MonsterInfo("Max Tennyson", Resources.Load<Sprite>("monstros/Max Tennyson_@rogemartines"), "@rogemartines"));
        monsters.Add(new MonsterInfo("Professor Paradoxo", Resources.Load<Sprite>("monstros/ProfessorParadoxo_@visturine"), "@visturine"));
        monsters.Add(new MonsterInfo("Seis-seis", Resources.Load<Sprite>("monstros/seis-seis_@zacarovs"), "@zacarovs"));
        monsters.Add(new MonsterInfo("Tini", Resources.Load<Sprite>("monstros/Tini_@vandersarts04"), "@vandersarts04"));
        monsters.Add(new MonsterInfo("Verdona", Resources.Load<Sprite>("monstros/verdona_@rafadreu"), "@rafadreu"));
        monsters.Add(new MonsterInfo("Azmuth", Resources.Load<Sprite>("monstros/Azmuth_@lkv_7f"), "@lkv_7f"));
        monsters.Add(new MonsterInfo("Ishyiama", Resources.Load<Sprite>("monstros/ishyiama@nathsenaart"), "@nathsenaart"));
        monsters.Add(new MonsterInfo("Vilgax", Resources.Load<Sprite>("monstros/vilgax_@fpjuni"), "@fpjuni"));
        monsters.Add(new MonsterInfo("Raff", Resources.Load<Sprite>("monstros/Raff_@auntkey.art"), "@auntkey.art"));
        monsters.Add(new MonsterInfo("Skurd", Resources.Load<Sprite>("monstros/Skurd@rafaccaldas"), "@rafaccaldas"));
        monsters.Add(new MonsterInfo("Zs'Skayr", Resources.Load<Sprite>("monstros/Zs_Skayr @rosa_lucasrosa"), "@rosa_lucasrosa"));
    }

    public void redrawn()
    {
        spriteRenderer.sprite = monsters[index].image;
        Artista.text = monsters[index].artist;
        Alien.text = monsters[index].name;

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
        animator.SetBool("diamante", false);
        animator.SetBool("baladecanhao", false);
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

    public void jumpTo(int _index)
    {
        index = _index;
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
