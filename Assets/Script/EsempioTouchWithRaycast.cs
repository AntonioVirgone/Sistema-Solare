using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EsempioTouchWithRaycast : MonoBehaviour 
{
	public Text text;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition); 
			ShootRay(ray);
		}
	}
		
	void ShootRay (Ray ray)
	{  
		RaycastHit rhit;

		GameObject gObjectHit = null;

		if (Physics.Raycast (ray, out rhit, 1000.0f)) {
			gObjectHit = rhit.collider.gameObject;
			//			print("Ray Shot and hit! Pianeta: " + gObjectHit.name);

			InfoPianeta (gObjectHit.name);
		}
	}

	void InfoPianeta(string nome)
	{
		if (nome == "Terra") {
			text.text = "Benvenuti sulla terra. Questo pianeta ha 1 satellite che gli ruota attorno, la Luna.";
		} 
		else if (nome == "Sole") {
			text.text = "Questa è una stella. Tutto in questo sistema ruota attorno a lei per effetto della forza di gravità.";
		} 
		else if (nome == "Venere") {
			text.text = "Venere è il secondo pianeta del Sistema solare in ordine di distanza dal Sole con un'orbita quasi circolare che lo porta a compiere una rivoluzione in 224,7 giorni terrestri.";
		} 
		else if (nome == "Mercurio") {
			text.text = "Mercurio è il pianeta più interno del sistema solare e il più vicino alla nostra stella, il Sole. È il più piccolo e la sua orbita è anche la più eccentrica (ovvero, la meno circolare) degli otto pianeti.";
		} 
		else if (nome == "Marte") {
			text.text = "Marte è il quarto pianeta del sistema solare in ordine di distanza dal Sole e l'ultimo dei pianeti di tipo terrestre dopo Mercurio, Venere e la Terra.";
		} 
		else if (nome == "Luna") {
			text.text = "La Luna è l'unico satellite naturale della Terra. Il suo nome proprio viene talvolta utilizzato, per estensione e con l'iniziale minuscola (una luna), come sinonimo di \"satellite naturale\" anche per i satelliti di altri pianeti.";
		}
	}
}
