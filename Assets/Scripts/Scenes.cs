using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{
    public TMP_InputField inputName;
    public void StartGame()
    {
        PlayerInfo.Instance.currentPlayer.name = inputName.text;
        SceneManager.LoadScene(1);
    }

}
