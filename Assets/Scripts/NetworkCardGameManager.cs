using UnityEngine;
using Mirror;

public class NetworkCardGameManager : NetworkManager
{
    GameObject menager;

    override public void Start()
    {
        base.Start();
        Debug.Log("Hej");
    }

    public override void OnStartServer()
    {
        Debug.Log("Hello from server");
    }

    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        // add player 
        GameObject player = Instantiate(playerPrefab);
        NetworkServer.AddPlayerForConnection(conn, player);

        
        Debug.Log("Yea we have " + numPlayers + "on scene");

        if (numPlayers == 2)
        {
            StartGame();
        }
    }

    void StartGame()
    {
        Debug.Log("StartGame()");

    }

}
