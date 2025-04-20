using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int coins = 0;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    private int health = 10;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Hp:" + health);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
    {
      Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
    }
    }
    public void CollectCoins()
    {
        coins += 1;
        print("Золото:" + coins);
    }
}
