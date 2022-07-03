using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestCollider : MonoBehaviour
{
    [HideInInspector]
    public bool isHarvestable = false;
    [HideInInspector]
    public GameObject harvest;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "plant")
        {
            isHarvestable = true;
            harvest = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "plant")
        {
            isHarvestable = false;
        }
    }
}
