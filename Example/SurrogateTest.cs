using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Malee;
using UnityEngine.Serialization;

public class SurrogateTest : MonoBehaviour {

	[SerializeField]
	private MyClass[] objects;

	// [FormerlySerializedAs("myClassArray")] [SerializeField, Reorderable(surrogateType = typeof(GameObject), surrogateProperty = "gameObject")]
	private MyClassList myClassList;

	[System.Serializable]
	public class MyClass {

		public string name;
		public GameObject gameObject;
	}

	[System.Serializable]
	public class MyClassList : ReorderableList<MyClass> {
	}
}
