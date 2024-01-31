using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace Diz.DependencyManager
{
	// Token: 0x0200312E RID: 12590
	public class TestLoadable : MonoBehaviour, GInterface395
	{
		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x0600F6AF RID: 63151 RVA: 0x00002050 File Offset: 0x00000250
		public BindableState<ELoadState> LoadState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x0600F6B0 RID: 63152 RVA: 0x00002050 File Offset: 0x00000250
		public string Key
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x0600F6B1 RID: 63153 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<string> DependencyKeys
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x0600F6B2 RID: 63154 RVA: 0x00002050 File Offset: 0x00000250
		public float Progress
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F6B3 RID: 63155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600F6B4 RID: 63156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600F6B5 RID: 63157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddToken(DependencyGraph<TestLoadable>.GClass3388 token)
		{
			throw null;
		}

		// Token: 0x0600F6B6 RID: 63158 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Load()
		{
			throw null;
		}

		// Token: 0x0600F6B7 RID: 63159 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator Load(IProgress<float> progress, CancellationToken ct)
		{
			throw null;
		}

		// Token: 0x0600F6B8 RID: 63160 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator Loading()
		{
			throw null;
		}

		// Token: 0x0600F6B9 RID: 63161 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Unload()
		{
			throw null;
		}

		// Token: 0x0600F6BA RID: 63162 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRefCount(int rc)
		{
			throw null;
		}

		// Token: 0x0600F6BB RID: 63163 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400FC40 RID: 64576
		[SerializeField]
		private Button _loadButton;

		// Token: 0x0400FC41 RID: 64577
		[SerializeField]
		private Image _mainImage;

		// Token: 0x0400FC42 RID: 64578
		[SerializeField]
		private Text _refCountLabel;

		// Token: 0x0400FC43 RID: 64579
		[SerializeField]
		private Transform _tokensContainer;

		// Token: 0x0400FC44 RID: 64580
		[SerializeField]
		private Button _tokenTemplate;

		// Token: 0x0400FC45 RID: 64581
		private BindableState<ELoadState> gclass3370_0;

		// Token: 0x0400FC46 RID: 64582
		public TestLoadable[] Dependencies;

		// Token: 0x0400FC47 RID: 64583
		public Action<TestLoadable> OnClicked;

		// Token: 0x0400FC48 RID: 64584
		public Action<TestLoadable> OnRightClicked;

		// Token: 0x0400FC49 RID: 64585
		private readonly Dictionary<Button, DependencyGraph<TestLoadable>.GClass3388> dictionary_0;

		// Token: 0x0200312F RID: 12591
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3180
		{
			// Token: 0x0600F6BC RID: 63164 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(TestLoadable x)
			{
				throw null;
			}

			// Token: 0x0400FC4A RID: 64586
			public static readonly TestLoadable.Class3180 class3180_0;

			// Token: 0x0400FC4B RID: 64587
			public static Func<TestLoadable, string> func_0;
		}

		// Token: 0x02003130 RID: 12592
		[CompilerGenerated]
		private sealed class Class3181
		{
			// Token: 0x0600F6BD RID: 63165 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400FC4C RID: 64588
			public TestLoadable testLoadable_0;

			// Token: 0x0400FC4D RID: 64589
			public Button tokenButton;
		}
	}
}
