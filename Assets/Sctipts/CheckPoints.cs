using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoints : MonoBehaviour
{
    [SerializeField] Text checkText;

    [SerializeField] public string checkpoint;

    [SerializeField]public Vector3 userPosition;

    Controller playerTransform;


    // Start is called before the first frame update
    void Awake()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Controller>();

        LoadData();
    }

    
    public void SaveData()
    {
        PlayerPrefs.SetString("name", checkpoint);

        PlayerPrefs.SetFloat("positionX", playerTransform.position.x);

        PlayerPrefs.SetFloat("positionY", playerTransform.position.y);

        PlayerPrefs.SetFloat("positionZ", playerTransform.position.z);

    }

    void LoadData()
    {
       

        /*userScoreText.text = "User score: " + PlayerPrefs.GetInt("score", 0).ToString();*/
        checkText.text = "Checkpoint: " + PlayerPrefs.GetString("name", "No name");
       /* userPosition.text = "User position: " + PlayerPrefs.GetFloat("positionX", 326.345f).ToString() + "x " + 

                                                    PlayerPrefs.GetFloat("positionY", 12.33999f).ToString() + "y " + 

                                                    PlayerPrefs.GetFloat("positionZ", 783.98f).ToString() + "z " ;*/

        userPosition = new Vector3 (PlayerPrefs.GetFloat("positionX", 326.345f),PlayerPrefs.GetFloat("positionY", 12.33999f),PlayerPrefs.GetFloat("positionZ", 783.98f));
    }
}
