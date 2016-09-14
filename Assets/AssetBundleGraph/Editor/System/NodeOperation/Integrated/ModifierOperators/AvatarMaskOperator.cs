using System;
using System.Linq;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

namespace AssetBundleGraph.ModifierOperators {
	
	[Serializable] public class AvatarMaskOperator : OperatorBase {
		
		public AvatarMaskOperator () {}

		private AvatarMaskOperator (
			string operatorType
		) {
			this.operatorType = operatorType;
		}

		/*
			constructor for default data setting.
		*/
		public override OperatorBase DefaultSetting () {
			return new AvatarMaskOperator(
				"UnityEditor.Animations.AvatarMask"
			);
		}

		public override bool IsChanged<T> (T asset) {
			var avarar = asset as AvatarMask;

			var changed = false;
			
			return changed; 
		}

		public override void Modify<T> (T asset) {
			var avarar = asset as AvatarMask;
			
		}
		
		public override void DrawInspector (Action changed) {
			GUILayout.Label("AvatarMaskOperator inspector.");
		}
	}

}