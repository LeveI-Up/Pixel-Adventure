using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
    
    [SerializeField] TextMeshProUGUI cherriesText;
    [SerializeField] AudioSource cherrySoundEffect;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cherry"))
        {
            StartCoroutine(Destroy(collision, 0.3f));

            
            cherrySoundEffect.Play();    
            cherries++;
            cherriesText.text = ""+cherries;
        }
    }

    IEnumerator Destroy(Collider2D collision, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        Destroy(collision.gameObject);
    }
}
