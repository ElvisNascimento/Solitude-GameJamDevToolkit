using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LightSystem : MonoBehaviour
{

    public Light lampada;
    public float intencidade;

    public float totalTime;
    public float currentTime;

    public Slider barra;

    // Update is called once per frame
    void Update()
    {
         totalTime -= 1 * Time.deltaTime;

         currentTime = totalTime;

        intencidade = currentTime;

        lampada.range = intencidade;

        barra.value = intencidade;
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Heart"))
        {
            totalTime += 30.0f;
            Destroy(other.gameObject);
        }
    }
}
