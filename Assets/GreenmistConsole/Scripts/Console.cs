using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Greenmist {
	
	public class Console : MonoBehaviour {

		[SerializeField]
		protected int fps = 30;
		private Subject<string> logSubject = new Subject<string>();

		// Use this for initialization
		void Start () {
			
		}

		// Update is called once per frame
		void Update () {
			
		}

		public void Log(string message) {
			Debug.Log (message);
			logSubject.OnNext (message);
		}

		public void subscribe(IObserver<string> observer) {
			logSubject.Subscribe (observer);
		}
	}
}