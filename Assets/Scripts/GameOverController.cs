using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    void Start()
    {
        gameOverPanel.SetActive(true);
        if (GameManager.Instance)
        {
            scoreText.text = "Score: " + GameManager.Instance.targetScore.ToString();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
