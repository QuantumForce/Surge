using UnityEngine;
using System.Collections;

public class motor : MonoBehaviour {
	public static motor Instance;
	public float MoveSpeed = 10f;
	public Vector3 MoveVector { get; set; }

	void Awake()
	{
		Instance = this;
	}
	void UpdateMotor () 
	{
		SnapAlignCharacterWithChamera ();
		ProcessMotion ();
	}
	void ProcessMotion()
	{

	}
	void SnapAlignCharacterWithChamera()
	{

	}
}
