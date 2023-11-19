using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game3 : MonoBehaviour
{
    [SerializeField] private PlayerProgress _playerProgress;
    private int counter;
    public InputManager _inputManager;
    public GameObject ToDos;
    public GameObject Done;
    private List<GameObject> ToDoList = new List<GameObject>();
    private List<GameObject> DoneList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        ToDoList = FülleListeMitChildObjekten(ToDos);
        DoneList = FülleListeMitChildObjekten(Done);
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerProgress.timeState != TimeState.Minigame) return;
        DoWork();
    }
    void DoWork()
    {
        if (_inputManager.buttonsPressed[1])
        {
            if( counter <= 50) 
            { 
                ToDoList[ToDoList.Count - counter - 1].gameObject.SetActive(false);
                DoneList[counter].gameObject.SetActive(true);
                counter++;
            }



        }
       
    }





    List<GameObject> FülleListeMitChildObjekten(GameObject Parent)
    {
        List<GameObject> ListObj = new List<GameObject>();
        // Überprüfe, ob das Elternobjekt zugewiesen ist
        if (ListObj != null)
        {
            // Iteriere durch alle Child-Objekte des angegebenen Elternobjekts
            foreach (Transform child in Parent.transform)
            {
                // Füge jedes Child-Objekt zur Liste hinzu
                ListObj.Add(child.gameObject);
            }

            
        }
        else
        {
            Debug.LogError("Elternobjekt nicht zugewiesen! Bitte weise das Elternobjekt in der Inspector-Ansicht zu.");
        }
        return ListObj;
    }
}
