using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Windows.Speech;
using System.Linq;

public class C: MonoBehaviour
{

    bool Move = true;

    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, System.Action> actions = new Dictionary<string, System.Action>();
    void Start()
    {

       // actions.Add("A", selectandmoveA);
        // actions.Add("B", selectandmoveB);
        actions.Add("C", selectandmoveC);
        actions.Add("start C", Start);
        actions.Add("Stop C", Stop);
        //actions.Add("D", selectandmoveD);
        //actions.Add("E", selectandmoveE);
        // actions.Add("F", selectandmoveF);
        // actions.Add("G", selectandmoveG);
        // actions.Add("H", selectandmoveH);
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray(), UnityEngine.Windows.Speech.ConfidenceLevel.Low);
        keywordRecognizer.OnPhraseRecognized += RecognisedSpeech;
        keywordRecognizer.Start();

    }
    private void RecognisedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

   public void Stop()
    {
        Move = false;
    }
    // Update is called once per frame
    //void Update()
    //{
    //    selectandmoveA();
    //}
    
    
    void selectandmoveC()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 5, false);
        if (gameObject.CompareTag("C"))
        {
            while(Move == true)
            {
                gameObject.transform.Translate(1.5f, 0, 0);
            }

        }
    }
   
    

}
