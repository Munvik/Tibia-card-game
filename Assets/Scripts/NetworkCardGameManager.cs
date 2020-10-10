using UnityEngine;
using Mirror;

public class NetworkCardGameManager : NetworkManager
{
    [SerializeField]
    private ServerManager serverManager;
    public ServerManager ServerManager => serverManager;

    override public void Start()
    {
        base.Start();
    }

    public override void OnStartServer()
    {
        Debug.Log("Hello from server");
    }

    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        if (numPlayers > 2)
            return;

        // add player 
        GameObject player = Instantiate(playerPrefab);
        NetworkServer.AddPlayerForConnection(conn, player);

        Debug.Log("Is network connection ready? " + conn.isReady);
        
        Debug.Log("Yea we have " + numPlayers + "on scene");

        if (numPlayers == 2)
        {
            StartGame();
        }    
    }

    void StartGame()
    {
        Debug.Log("StartGame()");
        serverManager.DealCards();
    }
}
