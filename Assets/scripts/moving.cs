using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {
	public static CharacterController CharacterController; 
	public static moving Instance;
	void Awake()
	{
		CharacterController = GetComponent ("CharacterController") as CharacterController;
		Instance = this;
	}
	void Update() 
	{
		if (Camera.mainCamera == null)
			return;

		GetLocomotionInput ();

	}
	void GetLocomotionInput()
	{
		
	}
}
