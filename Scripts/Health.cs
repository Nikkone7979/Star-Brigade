using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] Text healthtxt;
    [SerializeField] int health = 3;
    const int Damage = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        displayHealth();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0) {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
        }
    }

    public void reduceHealth() {

        health -= Damage;
    
    }

    public void displayHealth() {
        healthtxt.text = "Health: " + health;
    }
}
