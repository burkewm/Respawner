using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEquipment : MonoBehaviour
{
    public List<GameObject> equipmentOptions = new List<GameObject>();

    private List<GameObject> usedEquipment = new List<GameObject>();

    PlayerControls controls;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        controls = new PlayerControls();
        controls.Arm.LiftHand.performed += ctx => DoThing();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoThing()
    {
        List<GameObject> temp = new List<GameObject>();

        for (int i = 0; i < equipmentOptions.Count; i++)
        {
            temp.Add(equipmentOptions[i]);
        }

        Debug.Log("L was pressed");

        int rnd = Random.Range(0, temp.Count);
        Debug.Log(rnd);

        for(int i = 0; i < rnd; i++)
        {
            int randoIndex = Random.Range(0, temp.Count);

            int isBroken = Random.Range(0, 99);

            if(isBroken%2 == 0)
            {
                usedEquipment.Add(temp[randoIndex]);
                Debug.Log(temp[randoIndex] + " is not broken");
                temp.RemoveAt(randoIndex);
            }
            else
            {
                usedEquipment.Add(temp[randoIndex]);
                Debug.Log(temp[randoIndex] + " is broken");
                temp.RemoveAt(randoIndex);
            }
            
        }

        for(int i = 0; i < usedEquipment.Count; i++)
        {
            Debug.Log(usedEquipment[i].name);
        }

        ClearUsedEquipment();
    }

    void ClearUsedEquipment()
    {
        int count = usedEquipment.Count;

        for (int i = 0; i < count; i++)
        {
            usedEquipment.RemoveAt(0);
        }
    }
}
