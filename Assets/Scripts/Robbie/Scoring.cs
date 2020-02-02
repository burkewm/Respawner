using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    Mesh meshToScore;
    Vector3[] originalVerticiesPositions, finalVerticiesPositions;
    
    // Start is called before the first frame update
    void Start()
    {
        meshToScore = GetComponent<MeshFilter>().mesh;
        originalVerticiesPositions = meshToScore.vertices;
        finalVerticiesPositions = new Vector3[originalVerticiesPositions.Length];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ScoreTime()
    {
        Vector3 score = new Vector3(0,0,0);
        for(int i = 0; i < originalVerticiesPositions.Length; i++)
        {
            score += (originalVerticiesPositions[i] - finalVerticiesPositions[i]);
        }

        float finalX = Mathf.Abs(score.x);
        float finalY = Mathf.Abs(score.y);
        float finalZ = Mathf.Abs(score.z);

        float finalScore = finalX + finalY + finalZ;

        LetterGrade(finalScore);
    }

    private void LetterGrade(float finalScore)
    {
        if(finalScore >= 0 && finalScore < 1)
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
