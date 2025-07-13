using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int survival, happy, wealth;
    // Start is called before the first frame update
    void Awake()
    {
        survival = 10;
        happy = 10;
        wealth = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
