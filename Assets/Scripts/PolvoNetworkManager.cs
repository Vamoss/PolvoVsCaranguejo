using UnityEngine;

using System.Collections;

public class PolvoNetworkManager : MonoBehaviour { 

	public string registeredName = "PolvoVsCaranguejo";

	public NetworkPlayer thisPlayer;
	public bool isTentacle = false;

	public PolvoTentacle[] tentacles;
	private void StartServer () {
		Network.InitializeServer(100, 1337, !Network.HavePublicAddress());
		MasterServer.RegisterHost(registeredName, "Polvo Vs. Caranguejo");
	}

	void OnServerInitialized() {
		if(Network.isServer) {
			thisPlayer = Network.player;
			makePlayer(thisPlayer);
		}
	}

	void OnConnectedToServer() {
		thisPlayer = Network.player;
		GetComponent<NetworkView>().RPC("makePlayer", RPCMode.Server, thisPlayer);
	}

	[RPC]
	void makePlayer(NetworkPlayer player) {

	}

	[RPC]
	void setTentacleForPlayer(NetworkViewID playerID, int tentacle) {

	}

	[RPC]
	void movePlayer(NetworkPlayer player) {

	}

	// Update is called once per frame
	void Update () {
	
	}
}
