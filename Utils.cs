using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{

	/// <summary>
	/// Instance de lui même, crée une seule fois
	/// </summary>
	public static Utils instance;

	// Use this for initialization
	void Start ()
	{
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	/// <summary>
	/// Permet d'avancer vers l'avant en 3D sur l'axe Z, dans le sens positif
	/// </summary>
	/// <param name="unTransform">le transform a avncer</param>
	/// <param name="vitesse">la vitesse du deplacement</param>
	public void avancerDevant(Transform unTransform, float vitesse)
	{
		unTransform.Translate(Vector3.forward * vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet de reculer en 3D sur l'axe z, dans le sens négatif
	/// </summary>
	/// <param name="unTransform">le transform a avncer</param>
	/// <param name="vitesse">la vitesse du deplacement</param>
	public void reculer(Transform unTransform, float vitesse)
	{
		unTransform.Translate(Vector3.forward * -vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet d'avancer sur la droite en 3D sur l'axe x, dans le sens positif
	/// </summary>
	/// <param name="unTransform">le transform a avncer</param>
	/// <param name="vitesse">la vitesse du deplacement</param>
	public void avancerSurLaDroite(Transform unTransform, float vitesse)
	{
		unTransform.Translate(Vector3.right * vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet d'avancer sur la gauche en 3D sur l'axe x, dans le sens négatif
	/// </summary>
	/// <param name="unTransform">le transform a avncer</param>
	/// <param name="vitesse">la vitesse du deplacement</param>
	public void avancerSurLaGauche(Transform unTransform, float vitesse)
	{
		unTransform.Translate(Vector3.right * -vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet d'avancer vers l'avant en 3D sur l'axe Z, dans le sens positif
	/// </summary>
	/// <param name="unTransform">le transform a avncer</param>
	/// <param name="vitesse">la vitesse du deplacement</param>
	/// <param name="touche">la touche pour avancer</param>
	public void avancerDevant(Transform unTransform, float vitesse, KeyCode touche)
	{
		if(Input.GetKey(touche))
			unTransform.Translate(Vector3.forward * vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet de reculer en 3D sur l'axe z, dans le sens négatif
	/// </summary>
	/// <param name="unTransform">le transform a avncer</param>
	/// <param name="vitesse">la vitesse du deplacement</param>
	/// <param name="touche">la touche pour avancer</param>
	public void reculer(Transform unTransform, float vitesse, KeyCode touche)
	{
		if(Input.GetKey(touche))
			unTransform.Translate(Vector3.forward * -vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet d'avancer sur la droite en 3D sur l'axe x, dans le sens positif
	/// </summary>
	/// <param name="unTransform">le transform a avncer</param>
	/// <param name="vitesse">la vitesse du deplacement</param>
	/// <param name="touche">la touche pour avancer</param>
	public void avancerDroite(Transform unTransform, float vitesse, KeyCode touche)
	{
		if(Input.GetKey(touche))
			unTransform.Translate(Vector3.right * vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet d'avancer sur la gauche en 3D sur l'axe x, dans le sens négatif
	/// </summary>
	/// <param name="unTransform">le transform a avncer</param>
	/// <param name="vitesse">la vitesse du deplacement</param>
	/// <param name="touche">la touche pour avancer</param>
	public void avancerGauche(Transform unTransform, float vitesse, KeyCode touche)
	{
		if(Input.GetKey(touche))
			unTransform.Translate(Vector3.right * -vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet de faire une rotation en 3D sur l'axe y, dans le sens négatif
	/// </summary>
	/// <param name="unTransform">le transform a rotate</param>
	/// <param name="vitesse">la vitesse de rotation</param>
	public void rotationDroite(Transform unTransform, float vitesse)
	{
		unTransform.Rotate(Vector3.down * -vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet de faire une rotation en 3D sur l'axe y, dans le sens négatif
	/// </summary>
	/// <param name="unTransform">le transform a rotate</param>
	/// <param name="vitesse">la vitesse de rotation</param>
	public void rotationGauche(Transform unTransform, float vitesse)
	{
		unTransform.Rotate(Vector3.down * -vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet de faire une rotation en 3D sur l'axe x, dans le sens négatif
	/// </summary>
	/// <param name="unTransform">le transform a rotate</param>
	/// <param name="vitesse">la vitesse de rotation</param>
	public void rotationAvant(Transform unTransform, float vitesse)
	{
		unTransform.Rotate(Vector3.right * vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet de faire une rotation en 3D sur l'axe x, dans le sens négatif
	/// </summary>
	/// <param name="unTransform">le transform a rotate</param>
	/// <param name="vitesse">la vitesse de rotation</param>
	public void rotationArriere(Transform unTransform, float vitesse)
	{
		unTransform.Rotate(Vector3.right * -vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet de faire une rotation en 3D sur l'axe y, dans le sens négatif
	/// </summary>
	/// <param name="unTransform">le transform a rotate</param>
	/// <param name="vitesse">la vitesse de rotation</param>
	/// <param name="touche">la touche pour rotation</param>
	public void rotationDroite(Transform unTransform, float vitesse, KeyCode touche)
	{
		if(Input.GetKey(touche))
			unTransform.Rotate(Vector3.down * -vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet de faire une rotation en 3D sur l'axe y, dans le sens négatif
	/// </summary>
	/// <param name="unTransform">le transform a rotate</param>
	/// <param name="vitesse">la vitesse de rotation</param>
	/// <param name="touche">la touche pour rotation</param>
	public void rotationGauche(Transform unTransform, float vitesse, KeyCode touche)
	{
		if(Input.GetKey(touche))
			unTransform.Rotate(Vector3.down * -vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet de faire une rotation en 3D sur l'axe x, dans le sens négatif
	/// </summary>
	/// <param name="unTransform">le transform a rotate</param>
	/// <param name="vitesse">la vitesse de rotation</param>
	/// <param name="touche">la touche pour rotation</param>
	public void rotationAvant(Transform unTransform, float vitesse, KeyCode touche)
	{
		if(Input.GetKey(touche))
			unTransform.Rotate(Vector3.right * vitesse * Time.deltaTime);
	}
	
	/// <summary>
	/// Permet de faire une rotation en 3D sur l'axe x, dans le sens négatif
	/// </summary>
	/// <param name="unTransform">le transform a rotate</param>
	/// <param name="vitesse">la vitesse de rotation</param>
	/// <param name="touche">la touche pour rotation</param>
	public void rotationArriere(Transform unTransform, float vitesse, KeyCode touche)
	{
		if(Input.GetKey(touche))
			unTransform.Rotate(Vector3.right * -vitesse * Time.deltaTime);
	}

}
