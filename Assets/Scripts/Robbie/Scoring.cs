using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    List<GameObject> prefabs;
    Mesh meshToScore;
    Vector3[] originalVerticiesPositions, finalVerticiesPositions;
    string parentTag;
    // Start is called before the first frame update
    void Awake()
    {
        meshToScore = GetComponent<MeshFilter>().mesh;
        originalVerticiesPositions = meshToScore.vertices;
        //finalVerticiesPositions = new Vector3[originalVerticiesPositions.Length];


        parentTag = gameObject.tag;
        //Debug.Log("Tag is " + parentTag);

        SetVertList();
    }

    private void SetVertList()
    {
        prefabs = GameObject.FindWithTag("Skeleton").GetComponent<RandomEquipment>().equipmentOptions;
        //Debug.Log("The length of Prefabs is " + prefabs.Count);

        for(int i = 0; i < prefabs.Count; i++)
        {
            if(prefabs[i].tag == parentTag)
            {
                originalVerticiesPositions = prefabs[i].GetComponent<MeshFilter>().sharedMesh.vertices;
                finalVerticiesPositions = new Vector3[originalVerticiesPositions.Length];
                //Debug.Log("The tags match!");
            }
        }
    }

    public void ScoreTime()
    {
        finalVerticiesPositions = meshToScore.vertices;
        Vector3 score = new Vector3(0,0,0);
        for(int i = 0; i < originalVerticiesPositions.Length; i++)
        {
            //Debug.Log("og vert: "+originalVerticiesPositions[i] +" - final vert "+ finalVerticiesPositions[i]+" = "+ (originalVerticiesPositions[i] - finalVerticiesPositions[i]));
            score += (originalVerticiesPositions[i] - finalVerticiesPositions[i]);
            //Debug.Log("Score = " + score);
        }

        float finalX = Mathf.Abs(score.x);
        float finalY = Mathf.Abs(score.y);
        float finalZ = Mathf.Abs(score.z);

        float finalScore = finalX + finalY + finalZ;

        LetterGrade(finalScore);
    }

    private void LetterGrade(float finalScore)
    {
        if(finalScore == 0)
        {
            Debug.Log("You got an A!!!");
        }
        else if (finalScore >= 1 && finalScore < 2)
        {
            Debug.Log("You got a B!");
        }
        else if (finalScore >= 2 && finalScore < 3)
        {
            Debug.Log("You got a C.");
        }
        else if (finalScore >= 3 && finalScore < 4)
        {
            Debug.Log("You got a D...");
        }
        else
        {
            Debug.Log("You got an F. Consider a career change.");
        }
    }
    
}
