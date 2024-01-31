using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200094C RID: 2380
public class LightKeeperEyeTargetFollower : MonoBehaviour
{
	// Token: 0x17000924 RID: 2340
	// (get) Token: 0x0600358E RID: 13710 RVA: 0x00002050 File Offset: 0x00000250
	public float LeftEyeUpBlendLastValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000925 RID: 2341
	// (get) Token: 0x0600358F RID: 13711 RVA: 0x00002050 File Offset: 0x00000250
	public string LefttEyeBlendOnUp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000926 RID: 2342
	// (get) Token: 0x06003590 RID: 13712 RVA: 0x00002050 File Offset: 0x00000250
	public string RightEyeBlendOnUp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000927 RID: 2343
	// (get) Token: 0x06003591 RID: 13713 RVA: 0x00002050 File Offset: 0x00000250
	public float RightEyeUpBlendLastValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003592 RID: 13714 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003593 RID: 13715 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003594 RID: 13716 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GClass2898 invokedEvent)
	{
		throw null;
	}

	// Token: 0x06003595 RID: 13717 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ToggleWorking(bool enable)
	{
		throw null;
	}

	// Token: 0x06003596 RID: 13718 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_1()
	{
		throw null;
	}

	// Token: 0x06003597 RID: 13719 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ToggleBlockBlendShapes(bool blockIt)
	{
		throw null;
	}

	// Token: 0x06003598 RID: 13720 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetSignedAngle(float angle)
	{
		throw null;
	}

	// Token: 0x06003599 RID: 13721 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x0600359A RID: 13722 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GClass2898 interactEvent)
	{
		throw null;
	}

	// Token: 0x0400368B RID: 13963
	[SerializeField]
	private Transform _transformToLookAt;

	// Token: 0x0400368C RID: 13964
	[SerializeField]
	private SkinnedMeshRenderer _headMesh;

	// Token: 0x0400368D RID: 13965
	[SerializeField]
	private float _lerpToTargetRotationSpeed;

	// Token: 0x0400368E RID: 13966
	[SerializeField]
	private float _angleDifForStartRotation;

	// Token: 0x0400368F RID: 13967
	[SerializeField]
	private float _angleDifForStopRotation;

	// Token: 0x04003690 RID: 13968
	[SerializeField]
	private bool _returnStartRotationOnEnd;

	// Token: 0x04003691 RID: 13969
	[SerializeField]
	private int angleToBlendShapeMultiplier;

	// Token: 0x04003692 RID: 13970
	[SerializeField]
	private LightKeeperEyeTargetFollower.EEditorToggleEye _eyeToShow;

	// Token: 0x04003693 RID: 13971
	[SerializeField]
	private Transform _leftEye;

	// Token: 0x04003694 RID: 13972
	[SerializeField]
	private string _leBlendOnRight;

	// Token: 0x04003695 RID: 13973
	[SerializeField]
	private string _leBlendOnLeft;

	// Token: 0x04003696 RID: 13974
	[SerializeField]
	private string _leBlendOnUp;

	// Token: 0x04003697 RID: 13975
	[SerializeField]
	private string _leBlendOnDown;

	// Token: 0x04003698 RID: 13976
	[SerializeField]
	private Vector3 _leAdditionalRotation;

	// Token: 0x04003699 RID: 13977
	[SerializeField]
	private Space _leAdditionalRotSpace;

	// Token: 0x0400369A RID: 13978
	private Vector3 vector3_0;

	// Token: 0x0400369B RID: 13979
	private Quaternion quaternion_0;

	// Token: 0x0400369C RID: 13980
	private Vector3 vector3_1;

	// Token: 0x0400369D RID: 13981
	private Vector3 vector3_2;

	// Token: 0x0400369E RID: 13982
	private float float_0;

	// Token: 0x0400369F RID: 13983
	[SerializeField]
	private Transform _rightEye;

	// Token: 0x040036A0 RID: 13984
	[SerializeField]
	private string _reBlendOnRight;

	// Token: 0x040036A1 RID: 13985
	[SerializeField]
	private string _reBlendOnLeft;

	// Token: 0x040036A2 RID: 13986
	[SerializeField]
	private string _reBlendOnUp;

	// Token: 0x040036A3 RID: 13987
	[SerializeField]
	private string _reBlendOnDown;

	// Token: 0x040036A4 RID: 13988
	[SerializeField]
	private Vector3 _reAdditionalRotation;

	// Token: 0x040036A5 RID: 13989
	[SerializeField]
	private Space _reAdditionalRotSpace;

	// Token: 0x040036A6 RID: 13990
	private Vector3 vector3_3;

	// Token: 0x040036A7 RID: 13991
	private Quaternion quaternion_1;

	// Token: 0x040036A8 RID: 13992
	private Vector3 vector3_4;

	// Token: 0x040036A9 RID: 13993
	private Vector3 vector3_5;

	// Token: 0x040036AA RID: 13994
	private float float_1;

	// Token: 0x040036AB RID: 13995
	private Dictionary<string, int> dictionary_0;

	// Token: 0x040036AC RID: 13996
	private Action action_0;

	// Token: 0x040036AD RID: 13997
	private Coroutine coroutine_0;

	// Token: 0x040036AE RID: 13998
	private bool bool_0;

	// Token: 0x040036AF RID: 13999
	private Transform transform_0;

	// Token: 0x0200094D RID: 2381
	public enum EEditorToggleEye
	{
		// Token: 0x040036B1 RID: 14001
		Left,
		// Token: 0x040036B2 RID: 14002
		Right
	}
}
