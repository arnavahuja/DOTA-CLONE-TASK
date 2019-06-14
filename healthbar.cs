using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public enemy_dying enemydying;
    public Slider healthybar;
     
    void Start()
    {
      healthybar.value=2; 
    }

    // Update is called once per frame
    void Update()
    {
      healthybar.value = enemydying.count;  
    }
}
