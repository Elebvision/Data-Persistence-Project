using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{

    
    public static GameManager Instance;
    public string PlayerName;
    public int PlayerHightScore;
    //public List<Player> PlayerList;


    private void Awake() 
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
       // PlayerList = new List<Player>();

       // LoadHighScore();

    }



/*
    public void SaveHighScore(Player player)
    {
        player.Name = PlayerName;
        player.HightScore = PlayerHightScore;

        if (!PlayerList.Contains(player))
        {
            PlayerList.Add(player);
            string playerListJson = Newtonsoft.Json.JsonConvert.SerializeObject(player);
            //Debug.Log("Hight score list: " + playerListJson);
            File.WriteAllText(Application.persistentDataPath + "/playerScore.json", playerListJson);
        }

    }

      public void LoadHighScore()
    {
        string filePath = Application.persistentDataPath + "/playerScore.json";
        if (File.Exists(filePath))
        {
            string playerJson = File.ReadAllText(filePath);
             Debug.Log(playerJson);
            List<Player> player = JsonUtility.FromJson<List<Player>>(playerJson);
           
           // PlayerName = player.
            //PlayerHightScore = player[PlayerName].HightScore;
        }
    }


    public class Player
    {
        public string Name;
        public int HightScore;
        public bool CurrentPlayer;
    }
    */
}
