﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEquipment : MonoBehaviour
{
    public List<GameObject> equipmentOptions = new List<GameObject>();
    public List<GameObject> equipmentSpawns = new List<GameObject>();

    public List<GameObject> equippedArmor = new List<GameObject>();

    private void Start()
    {
        DoThing();
    }
    public void DoThing()
    {
        int rnd = Random.Range(1, equipmentOptions.Count);

        for(int i = 0; i < rnd; i++)
        {

            int isBroken = Random.Range(0, 99);

            if(isBroken%2 == 0)
            {
                Debug.Log("undamaged");
                int randoIndex = Random.Range(0, equipmentOptions.Count);
                GameObject armor = equipmentOptions[randoIndex].gameObject;
                var newArmor = Instantiate(armor, new Vector3(0, 4, 0), Quaternion.identity);
                equippedArmor.Add(newArmor);
            }
            else
            {
                Debug.Log("damaged");
                int randoIndex = Random.Range(0, equipmentOptions.Count);
                GameObject armor = equipmentOptions[randoIndex].gameObject;
                var newArmor = Instantiate(armor, new Vector3(0, 4, 0), Quaternion.identity);
                newArmor.GetComponent<Deformer>().StartingDamage();
                equippedArmor.Add(newArmor);
            }
            
        }

        for(int i = 0; i < equippedArmor.Count; i++)
        {
            equippedArmor[i].GetComponent<Scoring>().ScoreTime();
        }
    }

}