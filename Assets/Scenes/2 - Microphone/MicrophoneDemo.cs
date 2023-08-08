using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Whisper.Utils;
using Button = UnityEngine.UI.Button;
using Toggle = UnityEngine.UI.Toggle;

namespace Whisper.Samples
{
    /// <summary>
    /// Record audio clip from microphone and make a transcription.
    /// </summary>
    public class MicrophoneDemo : MonoBehaviour
    {
        public WhisperManager whisper;
        public MicrophoneRecord microphoneRecord;
        public bool echoSound = true;
        public bool streamSegments = true;
        public bool printLanguage = true;

        public GameObject textSpawn;
        public GameObject textFinalPosition;
        public Transform textSpawnPosition;
        public GameObject TextParent;
        public Transform player;
        string HelveticaText;

        [Header("UI")] 
        public Button button;
        public Text buttonText;
        public Text outputText;
        public Text timeText;
        public Dropdown languageDropdown;
        public Toggle translateToggle;
        public ScrollRect scroll;
        
        private string _buffer;

        private void Awake()
        {
            whisper.OnNewSegment += OnNewSegment;
            whisper.OnProgress += OnProgressHandler;
            
            microphoneRecord.OnRecordStop += OnRecordStop;
            
            button.onClick.AddListener(OnButtonPressed);
            languageDropdown.value = languageDropdown.options
                .FindIndex(op => op.text == whisper.language);
            languageDropdown.onValueChanged.AddListener(OnLanguageChanged);

            translateToggle.isOn = whisper.translateToEnglish;
            translateToggle.onValueChanged.AddListener(OnTranslateChanged);
        }

        private void OnButtonPressed()
        {
            if (!microphoneRecord.IsRecording)
            {
                microphoneRecord.StartRecord();
                buttonText.text = "Stop";
            }
            else
            {
                microphoneRecord.StopRecord();
                buttonText.text = "Record";
            }
        }
        
        private async void OnRecordStop(float[] data, int frequency, int channels, float length)
        {
            buttonText.text = "Record";
            _buffer = "";
            
            if (echoSound)
            {
                var clip = AudioClip.Create("mic", data.Length, channels, frequency, false);
                AudioSource.PlayClipAtPoint(clip, Vector3.zero);
            }
            
            var sw = new Stopwatch();
            sw.Start();
            
            var res = await whisper.GetTextAsync(data, frequency, channels);
            if (res == null || !outputText) 
                return;

            var time = sw.ElapsedMilliseconds;
            var rate = length / (time * 0.001f);
            timeText.text = $"Time: {time} ms\nRate: {rate:F1}x";

            var text = res.Result;
            if (printLanguage)
                text += $"\n\nLanguage: {res.Language}";
            
            outputText.text = text;
            //put the text spawn here because we want the output
            SpawnText(text);

            UiUtils.ScrollDown(scroll);
        }
        
        private void OnLanguageChanged(int ind)
        {
            var opt = languageDropdown.options[ind];
            whisper.language = opt.text;
        }
        
        private void OnTranslateChanged(bool translate)
        {
            whisper.translateToEnglish = translate;
        }

        private void OnProgressHandler(int progress)
        {
            if (!timeText)
                return;
            timeText.text = $"Progress: {progress}%";
        }
        
        private void OnNewSegment(WhisperSegment segment)
        {
            if (!streamSegments || !outputText)
                return;

            _buffer += segment.Text;
            outputText.text = _buffer + "...";
            UiUtils.ScrollDown(scroll);
        }

        public void SpawnText(string text)
        {
            var goParent = Instantiate(TextParent);
            goParent.transform.position = textSpawnPosition.position;

            //var smokeGo = Instantiate(SmokeParticle);
            //smokeGo.transform.position = textSpawnPosition;

            HelveticaText = text;
            var go = Instantiate(textSpawn);
            var helvComp = go.GetComponent<SimpleHelvetica>();

            helvComp.Text = HelveticaText;
            helvComp.GenerateText();
            go.transform.position = player.position + player.forward;

            go.GetComponent<testScript>().EmptyParent = goParent.transform;
            go.GetComponent<TextCollision>().CollisionID = rndWord.Value;
        }

    }
}