using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public abstract class ReorderableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver {
    [SerializeField] private List<TKey> serialisedKeys = new List<TKey>();
    // ReSharper disable once IdentifierTypo
    [SerializeField] private List<TValue> serialisedVals = new List<TValue>();
    
    [SerializeField] private List<TKey> items;

    
    
    public void OnBeforeSerialize() {
        serialisedKeys.Clear();
        serialisedVals.Clear();
        serialisedKeys = Keys.ToList();
        serialisedVals = Values.ToList();
    }

    public void OnAfterDeserialize() {
        this.Clear();
        // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
        serialisedKeys.Zip(serialisedVals, (key, value) => {
            this.Add(key, value);
            return 0;
        });
    }
}



[Serializable]
public class Test<TKey> {
    public TKey key;
}