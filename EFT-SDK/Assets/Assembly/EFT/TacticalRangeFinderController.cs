using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Profiling;

namespace EFT
{
	// Token: 0x02001577 RID: 5495
	public class TacticalRangeFinderController : MonoBehaviour
	{
		// Token: 0x060075D6 RID: 30166 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x04007BD6 RID: 31702
		[SerializeField]
		private TacticalRangeFinderController.DistanceOutputFormat _distanceOutputFormat;

		// Token: 0x04007BD7 RID: 31703
		[SerializeField]
		private string _noDistanceText;

		// Token: 0x04007BD8 RID: 31704
		[SerializeField]
		private float _delayInSecsBetweenCasts;

		// Token: 0x04007BD9 RID: 31705
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x04007BDA RID: 31706
		[SerializeField]
		private TMP_Text _textOnDisplay;

		// Token: 0x04007BDB RID: 31707
		[SerializeField]
		private Transform _boneToCastRay;

		// Token: 0x04007BDC RID: 31708
		[SerializeField]
		private float _rayStartOffset;

		// Token: 0x04007BDD RID: 31709
		[SerializeField]
		private float _maxCastDistance;

		// Token: 0x04007BDE RID: 31710
		[SerializeField]
		private float _cullDistance;

		// Token: 0x04007BDF RID: 31711
		[SerializeField]
		private LayerMask _mask;

		// Token: 0x04007BE0 RID: 31712
		private float float_0;

		// Token: 0x04007BE1 RID: 31713
		private readonly CustomSampler customSampler_0;

		// Token: 0x02001578 RID: 5496
		private enum DistanceOutputFormat
		{
			// Token: 0x04007BE3 RID: 31715
			FourDigits,
			// Token: 0x04007BE4 RID: 31716
			ThreeDigitsAndDot
		}
	}
}
