using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hideroad : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Destroy(gameObject);
        }
    }
}
