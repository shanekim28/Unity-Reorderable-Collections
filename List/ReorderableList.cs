using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Serialization;

namespace Malee {

	[Serializable]
	public abstract class ReorderableList<T> : List<T>, ISerializationCallbackReceiver {
		[SerializeField] private List<T> items = new List<T>();

		public void OnBeforeSerialize() {
			items.Clear();
			items.AddRange(this);
		}

		public void OnAfterDeserialize() {
			this.Clear();
			this.AddRange(items);
		}
	}
}
