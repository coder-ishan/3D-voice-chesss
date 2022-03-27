using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using System.Collections;

public class B : MonoBehaviour
{

    bool Move = true;
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, System.Action> actions = new Dictionary<string, System.Action>();
    void Start()
    {

        //actions.Add("A", selectandmoveA);
        actions.Add("B", selectandmoveB);
        
        // actions.Add("C", selectandmoveC);
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

    // Update is called once per frame
    //void Update()
    //{
    //    selectandmoveA();
    //}

    private void selectandmoveA()
    {
        Debug.Log("A");
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 5, false);
        if (gameObject.CompareTag("A"))
        {
            if (Move == true)
            {
                gameObject.transform.Translate(0.1f, 0, 0);
               // gameObject.transform.Translate(0.0f, 0, 0);
               // gameObject.transform.velocity = new Vector3(0.0f, 0.0f, 0.2f);
            }

        }
    }
    private void selectandmoveB()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 5, false);
        if (gameObject.CompareTag("B"))
        {
            if (Move == true)
            {
                gameObject.transform.Translate(1.5f, 0, 0);
            }

        }
    }
    void selectandmoveC()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 5, false);
        if (gameObject.CompareTag("C"))
        {
            if (Move == true)
            {
                gameObject.transform.Translate(0.1f, 0, 0);
            }

        }
    }
    void selectandmoveD()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 5, false);
        if (gameObject.CompareTag("D"))
        {
            if (Move == true)
            {
                gameObject.transform.Translate(0.1f, 0, 0);
            }

        }
    }
    void selectandmoveE()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 5, false);
        if (gameObject.CompareTag("E"))
        {
            if (Move == true)
            {
                gameObject.transform.Translate(0.1f, 0, 0);
            }

        }
    }
    void selectandmoveF()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 5, false);
        if (gameObject.CompareTag("F"))
        {
            if (Move == true)
            {
                gameObject.transform.Translate(0.1f, 0, 0);
            }

        }
    }
    void selectandmoveG()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 5, false);
        if (gameObject.CompareTag("G"))
        {
            if (Move == true)
            {
                gameObject.transform.Translate(0.1f, 0, 0);
            }

        }
    }
    void selectandmoveH()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 5, false);
        if (gameObject.CompareTag("H"))
        {
            if (Move == true)
            {
                gameObject.transform.Translate(0.1f, 0, 0);
            }

        }
    }

}
