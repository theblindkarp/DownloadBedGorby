using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantingBehavior : MonoBehaviour
{
    public GameObject player;
    public GameObject pizzaFlower;

    [HideInInspector]
    public bool isPlanted;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Plant()
    {
        Instantiate(pizzaFlower, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        isPlanted = true;
    }
}
