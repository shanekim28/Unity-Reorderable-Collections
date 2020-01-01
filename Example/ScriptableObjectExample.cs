using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Malee;

[CreateAssetMenu(fileName = "New ScriptableObject Example", menuName = "ScriptableObject Example")]
public class ScriptableObjectExample : ScriptableObject {

	// [SerializeField, Reorderable(paginate = true, pageSize = 0, elementNameProperty = "myString")]
	// private MyList list;

	[Space, Reorderable(singleLine = true)] public MyDict dict;
	
	[System.Serializable]
	private struct MyObject {

		public bool myBool;
		public float myValue;
		public string myString;
	}

	[System.Serializable]
	private class MyList : ReorderableList<MyObject> {
	}
	
	[System.Serializable]
	public class MyDict : ReorderableDictionary<string, int> {}
	
	
}
