using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoints : MonoBehaviour
{
    [SerializeField] private Text userPositionText;

    [SerializeField] private Vector3 userPosition;

    [SerializeField] Transform playerTransform;

    [SerializeField] public string userName;


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();

        LoadData();
    }

    
    public void SaveData()
    {
        PlayerPrefs.SetFloat("positionX", playerTransform.position.x);

        PlayerPrefs.SetFloat("positionY", playerTransform.position.y);

        PlayerPrefs.SetFloat("positionZ", playerTransform.position.z);

    }

    void LoadData()
    {
        /*userNameText.text = "User name: " + PlayerPrefs.GetString("name", "No name");

        userScoreText.text = "User score: " + PlayerPrefs.GetInt("score", 0).ToString();*/

        userPositionText.text = "User position: " + PlayerPrefs.GetFloat("positionX", 326.345f).ToString() + "x " + 

                                                    PlayerPrefs.GetFloat("positionY", 12.33999f).ToString() + "y " + 

                                                    PlayerPrefs.GetFloat("positionZ", 783.98f).ToString() + "z " ;
    }
}
