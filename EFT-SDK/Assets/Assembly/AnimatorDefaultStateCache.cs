using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020006D5 RID: 1749
public class AnimatorDefaultStateCache : MonoBehaviour
{
	// Token: 0x060027AC RID: 10156 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetupDefaultParameter()
	{
		throw null;
	}

	// Token: 0x040026C5 RID: 9925
	[SerializeField]
	private AnimatorDefaultStateCache.AnimatorParameterDefaultValue[] _parameters;

	// Token: 0x040026C6 RID: 9926
	[SerializeField]
	private AnimatorDefaultStateCache.DefaultLayerState[] _layersState;

	// Token: 0x040026C7 RID: 9927
	[SerializeField]
	private Animator _animator;

	// Token: 0x020006D6 RID: 1750
	[Serializable]
	private struct AnimatorParameterDefaultValue
	{
		// Token: 0x060027AD RID: 10157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetDefaultParameter(AnimatorDefaultStateCache.AnimatorParameterDefaultValue defaultValue, Animator animator)
		{
			throw null;
		}

		// Token: 0x040026C8 RID: 9928
		[SerializeField]
		private int _parameterNameHash;

		// Token: 0x040026C9 RID: 9929
		[SerializeField]
		private AnimatorControllerParameterType _type;

		// Token: 0x040026CA RID: 9930
		[SerializeField]
		private int _defaultIntValue;

		// Token: 0x040026CB RID: 9931
		[SerializeField]
		private float _defaultFloatValue;

		// Token: 0x040026CC RID: 9932
		[SerializeField]
		private bool _defaultBoolValue;
	}

	// Token: 0x020006D7 RID: 1751
	[Serializable]
	private struct DefaultLayerState
	{
		// Token: 0x060027AE RID: 10158 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetDefaultState(AnimatorDefaultStateCache.DefaultLayerState layerState, Animator animator)
		{
			throw null;
		}

		// Token: 0x040026CD RID: 9933
		[SerializeField]
		private int _layerIndex;

		// Token: 0x040026CE RID: 9934
		[SerializeField]
		private float _weight;

		// Token: 0x040026CF RID: 9935
		[SerializeField]
		private int _defaultStateHash;
	}
}
