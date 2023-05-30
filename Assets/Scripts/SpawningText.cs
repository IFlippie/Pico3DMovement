using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawningText : MonoBehaviour
{
    public GameObject spawnableText;
    public GameObject textSpawnPosition;
    public Dictionary<string, string> dict = new Dictionary<string, string>();
    string HelveticaText;
    public Transform[] LookingTexts;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        dict.Add("Mijn hart springt op als ik\n aan mijn favoriete hobby denk.", "Blij");
        dict.Add("Ik voel me vederlicht en \n positief gestemd vandaag.", "Blij");
        dict.Add("De zon schijnt en ik\n voel me als herboren.", "Blij");
        dict.Add("Ik voel me in de wolken door\n het succes dat ik vandaag heb behaald.", "Blij");
        dict.Add("Mijn hart maakt een sprongetje\n als ik jouw stem hoor.", "Blij");
        dict.Add("Ik heb de hele dag met een\n glimlach op mijn gezicht rondgelopen.", "Blij");
        dict.Add("Mijn dag kon niet beter zijn verlopen;\n ik heb alles bereikt wat ik wilde.", "Blij");
        dict.Add("Ik ben vrolijk gestemd door het vooruitzicht\n van een fijne vakantie.", "Blij");
        dict.Add("Mijn hart zingt als ik naar\n mijn favoriete muziek luister.", "Blij");
        dict.Add("Ik voel me opgetogen door het goede nieuws\n dat ik zojuist heb gehoord.", "Blij");
        dict.Add("Het is heerlijk om te kunnen genieten\n van de kleine momenten in het leven.", "Blij");
        dict.Add("Ik voel me als een kind zo blij\n als ik mijn favoriete gerecht eet.", "Blij");
        dict.Add("Mijn dag is helemaal goedgemaakt\n door het onverwachte compliment dat ik kreeg.", "Blij");
        dict.Add("Ik voel me warm van binnen door de\n liefde die ik van anderen ontvang.", "Blij");
        dict.Add("Ik ben in de wolken door de nieuwe\n mogelijkheden die zich voor mij openen.", "Blij");
        dict.Add("Ik voel me opgetogen en \nenthousiast over mijn toekomstplannen.", "Blij");
        dict.Add("Het voelt alsof ik op wolken loop\n sinds ik deze belangrijke mijlpaal heb bereikt.", "Blij");
        dict.Add("Ik ben dolgelukkig en dankbaar\n voor alle zegeningen in mijn leven.", "Blij");
        dict.Add("Ik voel me verheugd over \nde fijne dag die voor me ligt.", "Blij");
        dict.Add("Het is heerlijk om te kunnen genieten van de eenvoudige dingen\n in het leven, zoals een mooie wandeling in de natuur.", "Blij");
        dict.Add("Mijn hart klopt in mijn keel\n en ik voel me onzeker.", "Bang");
        dict.Add("Er is een onbehagelijk gevoel in mijn\nbuik dat me doet aarzelen.", "Bang");
        dict.Add("Mijn handen trillen en ik voel me\ngeïntimideerd.", "Bang");
        dict.Add("Er gaat een rilling door mijn lichaam als\nik aan de situatie denk.", "Bang");
        dict.Add("Het voelt alsof ik op een smal koord loop\nen ik ben bang om te vallen.", "Bang");
        dict.Add("Mijn gedachten draaien in cirkels en ik\nvoel me gevangen.", "Bang");
        dict.Add("Er hangt een dreigende sfeer en ik voel me\nniet op mijn gemak.", "Bang");
        dict.Add("Ik voel me onzeker en angstig door het\ngebrek aan controle in de situatie.", "Bang");
        dict.Add("Mijn ademhaling versnelt en ik voel me\noverweldigd.", "Bang");
        dict.Add("Ik voel me verlamd en kan niet goed\nnadenken of handelen.", "Bang");
        dict.Add("Er hangt een donkere wolk boven mijn\nhoofd en ik kan er niet aan ontsnappen.", "Bang");
        dict.Add("Mijn instinct zegt me dat ik moet vluchten\nof me verstoppen.", "Bang");
        dict.Add("Ik voel me klein en kwetsbaar in deze\nsituatie.", "Bang");
        dict.Add("Het voelt alsof er iemand of iets op de\nloer ligt en ik ben bang voor wat er kan gebeuren.", "Bang");
        dict.Add("Ik voel me beklemd en gevangen in\nde situatie.", "Bang");
        dict.Add("Mijn zenuwen zijn tot het uiterste\nGespannen en ik kan nauwelijks rust vinden.", "Bang");
        dict.Add("Er heerst een gevoel van dreiging en\nik kan er niet omheen.", "Bang");
        dict.Add("Ik voel me verloren en hulpeloos in\ndeze situatie.", "Bang");
        dict.Add("Het voelt alsof ik in het oog van de\nstorm zit en de chaos om me heen raast.", "Bang");
        dict.Add("Mijn gevoel van veiligheid is weg en\nik ben bang voor wat er gaat gebeuren.", "Bang");
        dict.Add("Mijn ademhaling versnelt en ik voel\nde hitte in mijn gezicht.", "Boos");
        dict.Add("Mijn spieren spannen zich aan en ik\nwil het uitschreeuwen.", "Boos");
        dict.Add("Er borrelt een gevoel van onrechtvaardigheid\nin me op en ik kan het niet negeren.", "Boos");
        dict.Add("Mijn kaken zijn gespannen en mijn handen\ntrillen van woede.", "Boos");
        dict.Add("Het voelt alsof er vuur door mijn aderen\nstroomt en ik kan het niet controleren.", "Boos");
        dict.Add("Ik voel de spanning in mijn lichaam\nToenemen en mijn geduld raakt op.", "Boos");
        dict.Add("Mijn lippen zijn op elkaar geperst en\nmijn blik is dreigend.", "Boos");
        dict.Add("Er is een storm aan emoties in me\nlosgebarsten en ik kan het niet stoppen.", "Boos");
        dict.Add("Het voelt alsof mijn bloed begint te\nkoken en ik wil schreeuwen.", "Boos");
        dict.Add("Mijn hart bonkt in mijn borst en mijn\neyen schieten vuur.", "Boos");
        dict.Add("Ik voel me gefrustreerd en machteloos\nin de situatie.", "Boos");
        dict.Add("Mijn lichaam trilt van woede en ik kan\nnauwelijks helder denken.", "Boos");
        dict.Add("Het voelt alsof er een explosie in me\nop de loer ligt en ik kan het niet tegenhouden.", "Boos");
        dict.Add("Ik voel de drang om te slaan of te\nschoppen en kan het maar moeilijk onderdrukken.", "Boos");
        dict.Add("Er is een knagend gevoel van onrechtvaardigheid\nin me en ik kan het niet negeren.", "Boos");
        dict.Add("Mijn stem is scherp en mijn lichaamstaal\nspreekt boekdelen.", "Boos");
        dict.Add("Het voelt alsof er een vulkaan in me op\nhet punt staat uit te barsten en ik kan het niet beheersen.", "Boos");
        dict.Add("Ik voel me geïrriteerd en gefrustreerd door\nde situatie en kan het niet van me afzetten.", "Boos");
        dict.Add("Mijn ogen schieten vuur en mijn ademhaling\nis onregelmatig.", "Boos");
        dict.Add("Het voelt alsof er een woede in me op\nde loer ligt die ik niet kan onderdrukken.", "Boos");
        dict.Add("Ik voel een zware last op mijn schouders\nen kan het niet van me afzetten.", "Bedroefd");
        dict.Add("Mijn hart voelt als een leegte en ik\nkan het niet opvullen.", "Bedroefd");
        dict.Add("Ik voel me moedeloos en weet niet hoe ik\nverder moet.", "Bedroefd");
        dict.Add("Er hangt een zware mist van somberheid\nom me heen en ik kan er niet uitkomen.", "Bedroefd");
        dict.Add("Mijn ogen prikken van de tranen die ik\nprobeer tegen te houden.", "Bedroefd");
        dict.Add("Ik voel me verloren en alleen in de wereld.", "Bedroefd");
        dict.Add("Er is een diepe pijn in mijn hart die\nniet weggaat.", "Bedroefd");
        dict.Add("Mijn gedachten zijn somber en ik kan de\nnegatieve spiraal niet doorbreken.", "Bedroefd");
        dict.Add("Er is een gevoel van hopeloosheid en ik kan\nhet niet afschudden.", "Bedroefd");
        dict.Add("Mijn geest voelt zwaar en belast door de\nlast van mijn emoties.", "Bedroefd");
        dict.Add("Er is een donkere wolk van verdriet die boven\nme hangt en niet weggaat.", "Bedroefd");
        dict.Add("Mijn hart is gevuld met een gevoel van verlies\nen ik kan het niet van me afzetten.", "Bedroefd");
        dict.Add("Er is een zwaarte in mijn ziel die niet weggaat.", "Bedroefd");
        dict.Add("Mijn stemming is somber en ik kan er niet uitkomen.", "Bedroefd");
        dict.Add("Er is een gevoel van leegte en verlies dat me\nniet loslaat.", "Bedroefd");
        dict.Add("Mijn hart huilt van verdriet en \nik kan het niet stoppen.", "Bedroefd");
        dict.Add("Er is een gevoel van eenzaamheid \ndat me niet loslaat.", "Bedroefd");
        dict.Add("Mijn gedachten zijn gevuld met sombere beelden\nen ik kan ze niet afschudden.", "Bedroefd");
        dict.Add("Er is een donkere schaduw van verdriet \ndie me blijft achtervolgen.", "Bedroefd");
        dict.Add("Mijn emoties voelen als een zware last die ik\nniet kan dragen.", "Bedroefd");
        dict.Add("Ik voel me ongemakkelijk en bloos als ik\nterugdenk aan wat er gebeurd is.", "Beschaamd");
        dict.Add("Ik ben niet trots op wat ik gedaan heb en\nhet laat me onzeker voelen.", "Beschaamd");
        dict.Add("Ik heb het gevoel dat ik faalde en dat iedereen\ndat zag.", "Beschaamd");
        dict.Add("Ik voel me onbeholpen en incompetent als ik\nterugdenk aan mijn acties.", "Beschaamd");
        dict.Add("Ik heb het gevoel dat ik niet aan de verwachtingen\nheb voldaan en het maakt me verlegen.", "Beschaamd");
        dict.Add("Ik ben niet blij met mijn gedrag en het maakt me onzeker.", "Beschaamd");
        dict.Add("Ik voel me alsof ik gefaald heb en dat iedereen daarvan\nop de hoogte is.", "Beschaamd");
        dict.Add("Ik ben niet tevreden met mijn prestaties en het laat\nme ongemakkelijk voelen.", "Beschaamd");
        dict.Add("Ik heb het gevoel dat ik iets verkeerd heb gedaan en dat\niedereen daarover oordeelt.", "Beschaamd");
        dict.Add("Ik ben niet trots op mijn keuzes en het maakt me verlegen.", "Beschaamd");
        dict.Add("Ik voel me minderwaardig en het maakt me ongemakkelijk.", "Beschaamd");
        dict.Add("Ik ben niet tevreden met hoe ik me gedragen heb en dat\nmaakt me onzeker.", "Beschaamd");
        dict.Add("Ik heb het gevoel dat ik niet genoeg ben en dat iedereen\ndaarachter zal komen.", "Beschaamd");
        dict.Add("Ik ben niet blij met hoe ik me gedragen heb en dat laat\nme ongemakkelijk voelen.", "Beschaamd");
        dict.Add("Ik voel me onbeholpen en incompetent \nen het maakt me verlegen.", "Beschaamd");
        dict.Add("Ik ben niet trots op mezelf en dat \nlaat me onzeker voelen.", "Beschaamd");
        dict.Add("Ik heb het gevoel dat ik gefaald heb \nen dat iedereen\ndaarover praat.", "Beschaamd");
        dict.Add("Ik ben niet tevreden met mijn gedrag \nen dat maakt me ongemakkelijk.", "Beschaamd");
        dict.Add("Ik voel me alsof ik de plank volledig misgeslagen heb en\ndat maakt me verlegen.", "Beschaamd");
        dict.Add("Ik ben niet blij met de manier waarop ik me gedragen heb en\ndat laat me onzeker voelen.", "Beschaamd");
        SpawnText();       
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform text in LookingTexts)
        {
            text.rotation = Quaternion.LookRotation(text.position - Player.position);
        }
    }

    public void SpawnText() 
    {
        var rndThought = dict.ElementAt(Random.Range(0, dict.Count));
        HelveticaText = rndThought.Key;
        var go = Instantiate(spawnableText);
        Renderer r = go.GetComponent<Renderer>();

        Color newColor = r.material.color;
        newColor.a = 0;
        r.material.color = newColor;
        var helvComp = go.GetComponent<SimpleHelvetica>();

        helvComp.emotionId = rndThought.Value;
        helvComp.Text = HelveticaText;
        helvComp.GenerateText();
        go.transform.position = textSpawnPosition.transform.position;

        go.transform.localScale = new Vector3(1f, 1f, 1f);
        helvComp.AddBoxCollider();
        go.transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);
        newColor.a = 1;
        r.material.color = newColor;
        dict.Remove(rndThought.Key);
    }
}
