using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnThoughts : MonoBehaviour
{
    public float circleRadius;
    public int AmountOfPoints;
    public GameObject FloatingText;
    public GameObject TextParent;
    public Transform player;
    public Dictionary<string, string> dictP = new Dictionary<string, string>();
    public Dictionary<string, string> dictN = new Dictionary<string, string>();
    string HelveticaText;
    // Start is called before the first frame update
    void Start()
    {
        CreatePosDict();
        CreateNegDict();
        ThoughtSpawns();
    }

    public void ThoughtSpawns() 
    {
        float vStep = (2f * Mathf.PI) / AmountOfPoints;
        for (int o = 0; o < AmountOfPoints; o++)
        {
            Vector3 p;
            float r = circleRadius * Mathf.Cos(o * vStep);
            //Y does nothing in our example
            p.x = transform.position.x + (r * Mathf.Cos(0f));
            //p.x = transform.position.x + (r * Mathf.Sin(0f));
            //p.y = transform.position.y + (r * Mathf.Cos(0f));
            p.z = transform.position.z + (circleRadius * Mathf.Sin(o * vStep));
            p.y = transform.position.y;
            var vPos = p;


            var rndWord = dictN.ElementAt(Random.Range(0, dictN.Count));
            HelveticaText = rndWord.Key;

            var go = Instantiate(FloatingText);
            //Renderer rend = go.GetComponent<Renderer>();
            //Color newColor = rend.material.color;
            //newColor.a = 0;
            //rend.material.color = newColor;
            //var helvComp = go.GetComponent<SimpleHelvetica>();
            //helvComp.emotionId = rndWord.Value;
            //helvComp.Text = HelveticaText;
            //helvComp.GenerateText();
            go.transform.position = vPos;
            go.GetComponent<SimpleHelvetica>().AddBoxCollider();
            //go.transform.localScale = new Vector3(1f, 1f, 1f);
            //helvComp.AddBoxCollider();
            //go.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            //newColor.a = 1;
            //rend.material.color = newColor;
            dictN.Remove(rndWord.Key);
            var goParent = Instantiate(TextParent);
            goParent.transform.position = go.GetComponent<SimpleHelvetica>().rend.center;
            go.transform.SetParent(goParent.transform);
            goParent.transform.LookAt(player);
            goParent.transform.rotation = new Quaternion(0f, goParent.transform.rotation.y, 0f, goParent.transform.rotation.w);
        }
    }

    void CreatePosDict() 
    {
        dictP.Clear();
        dictP.Add("Love", "Pos");
        dictP.Add("Joy", "Pos");
        dictP.Add("Happiness", "Pos");
        dictP.Add("Gratitude", "Pos");
        dictP.Add("Peace", "Pos");
        dictP.Add("Serenity", "Pos");
        dictP.Add("Hope", "Pos");
        dictP.Add("Kindness", "Pos");
        dictP.Add("Compassion", "Pos");
        dictP.Add("Generosity", "Pos");
        dictP.Add("Laughter", "Pos");
        dictP.Add("Smiling", "Pos");
        dictP.Add("Friendship", "Pos");
        dictP.Add("Unity", "Pos");
        dictP.Add("Bliss", "Pos");
        dictP.Add("Excitement", "Pos");
        dictP.Add("Success", "Pos");
        dictP.Add("Achievement", "Pos");
        dictP.Add("Courage", "Pos");
        dictP.Add("Empathy", "Pos");
        dictP.Add("Harmony", "Pos");
        dictP.Add("Contentment", "Pos");
        dictP.Add("Optimism", "Pos");
        dictP.Add("Confidence", "Pos");
        dictP.Add("Abundance", "Pos");
        dictP.Add("Appreciation", "Pos");
        dictP.Add("Fulfillment", "Pos");
        dictP.Add("Trust", "Pos");
        dictP.Add("Patience", "Pos");
        dictP.Add("Resilience", "Pos");
        dictP.Add("Inspiration", "Pos");
        dictP.Add("Enthusiasm", "Pos");
        dictP.Add("Support", "Pos");
        dictP.Add("Vitality", "Pos");
        dictP.Add("Bravery", "Pos");
        dictP.Add("Forgiveness", "Pos");
        dictP.Add("Wonder", "Pos");
        dictP.Add("Graciousness", "Pos");
        dictP.Add("Euphoria", "Pos");
        dictP.Add("Radiance", "Pos");
        dictP.Add("Progress", "Pos");
        dictP.Add("Jubilation", "Pos");
        dictP.Add("Sincerity", "Pos");
        dictP.Add("Playfulness", "Pos");
        dictP.Add("Belonging", "Pos");
        dictP.Add("Caring", "Pos");
        dictP.Add("Motivation", "Pos");
        dictP.Add("Satisfaction", "Pos");
        dictP.Add("Serendipity", "Pos");
        dictP.Add("Liberation", "Pos");
    }

    void CreateNegDict() 
    {
        dictN.Add("Pain", "Neg");
        dictN.Add("Grief", "Neg");
        dictN.Add("Sadness", "Neg");
        dictN.Add("Anger", "Neg");
        dictN.Add("Fear", "Neg");
        dictN.Add("Despair", "Neg");
        dictN.Add("Loneliness", "Neg");
        dictN.Add("Hate", "Neg");
        dictN.Add("Envy", "Neg");
        dictN.Add("Disappointment", "Neg");
        dictN.Add("Stress", "Neg");
        dictN.Add("Anxiety", "Neg");
        dictN.Add("Insecurity", "Neg");
        dictN.Add("Failure", "Neg");
        dictN.Add("Regret", "Neg");
        dictN.Add("Shame", "Neg");
        dictN.Add("Guilty", "Neg");
        dictN.Add("Desperation", "Neg");
        dictN.Add("Bitterness", "Neg");
        dictN.Add("Hostility", "Neg");
        dictN.Add("Sorrow", "Neg");
        dictN.Add("Pessimism", "Neg");
        dictN.Add("Doubt", "Neg");
        dictN.Add("Worry", "Neg");
        dictN.Add("Jealousy", "Neg");
        dictN.Add("Betrayal", "Neg");
        dictN.Add("Misery", "Neg");
        dictN.Add("Guilt", "Neg");
        dictN.Add("Resentment", "Neg");
        dictN.Add("Hopelessness", "Neg");
        dictN.Add("Frustration", "Neg");
        dictN.Add("Anguish", "Neg");
        dictN.Add("Disgust", "Neg");
        dictN.Add("Melancholy", "Neg");
        dictN.Add("Hurt", "Neg");
        dictN.Add("Suffering", "Neg");
        dictN.Add("Dejection", "Neg");
        dictN.Add("Shattered", "Neg");
        dictN.Add("Defeated", "Neg");
        dictN.Add("Humiliation", "Neg");
        dictN.Add("Embarrassment", "Neg");
        dictN.Add("Nervousness", "Neg");
        dictN.Add("Demoralized", "Neg");
        dictN.Add("Tension", "Neg");
        dictN.Add("Conflict", "Neg");
        dictN.Add("Alienation", "Neg");
        dictN.Add("Chaos", "Neg");
        dictN.Add("Devastation", "Neg");
        dictN.Add("Vulnerability", "Neg");
        dictN.Add("Dread", "Neg");
    }
}
