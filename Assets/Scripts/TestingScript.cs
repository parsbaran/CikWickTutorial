using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int score;
    string text = "Selam";

    // Oyun başlamadan önceki ilk fonksiyon
    void Awake()
    {
        score = 0;
        Debug.Log("Awake");

    }
    
    //start fonksiyonu, oyun başladığında ilk çağrılan fonksiyondur 
        void Start()
    {
        score = 0;
        Debug.Log("start");

    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log("update");

    }

    void FixedUpdate()
    {
        
    }
    void LateUpdate()
    {
        
    }

    void Testfunction()
    {
        
    }
}
