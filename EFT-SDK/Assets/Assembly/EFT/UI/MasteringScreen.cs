using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B1C RID: 11036
	[UsedImplicitly]
	public sealed class MasteringScreen : UIElement
	{
		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x0600DADF RID: 56031 RVA: 0x00002050 File Offset: 0x00000250
		public static List<string> ItemTemplates
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DAE0 RID: 56032 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DAE1 RID: 56033 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Profile profile, GInterface313 inventoryController)
		{
			throw null;
		}

		// Token: 0x0600DAE2 RID: 56034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_0(int index)
		{
			throw null;
		}

		// Token: 0x0600DAE3 RID: 56035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetItemTemplateText(string id)
		{
			throw null;
		}

		// Token: 0x0400DE24 RID: 56868
		[SerializeField]
		private MasteringList _masteringList;

		// Token: 0x0400DE25 RID: 56869
		[SerializeField]
		private MasteringThumbs _masteringThumbs;

		// Token: 0x0400DE26 RID: 56870
		[SerializeField]
		private DropDownBox _sortMethod;

		// Token: 0x0400DE27 RID: 56871
		[SerializeField]
		private DropDownBox _filterMethod;

		// Token: 0x0400DE28 RID: 56872
		[SerializeField]
		private TMP_InputField _searchWeaponInputField;

		// Token: 0x0400DE29 RID: 56873
		[SerializeField]
		private Tab _listTab;

		// Token: 0x0400DE2A RID: 56874
		[SerializeField]
		private Tab _thumbsTab;

		// Token: 0x0400DE2B RID: 56875
		private static List<string> list_0;

		// Token: 0x0400DE2C RID: 56876
		private GClass3065 gclass3065_0;

		// Token: 0x0400DE2D RID: 56877
		private KeyValuePair<string, GClass1764>[] keyValuePair_0;

		// Token: 0x02002B1D RID: 11037
		[CompilerGenerated]
		private sealed class Class2591
		{
			// Token: 0x0600DAE4 RID: 56036 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass1764 newMastering)
			{
				throw null;
			}

			// Token: 0x0600DAE5 RID: 56037 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(MasteringList x)
			{
				throw null;
			}

			// Token: 0x0600DAE6 RID: 56038 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(MasteringThumbs x)
			{
				throw null;
			}

			// Token: 0x0600DAE7 RID: 56039 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x0600DAE8 RID: 56040 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4()
			{
				throw null;
			}

			// Token: 0x0400DE2E RID: 56878
			public MasteringScreen masteringScreen_0;

			// Token: 0x0400DE2F RID: 56879
			public Profile profile;

			// Token: 0x0400DE30 RID: 56880
			public GInterface313 inventoryController;
		}

		// Token: 0x02002B1E RID: 11038
		[CompilerGenerated]
		private sealed class Class2592
		{
			// Token: 0x0600DAE9 RID: 56041 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal KeyValuePair<string, GClass1764> method_0(string templateId)
			{
				throw null;
			}

			// Token: 0x0400DE31 RID: 56881
			public KeyValuePair<string, GClass1764> mastering;
		}

		// Token: 0x02002B1F RID: 11039
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2593
		{
			// Token: 0x0600DAEA RID: 56042 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<KeyValuePair<string, GClass1764>> method_0(KeyValuePair<string, GClass1764> mastering)
			{
				throw null;
			}

			// Token: 0x0600DAEB RID: 56043 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(KeyValuePair<string, GClass1764> masteringData)
			{
				throw null;
			}

			// Token: 0x0400DE32 RID: 56882
			public static readonly MasteringScreen.Class2593 class2593_0;

			// Token: 0x0400DE33 RID: 56883
			public static Func<KeyValuePair<string, GClass1764>, IEnumerable<KeyValuePair<string, GClass1764>>> func_0;

			// Token: 0x0400DE34 RID: 56884
			public static Func<KeyValuePair<string, GClass1764>, string> func_1;
		}

		// Token: 0x02002B20 RID: 11040
		[CompilerGenerated]
		private sealed class Class2594
		{
			// Token: 0x0600DAEC RID: 56044 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyValuePair<string, GClass1764> skill)
			{
				throw null;
			}

			// Token: 0x0400DE35 RID: 56885
			public int index;
		}
	}
}
