using UnityEngine;

using System.Collections;

public class PolvoNetworkManager : MonoBehaviour { 

	public string registeredName = "PolvoVsCaranguejo";

	public NetworkPlayer thisPlayer;
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

	[RPC]
	void makePlayer(NetworkPlayer player) {

	}

	// Update is called once per frame
	void Update () {
	
	}
}
