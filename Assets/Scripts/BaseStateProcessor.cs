using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseStateProcessor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// 状態設定
    /// </summary>
    abstract protected void SetStates();

    /// <summary>
    /// 状態を切り替える
    /// </summary>
    abstract protected void SwitchState(int state);
}
