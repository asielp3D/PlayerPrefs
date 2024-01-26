using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoints : MonoBehaviour
{
    [SerializeField] Text checkText;

    [SerializeField] public string checkpoint;

    [SerializeField]public Vector3 userPosition;

    Transform playerTransform;


    // Start is called before the first frame update
    void Awake()
    {
        playerTransform = GameObject.Find("Player").transform;

        LoadData();

        playerTransform.position = userPosition;
    }

    
    public void SaveData()
    {
        PlayerPrefs.SetString("name", checkpoint);

        PlayerPrefs.SetFloat("positionX", playerTransform.transform.position.x);

        PlayerPrefs.SetFloat("positionY", playerTransform.transform.position.y);

        PlayerPrefs.SetFloat("positionZ", playerTransform.transform.position.z);

        LoadData();
    }

    void LoadData()
    {
    
        checkText.text = "Checkpoint: " + PlayerPrefs.GetString("name", "No name");
       
        userPosition = new Vector3 (PlayerPrefs.GetFloat("positionX", 326.345f),PlayerPrefs.GetFloat("positionY", 12.33999f),PlayerPrefs.GetFloat("positionZ", 783.98f));
    }
}
