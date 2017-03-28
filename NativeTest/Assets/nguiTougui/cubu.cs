using UnityEngine;
using System.Collections;

public class cubu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 获取当前游戏对象上的 Transform 组件
		// transform
		// 控制游戏对象的位置、旋转和缩放
		// 获取当前游戏对象的位置 - 世界坐标系中的位置
		Vector3 v = transform.position;
		print(v);
		// localPosiotion 是 在局部坐标系中的位置
		//        transform.localPosiotion;
		// 一般不直接修改 四元数
		// transform.rotation;
		// transform.localRotation;

		// 获取当前游戏父对象的 transform 组件
		//        transform.parent;
		// 当前游戏对象的根对象
		//        transform.root;
		// 获取当前游戏对象 叫做 Cube 的对象
		transform.Find("Cube");
		// 获取当前游戏对象 叫做 Cube 的子对象
		//        transform.FindChild("Cube");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.S)) {
			// 修改 transform 的位置
			//            transform.position = new Vector3(0, 1, 0);
			//            print (transform.position);
			//变化 当前游戏对象
			transform.Translate (new Vector3(0,  +1, 0));
		} else if (Input.GetKeyDown (KeyCode.W)) {
			// transform.Translate (new Vector3(0, +1, 0));
			// 旋转当前游戏对象
			// transform.Rotate (Vector3.up, 10.0f);
			// 欧拉角，也是旋转，但是只能旋转一次
			transform.eulerAngles = new Vector3(0.0f, 45.0f, 0.0f);
		}
	}
}