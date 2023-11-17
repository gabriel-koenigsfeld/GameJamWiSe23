using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayLogic : MonoBehaviour
{
    public GameObject trigger;
    public float delay = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("game start");
    }

    // Update is called once per frame


    
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("TriggerStay");
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("löschen");
            Destroy(collision.gameObject);
        }
    }
}
