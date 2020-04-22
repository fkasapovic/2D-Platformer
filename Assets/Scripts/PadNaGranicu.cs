using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadNaGranicu : MonoBehaviour {

     void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Die();
        }
          
        
    }
    void Die()
        {
            LevelMenager man = GameObject.Find("LevelMenager").GetComponent<LevelMenager>();
            man.LoadLevel("Win");
            Destroy(gameObject);
        }
}
