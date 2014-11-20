using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {
	
	public Node dir_1;
	public Node dir_2;
	public Node dir_3;
	public Node dir_4;
	public Node dir_5;
	public Node dir_6;

	public float cost;

	void Start(){
		initializeHex();
	}

	public void initializeHex(Node d1, Node d2, Node d3, Node d4 , Node d5 ,Node d6 ){
		dir_1 = d1;
		dir_2 = d2;
		dir_3 = d3;
		dir_4 = d4;
		dir_5 = d5;
		dir_6 = d6;
	}
	
	public void initializeHex(){
		//Placeholder atm
		//Debug.Log ("Hex: " + getFullPosition() + " initialized");
	}

	public Vector3 getFullPosition(){
		return this.transform.position;
	}

	public float getPositionX(){
		return this.transform.position.x;
	}

	public float getPositionY(){
		return this.transform.position.y;
	}

	public float getPositionZ(){
		return this.transform.position.z;
	}
	



}
