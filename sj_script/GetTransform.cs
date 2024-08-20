/************************************************************
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
public class GetTransform : MonoBehaviour
{
	/****************************************
	****************************************/
	
	/******************************
	******************************/
    void Start()
    {
        
    }
	
	/******************************
	******************************/
    void Update()
    {
		// if( Input.GetKeyDown(KeyCode.Space) ){
			SjTest();
		// }
    }
	
	/******************************
	******************************/
    void SjTest(){
		// System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
		// sw.Start();
		
		UnityEngine.Profiling.Profiler.BeginSample("this is sj test");
		
		// for (int i = 0; i < 1E+7; i++)
		for (int i = 0; i < 1E+5; i++)
		{
			/********************
			component 有
			********************/
			Transform t = gameObject.GetComponent<Transform>();
			// gameObject.TryGetComponent<Transform>(out Transform t);
			// Transform t = gameObject.transform;
			
			// Transform t = GetComponent<Transform>();
			// TryGetComponent<Transform>(out Transform t);
			// Transform t = transform;
			
			/********************
			component 無
			********************/
			// Collider t = gameObject.GetComponent<Collider>();
			// gameObject.TryGetComponent<Collider>(out Collider t);
			
			// Collider t = GetComponent<Collider>();
			// if( TryGetComponent<Collider>(out Collider t);
		}
		
		UnityEngine.Profiling.Profiler.EndSample();
		
		// sw.Stop();
		// UnityEngine.Debug.Log(sw.Elapsed);
	}
}
