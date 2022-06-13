using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameIsRunning;
    public Button startButton;
    public TextMeshProUGUI gameTitle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        gameIsRunning = true;
        startButton.gameObject.SetActive(false);
        gameTitle.gameObject.SetActive(false);
    }
}
