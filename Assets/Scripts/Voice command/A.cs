using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Windows.Speech;
using System.Linq;

public class A : MonoBehaviour
{
    bool Move = true;
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, System.Action> actions = new Dictionary<string, System.Action>();



    void Update()
    {
        Debug.Log("a");
        actions.Add("A", selectandmoveA);
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray(), UnityEngine.Windows.Speech.ConfidenceLevel.Low);
        keywordRecognizer.OnPhraseRecognized += RecognisedSpeech;
        keywordRecognizer.Start();




       // actions.Add("Stop A", stopA);
       // keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray(), UnityEngine.Windows.Speech.ConfidenceLevel.Low);
       // keywordRecognizer.OnPhraseRecognized += RecognisedSpeech;
       // keywordRecognizer.Start();

    }






   void Start()
    {
        Debug.Log("a");
        actions.Add("A", selectandmoveA); 
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray(), UnityEngine.Windows.Speech.ConfidenceLevel.Low);
        keywordRecognizer.OnPhraseRecognized += RecognisedSpeech;
        keywordRecognizer.Start();




       // actions.Add("Stop A", stopA);
       // keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray(), UnityEngine.Windows.Speech.ConfidenceLevel.Low);
        //keywordRecognizer.OnPhraseRecognized += RecognisedSpeech;
       // keywordRecognizer.Start();

    }



    private void RecognisedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

   
    // Update is called once per frame
    //void Update()
    //{
    //    selectandmoveA();
    //}

    void selectandmoveA()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 5, false);
           
        if (gameObject.CompareTag("A"))
        {
            if (Move == true)
           { 
                gameObject.transform.Translate(5f, 0, 0);
             }
          

        }
    }
   //void stopA()
  //  {
   //     gameObject.transform.Translate(0f, 0, 0);
  //  }

}
