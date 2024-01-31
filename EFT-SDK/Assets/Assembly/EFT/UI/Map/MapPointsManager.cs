using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI.Map
{
	// Token: 0x02002F18 RID: 12056
	public class MapPointsManager : UIElement
	{
		// Token: 0x0600EDF7 RID: 60919 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(bool allowSelection, [CanBeNull] MapPoints mapPoints)
		{
			throw null;
		}

		// Token: 0x0600EDF8 RID: 60920 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(EntryPoint entryPoint)
		{
			throw null;
		}

		// Token: 0x0600EDF9 RID: 60921 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(EntryPoint entryPoint)
		{
			throw null;
		}

		// Token: 0x0600EDFA RID: 60922 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(ExtractionPoint extractionPoint)
		{
			throw null;
		}

		// Token: 0x0600EDFB RID: 60923 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<ExtractionPoint> method_3(EntryPoint entryPoint)
		{
			throw null;
		}

		// Token: 0x0600EDFC RID: 60924 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_4(ExtractionPoint exfil)
		{
			throw null;
		}

		// Token: 0x0600EDFD RID: 60925 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectPoint([CanBeNull] EntryPoint entryPoint)
		{
			throw null;
		}

		// Token: 0x0600EDFE RID: 60926 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Load()
		{
			throw null;
		}

		// Token: 0x0600EDFF RID: 60927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600EE00 RID: 60928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600EE01 RID: 60929 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(EntryPoint arg)
		{
			throw null;
		}

		// Token: 0x0600EE02 RID: 60930 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(EntryPoint arg)
		{
			throw null;
		}

		// Token: 0x0400F33A RID: 62266
		[SerializeField]
		private SimplePocketMap _pocketMap;

		// Token: 0x0400F33B RID: 62267
		[SerializeField]
		private SelectEntryPointPanel _entryPointPanel;

		// Token: 0x0400F33C RID: 62268
		[SerializeField]
		private EntryPointView _entryPointTemplate;

		// Token: 0x0400F33D RID: 62269
		[SerializeField]
		private ExtractionPointView _extractionPointTemplate;

		// Token: 0x0400F33E RID: 62270
		[SerializeField]
		private bool _editPointPositions;

		// Token: 0x0400F33F RID: 62271
		private bool bool_0;

		// Token: 0x0400F340 RID: 62272
		private MapPoints mapPoints_0;

		// Token: 0x0400F341 RID: 62273
		private readonly Dictionary<EntryPoint, EntryPointView> dictionary_0;

		// Token: 0x0400F342 RID: 62274
		private readonly List<ExtractionPointView> list_0;

		// Token: 0x02002F19 RID: 12057
		[CompilerGenerated]
		private sealed class Class2976
		{
			// Token: 0x0600EE03 RID: 60931 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ExtractionPoint extraction)
			{
				throw null;
			}

			// Token: 0x0400F343 RID: 62275
			public EntryPoint entryPoint;
		}

		// Token: 0x02002F1A RID: 12058
		[CompilerGenerated]
		private sealed class Class2977
		{
			// Token: 0x0600EE04 RID: 60932 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyValuePair<EntryPoint, EntryPointView> x)
			{
				throw null;
			}

			// Token: 0x0400F344 RID: 62276
			public ExtractionPoint exfil;
		}

		// Token: 0x02002F1B RID: 12059
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2978
		{
			// Token: 0x0600EE05 RID: 60933 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(ExtractionPoint x)
			{
				throw null;
			}

			// Token: 0x0400F345 RID: 62277
			public static readonly MapPointsManager.Class2978 class2978_0;

			// Token: 0x0400F346 RID: 62278
			public static Func<ExtractionPoint, string> func_0;
		}
	}
}
