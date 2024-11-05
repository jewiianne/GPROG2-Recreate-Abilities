using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltKill : MonoBehaviour
{
    public GameObject lightning;
    public float health;

    void Start()
    {
        lightning.SetActive(false);
        health = 100f; 
    }

    private void OnMouseDown()
    {
        health -= 5f;
        StartCoroutine(lightningEffects());
    }

    private IEnumerator lightningEffects()
    {
        lightning.SetActive(true);
        
        yield return new WaitForSeconds(0.5f);
        lightning.SetActive(false);
        
        if (health == 0)
        {
        Destroy(gameObject);
        }
    }
}


