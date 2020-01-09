using System;
using UnityEngine;

// ReSharper disable StringLiteralTypo, IdentifierTypo, InconsistentNaming
namespace ZeroVector.Common.Reorderable {
    [CreateAssetMenu(fileName = "New ScriptableObject Example", menuName = "ScriptableObject Example")]
    public class ScriptableObjectExample : ScriptableObject {
        

        [SerializeField] // [Reorderable(paginate = true, pageSize = 0, elementNameProperty = "myString")]
        private MyList list;

        [Space]
        public MyDict dict;

        [Serializable]
        private struct MyObject {
            #pragma warning disable 649
            public bool myBool;
            public float myValue;
            public string myString;
            #pragma warning restore 649 
        }

        [Serializable]
        private class MyList : ReorderableList<MyObject> { }

        [Serializable]
        public class MyDict : ReorderableDictionary<float, string, MyDictKVP> {
            public override float DeduplicateKey(float duplicateKey) {
                return duplicateKey + 0.1f;
            }
        }


        [Serializable]
        public class MyDictKVP : ReorderableDictionary<float, string, MyDictKVP>.KeyValuePair { }
    }
}