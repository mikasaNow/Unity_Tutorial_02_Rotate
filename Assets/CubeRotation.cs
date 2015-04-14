using UnityEngine;
using System.Collections;

public class CubeRotation : MonoBehaviour {

	public float x = 0.0f;
	public float y = 0.0f;
	public float z = 0.0f;

	// Use this for initialization
	void Start () {
		// 初期位置はプロパティ（transform.rotation）に設定
		// Quaternion.Eulerでオイラー角をクォータニオンに変換して設定
		//transform.rotation = Quaternion.Euler(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		// 相対的に回転させる場合はtransform.Rotateを使用
		transform.Rotate(x, y, z);


		//transform.rotation = Quaternion.FromToRotation(transform.up, transform.forward );
	}
}
