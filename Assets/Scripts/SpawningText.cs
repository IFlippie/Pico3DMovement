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
        dict.Add("Mijn hart springt op als ik aan mijn favoriete hobby denk.", "Blij");
        dict.Add("Ik voel me vederlicht en positief gestemd vandaag.", "Blij");
        dict.Add("De zon schijnt en ik voel me als herboren.", "Blij");
        dict.Add("Ik voel me in de wolken door het succes dat ik vandaag heb behaald.", "Blij");
        dict.Add("Mijn hart maakt een sprongetje als ik jouw stem hoor.", "Blij");
        dict.Add("Ik heb de hele dag met een glimlach op mijn gezicht rondgelopen.", "Blij");
        dict.Add("Mijn dag kon niet beter zijn verlopen; ik heb alles bereikt wat ik wilde.", "Blij");
        dict.Add("Ik ben vrolijk gestemd door het vooruitzicht van een fijne vakantie.", "Blij");
        dict.Add("Mijn hart zingt als ik naar mijn favoriete muziek luister.", "Blij");
        dict.Add("Ik voel me opgetogen door het goede nieuws dat ik zojuist heb gehoord.", "Blij");
        dict.Add("Het is heerlijk om te kunnen genieten van de kleine momenten in het leven.", "Blij");
        dict.Add("Ik voel me als een kind zo blij als ik mijn favoriete gerecht eet.", "Blij");
        dict.Add("Mijn dag is helemaal goedgemaakt door het onverwachte compliment dat ik kreeg.", "Blij");
        dict.Add("Ik voel me warm van binnen door de liefde die ik van anderen ontvang.", "Blij");
        dict.Add("Ik ben in de wolken door de nieuwe mogelijkheden die zich voor mij openen.", "Blij");
        dict.Add("Ik voel me opgetogen en enthousiast over mijn toekomstplannen.", "Blij");
        dict.Add("Het voelt alsof ik op wolken loop sinds ik deze belangrijke mijlpaal heb bereikt.", "Blij");
        dict.Add("Ik ben dolgelukkig en dankbaar voor alle zegeningen in mijn leven.", "Blij");
        dict.Add("Ik voel me verheugd over de fijne dag die voor me ligt.", "Blij");
        dict.Add("Het is heerlijk om te kunnen genieten van de eenvoudige dingen in het leven, zoals een mooie wandeling in de natuur.", "Blij");
        dict.Add("Mijn hart klopt in mijn keel en ik voel me onzeker.", "Bang");
        dict.Add("Er is een onbehagelijk gevoel in mijn buik dat me doet aarzelen.", "Bang");
        dict.Add("Mijn handen trillen en ik voel me geïntimideerd.", "Bang");
        dict.Add("Er gaat een rilling door mijn lichaam als ik aan de situatie denk.", "Bang");
        dict.Add("Het voelt alsof ik op een smal koord loop en ik ben bang om te vallen.", "Bang");
        dict.Add("Mijn gedachten draaien in cirkels en ik voel me gevangen.", "Bang");
        dict.Add("Er hangt een dreigende sfeer en ik voel me niet op mijn gemak.", "Bang");
        dict.Add("Ik voel me onzeker en angstig door het gebrek aan controle in de situatie.", "Bang");
        dict.Add("Mijn ademhaling versnelt en ik voel me overweldigd.", "Bang");
        dict.Add("Ik voel me verlamd en kan niet goed nadenken of handelen.", "Bang");
        dict.Add("Er hangt een donkere wolk boven mijn hoofd en ik kan er niet aan ontsnappen.", "Bang");
        dict.Add("Mijn instinct zegt me dat ik moet vluchten of me verstoppen.", "Bang");
        dict.Add("Ik voel me klein en kwetsbaar in deze situatie.", "Bang");
        dict.Add("Het voelt alsof er iemand of iets op de loer ligt en ik ben bang voor wat er kan gebeuren.", "Bang");
        dict.Add("Ik voel me beklemd en gevangen in de situatie.", "Bang");
        dict.Add("Mijn zenuwen zijn tot het uiterste gespannen en ik kan nauwelijks rust vinden.", "Bang");
        dict.Add("Er heerst een gevoel van dreiging en ik kan er niet omheen.", "Bang");
        dict.Add("Ik voel me verloren en hulpeloos in deze situatie.", "Bang");
        dict.Add("Het voelt alsof ik in het oog van de storm zit en de chaos om me heen raast.", "Bang");
        dict.Add("Mijn gevoel van veiligheid is weg en ik ben bang voor wat er gaat gebeuren.", "Bang");
        dict.Add("Mijn ademhaling versnelt en ik voel de hitte in mijn gezicht.", "Boos");
        dict.Add("Mijn spieren spannen zich aan en ik wil het uitschreeuwen.", "Boos");
        dict.Add("Er borrelt een gevoel van onrechtvaardigheid in me op en ik kan het niet negeren.", "Boos");
        dict.Add("Mijn kaken zijn gespannen en mijn handen trillen van woede.", "Boos");
        dict.Add("Het voelt alsof er vuur door mijn aderen stroomt en ik kan het niet controleren.", "Boos");
        dict.Add("Ik voel de spanning in mijn lichaam toenemen en mijn geduld raakt op.", "Boos");
        dict.Add("Mijn lippen zijn op elkaar geperst en mijn blik is dreigend.", "Boos");
        dict.Add("Er is een storm aan emoties in me losgebarsten en ik kan het niet stoppen.", "Boos");
        dict.Add("Het voelt alsof mijn bloed begint te koken en ik wil schreeuwen.", "Boos");
        dict.Add("Mijn hart bonkt in mijn borst en mijn ogen schieten vuur.", "Boos");
        dict.Add("Ik voel me gefrustreerd en machteloos in de situatie.", "Boos");
        dict.Add("Mijn lichaam trilt van woede en ik kan nauwelijks helder denken.", "Boos");
        dict.Add("Het voelt alsof er een explosie in me op de loer ligt en ik kan het niet tegenhouden.", "Boos");
        dict.Add("Ik voel de drang om te slaan of te schoppen en kan het maar moeilijk onderdrukken.", "Boos");
        dict.Add("Er is een knagend gevoel van onrechtvaardigheid in me en ik kan het niet negeren.", "Boos");
        dict.Add("Mijn stem is scherp en mijn lichaamstaal spreekt boekdelen.", "Boos");
        dict.Add("Het voelt alsof er een vulkaan in me op het punt staat uit te barsten en ik kan het niet beheersen.", "Boos");
        dict.Add("Ik voel me geïrriteerd en gefrustreerd door de situatie en kan het niet van me afzetten.", "Boos");
        dict.Add("Mijn ogen schieten vuur en mijn ademhaling is onregelmatig.", "Boos");
        dict.Add("Het voelt alsof er een woede in me op de loer ligt die ik niet kan onderdrukken.", "Boos");
        dict.Add("Ik voel een zware last op mijn schouders en kan het niet van me afzetten.", "Bedroefd");
        dict.Add("Mijn hart voelt als een leegte en ik kan het niet opvullen.", "Bedroefd");
        dict.Add("Ik voel me moedeloos en weet niet hoe ik verder moet.", "Bedroefd");
        dict.Add("Er hangt een zware mist van somberheid om me heen en ik kan er niet uitkomen.", "Bedroefd");
        dict.Add("Mijn ogen prikken van de tranen die ik probeer tegen te houden.", "Bedroefd");
        dict.Add("Ik voel me verloren en alleen in de wereld.", "Bedroefd");
        dict.Add("Er is een diepe pijn in mijn hart die niet weggaat.", "Bedroefd");
        dict.Add("Mijn gedachten zijn somber en ik kan de negatieve spiraal niet doorbreken.", "Bedroefd");
        dict.Add("Er is een gevoel van hopeloosheid en ik kan het niet afschudden.", "Bedroefd");
        dict.Add("Mijn geest voelt zwaar en belast door de last van mijn emoties.", "Bedroefd");
        dict.Add("Er is een donkere wolk van verdriet die boven me hangt en niet weggaat.", "Bedroefd");
        dict.Add("Mijn hart is gevuld met een gevoel van verlies en ik kan het niet van me afzetten.", "Bedroefd");
        dict.Add("Er is een zwaarte in mijn ziel die niet weggaat.", "Bedroefd");
        dict.Add("Mijn stemming is somber en ik kan er niet uitkomen.", "Bedroefd");
        dict.Add("Er is een gevoel van leegte en verlies dat me niet loslaat.", "Bedroefd");
        dict.Add("Mijn hart huilt van verdriet en ik kan het niet stoppen.", "Bedroefd");
        dict.Add("Er is een gevoel van eenzaamheid dat me niet loslaat.", "Bedroefd");
        dict.Add("Mijn gedachten zijn gevuld met sombere beelden en ik kan ze niet afschudden.", "Bedroefd");
        dict.Add("Er is een donkere schaduw van verdriet die me blijft achtervolgen.", "Bedroefd");
        dict.Add("Mijn emoties voelen als een zware last die ik niet kan dragen.", "Bedroefd");
        dict.Add("Ik voel me ongemakkelijk en bloos als ik terugdenk aan wat er gebeurd is.", "Beschaamd");
        dict.Add("Ik ben niet trots op wat ik gedaan heb en het laat me onzeker voelen.", "Beschaamd");
        dict.Add("Ik heb het gevoel dat ik faalde en dat iedereen dat zag.", "Beschaamd");
        dict.Add("Ik voel me onbeholpen en incompetent als ik terugdenk aan mijn acties.", "Beschaamd");
        dict.Add("Ik heb het gevoel dat ik niet aan de verwachtingen heb voldaan en het maakt me verlegen.", "Beschaamd");
        dict.Add("Ik ben niet blij met mijn gedrag en het maakt me onzeker.", "Beschaamd");
        dict.Add("Ik voel me alsof ik gefaald heb en dat iedereen daarvan op de hoogte is.", "Beschaamd");
        dict.Add("Ik ben niet tevreden met mijn prestaties en het laat me ongemakkelijk voelen.", "Beschaamd");
        dict.Add("Ik heb het gevoel dat ik iets verkeerd heb gedaan en dat iedereen daarover oordeelt.", "Beschaamd");
        dict.Add("Ik ben niet trots op mijn keuzes en het maakt me verlegen.", "Beschaamd");
        dict.Add("Ik voel me minderwaardig en het maakt me ongemakkelijk.", "Beschaamd");
        dict.Add("Ik ben niet tevreden met hoe ik me gedragen heb en dat maakt me onzeker.", "Beschaamd");
        dict.Add("Ik heb het gevoel dat ik niet genoeg ben en dat iedereen daarachter zal komen.", "Beschaamd");
        dict.Add("Ik ben niet blij met hoe ik me gedragen heb en dat laat me ongemakkelijk voelen.", "Beschaamd");
        dict.Add("Ik voel me onbeholpen en incompetent en het maakt me verlegen.", "Beschaamd");
        dict.Add("Ik ben niet trots op mezelf en dat laat me onzeker voelen.", "Beschaamd");
        dict.Add("Ik heb het gevoel dat ik gefaald heb en dat iedereen daarover praat.", "Beschaamd");
        dict.Add("Ik ben niet tevreden met mijn gedrag en dat maakt me ongemakkelijk.", "Beschaamd");
        dict.Add("Ik voel me alsof ik de plank volledig misgeslagen heb en dat maakt me verlegen.", "Beschaamd");
        dict.Add("Ik ben niet blij met de manier waarop ik me gedragen heb en dat laat me onzeker voelen.", "Beschaamd");
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
