using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public static PlayerInfo Instance;
    public string playerName;
    public Player currentPlayer;
    public Player bestPlayer;

    public void Start()
    {
        currentPlayer = new Player();
        bestPlayer = new Player();
    }
    private void Awake()
    {
        if(PlayerInfo.Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [Serializable]
    public class Player
    {
        public string name;
        public int score;
    }
    

}
