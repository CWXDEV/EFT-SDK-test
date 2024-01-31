using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B15 RID: 6933
	public sealed class VideocardInstaller : MonoBehaviour
	{
		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x0600926C RID: 37484 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600926D RID: 37485 RVA: 0x00002050 File Offset: 0x00000250
		public static bool IsInited
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x0600926E RID: 37486 RVA: 0x00002050 File Offset: 0x00000250
		private PoolManager GClass1795_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600926F RID: 37487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetFromOther(VideocardInstaller oldInstaller)
		{
			throw null;
		}

		// Token: 0x06009270 RID: 37488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task AttachCard(int count = 1)
		{
			throw null;
		}

		// Token: 0x06009271 RID: 37489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DetachCard()
		{
			throw null;
		}

		// Token: 0x06009272 RID: 37490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task Init(string templateId)
		{
			throw null;
		}

		// Token: 0x06009273 RID: 37491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ReleaseBundles()
		{
			throw null;
		}

		// Token: 0x04009912 RID: 39186
		[SerializeField]
		private Transform[] _points;

		// Token: 0x04009913 RID: 39187
		[CompilerGenerated]
		private static bool bool_0;

		// Token: 0x04009914 RID: 39188
		private readonly List<GameObject> list_0;

		// Token: 0x04009915 RID: 39189
		private int int_0;

		// Token: 0x04009916 RID: 39190
		private PoolManager gclass1795_0;

		// Token: 0x04009917 RID: 39191
		private static Item item_0;

		// Token: 0x04009918 RID: 39192
		private static DependencyGraph<IEasyBundle>.GClass3388 gclass3388_0;

		// Token: 0x02001B17 RID: 6935
		[CompilerGenerated]
		private sealed class Class1641
		{
			// Token: 0x06009276 RID: 37494 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400991E RID: 39198
			public TaskCompletionSource<bool> source;
		}
	}
}
