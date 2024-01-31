using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.Serialization;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027EA RID: 10218
	public class Appliance : InteractableObject, ISerializationCallbackReceiver, ISupportsPrefabSerialization
	{
		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x0600CC99 RID: 52377 RVA: 0x00002050 File Offset: 0x00000250
		public string ObjectId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x0600CC9A RID: 52378 RVA: 0x00002050 File Offset: 0x00000250
		public bool Enabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CC9B RID: 52379 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600CC9C RID: 52380 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TurnOn()
		{
			throw null;
		}

		// Token: 0x0600CC9D RID: 52381 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TurnOff()
		{
			throw null;
		}

		// Token: 0x0600CC9E RID: 52382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool value)
		{
			throw null;
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x0600CC9F RID: 52383 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CCA0 RID: 52384 RVA: 0x00002050 File Offset: 0x00000250
		SerializationData ISupportsPrefabSerialization.SerializationData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600CCA1 RID: 52385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			throw null;
		}

		// Token: 0x0600CCA2 RID: 52386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
			throw null;
		}

		// Token: 0x0400CCC5 RID: 52421
		[SerializeField]
		private List<GInterface159> _ambianceObjects;

		// Token: 0x0400CCC6 RID: 52422
		[SerializeField]
		private string _objectId;

		// Token: 0x0400CCC7 RID: 52423
		private bool bool_0;

		// Token: 0x0400CCC8 RID: 52424
		[SerializeField]
		[HideInInspector]
		private SerializationData _serializationData;
	}
}
