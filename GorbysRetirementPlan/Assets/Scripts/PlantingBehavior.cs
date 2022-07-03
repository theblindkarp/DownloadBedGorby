using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantingBehavior : MonoBehaviour
{
    public GameObject player;
    public GameObject pizzaFlower;
    public float rootHeight = 0.5f;
    [HideInInspector]
    public GameObject plant;
    

    //[HideInInspector]
    public bool isPlanted;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerInteraction>().isPlantedDouble == false)
        {
            isPlanted = false;
        }
    }

    public void Plant()
    {
        plant = Instantiate(pizzaFlower, new Vector2(transform.position.x, transform.position.y + rootHeight), Quaternion.identity, transform);
        isPlanted = true;
        plant.GetComponent<PlantGrowing>().GrowCycle();
    }
}
