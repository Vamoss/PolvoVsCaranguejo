using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIControl : MonoBehaviour {

	public Text score;
	public Image foreground;
	public Image background;
	public Renderer backgroundRender;
	public Camera camera;

	void Start () {
			//backgroundMaterial = ;
	}

	void Update () {
		Vector3 dest = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
		camera.transform.localPosition = new Vector3(dest.x, dest.y, -10);
		this.transform.localPosition = dest;
		backgroundRender.material.SetTextureOffset("_MainTex", -dest);
		//foreground.transform.localPosition = dest;
		//background.transform.localPosition = -camera.transform.localPosition;
	}
}
