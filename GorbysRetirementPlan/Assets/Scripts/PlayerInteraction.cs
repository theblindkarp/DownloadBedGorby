using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [HideInInspector]
    public GameObject plant;
    public bool isPlantedDouble;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "tilleddirt" && col.gameObject.GetComponent<PlantingBehavior>().isPlanted == false)
        {
            isPlantedDouble = true;
            col.GetComponent<PlantingBehavior>().Plant();
        }
    }

    private void Update()
    {
        plant = GetComponentInChildren<HarvestCollider>().harvest;
        if (Input.GetKeyDown(KeyCode.P) && GetComponentInChildren<HarvestCollider>().isHarvestable == true)
        {
            Harvest();
        }
    }

    public void Harvest()
    {
        isPlantedDouble = false;
        Destroy(plant);
    }
}
