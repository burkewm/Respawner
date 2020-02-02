using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEquipment : MonoBehaviour
{
    public List<GameObject> equipmentOptions = new List<GameObject>();
    private List<GameObject> equipmentSpawns = new List<GameObject>();

    private List<GameObject> equippedArmor = new List<GameObject>();

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
                armor.SetActive(true);
                //var newArmor = Instantiate(armor, new Vector3(0, 4, 0), Quaternion.identity);
                equippedArmor.Add(armor);
            }
            else
            {
                Debug.Log("damaged");
                int randoIndex = Random.Range(0, equipmentOptions.Count);
                GameObject armor = equipmentOptions[randoIndex].gameObject;
                armor.SetActive(true);
                //var newArmor = Instantiate(armor, new Vector3(0, 4, 0), Quaternion.identity);
                armor.GetComponent<Deformer>().StartingDamage();
                equippedArmor.Add(armor);
            }
            
        }

        //for(int i = 0; i < equippedArmor.Count; i++)
        //{
        //    Debug.Log("equipped index["+i+"]");
        //    equippedArmor[i].GetComponent<Scoring>().ScoreTime();
        //}
    }

}
