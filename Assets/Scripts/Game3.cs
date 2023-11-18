using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game3 : MonoBehaviour
{
    public List<GameObject> toDo;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            toDo[counter].gameObject.SetActive(false);
            counter++;
        }
    }
}
