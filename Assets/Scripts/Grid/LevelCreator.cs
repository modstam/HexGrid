using UnityEngine;
using System.Collections;

public class LevelCreator : MonoBehaviour {

	public GameObject hexWirePrefab;
	public Node[,] gridList;

	public int ySize;
	public int xSize;


	// Use this for initialization
	void Start () {
		if(!hexWirePrefab || (xSize == null || ySize == null)){
			Debug.Log ("LevelCreator members not set properly");
		}
		else{
			gridList = new Node[xSize, ySize];
			Vector3 position = new Vector3(0,0,0);
			Quaternion rotation = Quaternion.Euler (new Vector3(-90,-180,0));

			GameObject tmp = (GameObject)Instantiate(hexWirePrefab, position, rotation);
			Node node = tmp.GetComponent<Node>();
			gridList[0,0] = node;
			Vector3 boundsSize = node.renderer.bounds.size;
			position.x += boundsSize.x;
			bool even = true;

			for(int i = 0; i < xSize; i++){

				if((i%2)!=0){ //uneven
					even=false;
					position.x = 0f;
					position.x += boundsSize.x/2;
					position.z -= (boundsSize.z - (boundsSize.z/4));
				}
				else{ //even
					if(i!=0){
					even=true;
					position.x = 0f;
					position.z -= (boundsSize.z - (boundsSize.z/4));
					}
				}

				for(int j = 0; j < ySize; j++){
					if((i==0 && j==0) || (j==(ySize-1) && !even)){
						continue; //skip first iteration because of previous initialization
					}
					tmp = (GameObject)Instantiate(hexWirePrefab, position, rotation);
					node = tmp.GetComponent<Node>();
					gridList[i,j] = node;
					position.x += boundsSize.x; 
				}
			}
		}	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
