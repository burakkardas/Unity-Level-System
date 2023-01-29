using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelCompleteController : MonoBehaviour
{
    private Button levelCompleteButton;




    private void Start()
    {
        levelCompleteButton = GetComponent<Button>();
        levelCompleteButton.onClick.AddListener(LevelComplete);
        Debug.Log("Level Index " + SceneManager.GetActiveScene().buildIndex);
    }



    public void LevelComplete()
    {
        if (PlayerPrefs.GetInt("LevelIndex") <= SceneManager.GetActiveScene().buildIndex)
        {
            LevelManager.Instance.SaveActiveLevelIndex();
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
