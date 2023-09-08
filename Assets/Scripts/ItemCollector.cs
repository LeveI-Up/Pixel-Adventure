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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherrySoundEffect.Play();    
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
        }
    }
}
