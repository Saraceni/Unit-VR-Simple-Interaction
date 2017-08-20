using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace VRStandardAssets {
	
	public class VRInteractiveItem : MonoBehaviour {

		public UnityEvent OnOver;             // Called when the gaze moves over this object
		public UnityEvent OnOut;              // Called when the gaze leaves this object
		public UnityEvent OnClick;            // Called when click input is detected whilst the gaze is over this object.
		public UnityEvent OnDoubleClick;      // Called when double click input is detected whilst the gaze is over this object.
		public UnityEvent OnUp;               // Called when Fire1 is released whilst the gaze is over this object.
		public UnityEvent OnDown;             // Called when Fire1 is pressed whilst the gaze is over this object.


		protected bool m_IsOver;


		public bool IsOver
		{
			get { return m_IsOver; }              // Is the gaze currently over this object?
		}


		// The below functions are called by the VREyeRaycaster when the appropriate input is detected.
		// They in turn call the appropriate events should they have subscribers.
		public void Over()
		{
			m_IsOver = true;

			if (OnOver != null)
				OnOver.Invoke ();
		}


		public void Out()
		{
			m_IsOver = false;

			if (OnOut != null)
				OnOut.Invoke ();
		}


		public void Click()
		{
			if (OnClick != null)
				OnClick.Invoke ();
		}


		public void DoubleClick()
		{
			if (OnDoubleClick != null)
				OnDoubleClick.Invoke ();
		}


		public void Up()
		{
			if (OnUp != null)
				OnUp.Invoke ();
		}


		public void Down()
		{
			if (OnDown != null)
				OnDown.Invoke ();
		}
	}
}
