using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    [SerializeField] private Text userPositionText;

    [SerializeField] private Vector3 userPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void SaveData()
    {
        PlayerPrefs.SetFloat("positionX", userPosition.x);

        PlayerPrefs.SetFloat("positionY", userPosition.y);

        PlayerPrefs.SetFloat("positionZ", userPosition.z);

    }

    void LoadData()
    {
        userNameText.text = "User name: " + PlayerPrefs.GetString("name", "No name");

        userScoreText.text = "User score: " + PlayerPrefs.GetInt("score", 0).ToString();

        userPositionText.text = "User position: " + PlayerPrefs.GetFloat("positionX", 0).ToString() + "x " + 

                                                    PlayerPrefs.GetFloat("positionY", 0).ToString() + "y " + 

                                                    PlayerPrefs.GetFloat("positionZ", 0).ToString() + "z " ;
    }
}
