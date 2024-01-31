using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Diz.Skinning
{
	// Token: 0x020030A5 RID: 12453
	public class Skeleton : MonoBehaviour, ISerializationCallbackReceiver
	{
		// Token: 0x0600F486 RID: 62598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnBeforeSerialize()
		{
			throw null;
		}

		// Token: 0x0600F487 RID: 62599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnAfterDeserialize()
		{
			throw null;
		}

		// Token: 0x0400FA95 RID: 64149
		public Dictionary<string, Transform> Bones;

		// Token: 0x0400FA96 RID: 64150
		[SerializeField]
		private List<string> _keys;

		// Token: 0x0400FA97 RID: 64151
		[SerializeField]
		private List<Transform> _values;
	}
}
